using Octokit;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuterra.Installer
{
	public partial class InstallProgressForm : Form
	{
		public static readonly string InstallPackageName = "mod.zip";
		public InstallSettings InstallSettings { get; }
		public string InstallDataDir => Path.Combine(InstallSettings.TerraTechDirectory, "Nuterra.Installer_Temp");
		public string InstallPackageFile => Path.Combine(InstallDataDir, InstallPackageName);
		public string InstallErrorFile => Path.Combine(InstallDataDir, "error.log");
		public string AccessorModFile => Path.Combine(InstallDataDir, "installer.access.mod");
		public string TerraTechDataDir { get; private set; }
		public string TerraTechMainAssemblyFile => Path.Combine(TerraTechDataDir ?? ".", "Managed", "Assembly-CSharp.dll");
		public bool Aborted { get; private set; } = false;

		public InstallProgressForm()
		{
			InitializeComponent();
		}

		public InstallProgressForm(InstallSettings settings) : this()
		{
			if (settings == null) throw new ArgumentNullException(nameof(settings));
			InstallSettings = settings;
		}

		private void InstallProgressForm_Load(object sender, EventArgs e)
		{
			PerformInstall();
		}

		private async void PerformInstall()
		{
			if (InstallSettings != null)
			{
				PrepareInstall();
				if (!Aborted)
				{
					switch (InstallSettings.PackageSource)
					{
						case PackageSource.Github:
							await DownloadPackage();
							break;
						case PackageSource.Local:
							await CopyPackage();
							break;
					}
				}
				if (!Aborted) await UnpackResources();
				if (!Aborted) await ModifyAccessors();
				if (!Aborted && InstallSettings.InstallMode == InstallMode.Install)
				{
					await InstallNuterra();
				}
			}
			Close();
		}

		private async Task CopyPackage()
		{
			string source = InstallSettings.LocalPackageFile;
			string target = InstallPackageFile;
			if (!source.Equals(target, StringComparison.OrdinalIgnoreCase))
			{
				File.Copy(source, target, true);
			}
		}

		private void PrepareInstall()
		{
			const string pattern = "TerraTech*_Data";
			TerraTechDataDir = Directory.GetDirectories(InstallSettings.TerraTechDirectory, pattern).SingleOrDefault();
			if (TerraTechDataDir == null)
			{
				Abort($"Unable to find TerraTech data directory using '{pattern}' pattern", contactModTeam: false);
				return;
			}
			if (!File.Exists(TerraTechMainAssemblyFile))
			{
				Abort($"Assembly-CSharp.dll is missing from '{TerraTechMainAssemblyFile}'", contactModTeam: false);
				return;
			}
			CreateInstallDataDir();
		}

		private async Task DownloadPackage()
		{
			ReleaseAsset asset = InstallSettings.SelectedRelease.Assets.FirstOrDefault(IsInstallPackageAsset);
			if (asset == null)
			{
				Abort("The selected release has no installable package associated with it", contactModTeam: true);
				return;
			}
			WebClient client = new WebClient();
			client.DownloadProgressChanged += Client_DownloadProgressChanged;
			await client.DownloadFileTaskAsync(asset.BrowserDownloadUrl, InstallPackageFile);
			client.DownloadProgressChanged -= Client_DownloadProgressChanged;
		}

		private bool IsInstallPackageAsset(ReleaseAsset arg)
		{
			return (arg != null) && InstallPackageName.Equals(arg.Name, StringComparison.OrdinalIgnoreCase);
		}

		private void CreateInstallDataDir()
		{
			if (Directory.Exists(InstallDataDir))
			{
				Directory.Delete(InstallDataDir, true);
			}
			Directory.CreateDirectory(InstallDataDir);
		}

		private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			downloadPackageProgress.Value = e.ProgressPercentage;
		}

		private async Task UnpackResources()
		{
			unpackResourcesProgress.Style = ProgressBarStyle.Marquee;
			ZipFile.ExtractToDirectory(InstallPackageFile, InstallDataDir);
			unpackResourcesProgress.Style = ProgressBarStyle.Continuous;
			unpackResourcesProgress.Value = unpackResourcesProgress.Maximum;
		}

		private async Task ModifyAccessors()
		{
			if (!File.Exists(AccessorModFile))
			{
				Abort($"The package is missing '{Path.GetFileName(AccessorModFile)}'", contactModTeam: true);
				return;
			}
			string pattern = "TerraTech*_Data";
			using (var modifier = new AccessModifier(TerraTechMainAssemblyFile))
			using (var fs = new FileStream(AccessorModFile, System.IO.FileMode.Open))
			using (var reader = new StreamReader(fs))
			{
				try
				{
					modifier.ApplyFromReader(reader);
				}
				catch (Exception ex)
				{
					StringBuilder builder = new StringBuilder();
					while (ex != null)
					{
						builder.AppendLine(ex.Message);
						builder.AppendLine(ex.StackTrace);
						builder.AppendLine();
					}
					File.WriteAllText(InstallErrorFile, builder.ToString());
					Abort($"An error occured while modifying the assembly. Please check '{InstallErrorFile}' for details.", contactModTeam: false);
					return;
				}
			}
		}

		private async Task InstallNuterra()
		{
			throw new NotImplementedException();
		}

		private void Abort(string reason, bool contactModTeam)
		{
			Aborted = true;
			string message = $"{reason}.{(contactModTeam ? " Please contact the mod-team to have it fixed" : string.Empty)}";
			MessageBox.Show(this, message, "Install aborted", MessageBoxButtons.OK, MessageBoxIcon.Error);
			Close();
		}
	}
}
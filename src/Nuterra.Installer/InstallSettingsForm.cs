using System;
using Octokit;

using System;

using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Nuterra.Installer
{
	public partial class InstallSettingsForm : Form
	{
		private List<Release> _releases = new List<Release>();

		private Dictionary<InstallMode, string> _installModeDescriptions = new Dictionary<InstallMode, string>
		{
			{ InstallMode.Install, "Install Nuterra" },
			{ InstallMode.AccessorOnly, "Modify accessors (for nuterra devs)" },
		};

		private Dictionary<PackageSource, string> _installSourceDescriptions = new Dictionary<PackageSource, string>
		{
			{ PackageSource.Github, "Github download" },
			{ PackageSource.Local, "Local file" },
		};

		public string TerraTechDirectory

		{
			get { return terraTechDirTextBox.Text; }
			set { terraTechDirTextBox.Text = value; }
		}

		public InstallMode InstallMode
		{
			get { return ((KeyValuePair<InstallMode, string>)installModeComboBox.SelectedItem).Key; }
			set { installModeComboBox.SelectedItem = new KeyValuePair<InstallMode, string>(value, _installModeDescriptions[value]); }
		}

		public PackageSource PackageSource
		{
			get { return ((KeyValuePair<PackageSource, string>)packageSourceComboBox.SelectedItem).Key; }
			set { ApplyPackageSource(value); }
		}

		public Release SelectedRelease
		{
			get { return (Release)releaseComboBox.SelectedItem; }
			set { releaseComboBox.SelectedItem = value; }
		}

		public string LocalPackage
		{
			get { return localPackageTextBox.Text; }
			set { localPackageTextBox.Text = value; }
		}

		public InstallSettingsForm()
		{
			InitializeComponent();
		}

		private void InstallSettingsForm_Load(object sender, EventArgs e)
		{
			DownloadNuterraReleases();

			installModeComboBox.ValueMember = "Key";
			installModeComboBox.DisplayMember = "Value";
			installModeComboBox.Items.AddRange(_installModeDescriptions.Cast<object>().ToArray());
			InstallMode = InstallMode.Install;

			packageSourceComboBox.ValueMember = "Key";
			packageSourceComboBox.DisplayMember = "Value";
			packageSourceComboBox.Items.AddRange(_installSourceDescriptions.Cast<object>().ToArray());
			PackageSource = PackageSource.Github;

			releaseComboBox.DisplayMember = "TagName";
		}

		private async void DownloadNuterraReleases()
		{
			GitHubClient client = new GitHubClient(new ProductHeaderValue("nuterra-installer"));
			var releases = await client.Repository.Release.GetAll("maritaria", "nuterra");
			_releases = new List<Release>(releases);
			UpdateReleaseComboBox();
		}

		private void UpdateReleaseComboBox()
		{
			Release previouslySelectedRelease = SelectedRelease;
			bool restorePreviousSelection = false;
			releaseComboBox.Items.Clear();
			foreach (Release release in _releases)
			{
				if (!release.Prerelease || includePreReleasesCheckBox.Checked)
				{
					releaseComboBox.Items.Add(release);
					if (release?.TagName == previouslySelectedRelease?.TagName)
					{
						previouslySelectedRelease = release;
						restorePreviousSelection = true;
					}
				}
			}
			if (restorePreviousSelection)
			{
				releaseComboBox.SelectedItem = previouslySelectedRelease;
			}
			else
			{
				releaseComboBox.SelectedIndex = 0;
			}
		}

		private void refreshVersionsButton_Click(object sender, EventArgs e)
		{
			DownloadNuterraReleases();
		}

		private void includePreReleasesCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			UpdateReleaseComboBox();
		}

		private void installDirButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "TerraTech|TerraTechWin64.exe";
			dialog.Multiselect = false;

			DialogResult result = dialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				TerraTechDirectory = new FileInfo(dialog.FileName).Directory.FullName;
			}
		}

		private void ApplyPackageSource(PackageSource value)
		{
			packageSourceComboBox.SelectedItem = new KeyValuePair<PackageSource, string>(value, _installSourceDescriptions[value]);
			switch (value)
			{
				case PackageSource.Github:
					packageSourceTabControl.SelectTab(githubPackageTab);
					break;
				case PackageSource.Local:
					packageSourceTabControl.SelectTab(localPackageTab);
					break;
			}
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			var settings = new InstallSettings
			{
				TerraTechDirectory = TerraTechDirectory,
				InstallMode = InstallMode,
				PackageSource = PackageSource,
				SelectedRelease = SelectedRelease,
				LocalPackageFile = LocalPackage,
			};
			InstallProgressForm form = new InstallProgressForm(settings);
			form.ShowDialog();
		}

		private void packageSourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ApplyPackageSource(PackageSource);
		}

		private void localPackageButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "mod package|mod.zip";
			dialog.Multiselect = false;

			DialogResult result = dialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				LocalPackage = new FileInfo(dialog.FileName).FullName;
			}
		}
	}
}
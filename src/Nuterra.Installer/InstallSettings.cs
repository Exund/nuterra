using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuterra.Installer
{
	public sealed class InstallSettings
	{
		public string TerraTechDirectory { get; set; }
		public Release SelectedRelease { get; set; }
		public InstallMode InstallMode { get; set; }
		public string LocalPackageFile { get; set; }
		public PackageSource PackageSource { get; internal set; }
	}
}

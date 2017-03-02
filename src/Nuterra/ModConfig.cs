using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Nuterra
{
	public static class ModConfig
	{
		public static JObject Data { get; }

		static ModConfig()
		{
			string configData = File.ReadAllText(Path.Combine(NuterraMain.DataFolder, "nuterra.json"));
			Console.WriteLine($"configData: {configData}");
			Data = JObject.Parse(configData);
		}
	}
}
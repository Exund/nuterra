using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Nuterra.Installer
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			/*
			var mod = new AccessModifier(Assembly.GetCallingAssembly().Location);
			var mod2 = new AccessModifier("rewrite.test.dll");
			mod.ApplyFromReader(null);
			*/
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new InstallSettingsForm());
		}
	}
}


public class AAA<T>
{
	public T ToStringy()
	{
		return default(T);
	}
	public class AAASubClass<G>
	{

	}
}
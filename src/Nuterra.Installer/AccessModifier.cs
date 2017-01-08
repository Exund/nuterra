using System;
using Mono.Cecil;

using System;

using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Nuterra.Installer
{
	public sealed class AccessModifier : IDisposable
	{
		private string _assemblyPath;
		private Mono.Cecil.AssemblyDefinition _assembly;

		public AccessModifier(string assemblyFilePath)
		{
			if (assemblyFilePath == null) throw new ArgumentNullException(nameof(assemblyFilePath));
			_assemblyPath = assemblyFilePath;
			_assembly = AssemblyDefinition.ReadAssembly(assemblyFilePath, new ReaderParameters(ReadingMode.Deferred));
		}

		public void ApplyFromReader(StreamReader reader)
		{
			string[] lines = reader.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			lines.AsParallel().ForAll(ApplyLine);
		}

		private void ApplyLine(string line)
		{
			//field namespace.typename fieldname (field becomes public)
			//method namespace.typename methodname (all overloads public)
			//type namespace.typename
			//typename: AAA`1/AAASubClass`1 (how to use nested types)
			string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			string subject = parts[0];
			TypeDefinition type = _assembly.MainModule.GetType(fullName: parts[1]);
			switch (subject.ToLower())
			{
				case "type": MakeTypePublic(type); break;
				case "field": MakeFieldPublic(type, parts[2]); break;
				case "method": MakeMethodsPublic(type, parts[2]); break;
				default:
					throw new NotSupportedException($"Unknown subject '{subject}'");
			}
		}

		private void MakeTypePublic(TypeDefinition type)
		{
			type.IsPublic = true;
		}

		private void MakeFieldPublic(TypeDefinition type, string memberName)
		{
			type.Fields.Single(field => field.Name.Equals(memberName, StringComparison.Ordinal)).IsPublic = true;
		}

		private void MakeMethodsPublic(TypeDefinition type, string memberName)
		{
			foreach (var method in type.Methods.Where(method => method.Name.Equals(memberName, StringComparison.Ordinal)))
			{
				method.IsPublic = true;
			}
		}

		public void Dispose()
		{
			_assembly.Write(_assemblyPath);
		}
	}
}
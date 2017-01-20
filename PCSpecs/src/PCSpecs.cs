using System;
using System.IO;

namespace PCSpecs 
{
	
	public class MainClass 
	{
		
		private static void WriteInfo(string info) 
		{
			string timenow = string.Format("{0}", DateTime.Now.ToString("dd-MM-yyyy - HH-mm-ss"));
			string filename = string.Format("PCSpecs - Result [{0}].txt", timenow);

			using (StreamWriter wf = File.CreateText(filename)) {
				wf.WriteLine(info);
			}

			Console.WriteLine(string.Format("Arquivo escrito em: {0}\\{1}", Environment.CurrentDirectory, filename));
		}

		public static void ShowInfo(bool write) 
		{
			string is64Bit;
			if (Environment.Is64BitOperatingSystem == true) {
				is64Bit = "Sim";
			}
			else {
				is64Bit = "Não";
			}

			string result = string.Format(
							"Informações do PC:\r\n" + 
							"==================\r\n\r\n" +
							
							"Sistema:\r\n" +
							"--------\r\n" +			
							"Nome da máquina: {0}\r\n" +
							"Versão do sistema: {1}\r\n" +
							"64-bit: {2}\r\n" +
							"Processadores: {3}\r\n" +
							"Versão CLR: {4}\r\n\r\n" +
							
							"Local:\r\n" +
							"------\r\n" +
							"Usuário atual: {5}\r\n" +
							"Diretório atual: {6}\r\n" +
							"Comando de execução: {7}\r\n", 
							Environment.MachineName,
							Environment.OSVersion,
							is64Bit,
							Environment.ProcessorCount,
							Environment.Version,
							Environment.UserName,
							Environment.CurrentDirectory,
							Environment.CommandLine);

			Console.WriteLine(result);
			if (write == true) {
				WriteInfo(result);
			}
		}
		
		public static void Main(string[] args) 
		{
			bool createFile = false;

			if (args.Length == 1) {
				if (args[0].Equals("-f") || args[0].Equals("--file")) {
					createFile = true;
				}
			}
			ShowInfo(createFile);
		}
	}
}
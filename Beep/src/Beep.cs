/*
The MIT License (MIT)

Copyright (c) 2016 Wolfgang Almeida <wolfgang.almeida@yahoo.com>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;

namespace BeepBeep {
	public class MainClass {
		public static int ChooseFreq() {
			int freq;
			Console.Write("Escolha a frequência do beep (hertz): ");
			string freqS = Console.ReadLine();

			if(!Int32.TryParse(freqS, out freq)) {
				return 800;
			}
			else {
				return freq;
			}
		}

		public static int ChooseDur() {
			int dur;
			Console.Write("Escolha a duração do beep (milissegundos): ");
			string durS = Console.ReadLine();

			if(!Int32.TryParse(durS, out dur)) {
				return 200;
			}
			else {
				return dur;
			}
		}

		public static void ConstantMode(int freq, int dur) {
			Console.WriteLine("Pressione CTRL + C para sair...");

			while(true) {
				Console.Beep(freq, dur);
			}
		}

		public static void TouchMode(int freq, int dur) {
			Console.WriteLine("Pressione X ou CTRL + C para sair...");

			ConsoleKeyInfo keyinfo;
	        do
	        {
	            keyinfo = Console.ReadKey();
	            Console.Beep(freq,dur);
	        }
	        while (keyinfo.Key != ConsoleKey.X);
		}

		public static void Main() {
			string version = "1.1";
			string choose;
			int freq, dur;

			Console.WriteLine("=======================================");
			Console.WriteLine("Beep: O programa que bipa! - Versão " + version);
			Console.WriteLine("=======================================\n");

			Console.WriteLine("Escolha o modo do programa:");
			Console.WriteLine("---------------------------");
			Console.WriteLine("(1) Modo Toque - Bipa quando tecla for pressionada");
			Console.WriteLine("(2) Modo Constante - Bipa constantemente até o programa ser fechado\n");

			Console.Write("Escolha o modo (qualquer outra opção para sair): ");
			choose = Console.ReadLine();

			if (choose == "1") {
				freq = ChooseFreq();
				dur = ChooseDur();
				TouchMode(freq, dur);
			}
			else if (choose == "2") {
				freq = ChooseFreq();
				dur = ChooseDur();
				ConstantMode(freq, dur);
			}
			else {
				Console.WriteLine("Saindo...");
			}
		}
	}
}

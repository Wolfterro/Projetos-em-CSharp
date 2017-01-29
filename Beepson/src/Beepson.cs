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
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace Beepson
{
	// Classe com variáveis globais com informações 
	// de pontuação, nível e sequência.
	// ============================================
	public static class ScoreBoard
	{
		public static int points = 0;
		public static int level = 1;
		public static List<string> RandomSequence = new List<string>();
	}
	
	// Classe principal do programa.
	// =============================
    class MainClass
    {
		
		// Bipa de acordo com a entrada na sequência sorteada ou do jogador.
		// =================================================================
		static void BeepsonBeepSequence(string s) 
		{
			int duration = 1000 - (10 * ScoreBoard.level);
			if (duration < 100) {
				duration = 100;
			}
			
			switch(s) {
				case "A":
					Console.Beep(500, duration);
					break;
				case "S":
					Console.Beep(2500, duration);
					break;
				case "D":
					Console.Beep(4500, duration);
					break;
				case "F":
					Console.Beep(6500, duration);
					break;
				default:
					break;
			}
		}
		
		// Sorteia uma entrada aleatória e insere na lista de sequência.
		// =============================================================
		static string[] BeepsonGetSequence() 
		{
			string[] PossibleEntries = {"A", "S", "D", "F"};
			string[] RandomSequence = new string[ScoreBoard.level];
			Random random = new Random();		// So much random...
			
			int x = random.Next(0, 4);
			ScoreBoard.RandomSequence.Add(PossibleEntries[x]);
			
			RandomSequence = ScoreBoard.RandomSequence.ToArray();
			return RandomSequence;
		}
		
		// Método de jogo do programa.
		// Caso o jogador erre, o loop no método Main() será descontinuado.
		// ================================================================
		static bool BeepsonGame()
		{
			ConsoleKeyInfo KeyInfo;
			string KeyInput;
			string[] sequence;
			
			string topscore = string.Format("Pontos do(a) Jogador(a): {0} - Nível {1}", ScoreBoard.points, ScoreBoard.level);
			
			Console.WriteLine(topscore);
			Console.WriteLine(string.Concat(Enumerable.Repeat("-", topscore.Length)));
			Thread.Sleep(1000);
			
			Console.WriteLine("Siga esta sequência (espere até terminar)...");
			sequence = BeepsonGetSequence();
			
			foreach (string i in sequence) {
				BeepsonBeepSequence(i);
				// Console.WriteLine("Input: {0}", i);		// Caso queira trapacear...
			}
			
			Console.WriteLine("Insira a sequência: ");
			foreach (string i in sequence) {
				KeyInfo = Console.ReadKey();
				KeyInput = KeyInfo.KeyChar.ToString().ToUpper();
				
				if (KeyInput != i) {
					Console.Beep(100, 1000);
					Console.WriteLine("\n\n------------------------");
					Console.WriteLine("Você errou! Fim de jogo!");
					Console.WriteLine("Pontuação final: {0}", ScoreBoard.points);
					Console.WriteLine("Nível: {0}", ScoreBoard.level);
					Console.WriteLine("------------------------\n");
					
					Console.WriteLine("Pressione ENTER para sair...");
					Console.ReadLine();
					return false;
				}
				else {
					BeepsonBeepSequence(KeyInput);
				}
			}
			
			Console.WriteLine("\n\n--------------------------------------------------");
			Console.WriteLine("Correto! Pressione ENTER para ir ao próximo nível!");
			Console.WriteLine("--------------------------------------------------");
			
			Console.ReadLine();
			Console.Clear();
			
			return true;
		}
		
		// Instruções de jogo, mostrando os sons das teclas.
		// =================================================
        static void BeepsonInstructions()
        {
            bool repeat = true;

            do
            {
				Console.WriteLine("Aqui estão as instruções:");
				Console.WriteLine("-------------------------");
			
                Console.WriteLine("Tecla (A) produz este som...");
                Console.Beep(500, 1000);
                Thread.Sleep(2000);

                Console.WriteLine("Tecla (S) produz este som...");
                Console.Beep(2500, 1000);
                Thread.Sleep(2000);

                Console.WriteLine("Tecla (D) produz este som...");
                Console.Beep(4500, 1000);
                Thread.Sleep(2000);

                Console.WriteLine("Tecla (F) produz este som...\n");
                Console.Beep(6500, 1000);
                Thread.Sleep(2000);

                Console.Write("Deseja repetir as instruções? [s/N]: ");
                if (Console.ReadLine().ToUpper() != "S") {
                    repeat = false;
                } 
				else {
					Console.Clear();
				}

            } while (repeat);

            Console.WriteLine("\nEntão você está pronto para o jogo!");
			Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
			Console.Clear();
        }

		// Método principal do programa.
		// =============================
        static void Main(string[] args)
        {
            string version = "1.0";

            Console.WriteLine("====================");
            Console.WriteLine("Beepson - Versão {0}", version);
            Console.WriteLine("====================\n");

            Thread.Sleep(1000);
            BeepsonInstructions();
			
			while(BeepsonGame()) {
				ScoreBoard.level += 1;
				ScoreBoard.points += 10;
			}
        }
    }
}
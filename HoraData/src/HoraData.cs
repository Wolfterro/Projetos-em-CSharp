using System;
using System.Threading;

namespace HoraData {
	// Classe Principal do Programa
	public class MainClass {

		// Método Principal do Programa
		public static void Main() {
			
			// Declarações de Variáveis
			string version = "1.0";
			string diaDaSemana;
			string mes;

			// Apresentação do Programa
			Console.WriteLine("========================");
			Console.WriteLine("Hora & Data - Versão {0}", version);
			Console.WriteLine("========================");
			Console.WriteLine("Dica: Pressione CTRL + C para sair do programa!\n");	

			// Contador do Programa, atualiza a data e hora a cada 1 segundo
			while(true) {
				
				// Switch para determinar o dia da semana
				switch((int)DateTime.Now.DayOfWeek) {
					case 0:
						diaDaSemana = "Domingo";
						break;
					case 1:
						diaDaSemana = "Segunda-Feira";
						break;
					case 2:
						diaDaSemana = "Terça-Feira";
						break;
					case 3:
						diaDaSemana = "Quarta-Feira";
						break;
					case 4:
						diaDaSemana = "Quinta-Feira";
						break;
					case 5:
						diaDaSemana = "Sexta-Feira";
						break;
					case 6:
						diaDaSemana = "Sábado";
						break;
					default:
						diaDaSemana = "N/D";
						break;
				}

				// Switch para determinar o nome do mês
				switch((int)DateTime.Now.Month) {
					case 1:
						mes = "Janeiro";
						break;
					case 2:
						mes = "Fevereiro";
						break;
					case 3:
						mes = "Março";
						break;
					case 4:
						mes = "Abril";
						break;
					case 5:
						mes = "Maio";
						break;
					case 6:
						mes = "Junho";
						break;
					case 7:
						mes = "Julho";
						break;
					case 8:
						mes = "Agosto";
						break;
					case 9:
						mes = "Setembro";
						break;
					case 10:
						mes = "Outubro";
						break;
					case 11:
						mes = "Novembro";
						break;
					case 12:
						mes = "Dezembro";
						break;
					default:
						mes = "N/D";
						break;
				}

				// Data e Hora são atualizados usando a mesma linha no console
				Console.Write("\r{0} - {1} de {2} de {3} - {4}", 
					diaDaSemana, DateTime.Now.ToString("dd"), 
					mes, DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("HH:mm:ss"));
				
				// Thread Principal espera 1 segundo antes de continuar o loop
				Thread.Sleep(1000);
			}
		}
	}
}

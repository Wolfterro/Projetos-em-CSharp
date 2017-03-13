/* 
The MIT License (MIT)

Copyright (c) 2017 Wolfgang Almeida <wolfgang.almeida@yahoo.com>

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

namespace Program
{
    class MainClass 
    {
        // Nosso objeto Logging utilizando um arquivo diferente
        // ----------------------------------------------------
        static Logging log = new Logging("LoggingFile.txt");
        
        // Método ruim, catalogando a mensagem de IndexOutOfRangeException
        // ---------------------------------------------------------------
        static void BadMethod()
        {
            string[] Fruits = {"Maçãs", "Bananas", "Laranjas"};
            
            try 
            {
                for(int i = 0; i < 4; i++) 
                {
                    Console.WriteLine("Eu gosto de {0}!", Fruits[i]);
                }
            }
            catch (IndexOutOfRangeException e) 
            {
                Console.WriteLine("Oops! Algo deu errado! Verifique o log!");
                log.WriteLog(e.ToString());
            }
        }
        
        // Métodos simples para testes
        // ---------------------------
        static void Multiply(int i, int j)
        {
            Console.WriteLine("O resultado de {0} * {1}: {2}", i, j, i * j);
            log.WriteLog(string.Format("Método: {0} - Resultado: {1}", 
               "Multiply(int i, int j)", i * j));
        }
        
        static void Subtract(int i, int j)
        {
            Console.WriteLine("O resultado de {0} - {1}: {2}", i, j, i - j);
            log.WriteLog(string.Format("Método: {0} - Resultado: {1}", 
                "Subtract(int i, int j)", i - j));
        }
        
        static void Add(int i, int j)
        {
            Console.WriteLine("O resultado de {0} + {1}: {2}", i, j, i + j);
            log.WriteLog(string.Format("Método: {0} - Resultado: {1}", 
                "Add(int i, int j)", i + j));
        }
    
        static void Main()
        {
            Console.WriteLine("Basic Logging Program:");
            Console.WriteLine("======================\n");
            
            Add(10, 20);
            Subtract(50, 10);
            Multiply(12, 12);
            
            BadMethod();
            
            Console.WriteLine("\nLendo Log:");
            Console.WriteLine("----------");
            log.ReadLog();
        }
    }
}
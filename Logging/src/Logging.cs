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
using System.IO;

namespace Program
{
    public class Logging
    {
        // Variáveis da Classe
        // ===================
        public string Filename {get; set;}
        
        // Construtor Padrão
        // =================
        public Logging()
        {
            this.Filename = "Log.txt";
        }
        
        // Construtor Customizado
        // ======================
        public Logging(string Filename)
        {
            this.Filename = Filename;
        }
        
        // Métodos da Classe
        // =================
        
        // Métodos Públicos
        // --------------
        
        // Escrevendo a mensagem no arquivo de log
        // ---------------------------------------
        public void WriteLog(string Message)
        {
            try
            {
                using(StreamWriter Log = new StreamWriter(this.Filename, true))
                {
                    Log.WriteLine("[{0}] {1}", DateTime.Now, Message);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Erro! Arquivo de Logging não pôde ser acessado!");
            }
        }
        
        // Lendo as mensagens do arquivo de log
        // ------------------------------------
        public void ReadLog()
        {
            string LogText = "";
            try
            {
                using(StreamReader Log = new StreamReader(this.Filename))
                {
                    LogText = Log.ReadToEnd();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Erro! Arquivo de Logging não encontrado!");
            }
            
            Console.WriteLine(LogText);
        }
    }
}
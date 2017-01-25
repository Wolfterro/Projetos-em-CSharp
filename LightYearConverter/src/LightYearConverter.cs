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
using System.Numerics;

namespace LightYearConverter
{

    class MainClass
    {
        static string ConvertToLightYears(BigInteger kilometers)
        {
            BigInteger LightYearInKilometers = new BigInteger();
            LightYearInKilometers = 9460730472580800;              // 1 ly = 9.460.730.472.580.800 km

            double result = (double)kilometers / (double)LightYearInKilometers;

            return string.Format("{0}", result);
        }

        static string ConvertToKilometers(BigInteger lightyears)
        {
            BigInteger LightYearInKilometers = new BigInteger();
            LightYearInKilometers = 9460730472580800;              // 1 ly = 9.460.730.472.580.800 km

            return string.Format("{0}", LightYearInKilometers * lightyears);
        }

        static void GetUserValue(int SelectedOption)
        {
            string Result;

            Console.Write("Insira o valor que deseja converter: ");
            switch (SelectedOption)
            {
                case 1:
                    BigInteger UserValueOption1 = new BigInteger();
                    UserValueOption1 = BigInteger.Parse(Console.ReadLine());
                    Result = ConvertToKilometers(UserValueOption1);

                    Console.WriteLine("O resultado é: {0} km", Result);
                    break;
                case 2:
                    BigInteger UserValueOption2 = new BigInteger();
                    UserValueOption2 = BigInteger.Parse(Console.ReadLine());
                    Result = ConvertToLightYears(UserValueOption2);

                    Console.WriteLine("O resultado é: {0} ly", Result);
                    break;
                default:
                    break;
            }

            Console.Read();
        }

        static void Main(string[] args)
        {
            string Version = "1.0";
            string Option;

            Console.WriteLine("=================================");
            Console.WriteLine("Light-Year Converter - Versão {0}", Version);
            Console.WriteLine("=================================\n");

            Console.WriteLine("Escolha uma das opções abaixo (qualquer outra tecla para sair):");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("(1) Anos-Luz para Quilômetros");
            Console.WriteLine("(2) Quilômetros para Anos-Luz\n");

            Console.Write("Sua escolha: ");
            Option = Console.ReadLine();

            switch (Option)
            {
                case "1":
                    GetUserValue(1);
                    break;
                case "2":
                    GetUserValue(2);
                    break;
                default:
                    Console.WriteLine("Saindo...");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

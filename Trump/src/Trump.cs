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
using System.Threading;

namespace Trump
{
    /* Global variables class */
    public static class GlobalVars
    {
        public static ConsoleColor OriginalColor = Console.ForegroundColor;
        public static double Meters = 0.0;
        public static bool Building = true;
    }

    /* Program's main class */
    class MainClass
    {
        /* Shows how much you've built when you exit the program */
        static void BuiltSoFar(object sender, ConsoleCancelEventArgs args)
        {
            Console.ForegroundColor = GlobalVars.OriginalColor;
            Console.WriteLine("\nBuilt so far: {0} meters", string.Format("{0:0.00}", GlobalVars.Meters / 10));

            GlobalVars.Building = false;
        }

        /* Make Programming Great Again */
        static void BuildingWall(ConsoleColor color)
        {
            Console.WriteLine("Building wall (press CTRL + C to stop)...");
            Thread.Sleep(1000);
            Console.ForegroundColor = color;

            Console.CancelKeyPress += new ConsoleCancelEventHandler(BuiltSoFar);
            while (GlobalVars.Building)
            {
                Console.Write("|¯¯¯¯");
                Thread.Sleep(80);

                GlobalVars.Meters += 0.2;
            }
        }

        /* Help menu */
        static void HelpMenu()
        {
            Console.WriteLine("Trump.cs - Makes Programming Great Again!");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Usage: ./Trump.exe [COLOR]\n");

            Console.WriteLine("Colors");
            Console.WriteLine("------");
            Console.WriteLine("  -rw || --red-wall\tBuilds a red wall.");
            Console.WriteLine("  -gw || --green-wall\tBuilds a green wall.");
            Console.WriteLine("  -yw || --yellow-wall\tBuilds a yellow wall.");
            Console.WriteLine("  -bw || --blue-wall\tBuilds a blue wall.");
            Console.WriteLine("  -mw || --magenta-wall\tBuilds a magenta wall.");
            Console.WriteLine("  -cw || --cyan-wall\tBuilds a cyan wall.");
            Console.WriteLine("  -ww || --white-wall\tBuilds a white wall.\n");

            Console.WriteLine(" * This program is the result of a joke allied with the lazyness from the programmer.");
            Console.WriteLine(" * Please, do not take this seriously!\n");

            Console.Read();
            Environment.Exit(0);
        }

        /* Main function, catches possible arguments from the terminal */
        static void Main(string[] args)
        {
            if (args.Length >= 1) {
                if (args[0].Equals("-rw") || args[0].Equals("--red-wall")) {
                    BuildingWall(ConsoleColor.Red);
                }

                else if (args[0].Equals("-gw") || args[0].Equals("--green-wall"))
                {
                    BuildingWall(ConsoleColor.Green);
                }

                else if (args[0].Equals("-yw") || args[0].Equals("--yellow-wall"))
                {
                    BuildingWall(ConsoleColor.Yellow);
                }

                else if (args[0].Equals("-bw") || args[0].Equals("--blue-wall"))
                {
                    BuildingWall(ConsoleColor.Blue);
                }

                else if (args[0].Equals("-mw") || args[0].Equals("--magenta-wall"))
                {
                    BuildingWall(ConsoleColor.Magenta);
                }

                else if (args[0].Equals("-cw") || args[0].Equals("--cyan-wall"))
                {
                    BuildingWall(ConsoleColor.Cyan);
                }

                else if (args[0].Equals("-ww") || args[0].Equals("--white-wall"))
                {
                    BuildingWall(ConsoleColor.White);
                }

                else if (args[0].Equals("-h") || args[0].Equals("--help"))
                {
                    HelpMenu();
                }

                else {
                    BuildingWall(ConsoleColor.White);
                }
            }
            else {
                BuildingWall(ConsoleColor.White);
            }
        }
    }
}

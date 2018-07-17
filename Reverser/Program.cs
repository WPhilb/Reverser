using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverser
{
    class Program
    {
        public static void DisplayUsage()
        {
            Console.WriteLine("usage: Reverser.exe input [-l] [-w] [-v]");
            Console.WriteLine("Reverses the string inputs");
            Console.WriteLine("-l Reverse the letters in the string");
            Console.WriteLine("-w Reverse the words in the string");
            Console.WriteLine("-v Verbose mode");
        }

        static void Main(string[] args)
        {
            bool verbose = false;
            string[] expectedFlags = { "-v", "-w", "-l" };

            if (args.Length == 0)
                Environment.Exit(0);

            //Retrieve mandatory string and flags
            string input = args[0];
            string[] flags = args.Skip(1).ToArray();
            string output = input;

            //Display usage and exit if an erroneous argument is found
            bool unexpectedFlag = flags.Any(flag => !expectedFlags.Contains(flag));
            if (unexpectedFlag)
            {
                DisplayUsage();
                Environment.Exit(0);
            }

            if (flags.Contains("-v"))
                verbose = true;

            Stopwatch stopwatch = Stopwatch.StartNew();

            //If flags include a reversing operation, output statistics
            if (verbose)
            {
                if (flags.Contains("-w") || flags.Contains("-l"))
                {
                    Console.WriteLine(
                        "Reversing {0} words with {1} letters in total:",
                        input.Trim(' ').Split(' ').Length,
                        input.Length
                    );
                }
            }

            if (flags.Contains("-w"))
                output = Operations.ReverseWords(output);

            if (flags.Contains("-l"))
                output = Operations.ReverseLettersInEachWord(output);

            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;

            Console.WriteLine(output);

            if (verbose)
                Console.Write("Completed in {0} seconds", elapsed.TotalSeconds);
        }
    }
}

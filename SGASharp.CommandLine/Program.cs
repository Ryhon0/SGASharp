using System;
using System.Linq;
using SGASharp;

namespace SGASharp.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            bool reverse = false;
            if (args.Length != 0) reverse = args[0] == "-r";
            if(reverse) args[0] = "";

            string text = string.Join(' ', args).Trim();
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Enter text to translate");
                text = Console.ReadLine();
            }

            Console.WriteLine(reverse ? text.SGAToLatin() : text.LatinToSGA());
            }
    }
}

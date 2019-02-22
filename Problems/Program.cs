using System;

namespace Problems
{
     public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.Read().ToString();
            Console.WriteLine(Prefix(input));
        }

        static string Prefix(string input)
        {
            int length = input.Length;

            if (input == null)
                    return null;
            if (input == "")
                    return "0.0:";

            return $"{length},{input.Split(' ').Length}:";
        }
    }
}

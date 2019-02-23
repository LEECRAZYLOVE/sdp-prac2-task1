using System;

namespace Problems
{
     public class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            Console.WriteLine(P.Prefix("Hello World"));
        }

         public string Prefix(string input)
        {
            int length = input.Length;

            if (input == null)
                return null;
            if (input == "")
                return "0,0:";

            string Words = "";
            
            foreach (string j in input.Split(' '))
            { 
                if (j.Length >= 1)
                {
                    Words += j + " ";
                }
            }
            return $"{length},{Words.Split(" ").Length - 1}:";
        }
    }
}

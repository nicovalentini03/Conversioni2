using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("inserisci un carattere");
            s = Console.ReadLine();
            foreach (char c in s)
            {
                Console.WriteLine((int)c);
                Console.ReadLine();
            }
        }
    }
}

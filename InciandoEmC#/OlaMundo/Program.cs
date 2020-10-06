using System;
using System.ComponentModel;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string nome = Console.ReadLine();
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Acabamos de conhecer {nome}, que está com {idade} anos");
        }
    }
}

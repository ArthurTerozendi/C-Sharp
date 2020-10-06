using System;
namespace PrimeirosProgramas
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Calculadora simples que aceita somente dois números
             */
            CalculadoraSimples calculadoraSimples = new CalculadoraSimples();
            Random rng = new Random();
            double num1 = Convert.ToDouble(rng.Next(10));
            double num2 = Convert.ToDouble(rng.Next(10));

            Console.WriteLine(calculadoraSimples.Somar(num1, num2));
            Console.WriteLine(calculadoraSimples.Subtrair(num1, num2));
            Console.WriteLine(calculadoraSimples.Multiplicar(num1, num2));
            Console.WriteLine(calculadoraSimples.Dividir(num1, num2));
        }
    }
}

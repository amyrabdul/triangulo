using System;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, af;

            Console.WriteLine("Vamos calcular a area de um triangulo");
            Console.Write("Digite a altura : ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite a base: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine();

            af = (a * b)/2;
            Console.WriteLine($"O Valor da area é de {af}");
            Console.WriteLine();
        }
    }
}

using System;
using System.Globalization;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            r.Largura = Double.Parse(Console.ReadLine());
            r.Altura = Double.Parse(Console.ReadLine());
            Console.WriteLine(r);

        }
    }
}

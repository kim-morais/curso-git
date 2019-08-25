using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercício
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return (2 * Altura) + (2 * Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Altura, 2)) + Math.Pow(Largura, 2));
        }

        public override string ToString()
        {
            return "AREA = "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + " PERÍMETRO = " 
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture) 
                + " Diagonal = " 
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

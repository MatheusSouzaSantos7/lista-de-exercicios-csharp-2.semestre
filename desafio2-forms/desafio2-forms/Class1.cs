using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio2_forms
{
    class Valores
    {
        // Atributos ou campos
        public double x, y, z;
        public string Calcular()
        {
            if (x < (y+z) && y < (z+x) && z < (x+y))
            {
                if (x == y && y == z)
                {
                    return "É um triângulo equilátero";
                }
                else if (x == y && y != z || y == z && z != x || x == z && z != y)
                {
                    return "É um triângulo isóceles";
                }
                else
                {
                    return "É um triângulo escaleno";
                }
            }
            else 
            { 
                return "Os dados informados não formam um triângulo";
            }
        }
    }
    internal class Class1
    {

    }
}

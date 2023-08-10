using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_lista2_exercicio1
{
    public static class Calculadora
    {
        public static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            /*Construa uma classe estática chamada Calculadora em C# com um método
            estático chamado Somar que recebe dois números inteiros como parâmetros e
            retorna a soma desses números. */
            double n1, n2;
            Console.WriteLine("Escreva dois valores:");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            double res = Calculadora.Somar(n1, n2);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

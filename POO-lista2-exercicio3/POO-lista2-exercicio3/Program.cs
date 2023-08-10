using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO_lista2_exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Construa uma classe estática chamada Matematica em C# com um método
            estático chamado Potencia que recebe um número inteiro x e um número inteiro n
            como parâmetros e retorna o valor de x elevado a n. */

            double x, n, res;
            Console.WriteLine("Escreva dois valores, iremos multiplicar o primeiro pelo segundo valor");
            x = Convert.ToDouble(Console.ReadLine());
            n = Convert.ToDouble(Console.ReadLine());
            res = Matematica.Potencia(x,n);
            Console.WriteLine("{0} elevado a {1} é igual a {2}", x, n, res);
            Console.ReadKey();
        }
    }
}

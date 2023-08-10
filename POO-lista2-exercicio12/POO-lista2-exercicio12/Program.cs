using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_lista2_exercicio12
{

    internal class Program
    {
        static void Main(string[] args)
        {
            /* Construa uma classe chamada Estatisticas em C# com um método estático
            chamado Media que recebe um array de números inteiros como parâmetro e
            retorna a média dos números. */

            int i; // Indicador do vetor
            int c = 0; // Contador
            double media;
            Console.WriteLine("Quantos números você quer escrever?");
            i = Convert.ToInt32(Console.ReadLine());

            int[] n = new int[i]; // Criação do vetor como número de valores escolhidos

            Console.WriteLine("Escreva {0} números: ", i);
            while (c < i)
            {
                n[c] = Convert.ToInt32(Console.ReadLine());
                c++;
            }
            media = Estatisticas.Media(n, i);
            Console.WriteLine("A média dos valores é {0}", media);
            Console.ReadKey();
        }
    }
}

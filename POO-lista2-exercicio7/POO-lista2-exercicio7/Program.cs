using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_lista2_exercicio7
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Construa uma classe chamada Pessoa em C# com uma propriedade estática
            chamada TotalPessoas que guarda o número total de instâncias da classe criadas.
            O valor de TotalPessoas deve ser atualizado sempre que uma nova instância de
            Pessoa for criada. */
            string escolha;
            int totalpessoas = 0;
            while (true)
            {
                Console.WriteLine("Criar uma nova instancia? s/n");
                escolha = Console.ReadLine();
                if (escolha == "n")
                {
                    break;
                }
                else if (escolha == "s")
                {
                    totalpessoas = Pessoa.TotalPessoas();
                }
                else
                {
                    Console.WriteLine("ERRO! Digite novamente");
                }
            }
            Console.WriteLine("total de pessoas: {0}", totalpessoas);
            Console.ReadKey();
        }
    }
}

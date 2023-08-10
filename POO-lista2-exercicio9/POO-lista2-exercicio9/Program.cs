using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_lista2_exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Construa uma classe chamada Contador em C# com um atributo estático chamado
            Valor e dois métodos estáticos chamados Incrementar e Decrementar. Os métodos
            Incrementar e Decrementar devem adicionar e subtrair, respectivamente, o
            percentual de um valor inteiro passado como parâmetro ao atributo Valor. */

            string escolha;
            double porcentagem;
            Console.WriteLine("Digite um valor");
            Contador.valor = Convert.ToInt32(Console.ReadLine());
            while(true)
            {
                Console.WriteLine("Incrementar? s/n");
                escolha = Console.ReadLine();
                if (escolha == "s")
                {
                    Console.WriteLine("Qual a porcentagem? (%)");
                    porcentagem = Convert.ToDouble(Console.ReadLine());
                    Contador.valor = Contador.Incrementar(Contador.valor, porcentagem);
                }
                else if (escolha == "n")
                {
                    Console.WriteLine("Decrementar? s/n");
                    escolha = Console.ReadLine();
                    if (escolha == "s")
                    {
                        Console.WriteLine("Qual a porcentagem?");
                        porcentagem = Convert.ToDouble(Console.ReadLine());
                        Contador.valor = Contador.Decrementar(Contador.valor, porcentagem);
                    }
                    else if (escolha == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ERRO! Digite novamente");
                    }
                }
                else
                {
                    Console.WriteLine("ERRO! Digite novamente");
                }
            }
            Console.WriteLine("Fim do programa. Valor total: {0}", Contador.valor);
            Console.ReadKey();  
        }
    }
}

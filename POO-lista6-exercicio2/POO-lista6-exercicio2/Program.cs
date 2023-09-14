using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_lista6_exercicio2
{
    interface IVeiculo
    {
        void Acelerar();
    }
    public class Carro : IVeiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Vruuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuummmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm no carro");
        }
    }

    public class Motoca : IVeiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Vruuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuummmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm na moto");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crie uma classe base chamada Veículo com um método Acelerar(). Em seguida, crie duas
          classes derivadas, Carro e Moto, que herdam de Veículo e implementam o método Acelerar()
          de forma diferente. */
            IVeiculo carro = new Carro();
            IVeiculo motoca = new Motoca();

            carro.Acelerar();
            motoca.Acelerar();
            Console.ReadKey();
        }
    }
}

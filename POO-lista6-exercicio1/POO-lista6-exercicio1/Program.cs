using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_lista6_exercicio1
{
    internal interface IAnimal
    {
        void FazerBarulho();
    }
    public class Cachorro : IAnimal
    {
        public void FazerBarulho()
        {
            Console.WriteLine("Au au");
        }
    }

    public class Gato : IAnimal
    {
        public void FazerBarulho()
        {
            Console.WriteLine("Miau");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Crie uma interface chamada IAnimal com um método FazerBarulho(). Em seguida, crie duas
           classes, Cachorro e Gato, que implementam essa interface e implementam o método
           FazerBarulho() de maneira diferente. */

            Cachorro cachorro = new Cachorro();
            Gato gato = new Gato();

            cachorro.FazerBarulho();
            gato.FazerBarulho();
            Console.ReadKey();
        }
    }
}

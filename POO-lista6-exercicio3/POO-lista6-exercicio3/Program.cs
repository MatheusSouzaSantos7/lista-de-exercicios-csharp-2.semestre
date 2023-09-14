using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_lista6_exercicio3
{
    interface IFigura
    {
        double CalcularArea();
    }

    // Classe do círculo
    public class Circulo : IFigura
    {
        private double raio;

        // Getters e Setters
        public double Raio
        {
            get { return raio;  }
            set { raio = value; }
        }

        // Métodos
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(raio, 2);
        }
    }
    public class Quadrado : IFigura
    {
        private double lado;

        // Getters e Setters
        public double Lado
        {
            get { return Lado; }
            set { lado = value; }
        }
        // Métodos
        public double CalcularArea() 
        {
            return Math.Pow(lado, 2);   
        }
    }

    public class Triangulo : IFigura
    {
        private double altura, largura;

        // Getters e Setters
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double Largura
        {
            get { return largura; }
            set { largura = value; }
        }

        // Métodos
        public double CalcularArea()
        {
            // Area do triangulo = (altura*largura)/2
            return (altura * largura)/2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crie uma classe base chamada Figura com um método CalcularÁrea(). Em seguida, crie classes
           derivadas, como Círculo, Quadrado e Triângulo, que sobrescrevem o método CalcularÁrea()
           para calcular a área de forma apropriada. */

            int escolha;
            Quadrado q = new Quadrado(); // Por padrão, os parâmetros ficarão zerados.
            Circulo c = new Circulo();
            Triangulo t = new Triangulo();

            while(true)
            {
                Console.WriteLine("Circulo (1), Quadrado (2), triangulo (3)");
                escolha = Convert.ToInt32(Console.ReadLine());
                if (escolha == 1)
                {
                    Console.WriteLine("Qual o valor do raio?");
                    c.Raio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Área: {0}", c.CalcularArea());
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Qual o valor do lado?");
                    q.Lado = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Área: {0}", q.CalcularArea());
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("Qual o valor da largura?");
                    t.Largura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Qual o valor da altura?");
                    t.Altura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Área: {0}", t.CalcularArea());
                }
                else
                    Console.WriteLine("Comando invalido, tente de novo");

                // Comando para terminar programa
                Console.WriteLine("Continuar? Responda \"n\" para sair");
                string sn = Console.ReadLine();
                if (sn == "n")
                    break;
            }
        }
    }
}

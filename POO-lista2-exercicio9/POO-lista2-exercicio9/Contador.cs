using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_lista2_exercicio9
{
    internal class Contador
    {
        public static double valor;

        public static double Incrementar(double valor, double porcento)
        {
            valor += valor * (porcento / 100);
            Console.WriteLine("Valor incrementado: {0}", valor);
            return valor;
        }
        public static double Decrementar(double valor, double porcento)
        {
            valor -= valor * (porcento / 100);
            Console.WriteLine("Valor decrementado: {0}", valor);
            return valor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_lista2_exercicio7
{
    static class Pessoa
    {
        public static int total = 0;
        public static int TotalPessoas()
        {
            total++;
            return total;
        }
        public static int totalFinal = total;
    }
}

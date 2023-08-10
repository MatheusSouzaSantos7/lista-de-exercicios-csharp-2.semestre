using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_lista2_exercicio12
{
    public class Estatisticas
    {
        public static double Media(int[] valores, int indicador)
        {
            double media = 0;
            int c = 0; // Contador.
            while (c < indicador)
            {
                media += valores[c];
                c++;
            }
            media = media / indicador;
            return media;
        }
    }
}

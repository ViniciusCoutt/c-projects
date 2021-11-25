using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDeMoeda_static
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double Conversao(double cotacao, double dolar)
        {
            return (cotacao * dolar) + (cotacao * dolar) * Iof / 100;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class Program
    {
        public const int INFERIOR = 14;
        public const int SUPERIOR = 1996;
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ4)");
            int i = INFERIOR, sumatoria = 0;
            while (i <= SUPERIOR)
            {
                sumatoria += i;
                i++;
            }
            Console.WriteLine("Limite inferior: " + INFERIOR);
            Console.WriteLine("Limite superior: " + SUPERIOR);
            Console.WriteLine("Sumatoria: " + sumatoria);
            Console.WriteLine("Promedio: " + ((decimal)sumatoria / (decimal)(SUPERIOR - INFERIOR)).ToString("0.00"));
            Console.ReadLine();
        }
    }
}

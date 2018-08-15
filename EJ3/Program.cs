using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class Program
    {
        public const int INFERIOR = 156;
        public const int SUPERIOR = 497;
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ3)");
            int sumatoria = 0;
            for (int i = INFERIOR; i <= SUPERIOR; i++)
            {
                sumatoria += i;
            }
            Console.WriteLine("Limite inferior: " + INFERIOR);
            Console.WriteLine("Limite superior: " + SUPERIOR);
            Console.WriteLine("Sumatoria: " + sumatoria);
            Console.WriteLine("Promedio: " + ((decimal)sumatoria / (decimal)(SUPERIOR - INFERIOR)).ToString("0.00"));
            Console.ReadLine();
        }
    }
}

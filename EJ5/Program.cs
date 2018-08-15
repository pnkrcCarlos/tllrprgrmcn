using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    class Program
    {
        public const int INFERIOR = 1;
        public const int SUPERIOR = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ5)");
            int i = INFERIOR, sumatoria = 0;
            do
            {
                sumatoria += i;
                i++;
            } while (i <= SUPERIOR);
            Console.WriteLine("Limite inferior: " + INFERIOR);
            Console.WriteLine("Limite superior: " + SUPERIOR);
            Console.WriteLine("Sumatoria: " + sumatoria);
            Console.WriteLine("Promedio: " + ((decimal)sumatoria / (decimal)(SUPERIOR - INFERIOR)).ToString("0.00"));
            Console.ReadLine();
        }
    }
}

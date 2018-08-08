using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class Program
    {
        public const int _inferior = 14;
        public const int _superior = 1996;
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ4)");
            int i = _inferior, sumatoria = 0;
            while (i <= _superior)
            {
                sumatoria += i;
                i++;
            }
            Console.WriteLine("Limite inferior: " + _inferior);
            Console.WriteLine("Limite superior: " + _superior);
            Console.WriteLine("Sumatoria: " + sumatoria);
            Console.WriteLine("Promedio: " + ((decimal)sumatoria / (decimal)(_superior - _inferior)).ToString("0.00"));
            Console.ReadLine();
        }
    }
}

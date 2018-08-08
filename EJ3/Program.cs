using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class Program
    {
        public const int _inferior = 156;
        public const int _superior = 497;
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ3)");
            int sumatoria = 0;
            for (int i = _inferior; i <= _superior; i++)
            {
                sumatoria += i;
            }
            Console.WriteLine("Limite inferior: " + _inferior);
            Console.WriteLine("Limite superior: " + _superior);
            Console.WriteLine("Sumatoria: " + sumatoria);
            Console.WriteLine("Promedio: " + ((decimal)sumatoria / (decimal)(_superior - _inferior)).ToString("0.00"));
            Console.ReadLine();
        }
    }
}

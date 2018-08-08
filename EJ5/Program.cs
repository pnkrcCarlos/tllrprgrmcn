using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    class Program
    {
        public const int _inferior = 1;
        public const int _superior = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ5)");
            int i = _inferior, sumatoria = 0;
            do
            {
                sumatoria += i;
                i++;
            } while (i <= _superior);
            Console.WriteLine("Limite inferior: " + _inferior);
            Console.WriteLine("Limite superior: " + _superior);
            Console.WriteLine("Sumatoria: " + sumatoria);
            Console.WriteLine("Promedio: " + ((decimal)sumatoria / (decimal)(_superior - _inferior)).ToString("0.00"));
            Console.ReadLine();
        }
    }
}

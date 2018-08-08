using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ6
{
    class Program
    {
        public const int _inferior = 1;
        public const int _superior = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ6)");
            int sumatoria = 0, contador = 0;
            for (int i = _inferior; i <= _superior; i++) // Podria usarse un incremento de i+2 ya que comienza en impar
            {
                if (i % 2 != 0)
                {
                    sumatoria += i;
                    contador++;
                }
            }
            Console.WriteLine("Limite inferior: " + _inferior);
            Console.WriteLine("Limite superior: " + _superior);
            Console.WriteLine("Sumatoria: " + sumatoria);
            Console.WriteLine("Promedio: " + ((decimal)sumatoria / (decimal)contador).ToString("0.00"));
            Console.ReadLine();
        }
    }
}

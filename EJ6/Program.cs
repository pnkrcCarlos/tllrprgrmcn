using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ6
{
    class Program
    {
        public const int INFERIOR = 1;
        public const int SUPERIOR = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ6)");
            int sumatoria = 0, contador = 0;
            for (int i = INFERIOR; i <= SUPERIOR; i++) // Podria usarse un incremento de i+2 ya que comienza en impar
            {
                if (i % 2 != 0)
                {
                    sumatoria += i;
                    contador++;
                }
            }
            Console.WriteLine("Limite inferior: " + INFERIOR);
            Console.WriteLine("Limite superior: " + SUPERIOR);
            Console.WriteLine("Sumatoria: " + sumatoria);
            Console.WriteLine("Promedio: " + ((decimal)sumatoria / (decimal)contador).ToString("0.00"));
            Console.ReadLine();
        }
    }
}

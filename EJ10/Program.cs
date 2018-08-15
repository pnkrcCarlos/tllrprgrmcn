using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ10
{
    class Program
    {
        public const int INFERIOR = 1900;
        public const int SUPERIOR = 2015;
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ10)");
            for (int i = INFERIOR; i <= SUPERIOR; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}

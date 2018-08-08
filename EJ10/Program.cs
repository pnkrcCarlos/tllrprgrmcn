using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ10
{
    class Program
    {
        public const int _inferior = 1900;
        public const int _superior = 2015;
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ10)");
            for (int i = _inferior; i <= _superior; i++)
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

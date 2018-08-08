using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ8)");
            ulong n1 = 0, n2 = 1, aux;
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("\t{0}:\t\t{1}", i, n1);
                aux = n2;
                n2 += n1;
                n1 = aux;
            }
            Console.ReadLine();
        }
    }
}

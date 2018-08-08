using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ12)");
            Console.Write("n = ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            ulong factorial = 1;
            if (n == 0)
            {
                factorial *= 1;
            }
            else
            {
                for (uint i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
            }
            if (n > 65) // Con ulong puedo hacer hasta 65!, después devuelve 0
            {
                Console.WriteLine("{0}! = Demasiado", n);
            }
            else
            {
                Console.WriteLine("{0}! = {1}", n, factorial);
            }
            Console.ReadLine();
        }
    }
}

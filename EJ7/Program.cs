using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ7)");
            decimal pi = 0, terminos;
            Console.Write("Terminos: ");
            terminos = Convert.ToDecimal(Console.ReadLine());
            for (int n = 0; n <= terminos; n++)
            {
                pi += (decimal)Math.Pow(-1, n) / (decimal)(2*n + 1); // ((-1)^n)/(2n+1)
            }
            pi *= 4; // pi = 4*pi
            Console.WriteLine("pi_(Lebniz) = {0:F5}", pi);
            Console.WriteLine("Error: {0:F5}%", Math.Pow((double)pi - Math.PI, 2)*100/Math.PI);
            Console.ReadLine();
        }
    }
}

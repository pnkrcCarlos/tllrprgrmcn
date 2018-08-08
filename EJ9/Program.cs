using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ9)");
            /*Console.Write("Limite inferior: ");
            int inf = Convert.ToInt32(Console.ReadLine());
            Console.Write("Limite superior: ");
            int sup = Convert.ToInt32(Console.ReadLine());*/
            int suma = 0;
            for (int i = 35 /*inf*/; i <= 1977 /*sup*/; i++)
            {
                if (EsPrimo(i))
                {
                    suma += i;
                    //Console.WriteLine("{0} es primo.", i);
                }
                /*else
                {
                    Console.WriteLine("{0} no es primo.", i);
                }*/

            }
            Console.WriteLine("Suma de primos: {0}", suma);
            Console.ReadLine();
        }
        static bool EsPrimo(int n)
        {
            int raiz = (int)Math.Floor(Math.Sqrt(n));
            int cont = 2;
            while (cont <= raiz)
            {
                if (n % cont == 0)
                {
                    break;
                }
                else
                {
                    cont++;
                }
            }
            if (cont > raiz)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

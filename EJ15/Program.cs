using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ15
{
    class Program
    {
        public const int INFERIOR= 20;
        public const int SUPERIOR = 50;
        public const int MAX = 200;
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ15)");
            int[] enteros = OrdenBurbuja(Acotar(Inicializar(new int[50])));
            for (int i = 0; i < enteros.Length; i++)
            {
                Console.WriteLine("{0} ", enteros[i]);
            }
            Console.ReadLine();
        }
        static int[] Inicializar(int[] arreglo)
        {
            Random rng = new Random();
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rng.Next(MAX);
                //Console.Write("{0} ", arreglo[i]);
            }
            //Console.WriteLine();
            return arreglo;
        }
        static int[] OrdenBurbuja(int[] arreglo)
        {
            int n = arreglo.Length;
            int nn;
            do
            {
                nn = 0;
                for (int i = 1; i <= n - 1; i++)
                {
                    if (arreglo[i - 1] > arreglo[i])
                    {
                        int aux = arreglo[i];
                        arreglo[i] = arreglo[i - 1];
                        arreglo[i - 1] = aux;
                        nn = i;
                    }
                }
                n = nn;
            } while (n != 0);
            return arreglo;
        }
        static int[] Acotar(int[] arreglo)
        {
            List<int> comprendidos = new List<int>();
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] > INFERIOR && arreglo[i] < SUPERIOR)
                {
                    comprendidos.Add(arreglo[i]);
                }
            }
            return comprendidos.ToArray();
        }
    }
}

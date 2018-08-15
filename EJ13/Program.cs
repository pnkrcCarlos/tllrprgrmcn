using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ13)");
            string[] argumentos = args;
            for (int i = 0; i < argumentos.Length; i++)
            {
                argumentos[i] = Invertir(argumentos[i]);
            }
            argumentos = OrdenBurbuja(argumentos);
            for (int i = 0; i <= argumentos.Length - 1; i++)
            {
                Console.WriteLine(argumentos[i]);
            }
            Console.ReadLine();
        }
        static string Invertir(string cadena)
        {
            char[] arreglo = cadena.ToCharArray(); // Convierto la cadena a un array para usar Reverse
            Array.Reverse(arreglo);
            return new string(arreglo);
        }
        static string[] OrdenBurbuja(string[] arreglo)
        {
            int n = arreglo.Length;
            int nn;
            do
            {
                nn = 0;
                for (int i = 1; i <= n - 1; i++)
                {
                    if (arreglo[i - 1].CompareTo(arreglo[i]) > 0)
                    {
                        string aux = arreglo[i];
                        arreglo[i] = arreglo[i - 1];
                        arreglo[i - 1] = aux;
                        nn = i;
                    }
                }
                n = nn;
            } while (n != 0);
            return arreglo;
        }
    }
}

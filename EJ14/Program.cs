using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ14)");
            double[] arreglo = new double[30];
            Random rng = new Random();
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rng.NextDouble()*100;
                Console.Write("{0:F3} ", arreglo[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Min: {0:F3}\nMax: {1:F3}\nSumatoria: {2:F3}\nPromedio: {3:F3}", Minimo(arreglo), Maximo(arreglo), Sumatoria(arreglo), Promedio(arreglo));
            Console.ReadLine();
        }
        static double Minimo(double[] arreglo)
        {
            double min = arreglo[0];
            for (int i = 1; i < arreglo.Length; i++)
            {
                if (arreglo[i] < min)
                {
                    min = arreglo[i];
                }
            }
            return min;
        }
        static double Maximo(double[] arreglo)
        {
            double max = arreglo[0];
            for (int i = 1; i < arreglo.Length; i++)
            {
                if (arreglo[i] > max)
                {
                    max = arreglo[i];
                }
            }
            return max;
        }
        static double Sumatoria(double[] arreglo)
        {
            double sum = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                sum += arreglo[i];
            }
            return sum;
        }
        static double Promedio(double[] arreglo)
        {
            return Sumatoria(arreglo) / arreglo.Length;            
        }
    }
}

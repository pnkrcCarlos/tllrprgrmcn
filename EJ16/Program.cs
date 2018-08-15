using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ16)");
            Console.Write("1er palabra: ");
            String palabra1 = Console.ReadLine();
            Console.Write("2da palabra: ");
            String palabra2 = Console.ReadLine();
            if (Anagramas(palabra1, palabra2))
            {
                Console.WriteLine("'{0}' y '{1}' son anagramas.", palabra1, palabra2);
            }
            else
            {
                Console.WriteLine("'{0}' y '{1}' no son anagramas.", palabra1, palabra2);
            }
            Console.ReadLine();
        }
        static bool Anagramas(String cadena1, String cadena2)
        {
            if (cadena1.Length==cadena2.Length)
            {
                // Convierto las cadenas a arreglos y las comparo
                char[] arreglo1 = cadena1.ToCharArray();
                char[] arreglo2 = cadena2.ToCharArray();
                Array.Sort(arreglo1);
                Array.Sort(arreglo2);
                if (arreglo1.SequenceEqual(arreglo2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }
    }
}

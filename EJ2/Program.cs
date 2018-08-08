using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ2)");
            int numero;
            String nombre;
            Console.Write("numero = ");
            numero = Convert.ToInt32(Console.ReadLine());
            switch(numero)
            {
                case 1:
                    nombre = "UNO";
                    break;
                case 2:
                    nombre = "DOS";
                    break;
                case 3:
                    nombre = "TRES";
                    break;
                case 4:
                    nombre = "CUATRO";
                    break;
                case 5:
                    nombre = "CINCO";
                    break;
                case 6:
                    nombre = "SEIS";
                    break;
                case 7:
                    nombre = "SIETE";
                    break;
                case 8:
                    nombre = "OCHO";
                    break;
                case 9:
                    nombre = "NUEVE";
                    break;
                default:
                    nombre = "OTRO";
                    break;
            }
            Console.WriteLine(nombre);
            Console.ReadLine();
        }
    }
}

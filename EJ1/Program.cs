using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ1)");
            int numero;
            String nombre;
            Console.Write("numero = ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 1)
            {
                nombre = "UNO";
            }
            else if (numero == 2)
            {
                nombre = "DOS";
            }
            else if (numero == 3)
            {
                nombre = "TRES";
            }
            else if (numero == 4)
            {
                nombre = "CUATRO";
            }
            else if (numero == 5)
            {
                nombre = "CINCO";
            }
            else if (numero == 6)
            {
                nombre = "SEIS";
            }
            else if (numero == 7)
            {
                nombre = "SIETE";
            }
            else if (numero == 8)
            {
                nombre = "OCHO";
            }
            else if (numero == 9)
            {
                nombre = "NUEVE";
            }
            else
            {
                nombre = "OTRO";
            }
            Console.WriteLine(nombre);
            Console.ReadLine();
        }
    }
}

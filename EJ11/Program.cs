using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(TP1/EJ11)");
            Console.Write("Radio = ");
            float radio = Convert.ToSingle(Console.ReadLine()); // Hay que usar "," para separar los decimales por la configuración de localización (supongo)
            Console.WriteLine("Area = {0:F3}; Perimetro = {1:F3}", Math.PI*radio*radio, 2*Math.PI*radio);
            Console.ReadLine();
        }
    }
}

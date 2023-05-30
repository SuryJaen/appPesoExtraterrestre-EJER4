using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPesoExtraterrestre_EJER4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("=======INDICE DE MASA CORPORAL====");
            Console.WriteLine("==================================");
            Console.WriteLine("");
            Console.WriteLine("DIGITE EL PESO EN KILOGRAMOS");
            String digito = Console.ReadLine();
            float peso = float.Parse(digito);
            Console.WriteLine("SU PESO EN LA LUNA CORESPONDE A {0} KILOGRAMOS", peso * 0.16);
            Console.WriteLine("SU PESO EN LA MERCURIO CORESPONDE A {0} KILOGRAMOS", peso * 0.4);
            Console.WriteLine("SU PESO EN LA VENUS CORESPONDE A {0} KILOGRAMOS", peso * 0.9);
            Console.WriteLine("SU PESO EN LA JUPITER CORESPONDE A {0} KILOGRAMOS", peso * 2.25);
            Console.WriteLine("SU PESO EN LA SATURNO CORESPONDE A {0} KILOGRAMOS", peso * 1.1);
            Console.Read();
        }
    }
}

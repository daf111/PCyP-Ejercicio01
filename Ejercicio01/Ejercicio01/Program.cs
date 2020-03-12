using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo!");

            Auto a = new Auto();
            a.cantidadPuertas = 4;
            Console.WriteLine("El auto tiene: " + a.cantidadPuertas + " puertas");

            Console.ReadLine();
        }
    }
}

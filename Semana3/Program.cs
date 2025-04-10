using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio1();
            Console.ReadKey();
        }

        static void ejercicio1()
        {
            string nombre;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("\n"+nombre+", Bienvenido al curso de Fundamentos de Algortimo");
        }
    }
}

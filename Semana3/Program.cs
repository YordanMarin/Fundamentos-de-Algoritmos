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
            ejercicio8();
            Console.ReadKey();
        }

        static void ejercicio1()
        {
            string nombre;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("\n"+nombre+", Bienvenido al curso de Fundamentos de Algortimo");
        }

        static void ejercicio2()
        {
            Console.WriteLine("Yordan\n19\nIng. Sistemas");
        }

        static void ejercicio3()
        {
            Console.WriteLine("\"Yordan\"");
        }

        static void ejercicio4()
        {
            int num1, num2;

            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("La suma es: " + (num1 + num2));
            Console.WriteLine("La resta es: " + (num1 - num2));
            Console.WriteLine("La multiplicación es: " + (num1 * num2));
            Console.WriteLine("La división es: " + (num1 / num2));
            Console.WriteLine("El módulo es: " + (num1 % num2));
        }

        static void ejercicio5()
        {
            int bs, alt;
            double area;

            Console.Write("Ingrese la base del triángulo: ");
            bs = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la altura del triángulo: ");
            alt = int.Parse(Console.ReadLine());

            area = (bs * alt) / 2;

            Console.WriteLine("\nEl área del triángulo es: " + area);
        }

        static void ejercicio6()
        {
            double num1, num2, num3, promedio;

            Console.Write("Ingrese el primer número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercero número: ");
            num3 = double.Parse(Console.ReadLine());

            promedio = (num1 + num2 + num3) / 3;

            Console.WriteLine("\nEl promedio es: " + Math.Round(promedio,2));

        }
        
        static void ejercicio7()
        {
            int radio;
            double area;

            Console.Write("Ingrese el radio del circulo: ");
            radio = Convert.ToInt32(Console.ReadLine());

            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("\nEl área del círculo es: " + Math.Round(area, 2));
        }

        static void ejercicio8()
        {
            double num1;

            Console.Write("Ingrese un número decimal: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nLa raiz cuadrada es: "+Math.Sqrt(num1));
            Console.WriteLine("La potencia a 3 es: " + Math.Pow(num1, 3));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana10
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion, continuar;
            Cajero c = new Cajero();

            do {
                do {
                    Console.WriteLine("BIENVENIDOS AL SISTEMA DE CAJERO\n");

                    Console.WriteLine("1. Consultar saldo");
                    Console.WriteLine("2. Depositar dinero");
                    Console.WriteLine("3. Retirar dinero");
                    Console.WriteLine("4. Salir\n");

                    Console.Write("Ingrese una opción: ");
                    opcion = Console.ReadKey().KeyChar;
                    Console.Clear();

                } while (opcion < '1' || opcion > '4');

                switch (opcion) {
                    case '1': Console.WriteLine("Saldo: S/."+c.consultar()); break;
                    case '2': c.depositar(0); break;
                    case '3': c.retirar(0); break;
                    case '4': Console.Write("Cerrando sistema!"); return;
                }
                do {
                    Console.Write("\nDesea regresar al menú (S/N): ");
                    continuar = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    if (continuar != 'S' && continuar != 'N')
                        Console.WriteLine("Opción no valida! Ingrese solo S/N: ");

                } while (continuar != 'S' && continuar != 'N');
                Console.Clear();

            } while (continuar == 'S');
            
        }
    }
}

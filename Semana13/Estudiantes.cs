using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana13
{
    class Estudiantes
    {
        private string[] nombres = new string[0];
        private byte[] edad = new byte[0];
        private int cantidad = 0;

        public void insertar() {
            string continuar;
            do {
                Console.Clear();

                Console.WriteLine("=== Registrar estudiantes ===\n");

                Array.Resize(ref nombres, nombres.Length + 1);
                Array.Resize(ref edad, edad.Length + 1);

                Console.Write("Ingrese sus nombres: ");
                nombres[cantidad] = Console.ReadLine();
                Console.Write("Ingrese su edad: ");
                edad[cantidad] = byte.Parse(Console.ReadLine());
                cantidad++;

                Console.Write("\nSe registro con exito! Desea seguir registrando (S): ?");
                continuar = Console.ReadLine().ToLower();
            } while (continuar == "s");
        }

        public void mostrar() {
            Console.Clear();
            Console.WriteLine("=== Estudiantes registrados ===\n");
            if (cantidad != 0) {
                for (int i = 0; i < nombres.Length; i++) {
                    Console.WriteLine($"{i + 1}. {nombres[i]}\t{edad[i]}");
                }
            } else
                Console.WriteLine("\nNo hay registros de estudiantes!");
        }

        public int buscar(string nom) {
            int indice = -1;
            for (int i = 0; i < nombres.Length; i++) {
                if (nombres[i] == nom) {
                    indice = i;
                }
            }
            return indice;
        }

        public void modificar() {
            Console.Clear();
            Console.WriteLine("=== Modificar estudiante ===\n");
            Console.Write("Ingrese el nombre: ");
            string ingreso = Console.ReadLine();

            int indice = buscar(ingreso);

            if (indice != -1) {
                Console.Write("\nIngrese el nuevo nombre: ");
                nombres[indice] = Console.ReadLine();
                Console.Write("Ingrese la nueva edad: ");
                edad[indice] = byte.Parse(Console.ReadLine());
                Console.WriteLine("\nEstudiante modificado correctamnete!");
            } else {
                Console.WriteLine("\nNo se puede modificar. Estudiante no existe!");
            }
        }
    }
}

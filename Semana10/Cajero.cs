using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana10
{
    class Cajero
    {
        private double saldo = 1000;

        public double consultar() {
            return saldo;
        }

        public void depositar(double monto) {
            do {
                Console.Write("¿Cuánto desea depositar?: ");
                string entrada = Console.ReadLine();

                if(double.TryParse(entrada, out monto)) {
                    if(monto > 0) {
                        saldo += monto;
                        Console.WriteLine("Depósito exitoso.");
                        break;
                    }else
                        Console.WriteLine("Error: solo se puede depositar montos mayores a 0");
                } else {
                    Console.WriteLine("Error: solo se permiten números!");
                }

            } while (true);
        }

        public void retirar(double monto) {
            do {
                Console.Write("¿Cuánto desea retirar?: ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out monto)) {
                    if (monto > saldo)
                        Console.WriteLine("No tiene saldo suficiente");
                    else if (monto < 0)
                        Console.WriteLine("Error: solo se puede retirar montos mayores o iguales 0");
                    else {
                        saldo -= monto;
                        Console.WriteLine("Retiro exitoso.");
                        break;
                    }
                } else {
                    Console.WriteLine("Error: solo se permiten números!");
                }
            } while (true);
        }
    }
}

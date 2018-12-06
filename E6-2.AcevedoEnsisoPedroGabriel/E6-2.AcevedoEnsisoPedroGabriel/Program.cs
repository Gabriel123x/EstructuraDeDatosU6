using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_2.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool activo = true;
            string seleccionador;
            while (activo == true)
            {
                try
                {
                    Console.WriteLine("1) Busqueda Binaria Ejemplo 1");
                    Console.WriteLine("2) Busqueda Binaria Ejemplo 2");
                    Console.WriteLine("3) Cerrar programa");
                    Console.WriteLine("Selecione ejercicio");
                    seleccionador = Console.ReadLine();
                    Console.Clear();
                    switch (seleccionador)
                    {
                        case "1":
                            BusquedaBinaria Ejemplo1 = new BusquedaBinaria();
                            Ejemplo1.Cargar();
                            Console.Write("\n\nQue numero desea buscar: ");
                            int num = int.Parse(Console.ReadLine());
                            Ejemplo1.Binario(num);
                            break;
                        case "2":
                            BusquedaBinariaTexto Ejemplo2 = new BusquedaBinariaTexto();
                            Ejemplo2.Cargar();
                            Console.Write("\n\nQue cadena desea buscar: ");
                            string texto = Console.ReadLine();
                            Ejemplo2.Binario(texto);
                            break;
                        case "3":
                            Console.WriteLine("Fin del programa");
                            activo = false;
                            break;
                        default:
                            Console.WriteLine("Error de seleccion solo se aceptan numeros del 1 al 3");
                            break;
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                finally
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}

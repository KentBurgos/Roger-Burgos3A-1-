using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RogerBurgos_3A.Metodos
{
    public class MetodoCola
    {
        private static void Main(string[] args)
        {
            // Variables necesarias
            int opcion = 0;
            string valor = "";
            int numero = 0;
            bool encontrado = false;

            // Creamos el stack
            Queue miPila = new Queue();
            do
            {
                // Mostramos menu
                Console.WriteLine("1- Ingresar elemento");
                Console.WriteLine("2- Eliminar elemento");
                Console.WriteLine("3- Borrar pila");
                Console.WriteLine("4- Buscar elemento");
                Console.WriteLine("5- Salir");
                Console.WriteLine("Dame tu opcion");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);
                switch (opcion)
                {
                    case 1:
                        // Pedimos el valor a introducir
                        Console.WriteLine("Dame el valor a introducir");
                        valor = Console.ReadLine();
                        numero = Convert.ToInt32(valor);
                        // Adicionamos el valor en el stack
                        miPila.Enqueue(numero);
                        break;
                    case 2:
                        // Obtnemos el elemento
                        numero = (int)miPila.Dequeue();
                        // Mostramos el elemento
                        Console.WriteLine("El valor obtenido es: {0}", numero);
                        break;
                    case 3:
                        // Limpiamos todos los contenidos del stack
                        miPila.Clear();
                        break;
                    case 4:
                        // Pedimos el valor a encontrar
                        Console.WriteLine("Dame el valor a encontrar");
                        valor = Console.ReadLine();
                        numero = Convert.ToInt32(valor);
                        // Vemos si el elemento esta
                        encontrado = miPila.Contains(numero);
                        // Mostramos el resultado
                        Console.WriteLine("Encontrado - {0}", encontrado);
                        break;
                    default:
                        Console.WriteLine("No existe opción intente de nuevo");
                        break;
                }
                // Mostramos la informacion del stack
                Console.WriteLine("La pila tiene {0} elementos", miPila.Count);
                foreach (int n in miPila)
                    Console.Write(" {0},", n);

                Console.WriteLine("");

            } while (opcion != 5);

        }
    }
}
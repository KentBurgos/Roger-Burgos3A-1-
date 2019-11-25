using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogerBurgos_3A.Metodos;
using RogerBurgos._3A.Clase;


namespace RogerBurgos._3A
{
    public class Program
    {

        static void Main(string[] args)
        {
            int entrada = 0;
            do
            {


                Console.WriteLine("Elija una opción?n" +
                    "1. Opcion Cola" +
                    "2. Opcion Pila");
                int numero = int.Parse(Console.ReadLine());

                switch (numero)
                {
                    case 1:
                        MetodoCola metodosCola = new MetodoCola();
                        break;
                    case 2:
                        MetodoPila metodosPila = new MetodoPila();
                        break;

                }
            } while (entrada != 3);
            Console.ReadLine();

        }
    }
}

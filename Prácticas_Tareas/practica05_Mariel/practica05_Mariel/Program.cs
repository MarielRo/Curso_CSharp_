using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica05_Mariel
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "";
            string refresco = "";

            Console.WriteLine("¿Gusta pedir una hamburguesa? (s / n)");
            respuesta = Console.ReadLine();
            if(respuesta == "s")
            {
                Console.WriteLine("¿Quieres papas y refresco? (s / n)");
                respuesta = Console.ReadLine();

                if (respuesta == "s")
                {
                    Console.WriteLine("¿Tipo de bebida? (gaseosa / natural)");
                    respuesta = Console.ReadLine();
                    if (respuesta == "natural")
                    {
                        Console.WriteLine("En 15 minutos te la entregamos!Son ¢5500");
                        Console.ReadKey();
                    }
                    else if (respuesta == "gaseosa")
                    {
                        Console.WriteLine("En 15 minutos te la entregamos!Son ¢6000");
                        Console.ReadKey();
                    }
                }
                else if (respuesta == "n")
                {
                    Console.WriteLine("En 15 minutos te la entregamos!Son ¢4500");
                    Console.ReadKey();
                }

            }
            else if (respuesta == "n")
            {
                Console.WriteLine("¿Quieres una ensalada? (s/n) ");
                respuesta = Console.ReadLine();
                if (respuesta == "s")
                {
                    Console.WriteLine("En 5 minutos te la entregamos!Son ¢3200");
                    Console.ReadKey();
                }
                else if (respuesta == "n")
                {
                    Console.WriteLine("En un momento te traemos el menú completo!");
                    Console.ReadKey();
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica08_Mariel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de Variables
            int aleatorio, intentos = 0, numeroDigitado;

            Random numeroAleatorio = new Random(); // numero que el usuario debe adivinar 

            aleatorio = numeroAleatorio.Next(20,101); // numero aleatorio entre 20 y 100
            Console.WriteLine("Adivine el número entre 20 y 100:");

            while (true)
            {
                numeroDigitado = Int32.Parse(Console.ReadLine()); // Número que digita el usuario para adivinar 
                intentos++; // cantidad de intentos para adivinar el numero 

                if (numeroDigitado == aleatorio)
                {
                    if (intentos == 1)
                    {
                        Console.WriteLine("¡Tenemos una suerte increíble!!");
                    }
                    else
                    {
                        Console.WriteLine($"¡Correcto! Adivinaste el número en {intentos} intentos.");
                    }
                    break;
                }
                else if (numeroDigitado < aleatorio)
                {
                    Console.WriteLine("El número a adivinar es mayor. Intenta nuevamente:");
                }
                else
                {
                    Console.WriteLine("El número a adivinar es menor. Intenta nuevamente:");
                }
            }

            Console.ReadKey();

        }
    }
}

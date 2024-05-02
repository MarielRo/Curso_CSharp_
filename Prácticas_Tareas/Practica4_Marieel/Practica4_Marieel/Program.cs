using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4_Marieel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool interruptorA = false;
            bool interruptorB = false;
            bool interruptorC = false;
            string autorizacion = "NIVEL4";
            if( autorizacion == "NIVEL4")
            {
                if ((interruptorA == true) && (interruptorB == false ) && ( interruptorC == false))
                {
                    Console.WriteLine("Solamente activo el interruptor A");
                }
                else if ((interruptorA == false) && (interruptorB == true) && (interruptorC == false))
                {
                    Console.WriteLine("Solamente activo el interruptor B");
                }
                else if ((interruptorA == false) && (interruptorB == false) && (interruptorC == true))
                {
                    Console.WriteLine("Solamente activo el interruptor C");
                }
                else if ((interruptorA == true) && (interruptorB == true) && (interruptorC == true))
                {
                    Console.WriteLine("Los tres interruptores están activos");
                }
                else if ((interruptorA == true) && (interruptorB == true) && (interruptorC == false))
                {
                    Console.WriteLine("Activos 2 interruptores: A y B");
                }
                else if ((interruptorA == true) && (interruptorB == false) && (interruptorC == true))
                {
                    Console.WriteLine("Activos 2 interruptores: A y C");
                }
                else if ((interruptorA == false) && (interruptorB == true) && (interruptorC == true))
                {
                    Console.WriteLine("Activos 2 interruptores: B y C");
                }
                else if (!interruptorA && !interruptorB && !interruptorC)
                {
                    Console.WriteLine("Los tres interruptores están apagadoss");
                }
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Nivel de autorización no es correcto");
            }
            Console.ReadKey();
        }
    }
}

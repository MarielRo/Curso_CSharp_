using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool interruptorA = false;
            bool interruptorB = false;
            bool interruptorC = false;
            string autorizacion = "NIVEL4";
            if (interruptorA && interruptorB && interruptorC && autorizacion == "NIVEL4")
            {
                Console.WriteLine("Los tres interruptores están activos");
            }
            if(interruptorA  || interruptorB || (interruptorC && autorizacion == "NIVEL4"))
            {
                Console.WriteLine("Al menos uno de los tres interruptores está activos");
            }
            Console.ReadKey();
        }
    }
}

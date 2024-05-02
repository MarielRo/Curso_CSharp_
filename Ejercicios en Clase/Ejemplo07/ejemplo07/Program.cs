using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo07
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();
            int miAleatorio = numAleatorio.Next(0, 2);

            for(int i=0; i < 20; i++)
            {

                miAleatorio = numAleatorio.Next(0, 200);
                Console.WriteLine($"El aleatorio es {i+1}:  {miAleatorio}");
            }

            Console.ReadKey();
        }
    }
}

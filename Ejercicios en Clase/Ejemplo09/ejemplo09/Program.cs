using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo09
{
    class Program
    {
        static void Main(string[] args)
        {
            int notFinal = 84;
            if (notFinal < 70)
            {
                Console.WriteLine($"Curso Reprobado");
            }
            if (notFinal >= 70)
            {
                Console.WriteLine($"Curso Aprobado");
            }

            Console.ReadKey();
        }
    }
}

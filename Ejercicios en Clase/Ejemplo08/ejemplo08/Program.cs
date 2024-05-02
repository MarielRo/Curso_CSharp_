using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo08
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pronosticoLluvia = true;
            Console.WriteLine($"¿Hoy va a llover? : {pronosticoLluvia}" );
            Console.WriteLine($"¿Mañana va a llover? : {!pronosticoLluvia}");
            Console.ReadKey();
        }
    }
}

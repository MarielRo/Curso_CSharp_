using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioportafolii08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int numero, positivo = 0, negativo = 0, cero = 0, i = 0;
            while (i < 20)
            {

                Console.WriteLine($"({i}).Ingrese un número positivo o negativo: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero > 0)
                {
                    positivo++;
                }
                else if (numero < 0)
                {
                    negativo++;
                }
                else
                {
                    cero++;
                }

                i++;

            }

            Console.WriteLine($"La cantidad de números positivos fue de {positivo}." +
                $" \n La cantidad de números negativos fue de {negativo}." +
                $"\nLa cantidad de números ceros fue de {cero}. \n  ");

            Console.ReadKey();
        }
    }
}

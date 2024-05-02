using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1_Mariel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre;
            nombre = Console.ReadLine();

            Console.WriteLine("Digite la calificación del Exámen 1 :");
            double examen1;
            examen1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite la calificación del Exámen 2 :");
            double examen2;
            examen2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del Exámen 3 (20%):");
            double examen3;
            examen3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del Proyecto 1 (18%):");
            double proyecto1;
            proyecto1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del Proyecto 2 (22%):");
            double proyecto2;
            proyecto2 = Convert.ToDouble(Console.ReadLine());

            // promedio final
            double promedioFinal = (examen1 * 0.15) + (examen2 * 0.25) + (examen3 * 0.20) + (proyecto1 * 0.18) + (proyecto2 * 0.22);

            
            Console.WriteLine($"Estudiante: {nombre}. Promedio Final: {promedioFinal}");  // interpolación
            Console.ReadKey(); // 
        }
    }
}

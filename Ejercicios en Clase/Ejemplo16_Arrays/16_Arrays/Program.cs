using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arreglo de enteros de 10 elementos
            int[] miArreglo;
            miArreglo = new int[10];
            miArreglo[0] = 28;
            miArreglo[9] = 28;

            //Arreglo de enteros de 10 elementos
            int[] miArreglo2 = new int[10];
            miArreglo2[0] = 28; // Primer indice 
            miArreglo2[9] = 28; // último indice

            // Arreglo de enteros de 6 elementos
            //Asignando valores en la declaracion
            int[] arregloB = { -8, 98, 15, 0, 75, 12 };

            // Arreglo de enteros de 6 elementos
            //Asignando valores en la declaracion
            int[] arregloC = new int[6] { -8, 98, 15, 0, 75, 12 };

            // var
            // con var convierte de int a double 
            var arregloD = new[] { 15.5, 20, 7.25, 18.32, 9 };
            

            //ARREGLOS DE CLASES ANONIMAS (que no tienen nombre)
            var Personas = new[]
            {
                new {Nombre = "Karla", Edad = 25},
                new {Nombre = "Juan", Edad = 27 },
                new {Nombre = "Maria", Edad = 21 }
            };
            // Acceder a los elementps del arreglo de clases anonimas
            Console.WriteLine(Personas[0]);
            Console.WriteLine(Personas[1]);
            Console.WriteLine(Personas[1].Nombre);
            Console.WriteLine(Personas[1].Edad);

            //Recorriendo arreglos con el ciclo for:
            Console.WriteLine($"Recorriendo arreglos con el ciclo for");
            int[] arreglosNumeros = { 15, 25, 98, 107, 5, 78 };
            for (int i= 0; i < arreglosNumeros.Length; i++)
            {
                Console.WriteLine($"Posición {i}: {arreglosNumeros[i]}");
            }

            // foreach
            Console.WriteLine("ciclo foreach");
            foreach (int numero in arreglosNumeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("");

            // se llaman los metodos de abajo 
            int[] numeros = { 41, 57, 84, 79, 25, 34 };
            MuestraDatos(numeros);
            ModificarDatos(numeros);
            MuestraDatos(numeros);
            Console.ReadKey();

        }
        //Un método que recibe por parametro un arreglo 
        static void MuestraDatos(int[] datos)
        {
            Console.WriteLine("Mostrando el arreglo");
            foreach (int i in datos )
            {
                Console.WriteLine(i);
            }
        }



        //Modificar datos 
        //Método que recibe un arreglo y modifica valores 
        static void ModificarDatos(int[] datos)
        {
            Console.WriteLine("Modificando el arreglo");
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] += 50;
            }
        }
    }




    class Productos
    {
        //--------------------------------------------------------------

        // arrays de objetos 
        // Creando un objeto de objetos tipo producto, con 15 elementos

        //Producto[] misProductos = new Producto[15];

        // Atributos 
        private int codigo;
        private int precio;
        private string descripcion;


        // Asignando un nuevo objeto a una posición 
        // misProductos = new Producto(11, 250000, "monitor curvo");

        //Creando primero un objeto y luego ASIGNARLO A UNA POSICIÓN;
        //Producto teclado001 = new Producto(12, 105000, "teclado mecánico");
        //For each 
            //utiliza la variable llamada iterados
            //en este ejemplo llamada a product
            //foreach (var product in misProductos)
            //{

            //    Console.WriteLine(numero);
            //}
    }
}


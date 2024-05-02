using System;

namespace POO_Modularizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            miMetodo();
            Console.WriteLine($"Cantidad de objetos creados; {Punto.getContadorDeObjetos()}");
            Console.ReadKey();
        }

        static void miMetodo()
        {
            //TODO: Falta realizar validación

            Punto coordenadaA = new Punto(5,3);
            Punto coordenadaB = new Punto();
            //TODO : Preguntar si se tiene aprobación 
            double distancia = coordenadaB.distanciasHasta(coordenadaA);
            Console.WriteLine($"La hipotenusa es {distancia}");

            Punto coordenadaC = new Punto(30,8);
            Punto coordenadaD = new Punto(10,2);
            distancia = coordenadaC.distanciasHasta(coordenadaD);
            Console.WriteLine($"La hipotenusa es {distancia}");

            Console.ReadKey();
        }

        //Métodos 
    }
}

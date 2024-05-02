using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Modularizacion
{
    class Punto
    {
        //Atributos
        private int x;
        private int y;

        // Variables estaticas 
        private static int contadorDeObjetos = 0;
        private const int ConstanteA = 1; 

        //Métodos cosnstructor
        // Constructor
        public Punto(int x,int y)
        {
            this.x = x;
            this.y = y;
            contadorDeObjetos++;
            //Console.WriteLine($"Cordenada x: {x}, Cordenada y: {y}");
        }

        public Punto()
        {
            //Console.WriteLine("Mensaje del constructor vacio");
            contadorDeObjetos++;
        }
        //Métodos funcionales
        public double distanciasHasta(Punto otroPunto)
        {
            double distanciaEntrePuntos = Math.Sqrt(Math.Pow(otroPunto.x, 2) +
                                          Math.Pow(otroPunto.y, 2)); // raiz(a+b)2

            return distanciaEntrePuntos;
        }

        //Método de acceso para la variable de contadorDe Objetos
       public static int getContadorDeObjetos()
        {
            return contadorDeObjetos;
        }


    }
}

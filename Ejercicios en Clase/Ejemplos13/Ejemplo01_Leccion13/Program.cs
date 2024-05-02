using System;

namespace Ejemplo01_Leccion13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circulo circuloA = new Circulo();
            //Console.WriteLine($"El área del objerto Circulo A con radio 5 es: {circuloA.CalculoArea(5)}");
            //Circulo circuloB = new Circulo();
            //Console.WriteLine($"El área del objerto CirculoB con radio 9 es: {circuloB.CalculoArea(9)}");
            //circuloB

            ConversorColonesDolares miObjeto = new ConversorColonesDolares();
            Console.WriteLine($"El monto $80  es {miObjeto.Convertir(80)} colones");

            Console.WriteLine($"El dolar equivale 555 colones");
            miObjeto.CambioValorDolar(555);
            Console.WriteLine($"El valor de $80 con el nuevo tipo de cambio es de {miObjeto.Convertir(80)} colones");
            Console.ReadKey();
        }
    }

    //class Circulo
    //{
    //    // atributos, tambien llamados campos de clase
    //    private const double PI = 3.1416;
    //    public string color = "";
    //    //Métodos
    //    public double CalculoArea(int radio)
    //    {
    //        return PI * radio * radio;
    //    }

    //}

    class ConversorColonesDolares
    {
        //atributos
        private double DolarPrice = 525;
        // Métodos 
        public double Convertir(double cantDolares)
        {
            return cantDolares * DolarPrice;
        }
        public void CambioValorDolar(double nuevoValor)
        {
            if (nuevoValor > 100 && nuevoValor < 1000)
            {
                DolarPrice = nuevoValor;
                Console.WriteLine($"El nuevo valor del dolar es de ¨{nuevoValor} colones");
            }
            else
            {
                Console.WriteLine("El valor introducido no es válido");
            }
        }
    }
}

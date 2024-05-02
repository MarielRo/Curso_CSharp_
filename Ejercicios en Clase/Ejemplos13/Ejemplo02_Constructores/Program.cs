using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil vehiculoINA_01 = new Automovil();
            Automovil vehiculoINA_02 = new Automovil();
            Automovil vehiculoINA_03 = new Automovil("ABI123", "AZUL");

            //seller
            vehiculoINA_01.setPlaca("EM456");
            vehiculoINA_02.setPlaca("MRS128");
            vehiculoINA_02.setColor("Negro");
            vehiculoINA_02.setVolante(true);
            vehiculoINA_02.setDimensiones(4.2, 2.7, 2.1);
            vehiculoINA_02.setPuertas(4);
            Console.WriteLine("Datos del vehiculoINA_02;");
            Console.WriteLine(vehiculoINA_02.getInfoVehiculo());

            Console.WriteLine("Datos del vehiculoINA_01;");
            Console.WriteLine(vehiculoINA_01.getInfoVehiculo());
            Console.WriteLine("Datos del vehiculoINA_03;");
            Console.WriteLine(vehiculoINA_03.getInfoVehiculo());
            Console.ReadKey();
        }
    }

    class Automovil
    {
        //Atributos
        private string placa;
        private int cantidadPuertas;
        private string color;
        private bool volanteAjustable;
        private double largo;
        private double ancho;
        private double peso;

        // MÉTODOS

        //constructor 
        // su finalidad es dar un estado inicial a los objetos que se crean --> valores iniciales 
        public Automovil()
        {
            placa ="BLANCO";
            cantidadPuertas = 4;
            color = "blanco";
            volanteAjustable = true;
            largo = 3.9;
            ancho = 1.8;
            peso = 1.6;

        }
        public Automovil(string placa, string colorV)
        {
            this.placa = placa;
            cantidadPuertas = 4;
            color = "blanco";
            volanteAjustable = true;
            largo = 3.9;
            ancho = 1.8;
            peso = 1.6;

        }

        // metodos de acceso para cada atributo 

        public string getPlaca()
        {
            return placa;
        }
        public int getCantidadPuertas()
        {
            return cantidadPuertas;
        }
        public string getColor()
        {
            return color;
        }
        public bool getVolanteAjustable()
        {
            return volanteAjustable;
        }
        public double getLargo()
        {
            return largo;
        }
        public double getAncho()
        {
            return ancho;
        }
        public double getPeso()
        {
            return peso;
        }
        public string getInfoVehiculo()
        {
            string informacion = $"Información del vehiculo:" +
                $"\nPlaca: {placa}." +
                $"\nPuertas: {cantidadPuertas}." +
                 $"\nVolante Ajustable: {volanteAjustable}" +
                $"\n Color: {color}" +
                $"\nLargo: {largo}." +
                $"\nAncho: {ancho}.\n";
            return informacion;

        }

        // Setter 
        public void setPlaca(string placa)
        {
            this.placa = placa;
        }

        public void setDimensiones(double largo,double ancho, double peso)
        {
            this.largo = largo;
            this.ancho = ancho;
            this.peso = peso;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public void setPuertas(int cantidadPuertas)
        {
            this.cantidadPuertas = cantidadPuertas;
        }

        public void setVolante(bool volanteAjustable)
        {
            this.volanteAjustable = volanteAjustable;
        }
    }
}

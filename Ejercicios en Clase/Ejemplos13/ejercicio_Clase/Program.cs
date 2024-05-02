using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Llamar al constructor 
            Producto producto_01 = new Producto(); //sin parametros
            Producto producto_02 = new Producto("Pasta Dental",2000); // con parametros
            Producto producto_03 = new Producto();
            Producto producto_04 = new Producto();

            // llamar a getter
            //sin parametros
            Console.WriteLine(producto_01.getProducto());
            Console.WriteLine("");

            // con parametros
            Console.WriteLine(producto_02.getProducto());
            Console.WriteLine("");
            

            // llamando al metodo seller 
            producto_03.setNombre("Arroz");
            producto_03.setMarca("Luiciana");
            producto_03.setPrecio(2500);
            producto_03.setPeso(1800);
            Console.WriteLine(producto_03.getProducto());
            Console.WriteLine("");

            // seller con varios parametros
            producto_04.setCaracteristicas("Masa","Juana",1550);
            Console.WriteLine(producto_04.getProducto());
            Console.WriteLine("");
            Console.ReadKey();
        }
    }

    class Producto
    {
        //Atributos (siempre privados) 
        private string nombre;
        private string marca;
        private float precio;
        private int pesoGramos;
        private int cantidad; //no siempre es entera (en este caso es cuantos productos)

        //Metodos 
        //Constructor sin parámetros
        public Producto()
        {
           nombre = "frijoles";
           marca = "Don Pedro";
           precio = 1850;
           pesoGramos = 1000;
           cantidad = 2 ;
        }
        //Constructor con parámetros
        public Producto(string nombre, float precio) // como la propiedad y el parametro se llama igual se debe utilizar this
        {
            this.nombre = nombre;
            marca = "Colgate";
            this.precio = precio;
            pesoGramos = 70;
            cantidad = 1;
        }



        // Métodos de acceco, para ser accedidos fuera de esta clase 
        // Getter
        public string getNombre()
        {
            return nombre;
        }
        public string getMarca()
        {
            return marca;
        }
        public float getPrecio()
        {
            return precio;
        }
        public int getPeso()
        {
            return pesoGramos;
        }
        public int getCantidad()
        {
            return cantidad;
        }

        // retorno de toda la información
        public string getProducto()
        {
            string informacion = $"Información del producto: " +
                $"\nNombre del producto: {nombre}." +
                $"\nMarca: {marca}." +
                 $"\nPrecio: {precio}" +
                $"\n Peso: {pesoGramos}" +
                $"\nCantidad: {cantidad}.";
            return informacion;
        }

        //seller acceder a las propiedaddes y modificarles su valor
        // void porque no retornan nada 
        public void setNombre (string nombre)
        {
            this.nombre = nombre;
        }
        public void setMarca(string marca)
        {
            this.marca = marca;
        }
        public void setPrecio(float precio)
        {
            this.precio = precio;
        }
        public void setPeso(int pesoGramos)
        {
            this.pesoGramos = pesoGramos;
        }
        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        // seller con parametros
        public void setCaracteristicas(string nombre, string marca, float precio)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
        }


    }

}

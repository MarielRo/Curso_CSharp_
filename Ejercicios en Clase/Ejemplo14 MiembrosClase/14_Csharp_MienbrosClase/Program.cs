using System;

namespace _14_Csharp_MienbrosClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto producto1 = new Producto();

            // Utilizando los Setters:
            producto1.IdProducto = 1;
            producto1.Precio = 2000;
            producto1.Descripcion = "Martillo";

            //Getters
            Console.WriteLine($"Código: {producto1.IdProducto}");
            Console.WriteLine($"Precio: {producto1.Precio}");
            Console.WriteLine($"Descripcion: {producto1.Descripcion}");

            //Utilizando método funcional 
            Console.WriteLine("Realizando un 25% de descuento:");
            Console.WriteLine($"Monto descuento: { producto1.darDescuento(0.25)}");
            Console.ReadKey();


        }

        class Producto
        {
            //Atributos 
            private int _idProducto;
            private double _precio;
            private String _descripcion;

            //Métodos

            //constructores 
            public Producto() //sin parametros
            {
                _idProducto = 0;
                _precio = 0;
                _descripcion = string.Empty;
            }
            public Producto(int idProducto, int precio, string descripcion) //sin parametros
            {
                _idProducto = idProducto;
                _precio = precio;
                _descripcion = descripcion;
            }

            //propiedades
            public int IdProducto
            {
                get { return _idProducto; }
                set { _idProducto = value; }
            }

            public double Precio
            {
                get { return _precio; }
                set { _precio = value; }
            }

            public string Descripcion
            {
                get { return _descripcion; }
                set { _descripcion = value; }
            }

            //Métodos funcionalidades
            public double darDescuento (double descuento)
            {
                double montoDescuento = 0;
                montoDescuento = _precio - (_precio * descuento);
                return montoDescuento;

            }

          



        }
    }
}

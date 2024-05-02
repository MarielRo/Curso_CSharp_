using System;

namespace LogicaNegocio
{
    public class ClsPromedio
    {
        private string condicion;
        private string color;
        private double promedio;

        public string Color { get => color; set => color = value; }
        public double Promedio { get => promedio; set => promedio = value; }
        public string Condicion { get => condicion; set => condicion = value; }
    }
}

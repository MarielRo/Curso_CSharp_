using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NotasExcelencia02
{
    public partial class FrmDeterminarExcelencia : Form
    {
        public FrmDeterminarExcelencia()
        {
            InitializeComponent();
        }


        public void ValidarEntrada(object sender, KeyPressEventArgs e)
        {
            // si es numerico o una tecla de retroceso, No Cancele el evento
            if(char.IsDigit(e.KeyChar) | e.KeyChar == 8 | e.KeyChar == 44)
            {
                e.Handled = false;
            }
            else
            {
                // Cancele el evento asociado
                e.Handled = true;
            }
        }

        public void txtPromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntrada(sender, e);
        }
        // click  del boton de calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de Variables
            double promedio = 0;
            string condicion = string.Empty;
            if(string.IsNullOrEmpty(txtNombre1.Text) || string.IsNullOrEmpty(txtPromedio.Text))
            {
                MessageBox.Show("Ingrese el nombre o el promedio antes de calcular la condición", "Datos Incompletos", MessageBoxButtons.OK);

            }
            else
            {
                double.TryParse(txtPromedio.Text, out promedio);
                // condicion del promedi o 
                if(promedio>=90)
                {
                    condicion = "EXCELENTE";
                }
                else if (promedio >= 70)
                {
                    condicion = "APROBADO";
                }
                else if (promedio >= 60)
                {
                    condicion = "APLAZADO";
                }
                else  
                {
                    condicion = "REPROBADO";
                }
                txtCondicion.Text = condicion;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string datos = string.Empty;
            if(string.IsNullOrEmpty(txtNombre1.Text) || string.IsNullOrEmpty(txtPromedio.Text) 
                || string.IsNullOrEmpty(txtCondicion.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos antes de agregar al estudiante",
                    "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                datos = txtNombre1.Text + ":" + txtPromedio.Text + " " + txtCondicion.Text;
                LstEstudiantes.Items.Add(datos);
                Limpiar();
                txtNombre1.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Limpiar()
        {
            txtNombre1.Text = string.Empty;
            txtPromedio.Text = string.Empty;
            txtCondicion.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LstEstudiantes.Items.Clear();
        }
    }
}

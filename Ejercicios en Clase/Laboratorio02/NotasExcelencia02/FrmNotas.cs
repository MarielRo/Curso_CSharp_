using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NotasExcelencia02
{
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtNombre.Text = String.Empty;
            txtexamen1.Text = "";
            txtexamen2.Text = "";
            txtexamen3.Text = "";
            txtexamen4.Text = "";
            txtporcentaje1.Text = String.Empty;
            txtporcentaje2.Text = String.Empty;
            txtporcentaje3.Text = String.Empty;
            txtporcentaje4.Text = String.Empty;
            txtpromedio.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // Funcion Calcular Porcentaje 
        public double CalcularPorcentaje(double nota)
        {
            return nota * 0.25;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            double examen1, examen2, examen3, examen4;
            examen1 = examen2 = examen3 = examen4 = 0;
            double promedio = 0;
            string condicion = string.Empty;

            //Verificar que el nombre no esté vacio
            // if(txtNombre.Text == "") or // if(txtNombre.Text == string.Empty

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                if(string.IsNullOrEmpty(txtexamen1.Text) || string.IsNullOrEmpty(txtexamen2.Text) ||
                    string.IsNullOrEmpty(txtexamen3.Text) || string.IsNullOrEmpty(txtexamen4.Text))
                {
                    MessageBox.Show("Falta almenos una nota. Favor verificar e initentar de nuevo", "Atención", MessageBoxButtons.OK);
                    if (!string.IsNullOrEmpty(txtexamen1.Text))
                    {
                        txtexamen1.Focus();
                    }
                    else if (!string.IsNullOrEmpty(txtexamen2.Text))
                    {
                        txtexamen2.Focus();
                    }
                    else if (!string.IsNullOrEmpty(txtexamen3.Text))
                    {
                        txtexamen3.Focus();
                    }
                    else
                    {
                        txtexamen4.Focus();
                    }
                }
                else //Todas las cajas si tinene los campos llenos
                {
                    double.TryParse(txtexamen1.Text, out examen1);
                    double.TryParse(txtexamen2.Text, out examen2);
                    double.TryParse(txtexamen3.Text, out examen3);
                    double.TryParse(txtexamen4.Text, out examen4);
                    // si las notas ingresadas estan el el rango correcto
                    if (examen1 > 0 & examen1 <= 100 & examen2 > 0 & examen2 <= 100 &
                        examen3 > 0 & examen3 <= 100 & examen4 > 0 & examen4 <= 100)
                    {
                        txtporcentaje1.Text = CalcularPorcentaje(examen1).ToString();
                        txtporcentaje2.Text = string.Format("{0}", CalcularPorcentaje(examen2));
                        txtporcentaje3.Text = Math.Round(CalcularPorcentaje(examen3), 2).ToString();
                        txtporcentaje4.Text = string.Format("{0}", Math.Round(CalcularPorcentaje(examen4),2));

                        promedio = (examen1 + examen2 + examen3 + examen4) / 4; //Calculo del promedio 
                        
                        if(promedio >= 70)
                        {
                            condicion = "APROBADO";
                            txtpromedio.ForeColor = Color.Black;
                        }
                        else if(promedio >= 50)
                        {
                            condicion = "APLAZADO";
                            txtpromedio.BackColor = Color.Brown;
                        }
                        else
                        {
                            condicion = "REPROBADO";
                            txtpromedio.BackColor = Color.Red;

                        }
                        txtpromedio.Text = String.Format("{0} - {1} - {2}", txtNombre.Text, promedio, condicion);
                    }
                    else
                    {
                        MessageBox.Show("Nota(s) incorrecta(s). Las notas deben ser numericas dentro de un rango de 1 a 100.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor incluir el nombre del estudiante", "Atención", MessageBoxButtons.OK);
                txtNombre.Focus();
            }



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ValidarEntrada(object sender, KeyPressEventArgs e)
        {
            // si es numerico o na tecla de tretroceso, NO CANCELE EL EVENTO
            if(char.IsDigit(e.KeyChar) | e.KeyChar == 8 | e.KeyChar ==  44)
            {
                e.Handled = false;
            }
            else
            {
                //SI CANCELAR EL EVENTO ASOCIADO
                e.Handled = true;
            }
        }

        public void MuyGrande(TextBox num)
        {
            double n = 0;
            double.TryParse(num.Text, out n);
            if(n > 100)
            {
                MessageBox.Show("La nota no puede ser mayor a 100", "Nota fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
                num.Text = string.Empty;
            }
        }




        private void txtExamen1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntrada(sender, e);
        }
        private void txtExamen2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntrada(sender, e);
        }
        private void txtExamen3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntrada(sender, e);
        }
        private void txtExamen4_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEntrada(sender, e);
        }
        private void txtExamen1_KeyUp(object sender, KeyEventArgs e)
        {
            MuyGrande(txtexamen1);
        }
        private void txtExamen2_KeyUp(object sender, KeyEventArgs e)
        {
            MuyGrande(txtexamen2);
        }
        private void txtExamen3_KeyUp(object sender, KeyEventArgs e)
        {
            MuyGrande(txtexamen3);
        }
        private void txtExamen4_KeyUp(object sender, KeyEventArgs e)
        {
            MuyGrande(txtexamen4);
        }

        public void Limpiar2()
        {

        }

        private void txtpromedio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

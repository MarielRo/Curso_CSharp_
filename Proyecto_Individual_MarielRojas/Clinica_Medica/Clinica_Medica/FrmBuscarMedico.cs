using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_LogicaNegocio;

namespace Capa_Presentación
{
    public partial class FrmBuscarMedico : Form
    {
        public FrmBuscarMedico()
        {
            InitializeComponent();
        }


        public event EventHandler Aceptar;
        int vgn_id_medico;



        private void cargarListaDataSet(string condicion = "", string orden = "")
        {
            BLMedico logica = new BLMedico(Configuracion.getConnectionString);
            DataSet DSMedicos;
            try
            {
                DSMedicos = logica.ListarMedicos(condicion, orden);
                grdListaMedico.DataSource = DSMedicos;
                grdListaMedico.DataMember = DSMedicos.Tables["Medicos"].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBuscarMedico_Load(object sender, EventArgs e)
        {
            try
            {
                cargarListaDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string condicion = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    condicion = string.Format("Nombre like'%{0}%'", txtNombre.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir parte del nombre a buscar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                }

                cargarListaDataSet(condicion);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Seleccionar()
        {
            if (grdListaMedico.SelectedRows.Count > 0)
            {
                vgn_id_medico = (int)grdListaMedico.SelectedRows[0].Cells[0].Value;
                // le manda id al evento Aceptar que esta en FrmClientes
                Aceptar(vgn_id_medico, null);
                Close();
            }
        }// fin seleccionar



        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void grdListaMedico_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }
    }
}

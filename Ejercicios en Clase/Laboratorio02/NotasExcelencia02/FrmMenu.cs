using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotasExcelencia02
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void calcularPromedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // crea la instancia del formulario
            FrmNotas frm = new FrmNotas();
            // hace que el formulario se muestre como un hijo de MDI
            frm.MdiParent = this;
            //
            frm.Show();
        }

        private void determinarExcelenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // crea la instancia del formulario
            FrmDeterminarExcelencia frm = new FrmDeterminarExcelencia();
            // hace que el formulario se muestre como un hijo de MDI
            frm.MdiParent = this;
            //
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INA_Práctica Guiada_ Mariel Rojas");
        }
    }
}

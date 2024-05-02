using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Guiada_01
{
    public partial class FrmNotas : Form
    {
       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FrmNotas
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "FrmNotas";
            this.Click += new System.EventHandler(this.FrmNotas_Click);
            this.ResumeLayout(false);

        }

        private void FrmNotas_Click(object sender, EventArgs e)
        {

        }
    }
}

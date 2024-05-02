
namespace NotasExelencia
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalcular = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuexcelencia = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCalcular,
            this.mnuexcelencia,
            this.salirToolStripMenuItem});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(73, 24);
            this.mnuArchivo.Text = "Archivo";
            this.mnuArchivo.Click += new System.EventHandler(this.calcularPromedioToolStripMenuItem_Click);
            // 
            // mnuCalcular
            // 
            this.mnuCalcular.Name = "mnuCalcular";
            this.mnuCalcular.Size = new System.Drawing.Size(224, 26);
            this.mnuCalcular.Text = "Calcular Promedio";
            // 
            // mnuexcelencia
            // 
            this.mnuexcelencia.Name = "mnuexcelencia";
            this.mnuexcelencia.Size = new System.Drawing.Size(224, 26);
            this.mnuexcelencia.Text = "Excelencia";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcerca});
            this.mnuAyuda.Name = "mnuAyuda";
            this.mnuAyuda.Size = new System.Drawing.Size(65, 24);
            this.mnuAyuda.Text = "Ayuda";
            // 
            // mnuAcerca
            // 
            this.mnuAcerca.Name = "mnuAcerca";
            this.mnuAcerca.Size = new System.Drawing.Size(164, 26);
            this.mnuAcerca.Text = "Acerca de..";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuCalcular;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnuexcelencia;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAcerca;
    }
}


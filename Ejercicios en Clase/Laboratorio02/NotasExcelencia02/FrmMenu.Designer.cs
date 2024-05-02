
namespace NotasExcelencia02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalcular = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExcelencia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo2,
            this.mnuAayuda});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(938, 28);
            this.mnuStrip.TabIndex = 1;
            this.mnuStrip.Text = "Archivo";
            // 
            // mnuArchivo2
            // 
            this.mnuArchivo2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCalcular,
            this.mnuExcelencia,
            this.mnuSalir});
            this.mnuArchivo2.Name = "mnuArchivo2";
            this.mnuArchivo2.Size = new System.Drawing.Size(73, 24);
            this.mnuArchivo2.Text = "Archivo";
            // 
            // mnuCalcular
            // 
            this.mnuCalcular.Name = "mnuCalcular";
            this.mnuCalcular.Size = new System.Drawing.Size(240, 26);
            this.mnuCalcular.Text = "Calcular Promedio";
            this.mnuCalcular.Click += new System.EventHandler(this.calcularPromedioToolStripMenuItem_Click);
            // 
            // mnuExcelencia
            // 
            this.mnuExcelencia.Name = "mnuExcelencia";
            this.mnuExcelencia.Size = new System.Drawing.Size(240, 26);
            this.mnuExcelencia.Text = "Determinar Excelencia";
            this.mnuExcelencia.Click += new System.EventHandler(this.determinarExcelenciaToolStripMenuItem_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(240, 26);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mnuAayuda
            // 
            this.mnuAayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcerca});
            this.mnuAayuda.Name = "mnuAayuda";
            this.mnuAayuda.Size = new System.Drawing.Size(65, 24);
            this.mnuAayuda.Text = "Ayuda";
            // 
            // mnuAcerca
            // 
            this.mnuAcerca.Name = "mnuAcerca";
            this.mnuAcerca.Size = new System.Drawing.Size(224, 26);
            this.mnuAcerca.Text = "Acerca de..";
            this.mnuAcerca.Click += new System.EventHandler(this.mnuAcerca_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 553);
            this.Controls.Add(this.mnuStrip);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio02";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo2;
        private System.Windows.Forms.ToolStripMenuItem mnuCalcular;
        private System.Windows.Forms.ToolStripMenuItem mnuExcelencia;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuAayuda;
        private System.Windows.Forms.ToolStripMenuItem mnuAcerca;
    }
}


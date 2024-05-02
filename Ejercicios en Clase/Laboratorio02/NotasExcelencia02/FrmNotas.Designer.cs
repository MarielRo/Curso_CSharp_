
namespace NotasExcelencia02
{
    partial class FrmNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbnotasObtenidas = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtporcentaje4 = new System.Windows.Forms.TextBox();
            this.txtporcentaje3 = new System.Windows.Forms.TextBox();
            this.txtporcentaje2 = new System.Windows.Forms.TextBox();
            this.txtporcentaje1 = new System.Windows.Forms.TextBox();
            this.txtexamen4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtexamen3 = new System.Windows.Forms.TextBox();
            this.txtexamen2 = new System.Windows.Forms.TextBox();
            this.txtexamen1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPromedio = new System.Windows.Forms.GroupBox();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.Mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbnotasObtenidas.SuspendLayout();
            this.gbPromedio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbnotasObtenidas
            // 
            this.gbnotasObtenidas.Controls.Add(this.label6);
            this.gbnotasObtenidas.Controls.Add(this.txtporcentaje4);
            this.gbnotasObtenidas.Controls.Add(this.txtporcentaje3);
            this.gbnotasObtenidas.Controls.Add(this.txtporcentaje2);
            this.gbnotasObtenidas.Controls.Add(this.txtporcentaje1);
            this.gbnotasObtenidas.Controls.Add(this.txtexamen4);
            this.gbnotasObtenidas.Controls.Add(this.label5);
            this.gbnotasObtenidas.Controls.Add(this.label4);
            this.gbnotasObtenidas.Controls.Add(this.txtexamen3);
            this.gbnotasObtenidas.Controls.Add(this.txtexamen2);
            this.gbnotasObtenidas.Controls.Add(this.txtexamen1);
            this.gbnotasObtenidas.Controls.Add(this.label3);
            this.gbnotasObtenidas.Controls.Add(this.label2);
            this.gbnotasObtenidas.Controls.Add(this.txtNombre);
            this.gbnotasObtenidas.Controls.Add(this.label1);
            this.gbnotasObtenidas.Location = new System.Drawing.Point(20, 12);
            this.gbnotasObtenidas.Name = "gbnotasObtenidas";
            this.gbnotasObtenidas.Size = new System.Drawing.Size(390, 220);
            this.gbnotasObtenidas.TabIndex = 0;
            this.gbnotasObtenidas.TabStop = false;
            this.gbnotasObtenidas.Text = "Notas Obtenidas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "%(25%)";
            // 
            // txtporcentaje4
            // 
            this.txtporcentaje4.BackColor = System.Drawing.SystemColors.Info;
            this.txtporcentaje4.Enabled = false;
            this.txtporcentaje4.Location = new System.Drawing.Point(279, 180);
            this.txtporcentaje4.Name = "txtporcentaje4";
            this.txtporcentaje4.Size = new System.Drawing.Size(105, 28);
            this.txtporcentaje4.TabIndex = 13;
            // 
            // txtporcentaje3
            // 
            this.txtporcentaje3.BackColor = System.Drawing.SystemColors.Info;
            this.txtporcentaje3.Enabled = false;
            this.txtporcentaje3.Location = new System.Drawing.Point(279, 146);
            this.txtporcentaje3.Name = "txtporcentaje3";
            this.txtporcentaje3.Size = new System.Drawing.Size(105, 28);
            this.txtporcentaje3.TabIndex = 12;
            // 
            // txtporcentaje2
            // 
            this.txtporcentaje2.BackColor = System.Drawing.SystemColors.Info;
            this.txtporcentaje2.Enabled = false;
            this.txtporcentaje2.Location = new System.Drawing.Point(279, 112);
            this.txtporcentaje2.Name = "txtporcentaje2";
            this.txtporcentaje2.Size = new System.Drawing.Size(105, 28);
            this.txtporcentaje2.TabIndex = 11;
            // 
            // txtporcentaje1
            // 
            this.txtporcentaje1.BackColor = System.Drawing.SystemColors.Info;
            this.txtporcentaje1.Enabled = false;
            this.txtporcentaje1.Location = new System.Drawing.Point(279, 78);
            this.txtporcentaje1.Name = "txtporcentaje1";
            this.txtporcentaje1.Size = new System.Drawing.Size(105, 28);
            this.txtporcentaje1.TabIndex = 10;
            // 
            // txtexamen4
            // 
            this.txtexamen4.Location = new System.Drawing.Point(128, 180);
            this.txtexamen4.Name = "txtexamen4";
            this.txtexamen4.Size = new System.Drawing.Size(103, 28);
            this.txtexamen4.TabIndex = 9;
            this.txtexamen4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExamen4_KeyPress);
            this.txtexamen4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtExamen4_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "IV Examen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "III Examen";
            // 
            // txtexamen3
            // 
            this.txtexamen3.Location = new System.Drawing.Point(128, 146);
            this.txtexamen3.Name = "txtexamen3";
            this.txtexamen3.Size = new System.Drawing.Size(103, 28);
            this.txtexamen3.TabIndex = 6;
            this.txtexamen3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExamen3_KeyPress);
            this.txtexamen3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtExamen3_KeyUp);
            // 
            // txtexamen2
            // 
            this.txtexamen2.Location = new System.Drawing.Point(128, 112);
            this.txtexamen2.Name = "txtexamen2";
            this.txtexamen2.Size = new System.Drawing.Size(103, 28);
            this.txtexamen2.TabIndex = 5;
            this.txtexamen2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExamen2_KeyPress);
            this.txtexamen2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtExamen2_KeyUp);
            // 
            // txtexamen1
            // 
            this.txtexamen1.Location = new System.Drawing.Point(128, 78);
            this.txtexamen1.Name = "txtexamen1";
            this.txtexamen1.Size = new System.Drawing.Size(103, 28);
            this.txtexamen1.TabIndex = 4;
            this.txtexamen1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExamen1_KeyPress);
            this.txtexamen1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtExamen1_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "II Examen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "I Examen ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(256, 28);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // gbPromedio
            // 
            this.gbPromedio.Controls.Add(this.txtpromedio);
            this.gbPromedio.Location = new System.Drawing.Point(20, 250);
            this.gbPromedio.Name = "gbPromedio";
            this.gbPromedio.Size = new System.Drawing.Size(390, 70);
            this.gbPromedio.TabIndex = 1;
            this.gbPromedio.TabStop = false;
            this.gbPromedio.Text = "Promedio";
            // 
            // txtpromedio
            // 
            this.txtpromedio.BackColor = System.Drawing.SystemColors.Info;
            this.txtpromedio.Enabled = false;
            this.txtpromedio.Location = new System.Drawing.Point(53, 27);
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.Size = new System.Drawing.Size(296, 28);
            this.txtpromedio.TabIndex = 0;
            this.txtpromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpromedio.TextChanged += new System.EventHandler(this.txtpromedio_TextChanged);
            // 
            // Mensaje
            // 
            this.Mensaje.IsBalloon = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(34, 342);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "&Nuevo";
            this.Mensaje.SetToolTip(this.btnNuevo, "Click \r\nAlt+N\r\n");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(157, 342);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 29);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "&Calcular";
            this.Mensaje.SetToolTip(this.btnCalcular, "Click\r\nAlt+C\r\n\r\n");
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(285, 342);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.Mensaje.SetToolTip(this.btnSalir, "Click\r\nAlt+S");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(432, 383);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbPromedio);
            this.Controls.Add(this.gbnotasObtenidas);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Promedio";
            this.gbnotasObtenidas.ResumeLayout(false);
            this.gbnotasObtenidas.PerformLayout();
            this.gbPromedio.ResumeLayout(false);
            this.gbPromedio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbnotasObtenidas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtexamen1;
        private System.Windows.Forms.TextBox txtexamen2;
        private System.Windows.Forms.TextBox txtexamen3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtporcentaje4;
        private System.Windows.Forms.TextBox txtporcentaje3;
        private System.Windows.Forms.TextBox txtporcentaje2;
        private System.Windows.Forms.TextBox txtporcentaje1;
        private System.Windows.Forms.TextBox txtexamen4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbPromedio;
        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.ToolTip Mensaje;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
    }
}
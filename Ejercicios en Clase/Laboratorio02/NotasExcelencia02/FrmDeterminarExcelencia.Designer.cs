
namespace NotasExcelencia02
{
    partial class FrmDeterminarExcelencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeterminarExcelencia));
            this.Mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LstEstudiantes = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.txtPromedio);
            this.groupBox1.Controls.Add(this.txtNombre1);
            this.groupBox1.Controls.Add(this.txtCondicion);
            this.groupBox1.Controls.Add(this.lblCondicion);
            this.groupBox1.Controls.Add(this.lblPromedio);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Estudiante";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(229, 39);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(89, 20);
            this.lblPromedio.TabIndex = 1;
            this.lblPromedio.Text = "Promedio";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(412, 39);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(93, 20);
            this.lblCondicion.TabIndex = 2;
            this.lblCondicion.Text = "Condición";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(229, 62);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(89, 28);
            this.txtPromedio.TabIndex = 1;
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(21, 62);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(202, 28);
            this.txtNombre1.TabIndex = 2;
            // 
            // txtCondicion
            // 
            this.txtCondicion.BackColor = System.Drawing.SystemColors.Info;
            this.txtCondicion.Location = new System.Drawing.Point(412, 62);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(162, 28);
            this.txtCondicion.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(340, 58);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(52, 34);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(480, 101);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "&Agregar";
            this.Mensaje.SetToolTip(this.btnAgregar, "Click\r\nAlt + A");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 200);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Estudiantes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LstEstudiantes);
            this.groupBox3.Location = new System.Drawing.Point(12, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 200);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de estudiante";
            // 
            // LstEstudiantes
            // 
            this.LstEstudiantes.FormattingEnabled = true;
            this.LstEstudiantes.ItemHeight = 20;
            this.LstEstudiantes.Location = new System.Drawing.Point(21, 36);
            this.LstEstudiantes.Name = "LstEstudiantes";
            this.LstEstudiantes.Size = new System.Drawing.Size(553, 144);
            this.LstEstudiantes.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(487, 371);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.Mensaje.SetToolTip(this.btnSalir, "Click\r\nAlt + S");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(387, 371);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "&Limpiar";
            this.Mensaje.SetToolTip(this.btnLimpiar, "Click\r\nAlt + L\r\n");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmDeterminarExcelencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(607, 443);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmDeterminarExcelencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Determinar Excelencia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip Mensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox LstEstudiantes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
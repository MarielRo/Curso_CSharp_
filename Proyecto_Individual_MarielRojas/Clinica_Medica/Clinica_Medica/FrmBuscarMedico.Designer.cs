
namespace Capa_Presentación
{
    partial class FrmBuscarMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarMedico));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grdListaMedico = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(549, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 80);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(443, 350);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 80);
            this.btnAceptar.TabIndex = 39;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // grdListaMedico
            // 
            this.grdListaMedico.AllowUserToAddRows = false;
            this.grdListaMedico.AllowUserToDeleteRows = false;
            this.grdListaMedico.AllowUserToResizeColumns = false;
            this.grdListaMedico.AllowUserToResizeRows = false;
            this.grdListaMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.telefono,
            this.direccion});
            this.grdListaMedico.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaMedico.Location = new System.Drawing.Point(30, 106);
            this.grdListaMedico.Name = "grdListaMedico";
            this.grdListaMedico.RowHeadersWidth = 51;
            this.grdListaMedico.RowTemplate.Height = 29;
            this.grdListaMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaMedico.Size = new System.Drawing.Size(619, 149);
            this.grdListaMedico.TabIndex = 38;
            this.grdListaMedico.DoubleClick += new System.EventHandler(this.grdListaMedico_DoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "ID_PACIENTE";
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.Width = 70;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "NOMBRE";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 350;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "TELEFONO";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.Width = 125;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "DIRECCION";
            this.direccion.HeaderText = "Dirección";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.Visible = false;
            this.direccion.Width = 125;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(549, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 80);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 27);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(443, 27);
            this.txtNombre.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre";
            // 
            // FrmBuscarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grdListaMedico);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Name = "FrmBuscarMedico";
            this.Text = "FrmBuscarMedico";
            this.Load += new System.EventHandler(this.FrmBuscarMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView grdListaMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
    }
}
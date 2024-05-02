
namespace _01_Capas
{
    partial class FrmBuscarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarClientes));
            this.lblNombreBuscar = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreBuscar
            // 
            this.lblNombreBuscar.AutoSize = true;
            this.lblNombreBuscar.Location = new System.Drawing.Point(44, 31);
            this.lblNombreBuscar.Name = "lblNombreBuscar";
            this.lblNombreBuscar.Size = new System.Drawing.Size(64, 20);
            this.lblNombreBuscar.TabIndex = 0;
            this.lblNombreBuscar.Text = "Nombre";
            this.lblNombreBuscar.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(356, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(663, 335);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 92);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(541, 335);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 92);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToResizeColumns = false;
            this.dgvLista.AllowUserToResizeRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.ColumnHeadersVisible = false;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.telefono,
            this.direccion});
            this.dgvLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLista.Location = new System.Drawing.Point(44, 99);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 29;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(719, 219);
            this.dgvLista.TabIndex = 18;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "ID_CLIENTE";
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 70;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "NOMBRE";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 350;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "TELEFONO";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 120;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "DIRECCION";
            this.direccion.HeaderText = "Dirección";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Visible = false;
            this.direccion.Width = 125;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(670, 1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 81);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreBuscar);
            this.Name = "FrmBuscarClientes";
            this.Text = "Buscar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.Button btnBuscar;
    }
}
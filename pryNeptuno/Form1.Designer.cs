namespace pryNeptuno
{
    partial class frmNeptuno
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.mrcFiltrar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cmbMostrarCiudad = new System.Windows.Forms.ComboBox();
            this.lblCargos = new System.Windows.Forms.Label();
            this.cmbCargos = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.mrcFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvClientes.Location = new System.Drawing.Point(53, 137);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(927, 185);
            this.dgvClientes.TabIndex = 1;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(707, 36);
            this.btnMostrarTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(100, 28);
            this.btnMostrarTodos.TabIndex = 2;
            this.btnMostrarTodos.Text = "Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // mrcFiltrar
            // 
            this.mrcFiltrar.Controls.Add(this.button1);
            this.mrcFiltrar.Controls.Add(this.lblCiudad);
            this.mrcFiltrar.Controls.Add(this.cmbMostrarCiudad);
            this.mrcFiltrar.Controls.Add(this.lblCargos);
            this.mrcFiltrar.Controls.Add(this.cmbCargos);
            this.mrcFiltrar.Controls.Add(this.btnMostrarTodos);
            this.mrcFiltrar.Location = new System.Drawing.Point(53, 28);
            this.mrcFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.mrcFiltrar.Name = "mrcFiltrar";
            this.mrcFiltrar.Padding = new System.Windows.Forms.Padding(4);
            this.mrcFiltrar.Size = new System.Drawing.Size(823, 87);
            this.mrcFiltrar.TabIndex = 5;
            this.mrcFiltrar.TabStop = false;
            this.mrcFiltrar.Text = "Filtrar por";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(223, 43);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(50, 16);
            this.lblCiudad.TabIndex = 6;
            this.lblCiudad.Text = "Ciudad";
            // 
            // cmbMostrarCiudad
            // 
            this.cmbMostrarCiudad.FormattingEnabled = true;
            this.cmbMostrarCiudad.Location = new System.Drawing.Point(284, 37);
            this.cmbMostrarCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMostrarCiudad.Name = "cmbMostrarCiudad";
            this.cmbMostrarCiudad.Size = new System.Drawing.Size(120, 24);
            this.cmbMostrarCiudad.TabIndex = 5;
            // 
            // lblCargos
            // 
            this.lblCargos.AutoSize = true;
            this.lblCargos.Location = new System.Drawing.Point(19, 43);
            this.lblCargos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(51, 16);
            this.lblCargos.TabIndex = 4;
            this.lblCargos.Text = "Cargos";
            // 
            // cmbCargos
            // 
            this.cmbCargos.FormattingEnabled = true;
            this.cmbCargos.Location = new System.Drawing.Point(80, 37);
            this.cmbCargos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCargos.Name = "cmbCargos";
            this.cmbCargos.Size = new System.Drawing.Size(120, 24);
            this.cmbCargos.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(945, 63);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar Tabla";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre de Compañia";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre del Contacto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cargo del Contacto";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Direccion";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Codigo postal";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Pais";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Fax";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // frmNeptuno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 359);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.mrcFiltrar);
            this.Controls.Add(this.dgvClientes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNeptuno";
            this.Text = "Neptuno";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.mrcFiltrar.ResumeLayout(false);
            this.mrcFiltrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.GroupBox mrcFiltrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbCargos;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.ComboBox cmbMostrarCiudad;
        private System.Windows.Forms.Label lblCargos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}


namespace Bendiciones
{
    partial class frmBuscarServicioDeudaPorCliente
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
			this.dgvMatriculas = new System.Windows.Forms.DataGridView();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvMatriculas
			// 
			this.dgvMatriculas.AllowUserToAddRows = false;
			this.dgvMatriculas.AllowUserToDeleteRows = false;
			this.dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Fecha,
            this.Saldo});
			this.dgvMatriculas.Location = new System.Drawing.Point(13, 13);
			this.dgvMatriculas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvMatriculas.Name = "dgvMatriculas";
			this.dgvMatriculas.ReadOnly = true;
			this.dgvMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMatriculas.Size = new System.Drawing.Size(817, 239);
			this.dgvMatriculas.TabIndex = 26;
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.FlatAppearance.BorderSize = 0;
			this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionar.Location = new System.Drawing.Point(725, 260);
			this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(133, 37);
			this.btnSeleccionar.TabIndex = 25;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// Nombre
			// 
			this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Fecha
			// 
			this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			// 
			// Saldo
			// 
			this.Saldo.HeaderText = "Saldo";
			this.Saldo.Name = "Saldo";
			this.Saldo.ReadOnly = true;
			// 
			// frmBuscarServicioDeudaPorCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(871, 325);
			this.Controls.Add(this.dgvMatriculas);
			this.Controls.Add(this.btnSeleccionar);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmBuscarServicioDeudaPorCliente";
			this.Text = "frmBuscarServicioPorCliente";
			((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatriculas;
        private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
	}
}
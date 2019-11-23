namespace Bendiciones
{
    partial class frmBuscarBebe
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
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.dgvBebes = new System.Windows.Forms.DataGridView();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBebes)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Enabled = false;
			this.txtNombre.HideSelection = false;
			this.txtNombre.Location = new System.Drawing.Point(301, 133);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(583, 22);
			this.txtNombre.TabIndex = 39;
			this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// dgvBebes
			// 
			this.dgvBebes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBebes.Location = new System.Drawing.Point(184, 240);
			this.dgvBebes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvBebes.Name = "dgvBebes";
			this.dgvBebes.Size = new System.Drawing.Size(701, 185);
			this.dgvBebes.TabIndex = 38;
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.FlatAppearance.BorderSize = 0;
			this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionar.Location = new System.Drawing.Point(752, 44);
			this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(133, 37);
			this.btnSeleccionar.TabIndex = 37;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			// 
			// btnBuscar
			// 
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Location = new System.Drawing.Point(597, 44);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(133, 37);
			this.btnBuscar.TabIndex = 36;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Location = new System.Drawing.Point(466, 44);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(133, 37);
			this.btnEliminar.TabIndex = 40;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// frmBuscarBebe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.dgvBebes);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.btnBuscar);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmBuscarBebe";
			this.Text = "frmBuscarBebe";
			((System.ComponentModel.ISupportInitialize)(this.dgvBebes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvBebes;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnEliminar;
	}
}
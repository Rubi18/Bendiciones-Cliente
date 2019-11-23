namespace Bendiciones
{
    partial class frmBuscarClaseParticularSinDocente
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
            this.lblBuscarClaseParticular = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.dgvClasesParticulares = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasesParticulares)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarClaseParticular
            // 
            this.lblBuscarClaseParticular.AutoSize = true;
            this.lblBuscarClaseParticular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarClaseParticular.Location = new System.Drawing.Point(69, 31);
            this.lblBuscarClaseParticular.Name = "lblBuscarClaseParticular";
            this.lblBuscarClaseParticular.Size = new System.Drawing.Size(226, 22);
            this.lblBuscarClaseParticular.TabIndex = 7;
            this.lblBuscarClaseParticular.Text = "Buscar Clase Particular";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.dgvClasesParticulares);
            this.pnlContainer.Controls.Add(this.btnSeleccionar);
            this.pnlContainer.Controls.Add(this.btnBuscar);
            this.pnlContainer.Location = new System.Drawing.Point(73, 83);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(659, 391);
            this.pnlContainer.TabIndex = 6;
            // 
            // dgvClasesParticulares
            // 
            this.dgvClasesParticulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasesParticulares.Location = new System.Drawing.Point(76, 130);
            this.dgvClasesParticulares.Name = "dgvClasesParticulares";
            this.dgvClasesParticulares.Size = new System.Drawing.Size(526, 211);
            this.dgvClasesParticulares.TabIndex = 17;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Location = new System.Drawing.Point(502, 81);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(100, 30);
            this.btnSeleccionar.TabIndex = 16;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(386, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmBuscarClaseParticularSinDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.lblBuscarClaseParticular);
            this.Controls.Add(this.pnlContainer);
            this.Name = "frmBuscarClaseParticularSinDocente";
            this.Text = "frmBuscarClaseParticularSinDocente";
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasesParticulares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarClaseParticular;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.DataGridView dgvClasesParticulares;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
    }
}
namespace Bendiciones
{
    partial class ___frmInfoCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(___frmInfoCurso));
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblDescripcionCurso = new System.Windows.Forms.Label();
            this.lblNumClases = new System.Windows.Forms.Label();
            this.lblCondicones = new System.Windows.Forms.Label();
            this.txtNumClases = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMasCondiciones = new System.Windows.Forms.Button();
            this.listBoxCondiciones = new System.Windows.Forms.ListBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnMasProfes = new System.Windows.Forms.Button();
            this.lblProfesores = new System.Windows.Forms.Label();
            this.listBoxProfesores = new System.Windows.Forms.ListBox();
            this.txtSede = new System.Windows.Forms.TextBox();
            this.lblSede = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCurso.Location = new System.Drawing.Point(54, 36);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(144, 25);
            this.lblNombreCurso.TabIndex = 1;
            this.lblNombreCurso.Text = "NombreCurso";
            // 
            // lblDescripcionCurso
            // 
            this.lblDescripcionCurso.AutoSize = true;
            this.lblDescripcionCurso.Location = new System.Drawing.Point(55, 96);
            this.lblDescripcionCurso.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblDescripcionCurso.Name = "lblDescripcionCurso";
            this.lblDescripcionCurso.Size = new System.Drawing.Size(695, 52);
            this.lblDescripcionCurso.TabIndex = 2;
            this.lblDescripcionCurso.Text = resources.GetString("lblDescripcionCurso.Text");
            // 
            // lblNumClases
            // 
            this.lblNumClases.AutoSize = true;
            this.lblNumClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumClases.Location = new System.Drawing.Point(3, 49);
            this.lblNumClases.Name = "lblNumClases";
            this.lblNumClases.Size = new System.Drawing.Size(121, 16);
            this.lblNumClases.TabIndex = 4;
            this.lblNumClases.Text = "Numero de clases:";
            // 
            // lblCondicones
            // 
            this.lblCondicones.AutoSize = true;
            this.lblCondicones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicones.Location = new System.Drawing.Point(307, 5);
            this.lblCondicones.Name = "lblCondicones";
            this.lblCondicones.Size = new System.Drawing.Size(208, 16);
            this.lblCondicones.TabIndex = 6;
            this.lblCondicones.Text = "Condiciones medicas restrictivas:";
            // 
            // txtNumClases
            // 
            this.txtNumClases.Enabled = false;
            this.txtNumClases.Location = new System.Drawing.Point(174, 47);
            this.txtNumClases.Name = "txtNumClases";
            this.txtNumClases.Size = new System.Drawing.Size(70, 20);
            this.txtNumClases.TabIndex = 8;
            this.txtNumClases.Text = "12";
            this.txtNumClases.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(377, 159);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 37);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(503, 159);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 37);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnMasCondiciones
            // 
            this.btnMasCondiciones.FlatAppearance.BorderSize = 0;
            this.btnMasCondiciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasCondiciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasCondiciones.Location = new System.Drawing.Point(539, 4);
            this.btnMasCondiciones.Name = "btnMasCondiciones";
            this.btnMasCondiciones.Size = new System.Drawing.Size(70, 20);
            this.btnMasCondiciones.TabIndex = 14;
            this.btnMasCondiciones.Text = "Agregar";
            this.btnMasCondiciones.UseVisualStyleBackColor = true;
            this.btnMasCondiciones.Click += new System.EventHandler(this.btnMasCondiciones_Click);
            // 
            // listBoxCondiciones
            // 
            this.listBoxCondiciones.FormattingEnabled = true;
            this.listBoxCondiciones.Items.AddRange(new object[] {
            "Condición 1",
            "Condición 2",
            "Condición 3"});
            this.listBoxCondiciones.Location = new System.Drawing.Point(336, 36);
            this.listBoxCondiciones.Name = "listBoxCondiciones";
            this.listBoxCondiciones.Size = new System.Drawing.Size(273, 108);
            this.listBoxCondiciones.TabIndex = 16;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.listBoxProfesores);
            this.pnlContainer.Controls.Add(this.listBoxCondiciones);
            this.pnlContainer.Controls.Add(this.lblSede);
            this.pnlContainer.Controls.Add(this.lblNumClases);
            this.pnlContainer.Controls.Add(this.btnMasCondiciones);
            this.pnlContainer.Controls.Add(this.lblProfesores);
            this.pnlContainer.Controls.Add(this.btnMasProfes);
            this.pnlContainer.Controls.Add(this.lblCondicones);
            this.pnlContainer.Controls.Add(this.btnGuardar);
            this.pnlContainer.Controls.Add(this.txtSede);
            this.pnlContainer.Controls.Add(this.btnModificar);
            this.pnlContainer.Controls.Add(this.txtNumClases);
            this.pnlContainer.Location = new System.Drawing.Point(104, 205);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(614, 211);
            this.pnlContainer.TabIndex = 17;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(476, 432);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(237, 37);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMasProfes
            // 
            this.btnMasProfes.FlatAppearance.BorderSize = 0;
            this.btnMasProfes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasProfes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasProfes.Location = new System.Drawing.Point(174, 96);
            this.btnMasProfes.Name = "btnMasProfes";
            this.btnMasProfes.Size = new System.Drawing.Size(70, 20);
            this.btnMasProfes.TabIndex = 13;
            this.btnMasProfes.Text = "Agregar";
            this.btnMasProfes.UseVisualStyleBackColor = true;
            this.btnMasProfes.Click += new System.EventHandler(this.btnMasProfes_Click);
            // 
            // lblProfesores
            // 
            this.lblProfesores.AutoSize = true;
            this.lblProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesores.Location = new System.Drawing.Point(3, 97);
            this.lblProfesores.Name = "lblProfesores";
            this.lblProfesores.Size = new System.Drawing.Size(77, 16);
            this.lblProfesores.TabIndex = 5;
            this.lblProfesores.Text = "Profesores:";
            // 
            // listBoxProfesores
            // 
            this.listBoxProfesores.FormattingEnabled = true;
            this.listBoxProfesores.Items.AddRange(new object[] {
            "Freddy Paz"});
            this.listBoxProfesores.Location = new System.Drawing.Point(77, 127);
            this.listBoxProfesores.Name = "listBoxProfesores";
            this.listBoxProfesores.Size = new System.Drawing.Size(167, 69);
            this.listBoxProfesores.TabIndex = 15;
            // 
            // txtSede
            // 
            this.txtSede.Enabled = false;
            this.txtSede.HideSelection = false;
            this.txtSede.Location = new System.Drawing.Point(77, 3);
            this.txtSede.Name = "txtSede";
            this.txtSede.Size = new System.Drawing.Size(167, 20);
            this.txtSede.TabIndex = 7;
            this.txtSede.Text = "Sede 1";
            this.txtSede.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSede
            // 
            this.lblSede.AutoSize = true;
            this.lblSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSede.Location = new System.Drawing.Point(3, 5);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(44, 16);
            this.lblSede.TabIndex = 3;
            this.lblSede.Text = "Sede:";
            // 
            // frmInfoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 501);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblDescripcionCurso);
            this.Controls.Add(this.lblNombreCurso);
            this.Name = "frmInfoCurso";
            this.Text = "frmInfoCurso";
            this.Load += new System.EventHandler(this.frmInfoCurso_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblDescripcionCurso;
        private System.Windows.Forms.Label lblNumClases;
        private System.Windows.Forms.Label lblCondicones;
        private System.Windows.Forms.TextBox txtNumClases;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMasCondiciones;
        private System.Windows.Forms.ListBox listBoxCondiciones;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox listBoxProfesores;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Label lblProfesores;
        private System.Windows.Forms.Button btnMasProfes;
        private System.Windows.Forms.TextBox txtSede;
    }
}
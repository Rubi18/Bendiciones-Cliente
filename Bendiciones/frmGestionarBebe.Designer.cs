﻿namespace Bendiciones
{
    partial class frmGestionarBebe
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.cboRelacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDNIBebe = new System.Windows.Forms.TextBox();
            this.lblDNIBebe = new System.Windows.Forms.Label();
            this.udNumHermanos = new System.Windows.Forms.NumericUpDown();
            this.lblNumHermanos = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.pnlCtn = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCondiciones = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumHermanos)).BeginInit();
            this.pnlCtn.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(300, 378);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 20);
            this.btnModificar.TabIndex = 64;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(584, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 20);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(138, 378);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 20);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.cboRelacion);
            this.gbDatosGenerales.Controls.Add(this.label1);
            this.gbDatosGenerales.Controls.Add(this.lblSexo);
            this.gbDatosGenerales.Controls.Add(this.rbMasculino);
            this.gbDatosGenerales.Controls.Add(this.rbFemenino);
            this.gbDatosGenerales.Controls.Add(this.txtNombre);
            this.gbDatosGenerales.Controls.Add(this.lblNombre);
            this.gbDatosGenerales.Controls.Add(this.txtDNIBebe);
            this.gbDatosGenerales.Controls.Add(this.lblDNIBebe);
            this.gbDatosGenerales.Controls.Add(this.udNumHermanos);
            this.gbDatosGenerales.Controls.Add(this.lblNumHermanos);
            this.gbDatosGenerales.Controls.Add(this.dtpFechaNac);
            this.gbDatosGenerales.Controls.Add(this.lblFechaNac);
            this.gbDatosGenerales.Location = new System.Drawing.Point(3, 3);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(412, 232);
            this.gbDatosGenerales.TabIndex = 61;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales";
            // 
            // cboRelacion
            // 
            this.cboRelacion.FormattingEnabled = true;
            this.cboRelacion.Items.AddRange(new object[] {
            "Papá",
            "Mamá",
            "Tío/Tía",
            "Hermano/Hermana",
            "Otro"});
            this.cboRelacion.Location = new System.Drawing.Point(194, 112);
            this.cboRelacion.Name = "cboRelacion";
            this.cboRelacion.Size = new System.Drawing.Size(196, 21);
            this.cboRelacion.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Relación";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(19, 189);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 42;
            this.lblSexo.Text = "Sexo:";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(194, 185);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 40;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(275, 185);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 41;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(193, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 20);
            this.txtNombre.TabIndex = 39;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 38;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDNIBebe
            // 
            this.txtDNIBebe.Location = new System.Drawing.Point(193, 19);
            this.txtDNIBebe.Name = "txtDNIBebe";
            this.txtDNIBebe.Size = new System.Drawing.Size(197, 20);
            this.txtDNIBebe.TabIndex = 37;
            // 
            // lblDNIBebe
            // 
            this.lblDNIBebe.AutoSize = true;
            this.lblDNIBebe.Location = new System.Drawing.Point(19, 27);
            this.lblDNIBebe.Name = "lblDNIBebe";
            this.lblDNIBebe.Size = new System.Drawing.Size(26, 13);
            this.lblDNIBebe.TabIndex = 36;
            this.lblDNIBebe.Text = "DNI";
            // 
            // udNumHermanos
            // 
            this.udNumHermanos.Location = new System.Drawing.Point(193, 148);
            this.udNumHermanos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.udNumHermanos.Name = "udNumHermanos";
            this.udNumHermanos.Size = new System.Drawing.Size(120, 20);
            this.udNumHermanos.TabIndex = 35;
            // 
            // lblNumHermanos
            // 
            this.lblNumHermanos.AutoSize = true;
            this.lblNumHermanos.Location = new System.Drawing.Point(19, 148);
            this.lblNumHermanos.Name = "lblNumHermanos";
            this.lblNumHermanos.Size = new System.Drawing.Size(108, 13);
            this.lblNumHermanos.TabIndex = 34;
            this.lblNumHermanos.Text = "Número de hermanos";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(193, 81);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(197, 20);
            this.dtpFechaNac.TabIndex = 29;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(19, 81);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNac.TabIndex = 28;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // pnlCtn
            // 
            this.pnlCtn.Controls.Add(this.groupBox2);
            this.pnlCtn.Controls.Add(this.groupBox1);
            this.pnlCtn.Controls.Add(this.gbDatosGenerales);
            this.pnlCtn.Location = new System.Drawing.Point(78, 77);
            this.pnlCtn.Name = "pnlCtn";
            this.pnlCtn.Size = new System.Drawing.Size(664, 238);
            this.pnlCtn.TabIndex = 66;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Location = new System.Drawing.Point(421, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 86);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(21, 20);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(197, 60);
            this.txtObservaciones.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCondiciones);
            this.groupBox1.Location = new System.Drawing.Point(421, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 133);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condiciones Médicas";
            // 
            // dgvCondiciones
            // 
            this.dgvCondiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Sel});
            this.dgvCondiciones.Location = new System.Drawing.Point(6, 19);
            this.dgvCondiciones.Name = "dgvCondiciones";
            this.dgvCondiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCondiciones.Size = new System.Drawing.Size(225, 108);
            this.dgvCondiciones.TabIndex = 0;
            this.dgvCondiciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCondiciones_CellFormatting);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Sel
            // 
            this.Sel.HeaderText = "Sel";
            this.Sel.Name = "Sel";
            this.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sel.Width = 30;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(26, 378);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 20);
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(399, 378);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(136, 20);
            this.btnNuevo.TabIndex = 68;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // frmGestionarBebe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pnlCtn);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmGestionarBebe";
            this.Text = "frmGestionarBebe";
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumHermanos)).EndInit();
            this.pnlCtn.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.Label lblNumHermanos;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblDNIBebe;
        private System.Windows.Forms.NumericUpDown udNumHermanos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDNIBebe;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.Panel pnlCtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cboRelacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DataGridView dgvCondiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
    }
}
namespace Bendiciones
{
    partial class frmAsistenciaColaborador
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
			this.pnlCtn = new System.Windows.Forms.Panel();
			this.cboCursos = new System.Windows.Forms.ComboBox();
			this.lblCurso = new System.Windows.Forms.Label();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.lblHoraFin = new System.Windows.Forms.Label();
			this.lblHoraIni = new System.Windows.Forms.Label();
			this.cboHoraFin = new System.Windows.Forms.ComboBox();
			this.cboHoraIni = new System.Windows.Forms.ComboBox();
			this.tabAsistencia = new System.Windows.Forms.TabControl();
			this.tpPorAsistir = new System.Windows.Forms.TabPage();
			this.dgvPorAsistir = new System.Windows.Forms.DataGridView();
			this.tpYaAsistieron = new System.Windows.Forms.TabPage();
			this.dgvYaAsistieron = new System.Windows.Forms.DataGridView();
			this.txtDni = new System.Windows.Forms.TextBox();
			this.lblDni = new System.Windows.Forms.Label();
			this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoraIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlCtn.SuspendLayout();
			this.tabAsistencia.SuspendLayout();
			this.tpPorAsistir.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPorAsistir)).BeginInit();
			this.tpYaAsistieron.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvYaAsistieron)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlCtn
			// 
			this.pnlCtn.Controls.Add(this.cboCursos);
			this.pnlCtn.Controls.Add(this.lblCurso);
			this.pnlCtn.Controls.Add(this.btnRegistrar);
			this.pnlCtn.Controls.Add(this.lblHoraFin);
			this.pnlCtn.Controls.Add(this.lblHoraIni);
			this.pnlCtn.Controls.Add(this.cboHoraFin);
			this.pnlCtn.Controls.Add(this.cboHoraIni);
			this.pnlCtn.Controls.Add(this.tabAsistencia);
			this.pnlCtn.Controls.Add(this.txtDni);
			this.pnlCtn.Controls.Add(this.lblDni);
			this.pnlCtn.Location = new System.Drawing.Point(57, 15);
			this.pnlCtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnlCtn.Name = "pnlCtn";
			this.pnlCtn.Size = new System.Drawing.Size(825, 447);
			this.pnlCtn.TabIndex = 26;
			// 
			// cboCursos
			// 
			this.cboCursos.FormattingEnabled = true;
			this.cboCursos.Location = new System.Drawing.Point(99, 123);
			this.cboCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboCursos.Name = "cboCursos";
			this.cboCursos.Size = new System.Drawing.Size(532, 24);
			this.cboCursos.TabIndex = 17;
			// 
			// lblCurso
			// 
			this.lblCurso.AutoSize = true;
			this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurso.Location = new System.Drawing.Point(4, 118);
			this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCurso.Name = "lblCurso";
			this.lblCurso.Size = new System.Drawing.Size(83, 29);
			this.lblCurso.TabIndex = 16;
			this.lblCurso.Text = "Curso:";
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Location = new System.Drawing.Point(333, 0);
			this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(161, 28);
			this.btnRegistrar.TabIndex = 15;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// lblHoraFin
			// 
			this.lblHoraFin.AutoSize = true;
			this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHoraFin.Location = new System.Drawing.Point(333, 69);
			this.lblHoraFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHoraFin.Name = "lblHoraFin";
			this.lblHoraFin.Size = new System.Drawing.Size(111, 29);
			this.lblHoraFin.TabIndex = 14;
			this.lblHoraFin.Text = "Hora Fin:";
			// 
			// lblHoraIni
			// 
			this.lblHoraIni.AutoSize = true;
			this.lblHoraIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHoraIni.Location = new System.Drawing.Point(4, 69);
			this.lblHoraIni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHoraIni.Name = "lblHoraIni";
			this.lblHoraIni.Size = new System.Drawing.Size(134, 29);
			this.lblHoraIni.TabIndex = 13;
			this.lblHoraIni.Text = "Hora Inicio:";
			// 
			// cboHoraFin
			// 
			this.cboHoraFin.FormattingEnabled = true;
			this.cboHoraFin.Location = new System.Drawing.Point(459, 74);
			this.cboHoraFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboHoraFin.Name = "cboHoraFin";
			this.cboHoraFin.Size = new System.Drawing.Size(172, 24);
			this.cboHoraFin.TabIndex = 12;
			// 
			// cboHoraIni
			// 
			this.cboHoraIni.FormattingEnabled = true;
			this.cboHoraIni.Location = new System.Drawing.Point(152, 74);
			this.cboHoraIni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboHoraIni.Name = "cboHoraIni";
			this.cboHoraIni.Size = new System.Drawing.Size(172, 24);
			this.cboHoraIni.TabIndex = 11;
			// 
			// tabAsistencia
			// 
			this.tabAsistencia.Controls.Add(this.tpPorAsistir);
			this.tabAsistencia.Controls.Add(this.tpYaAsistieron);
			this.tabAsistencia.Location = new System.Drawing.Point(9, 165);
			this.tabAsistencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabAsistencia.Name = "tabAsistencia";
			this.tabAsistencia.SelectedIndex = 0;
			this.tabAsistencia.Size = new System.Drawing.Size(787, 276);
			this.tabAsistencia.TabIndex = 9;
			// 
			// tpPorAsistir
			// 
			this.tpPorAsistir.Controls.Add(this.dgvPorAsistir);
			this.tpPorAsistir.Location = new System.Drawing.Point(4, 25);
			this.tpPorAsistir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tpPorAsistir.Name = "tpPorAsistir";
			this.tpPorAsistir.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tpPorAsistir.Size = new System.Drawing.Size(779, 247);
			this.tpPorAsistir.TabIndex = 0;
			this.tpPorAsistir.Text = "Por Asistir";
			this.tpPorAsistir.UseVisualStyleBackColor = true;
			// 
			// dgvPorAsistir
			// 
			this.dgvPorAsistir.AllowUserToAddRows = false;
			this.dgvPorAsistir.AllowUserToDeleteRows = false;
			this.dgvPorAsistir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPorAsistir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre,
            this.Curso,
            this.HoraIni,
            this.HoraFin});
			this.dgvPorAsistir.Location = new System.Drawing.Point(4, 20);
			this.dgvPorAsistir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvPorAsistir.Name = "dgvPorAsistir";
			this.dgvPorAsistir.ReadOnly = true;
			this.dgvPorAsistir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPorAsistir.Size = new System.Drawing.Size(764, 185);
			this.dgvPorAsistir.TabIndex = 0;
			// 
			// tpYaAsistieron
			// 
			this.tpYaAsistieron.Controls.Add(this.dgvYaAsistieron);
			this.tpYaAsistieron.Location = new System.Drawing.Point(4, 25);
			this.tpYaAsistieron.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tpYaAsistieron.Name = "tpYaAsistieron";
			this.tpYaAsistieron.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tpYaAsistieron.Size = new System.Drawing.Size(779, 247);
			this.tpYaAsistieron.TabIndex = 1;
			this.tpYaAsistieron.Text = "Ya asistieron";
			this.tpYaAsistieron.UseVisualStyleBackColor = true;
			// 
			// dgvYaAsistieron
			// 
			this.dgvYaAsistieron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvYaAsistieron.Location = new System.Drawing.Point(7, 30);
			this.dgvYaAsistieron.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvYaAsistieron.Name = "dgvYaAsistieron";
			this.dgvYaAsistieron.Size = new System.Drawing.Size(764, 185);
			this.dgvYaAsistieron.TabIndex = 1;
			// 
			// txtDni
			// 
			this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDni.Location = new System.Drawing.Point(73, 18);
			this.txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(251, 30);
			this.txtDni.TabIndex = 8;
			// 
			// lblDni
			// 
			this.lblDni.AutoSize = true;
			this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDni.Location = new System.Drawing.Point(4, 20);
			this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDni.Name = "lblDni";
			this.lblDni.Size = new System.Drawing.Size(60, 29);
			this.lblDni.TabIndex = 7;
			this.lblDni.Text = "DNI:";
			// 
			// DNI
			// 
			this.DNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DNI.HeaderText = "DNI";
			this.DNI.Name = "DNI";
			this.DNI.ReadOnly = true;
			// 
			// Nombre
			// 
			this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Curso
			// 
			this.Curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Curso.HeaderText = "Curso";
			this.Curso.Name = "Curso";
			this.Curso.ReadOnly = true;
			// 
			// HoraIni
			// 
			this.HoraIni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.HoraIni.HeaderText = "Hora inicio";
			this.HoraIni.Name = "HoraIni";
			this.HoraIni.ReadOnly = true;
			// 
			// HoraFin
			// 
			this.HoraFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.HoraFin.HeaderText = "Hora fin";
			this.HoraFin.Name = "HoraFin";
			this.HoraFin.ReadOnly = true;
			// 
			// frmAsistenciaColaborador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.pnlCtn);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmAsistenciaColaborador";
			this.Text = "frmAsistenciaColaborador";
			this.pnlCtn.ResumeLayout(false);
			this.pnlCtn.PerformLayout();
			this.tabAsistencia.ResumeLayout(false);
			this.tpPorAsistir.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvPorAsistir)).EndInit();
			this.tpYaAsistieron.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvYaAsistieron)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCtn;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label lblHoraIni;
        private System.Windows.Forms.ComboBox cboHoraFin;
        private System.Windows.Forms.ComboBox cboHoraIni;
        private System.Windows.Forms.TabControl tabAsistencia;
        private System.Windows.Forms.TabPage tpPorAsistir;
        private System.Windows.Forms.DataGridView dgvPorAsistir;
        private System.Windows.Forms.TabPage tpYaAsistieron;
        private System.Windows.Forms.DataGridView dgvYaAsistieron;
        private System.Windows.Forms.ComboBox cboCursos;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoraIni;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
	}
}
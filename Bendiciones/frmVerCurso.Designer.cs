namespace Bendiciones
{
    partial class frmVerCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerCurso));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Profesor 1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Profesor 2");
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblDescripcionCurso = new System.Windows.Forms.Label();
            this.btnMasInfo = new System.Windows.Forms.Button();
            this.tabCurso = new System.Windows.Forms.TabControl();
            this.tabPageHorarios = new System.Windows.Forms.TabPage();
            this.btnRegistrarHorario = new System.Windows.Forms.Button();
            this.dgHorarios = new System.Windows.Forms.DataGridView();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.tabPageProfesores = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblProfesores = new System.Windows.Forms.Label();
            this.Clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCurso.SuspendLayout();
            this.tabPageHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorarios)).BeginInit();
            this.tabPageProfesores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCurso.Location = new System.Drawing.Point(63, 29);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(142, 22);
            this.lblNombreCurso.TabIndex = 0;
            this.lblNombreCurso.Text = "Nombre Curso";
            // 
            // lblDescripcionCurso
            // 
            this.lblDescripcionCurso.AutoSize = true;
            this.lblDescripcionCurso.Location = new System.Drawing.Point(88, 80);
            this.lblDescripcionCurso.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblDescripcionCurso.Name = "lblDescripcionCurso";
            this.lblDescripcionCurso.Size = new System.Drawing.Size(199, 208);
            this.lblDescripcionCurso.TabIndex = 1;
            this.lblDescripcionCurso.Text = resources.GetString("lblDescripcionCurso.Text");
            // 
            // btnMasInfo
            // 
            this.btnMasInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasInfo.Location = new System.Drawing.Point(122, 331);
            this.btnMasInfo.Name = "btnMasInfo";
            this.btnMasInfo.Size = new System.Drawing.Size(124, 23);
            this.btnMasInfo.TabIndex = 2;
            this.btnMasInfo.Text = "Más información";
            this.btnMasInfo.UseVisualStyleBackColor = true;
            this.btnMasInfo.Click += new System.EventHandler(this.btnMasInfo_Click);
            // 
            // tabCurso
            // 
            this.tabCurso.Controls.Add(this.tabPageHorarios);
            this.tabCurso.Controls.Add(this.tabPageProfesores);
            this.tabCurso.Location = new System.Drawing.Point(303, 80);
            this.tabCurso.Name = "tabCurso";
            this.tabCurso.SelectedIndex = 0;
            this.tabCurso.Size = new System.Drawing.Size(485, 313);
            this.tabCurso.TabIndex = 5;
            // 
            // tabPageHorarios
            // 
            this.tabPageHorarios.Controls.Add(this.btnRegistrarHorario);
            this.tabPageHorarios.Controls.Add(this.dgHorarios);
            this.tabPageHorarios.Controls.Add(this.lblHorarios);
            this.tabPageHorarios.Location = new System.Drawing.Point(4, 22);
            this.tabPageHorarios.Name = "tabPageHorarios";
            this.tabPageHorarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHorarios.Size = new System.Drawing.Size(477, 287);
            this.tabPageHorarios.TabIndex = 0;
            this.tabPageHorarios.Text = "Horarios";
            this.tabPageHorarios.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarHorario
            // 
            this.btnRegistrarHorario.FlatAppearance.BorderSize = 0;
            this.btnRegistrarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarHorario.Location = new System.Drawing.Point(303, 234);
            this.btnRegistrarHorario.Name = "btnRegistrarHorario";
            this.btnRegistrarHorario.Size = new System.Drawing.Size(154, 34);
            this.btnRegistrarHorario.TabIndex = 12;
            this.btnRegistrarHorario.Text = "Registrar horario";
            this.btnRegistrarHorario.UseVisualStyleBackColor = true;
            this.btnRegistrarHorario.Click += new System.EventHandler(this.btnRegistrarHorario_Click_1);
            // 
            // dgHorarios
            // 
            this.dgHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clase,
            this.Sede,
            this.Dia,
            this.Hora,
            this.Profesor});
            this.dgHorarios.Location = new System.Drawing.Point(20, 55);
            this.dgHorarios.Name = "dgHorarios";
            this.dgHorarios.ReadOnly = true;
            this.dgHorarios.Size = new System.Drawing.Size(447, 161);
            this.dgHorarios.TabIndex = 11;
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarios.Location = new System.Drawing.Point(20, 20);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(69, 20);
            this.lblHorarios.TabIndex = 10;
            this.lblHorarios.Text = "Horarios";
            // 
            // tabPageProfesores
            // 
            this.tabPageProfesores.Controls.Add(this.listView1);
            this.tabPageProfesores.Controls.Add(this.lblProfesores);
            this.tabPageProfesores.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfesores.Name = "tabPageProfesores";
            this.tabPageProfesores.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfesores.Size = new System.Drawing.Size(477, 287);
            this.tabPageProfesores.TabIndex = 1;
            this.tabPageProfesores.Text = "Profesores";
            this.tabPageProfesores.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(55, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(377, 170);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblProfesores
            // 
            this.lblProfesores.AutoSize = true;
            this.lblProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesores.Location = new System.Drawing.Point(20, 20);
            this.lblProfesores.Name = "lblProfesores";
            this.lblProfesores.Size = new System.Drawing.Size(86, 20);
            this.lblProfesores.TabIndex = 16;
            this.lblProfesores.Text = "Profesores";
            this.lblProfesores.Click += new System.EventHandler(this.lblProfesores_Click);
            // 
            // Clase
            // 
            this.Clase.HeaderText = "Clase";
            this.Clase.Name = "Clase";
            this.Clase.ReadOnly = true;
            // 
            // Sede
            // 
            this.Sede.HeaderText = "Sede";
            this.Sede.Name = "Sede";
            this.Sede.ReadOnly = true;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Día";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            this.Dia.Width = 80;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 80;
            // 
            // Profesor
            // 
            this.Profesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.Name = "Profesor";
            this.Profesor.ReadOnly = true;
            // 
            // frmVerCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCurso);
            this.Controls.Add(this.btnMasInfo);
            this.Controls.Add(this.lblDescripcionCurso);
            this.Controls.Add(this.lblNombreCurso);
            this.Name = "frmVerCurso";
            this.Text = "frmVerCurso";
            this.tabCurso.ResumeLayout(false);
            this.tabPageHorarios.ResumeLayout(false);
            this.tabPageHorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorarios)).EndInit();
            this.tabPageProfesores.ResumeLayout(false);
            this.tabPageProfesores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblDescripcionCurso;
        private System.Windows.Forms.Button btnMasInfo;
        private System.Windows.Forms.TabControl tabCurso;
        private System.Windows.Forms.TabPage tabPageHorarios;
        private System.Windows.Forms.TabPage tabPageProfesores;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblProfesores;
        private System.Windows.Forms.Button btnRegistrarHorario;
        private System.Windows.Forms.DataGridView dgHorarios;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
    }
}
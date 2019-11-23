namespace Bendiciones
{
    partial class ___frmAsistencia
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
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.pnlContainerAsistCliente = new System.Windows.Forms.Panel();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegCliente = new System.Windows.Forms.Button();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDniCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContainerAsistProfesor = new System.Windows.Forms.Panel();
            this.btnBuscarDocente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNombreDocente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegDocente = new System.Windows.Forms.Button();
            this.txbDniDocente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlOut = new System.Windows.Forms.Panel();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlContainerAsistCliente.SuspendLayout();
            this.pnlContainerAsistProfesor.SuspendLayout();
            this.pnlOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.Location = new System.Drawing.Point(40, 40);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(205, 22);
            this.lblAsistencia.TabIndex = 23;
            this.lblAsistencia.Text = "Control de Asistencia";
            // 
            // pnlContainerAsistCliente
            // 
            this.pnlContainerAsistCliente.Controls.Add(this.btnBuscarAlumno);
            this.pnlContainerAsistCliente.Controls.Add(this.label8);
            this.pnlContainerAsistCliente.Controls.Add(this.label4);
            this.pnlContainerAsistCliente.Controls.Add(this.cmbCurso);
            this.pnlContainerAsistCliente.Controls.Add(this.btnRegCliente);
            this.pnlContainerAsistCliente.Controls.Add(this.lblNombreCliente);
            this.pnlContainerAsistCliente.Controls.Add(this.label2);
            this.pnlContainerAsistCliente.Controls.Add(this.txbDniCliente);
            this.pnlContainerAsistCliente.Controls.Add(this.label1);
            this.pnlContainerAsistCliente.Location = new System.Drawing.Point(4, 3);
            this.pnlContainerAsistCliente.Name = "pnlContainerAsistCliente";
            this.pnlContainerAsistCliente.Size = new System.Drawing.Size(350, 350);
            this.pnlContainerAsistCliente.TabIndex = 24;
            this.pnlContainerAsistCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainerAsistCliente_Paint);
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Location = new System.Drawing.Point(177, 115);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(123, 30);
            this.btnBuscarAlumno.TabIndex = 27;
            this.btnBuscarAlumno.Text = "Buscar Cliente";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Cliente";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnRegCliente
            // 
            this.btnRegCliente.Location = new System.Drawing.Point(94, 266);
            this.btnRegCliente.Name = "btnRegCliente";
            this.btnRegCliente.Size = new System.Drawing.Size(150, 40);
            this.btnRegCliente.TabIndex = 4;
            this.btnRegCliente.Text = "Registrar asistencia";
            this.btnRegCliente.UseVisualStyleBackColor = true;
            this.btnRegCliente.Click += new System.EventHandler(this.btnRegAlu_Click);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(114, 161);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(13, 13);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "- ";
            this.lblNombreCliente.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txbDniCliente
            // 
            this.txbDniCliente.Location = new System.Drawing.Point(117, 86);
            this.txbDniCliente.Name = "txbDniCliente";
            this.txbDniCliente.Size = new System.Drawing.Size(183, 20);
            this.txbDniCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlContainerAsistProfesor
            // 
            this.pnlContainerAsistProfesor.Controls.Add(this.btnBuscarDocente);
            this.pnlContainerAsistProfesor.Controls.Add(this.label9);
            this.pnlContainerAsistProfesor.Controls.Add(this.lblNombreDocente);
            this.pnlContainerAsistProfesor.Controls.Add(this.label6);
            this.pnlContainerAsistProfesor.Controls.Add(this.btnRegDocente);
            this.pnlContainerAsistProfesor.Controls.Add(this.txbDniDocente);
            this.pnlContainerAsistProfesor.Controls.Add(this.label7);
            this.pnlContainerAsistProfesor.Location = new System.Drawing.Point(373, 3);
            this.pnlContainerAsistProfesor.Name = "pnlContainerAsistProfesor";
            this.pnlContainerAsistProfesor.Size = new System.Drawing.Size(350, 350);
            this.pnlContainerAsistProfesor.TabIndex = 25;
            this.pnlContainerAsistProfesor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainerAsistProfesor_Paint);
            // 
            // btnBuscarDocente
            // 
            this.btnBuscarDocente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarDocente.Location = new System.Drawing.Point(184, 115);
            this.btnBuscarDocente.Name = "btnBuscarDocente";
            this.btnBuscarDocente.Size = new System.Drawing.Size(123, 30);
            this.btnBuscarDocente.TabIndex = 28;
            this.btnBuscarDocente.Text = "Buscar Docente";
            this.btnBuscarDocente.UseVisualStyleBackColor = true;
            this.btnBuscarDocente.Click += new System.EventHandler(this.btnBuscarDocente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Docente";
            // 
            // lblNombreDocente
            // 
            this.lblNombreDocente.AutoSize = true;
            this.lblNombreDocente.Location = new System.Drawing.Point(121, 161);
            this.lblNombreDocente.Name = "lblNombreDocente";
            this.lblNombreDocente.Size = new System.Drawing.Size(10, 13);
            this.lblNombreDocente.TabIndex = 10;
            this.lblNombreDocente.Text = "-";
            this.lblNombreDocente.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre:";
            // 
            // btnRegDocente
            // 
            this.btnRegDocente.Location = new System.Drawing.Point(105, 276);
            this.btnRegDocente.Name = "btnRegDocente";
            this.btnRegDocente.Size = new System.Drawing.Size(150, 40);
            this.btnRegDocente.TabIndex = 5;
            this.btnRegDocente.Text = "Registrar asistencia";
            this.btnRegDocente.UseVisualStyleBackColor = true;
            this.btnRegDocente.Click += new System.EventHandler(this.btnRegDocente_Click);
            // 
            // txbDniDocente
            // 
            this.txbDniDocente.Location = new System.Drawing.Point(124, 86);
            this.txbDniDocente.Name = "txbDniDocente";
            this.txbDniDocente.Size = new System.Drawing.Size(183, 20);
            this.txbDniDocente.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "DNI:";
            // 
            // pnlOut
            // 
            this.pnlOut.Controls.Add(this.pnlContainerAsistProfesor);
            this.pnlOut.Controls.Add(this.pnlContainerAsistCliente);
            this.pnlOut.Location = new System.Drawing.Point(44, 94);
            this.pnlOut.Name = "pnlOut";
            this.pnlOut.Size = new System.Drawing.Size(726, 357);
            this.pnlOut.TabIndex = 25;
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "Curso 1",
            "Curso 2",
            "Curso 3"});
            this.cmbCurso.Location = new System.Drawing.Point(117, 192);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(183, 21);
            this.cmbCurso.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Curso:";
            // 
            // frmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 501);
            this.Controls.Add(this.pnlOut);
            this.Controls.Add(this.lblAsistencia);
            this.Name = "frmAsistencia";
            this.Text = "Asistencia";
            this.pnlContainerAsistCliente.ResumeLayout(false);
            this.pnlContainerAsistCliente.PerformLayout();
            this.pnlContainerAsistProfesor.ResumeLayout(false);
            this.pnlContainerAsistProfesor.PerformLayout();
            this.pnlOut.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.Panel pnlContainerAsistCliente;
        private System.Windows.Forms.Panel pnlContainerAsistProfesor;
        private System.Windows.Forms.Panel pnlOut;
        private System.Windows.Forms.Button btnRegCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDniCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegDocente;
        private System.Windows.Forms.Label lblNombreDocente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDniDocente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.Button btnBuscarDocente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCurso;
    }
}
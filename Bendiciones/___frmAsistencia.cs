using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bendiciones
{
    public partial class ___frmAsistencia : Form
    {
        public ___frmAsistencia()
        {
            InitializeComponent();
            pnlOut.Location = new Point((this.Width-pnlOut.Width)/2,pnlOut.Top);

            Paleta paleta = new Paleta();
            this.BackColor = paleta.Blanco;
            pnlContainerAsistCliente.BackColor = paleta.GrisClaro;
            pnlContainerAsistProfesor.BackColor = paleta.GrisClaro;
            
            btnRegCliente.FlatStyle = FlatStyle.Flat;
            btnRegCliente.FlatAppearance.BorderSize = 0;
            btnRegCliente.BackColor = paleta.Naranja;
            btnRegCliente.ForeColor = paleta.Blanco;
            btnRegCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnRegCliente.Location = new Point((pnlContainerAsistCliente.Width - btnRegCliente.Width) / 2, btnRegCliente.Top);

            btnRegDocente.FlatStyle = FlatStyle.Flat;
            btnRegDocente.FlatAppearance.BorderSize = 0;
            btnRegDocente.BackColor = paleta.Naranja;
            btnRegDocente.ForeColor = paleta.Blanco;
            btnRegDocente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnRegDocente.Location = new Point((pnlContainerAsistProfesor.Width - btnRegDocente.Width) / 2, btnRegDocente.Top);

            btnBuscarAlumno.FlatStyle = FlatStyle.Flat;
            btnBuscarAlumno.FlatAppearance.BorderSize = 0;
            btnBuscarAlumno.BackColor = paleta.Lila;
            btnBuscarAlumno.ForeColor = paleta.Marron;
            btnBuscarAlumno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnBuscarDocente.FlatStyle = FlatStyle.Flat;
            btnBuscarDocente.FlatAppearance.BorderSize = 0;
            btnBuscarDocente.BackColor = paleta.Lila;
            btnBuscarDocente.ForeColor = paleta.Marron;
            btnBuscarDocente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void pnlContainerAsistProfesor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pnlContainerAsistCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegAlu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbDniCliente.Text))
            {
                frmMensaje msg = new frmMensaje();
                msg.ventanaMensaje("Ingresar DNI de cliente.");
            }
            else if (String.IsNullOrEmpty(cmbCurso.Text)) {
                frmMensaje msg = new frmMensaje();
                msg.ventanaMensaje("Seleccionar curso");

            } else {
                frmMensaje msg = new frmMensaje();
                msg.ventanaMensaje("Asistencia de alumno registrada.");
                txbDniCliente.Text = String.Empty;
                cmbCurso.Text = String.Empty;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbDniCliente.Text))
            {
                frmMensaje msg = new frmMensaje();
                msg.ventanaMensaje("Ingresar DNI de cliente.");
            } else {
                lblNombreCliente.Text = "Antony Palacios Coronado";
            }
        }

        private void btnBuscarDocente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbDniDocente.Text))
            {
                frmMensaje msg = new frmMensaje();
                msg.ventanaMensaje("Ingresar DNI de docente.");
            }
            else
            {
                lblNombreDocente.Text = "Freddy Paz";
            }
        }

        private void btnRegDocente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbDniDocente.Text))
            {
                frmMensaje msg = new frmMensaje();
                msg.ventanaMensaje("Ingresar DNI de docente.");
            }
            else {
                frmMensaje msg = new frmMensaje();
                msg.ventanaMensaje("Asistencia de docente registrada.");
                txbDniDocente.Text = String.Empty;
            }
        }
    }
}

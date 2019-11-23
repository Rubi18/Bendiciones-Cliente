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
    public partial class ___frmInfoCurso : Form
    {
        public ___frmInfoCurso()
        {
            InitializeComponent();
            Paleta paleta = new Paleta();
            this.BackColor = paleta.Blanco;

            Margenes mrg = new Margenes();
            lblNombreCurso.Location = new Point(mrg.MargenTituloForm, mrg.MargenTituloForm);
            lblNombreCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            lblDescripcionCurso.Location = new Point(mrg.MargenTituloForm + mrg.MargenPequeño, mrg.MargenTituloForm + lblNombreCurso.Height + mrg.MargenPequeño * 2);


            btnGuardar.BackColor = paleta.Lila;
            btnGuardar.ForeColor = paleta.Marron;
            btnGuardar.Height = 30;
            btnGuardar.Width = 100;
            btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //btnAceptar.Location = new Point(lblDescripcionCurso.Location.X + (lblDescripcionCurso.Width - btnMasInfo.Width) / 2, 380);

            btnModificar.BackColor = paleta.Lila;
            btnModificar.ForeColor = paleta.Marron;
            btnModificar.Height = 30;
            btnModificar.Width = 100;
            btnModificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //btnModificar.Location = new Point(lblDescripcionCurso.Location.X + (lblDescripcionCurso.Width - btnMasInfo.Width) / 2, 380);

            btnMasCondiciones.BackColor = paleta.Lila;
            btnMasCondiciones.ForeColor = paleta.Marron;
            btnMasProfes.BackColor = paleta.Lila;
            btnMasProfes.ForeColor = paleta.Marron;

            btnMasCondiciones.Visible = false;
            btnMasProfes.Visible = false;

            pnlContainer.Location = new Point((this.Width-pnlContainer.Width)/2,pnlContainer.Top);

            btnAceptar.BackColor = paleta.Naranja;
            btnAceptar.ForeColor = paleta.Blanco;
            btnAceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void lblProfeores_Click(object sender, EventArgs e)
        {

        }

        private void btnMasProfes_Click(object sender, EventArgs e)
        {
            frmBuscarDocente formBuscarProfesor = new frmBuscarDocente();
            formBuscarProfesor.Visible = true;
        }

        private void btnMasCondiciones_Click(object sender, EventArgs e)
        {
            frmBuscarCondicion formBuscarCondicion = new frmBuscarCondicion();
            formBuscarCondicion.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Enabled == false) {
                btnMasCondiciones.Visible = true;
                btnMasProfes.Visible = true;
                txtNumClases.Enabled = true;
                txtSede.Enabled = true;
                btnGuardar.Enabled = true;
                btnModificar.Text = "Cancelar";
            } else {
                btnMasCondiciones.Visible = false;
                btnMasProfes.Visible = false;
                txtNumClases.Enabled = false;
                txtSede.Enabled = false;
                btnGuardar.Enabled = false;
                btnModificar.Text = "Modificar";
            }
        }

        private void frmInfoCurso_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            btnMasCondiciones.Visible = false;
            btnMasProfes.Visible = false;
            txtNumClases.Enabled = false;
            txtSede.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Text = "Modificar";

            frmMensaje msg = new frmMensaje();
            msg.ventanaMensaje("Cambios registrados");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVerCurso formVerCurso = new frmVerCurso();
            formVerCurso.MdiParent = this.ParentForm;
            formVerCurso.FormBorderStyle = FormBorderStyle.None;
            formVerCurso.Dock = DockStyle.Fill;
            formVerCurso.Visible = true;
        }
    }
}

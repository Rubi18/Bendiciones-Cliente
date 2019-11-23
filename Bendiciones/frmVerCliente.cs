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
    public partial class frmVerCliente : Form
    {
        public frmVerCliente()
        {
            InitializeComponent();
            Paleta paleta = new Paleta();
            this.BackColor = paleta.Blanco;

            btnMasInfo.FlatStyle = FlatStyle.Flat;
            btnMasInfo.BackColor = paleta.Lila;
            btnMasInfo.ForeColor = paleta.Marron;
            btnMasInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnMatricular.FlatStyle = FlatStyle.Flat;
            btnMatricular.BackColor = paleta.Naranja;
            btnMatricular.ForeColor = paleta.Blanco;
            btnMatricular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnRegistrarPago.FlatStyle = FlatStyle.Flat;
            btnRegistrarPago.BackColor = paleta.Naranja;
            btnRegistrarPago.ForeColor = paleta.Blanco;
            btnRegistrarPago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmVerCliente_Load(object sender, EventArgs e)
        {

        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            frmGestionarCliente formInfoCliente = new frmGestionarCliente();
            formInfoCliente.MdiParent = this.ParentForm;
            formInfoCliente.FormBorderStyle = FormBorderStyle.None;
            formInfoCliente.Dock = DockStyle.Fill;
            formInfoCliente.Visible = true;
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {

		}
	}
}

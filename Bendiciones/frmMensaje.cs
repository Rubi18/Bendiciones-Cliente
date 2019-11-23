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
    public partial class frmMensaje : Form
    {
        public frmMensaje()
        {
            InitializeComponent();
            Paleta paleta = new Paleta();

            this.BackColor = paleta.Amarillo;
            btnOk.ForeColor = paleta.Blanco;
            btnOk.BackColor = paleta.Naranja;
        }

        public void ventanaMensaje(String mensaje) {
            lblMsg.Text = mensaje;
            lblMsg.Left = (this.Width - lblMsg.Width) / 2;
            this.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}

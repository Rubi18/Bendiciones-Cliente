using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bendiciones.Service;

namespace Bendiciones
{
    public partial class frmGestionarGestacion : Form
    {
        private Service.gestacion gestacion;
        public frmGestionarGestacion()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Gestionar bebé", pnlCtn, btnNuevo, btnBuscar, btnGuardar, btnModificar, btnCancelar, true);
        }
        public frmGestionarGestacion(Service.gestacion gestacion)
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Gestionar bebé", pnlCtn, btnNuevo, btnBuscar, btnGuardar, btnModificar, btnCancelar, true);
        }

        public gestacion Gestacion { get => gestacion; set => gestacion = value; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            gestacion = new gestacion();
            gestacion.clinica = txtClinica.Text;
            gestacion.fecha_probable_parto = dtpFPP.Value;
            gestacion.fecha_probable_partoSpecified = true;
            gestacion.medico = txtMedico.Text;
            //número de embarazo debería contar solo
            gestacion.numEmbar = Int32.Parse(txtNumEmbarazo.Text);

            this.DialogResult = DialogResult.OK;
        }
    }
}

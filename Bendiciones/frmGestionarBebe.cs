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
    public partial class frmGestionarBebe : Form
    {
        private Service.bebe bebeSeleccionado = new Service.bebe();
        public frmGestionarBebe()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Gestionar Bebe", pnlCtn,btnNuevo,btnBuscar, btnGuardar, btnModificar, btnCancelar,true);
            btnBuscar.Visible = false;
            btnNuevo.Visible = false;
            dgvCondiciones.AutoGenerateColumns = false;
            dgvCondiciones.DataSource = Program.dbController.listarCondMedicasPorNombre("");
        }

        public frmGestionarBebe(Service.bebe bebe)
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Gestionar Bebe", pnlCtn, btnNuevo, btnBuscar, btnGuardar, btnModificar, btnCancelar, true);
            btnBuscar.Visible = false;
            btnNuevo.Visible = false;
            dgvCondiciones.AutoGenerateColumns = false;
            dgvCondiciones.DataSource = Program.dbController.listarCondMedicasPorNombre("");
            txtDNIBebe.Text = bebe.dni;
            txtNombre.Text = bebe.nombre;
            dtpFechaNac.Value = bebe.fechaNaci;
            cboRelacion.SelectedText = bebe.relacion;
            udNumHermanos.Value = bebe.numHerman;
            if (bebe.sexo == 'F')
                rbFemenino.Checked = true;
            else
                rbMasculino.Checked = true;
            txtObservaciones.Text = bebe.observMedicas;
            dgvCondiciones.DataSource = bebe.condMedicas;
            for (int i = 0; i < dgvCondiciones.RowCount; i++)
                dgvCondiciones.Rows[i].Cells[1].Value = true;

        }

        public bebe BebeSeleccionado { get => bebeSeleccionado; set => bebeSeleccionado = value; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Datos generales
            bebeSeleccionado.dni = txtDNIBebe.Text;
            bebeSeleccionado.fechaNaci = dtpFechaNac.Value;
            bebeSeleccionado.fechaNaciSpecified = true;
            bebeSeleccionado.nombre = txtNombre.Text;
            if (rbFemenino.Checked == true)
                bebeSeleccionado.sexo = 'F';
            else
                bebeSeleccionado.sexo = 'M';
            bebeSeleccionado.numHerman = (int)udNumHermanos.Value;
            bebeSeleccionado.observMedicas = txtObservaciones.Text;
            bebeSeleccionado.relacion = (String)cboRelacion.SelectedItem;

            //condiciones medicas

            List<Service.condicionMedica> condicionMedicas = new List<Service.condicionMedica>();
            for (int i = 0; i < dgvCondiciones.Rows.Count; i++)
            {
                if (dgvCondiciones.Rows[i].Cells[1].Value == null)
                { }
                else if ((bool)dgvCondiciones.Rows[i].Cells[1].Value == true)
                {
                    Service.condicionMedica cond = new Service.condicionMedica();
                    cond = (Service.condicionMedica)dgvCondiciones.Rows[i].DataBoundItem;
                    condicionMedicas.Add(cond);
                }
            }

            bebeSeleccionado.condMedicas = condicionMedicas.ToArray();

            

            this.DialogResult = DialogResult.OK;
        }

        private void dgvCondiciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.condicionMedica conFila = (Service.condicionMedica)dgvCondiciones.Rows[e.RowIndex].DataBoundItem;
            if (conFila != null)
                dgvCondiciones.Rows[e.RowIndex].Cells["Nombre"].Value = conFila.nombre;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dgvCondiciones.DataSource = Program.dbController.listarCondMedicasPorNombre("");
            foreach (Service.condicionMedica con in bebeSeleccionado.condMedicas)
            {
                for (int i = 0; i < dgvCondiciones.RowCount; i++)
                {
                    if (con.nombre.Equals(((Service.condicionMedica)dgvCondiciones.Rows[i].DataBoundItem).nombre))
                    {
                        dgvCondiciones.Rows[i].Cells[1].Value = true;
                        i = dgvCondiciones.RowCount;
                    }
                }
            }
        }
    }
}

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
    public partial class frmGestionarHorario : Form
    {
        private Service.horario horarioSeleccionado;
        private Service.colaborador docente = null;
        public frmGestionarHorario()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.formGestionarHorario(this,"Gestionar Horario",pnlCtn,btnGuardar,btnModificar,btnCancelar);
            cboSede.DataSource = Program.dbController.listarSedes();
            cboSede.DisplayMember = "direccion";
            
        }

        public frmGestionarHorario(Service.horario h)
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.formGestionarHorario(this, "Gestionar Horario", pnlCtn, btnGuardar, btnModificar, btnCancelar);
            cboSede.DataSource = Program.dbController.listarSedes();
            cboSede.DisplayMember = "direccion";

            //llena los datos
            cboSede.SelectedItem = h.sede;
            dtpFechaMatricula.Value = h.fecha;
            cboHoraFin.SelectedItem = (String)h.horaIni.ToShortTimeString();
            cboHoraIni.SelectedItem = (String)h.horaFin.ToShortTimeString();
            txtNumClase.Text = h.clase.ToString();
            txtNumVac.Text = h.numVacantes.ToString(); 

            //docente nulo
            if (h.colaborador != null)
            {
                txtDNIDocente.Text = h.colaborador.dni;
                txtNombreDocente.Text = h.colaborador.nombre;
            }
        }

        public horario HorarioSeleccionado { get => horarioSeleccionado; set => horarioSeleccionado = value; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            horarioSeleccionado = new Service.horario();
            horarioSeleccionado.fecha = dtpFechaMatricula.Value;
            horarioSeleccionado.fechaSpecified = true;
            horarioSeleccionado.horaIni = DateTime.Now;
            horarioSeleccionado.horaFinSpecified = true;
            horarioSeleccionado.horaIniSpecified = true;
            horarioSeleccionado.horaFin = DateTime.Now;
            horarioSeleccionado.clase = Int32.Parse(txtNumClase.Text);
            horarioSeleccionado.numVacantes = Int32.Parse(txtNumVac.Text);
            horarioSeleccionado.sede = (Service.sede)cboSede.SelectedItem;
            //si hay docente
            if(docente != null)
            {
                horarioSeleccionado.colaborador = docente;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscarDocente_Click(object sender, EventArgs e)
        {
            frmBuscarDocente formBuscarDocente = new frmBuscarDocente();
            if(formBuscarDocente.ShowDialog() == DialogResult.OK)
            {
                docente = formBuscarDocente.DocenteSeleccionado;
                txtDNIDocente.Text = docente.dni;
                txtNombreDocente.Text = docente.nombre;
            }
        }
    }
}

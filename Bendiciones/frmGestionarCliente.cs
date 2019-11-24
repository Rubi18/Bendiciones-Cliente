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
	public partial class frmGestionarCliente : Form
	{
		private Service.cliente cliente;
		private Service.apoderado apoderado;
		private Service.gestante gestante;
		private Service.gestacion gestacion;
		private Service.contactoEmergencia contacto;
		private BindingList<Service.contactoEmergencia> contactos = new BindingList<Service.contactoEmergencia>();
		private BindingList<Service.bebe> bebes = new BindingList<Service.bebe>();
		private BindingList<Service.gestacion> gestaciones = new BindingList<Service.gestacion>();
		private BindingList<Service.condicionMedica> condiciones = new BindingList<Service.condicionMedica>();

		Estado estadoObjCliente;
		public frmGestionarCliente()
		{
			InitializeComponent();
			Formateador f = new Formateador();
			estadoObjCliente = Estado.Nuevo;
			cliente = new Service.cliente();
            dgvCondiciones.AutoGenerateColumns = false;
            f.iniFormFreddyGestionar(this, "Gestionar Cliente", pnlCtn, btnNuevo, btnBuscar, btnGuardar, btnModificar, btnCancelar, false);
            estadoComponentes(Estado.Inicial);
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    txtNombreCliente.Enabled = false;
                    txtDNI.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtTelef.Enabled = false;
                    rbFemenino.Enabled = false;
                    rbMasculino.Enabled = false;
                    txtAseguradora.Enabled = false;
                    txtNumAseguradora.Enabled = false;
                    txtNombreEmergencia.Enabled = false;
                    txtTelefonoEmergencia.Enabled = false;
                    btnAddContacto.Enabled = false;
                    btnQuitarContacto.Enabled = false;
                    udNumPartos.Enabled = false;
                    udNumEmbarazos.Enabled = false;
                    dtpFechaNacimiento.Enabled = false;
                    txtObservaciones.Enabled = false;
                    txtDNIPareja.Enabled = false;
                    txtNombrePareja.Enabled = false;
                    rbFemeninoPareja.Enabled = false;
                    rbMasculinoPareja.Enabled = false;
                    btnSeleccionarGestacion.Enabled = false;
                    btnAgregarGestacion.Enabled = false;
                    btnSeleccionarBebe.Enabled = false;
                    btnAgregarBebe.Enabled = false;

                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnModificar.Enabled = false;
                    break;
                case Estado.Nuevo:
                    txtNombreCliente.Enabled = true;
                    txtDNI.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtTelef.Enabled = true;
                    rbFemenino.Enabled = true;
                    rbMasculino.Enabled = true;
                    txtAseguradora.Enabled = true;
                    txtNumAseguradora.Enabled = true;
                    txtNombreEmergencia.Enabled = true;
                    txtTelefonoEmergencia.Enabled = true;
                    btnAddContacto.Enabled = true;
                    btnQuitarContacto.Enabled = true;
                    udNumPartos.Enabled = true;
                    udNumEmbarazos.Enabled = true;
                    dtpFechaNacimiento.Enabled = true;
                    txtObservaciones.Enabled = true;
                    txtDNIPareja.Enabled = true;
                    txtNombrePareja.Enabled = true;
                    rbFemeninoPareja.Enabled = true;
                    rbMasculinoPareja.Enabled = true;
                    btnSeleccionarGestacion.Enabled = true;
                    btnAgregarGestacion.Enabled = true;
                    btnSeleccionarBebe.Enabled = true;
                    btnAgregarBebe.Enabled = true;

                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    break;
                case Estado.Buscar:
                    txtNombreCliente.Enabled = false;
                    txtDNI.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtTelef.Enabled = false;
                    rbFemenino.Enabled = false;
                    rbMasculino.Enabled = false;
                    txtAseguradora.Enabled = false;
                    txtNumAseguradora.Enabled = false;
                    txtNombreEmergencia.Enabled = false;
                    txtTelefonoEmergencia.Enabled = false;
                    btnAddContacto.Enabled = false;
                    btnQuitarContacto.Enabled = false;
                    udNumPartos.Enabled = false;
                    udNumEmbarazos.Enabled = false;
                    dtpFechaNacimiento.Enabled = false;
                    txtObservaciones.Enabled = false;
                    txtDNIPareja.Enabled = false;
                    txtNombrePareja.Enabled = false;
                    rbFemeninoPareja.Enabled = false;
                    rbMasculinoPareja.Enabled = false;
                    btnSeleccionarGestacion.Enabled = false;
                    btnAgregarGestacion.Enabled = false;
                    btnSeleccionarBebe.Enabled = false;
                    btnAgregarBebe.Enabled = false;

                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    break;
                case Estado.Modificar:
                    txtNombreCliente.Enabled = true;
                    txtDNI.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtTelef.Enabled = true;
                    rbFemenino.Enabled = true;
                    rbMasculino.Enabled = true;
                    txtAseguradora.Enabled = true;
                    txtNumAseguradora.Enabled = true;
                    txtNombreEmergencia.Enabled = true;
                    txtTelefonoEmergencia.Enabled = true;
                    btnAddContacto.Enabled = true;
                    btnQuitarContacto.Enabled = true;
                    udNumPartos.Enabled = true;
                    udNumEmbarazos.Enabled = true;
                    dtpFechaNacimiento.Enabled = true;
                    txtObservaciones.Enabled = true;
                    txtDNIPareja.Enabled = true;
                    txtNombrePareja.Enabled = true;
                    rbFemeninoPareja.Enabled = true;
                    rbMasculinoPareja.Enabled = true;
                    btnSeleccionarGestacion.Enabled = true;
                    btnAgregarGestacion.Enabled = true;
                    btnSeleccionarBebe.Enabled = true;
                    btnAgregarBebe.Enabled = true;

                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    break;

            }
        }
		private void btnAgregarBebe_Click(object sender, EventArgs e)
		{
			frmGestionarBebe formGestionarBebe = new frmGestionarBebe();
			//formGestionarBebe.Show();
			if (formGestionarBebe.ShowDialog() == DialogResult.OK)
			{
				Service.bebe bebe;
				bebe = formGestionarBebe.BebeSeleccionado;
				bebes.Add(bebe);
				Object[] filaBebe = new Object[4];
				filaBebe[0] = bebe.dni;
				filaBebe[1] = bebe.nombre;
				filaBebe[2] = bebe.relacion;
				filaBebe[3] = bebe.fechaNaci.ToShortDateString();
				dgvBebes.Rows.Add(filaBebe);
			}
		}

		private void btnSeleccionarBebe_Click(object sender, EventArgs e)
		{
			frmBuscarBebe formBuscarBebe = new frmBuscarBebe();
			formBuscarBebe.Show();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			frmBuscarCliente formCliente = new frmBuscarCliente();
			if (formCliente.ShowDialog() == DialogResult.OK)
			{
				cliente = formCliente.ClienteSeleccionado;
				txtNombreCliente.Text = cliente.nombre;
				txtDNI.Text = cliente.dni;
				txtCorreo.Text = cliente.email;
				txtTelef.Text = cliente.telefono;
				if (cliente.sexo == 'F')
					rbFemenino.Checked = true;
				else
					rbMasculino.Checked = true;
				txtAseguradora.Text = cliente.aseguradora;
				txtNumAseguradora.Text = cliente.numSeguro;
				if (cliente.contactos != null)
				{
                    dgvContactos.AutoGenerateColumns = false;
                    dgvContactos.DataSource = cliente.contactos;
				}

				if (cliente is Service.apoderado)
				{
					apoderado = (Service.apoderado)cliente;
					if (apoderado.bebes != null) {

                        dgvBebes.AutoGenerateColumns = false;
                        dgvBebes.DataSource = apoderado.bebes;
                    }	
				}
				else
				{
					gestante = (Service.gestante)cliente;
					udNumPartos.Value = gestante.numPartos;
					udNumEmbarazos.Value = gestante.cantEmbar;
					dtpFechaNacimiento.Value = gestante.fechaNaci;
                    dgvCondiciones.AutoGenerateColumns = false;
					dgvCondiciones.DataSource = gestante.condMedicas;
					for (int i = 0; i < dgvCondiciones.RowCount; i++)
						dgvCondiciones.Rows[i].Cells[1].Value = true;
					txtObservaciones.Text = gestante.observMedicas;
					if (gestante.pareja != null)
					{
						Service.pareja pareja = gestante.pareja;
						txtDNIPareja.Text = pareja.dni;
						txtNombrePareja.Text = pareja.nombre;
						if (pareja.sexo == 'F')
							rbFemenino.Checked = true;
						else
							rbMasculino.Checked = true;
					}
                    dgvGestaciones.AutoGenerateColumns = false;
                    dgvGestaciones.DataSource = gestante.gestaciones;
				}
                estadoComponentes(Estado.Buscar);
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			#region general
			cliente.nombre = txtNombreCliente.Text;
			cliente.dni = txtDNI.Text;
			cliente.email = txtCorreo.Text;
			cliente.telefono = txtTelef.Text;

			cliente.aseguradora = txtAseguradora.Text;
			cliente.numSeguro = txtNumAseguradora.Text;

			if (rbFemenino.Checked == true)
				cliente.sexo = 'F';
			else
				cliente.sexo = 'M';

			List<Service.contactoEmergencia> contactos = new List<Service.contactoEmergencia>();
			for (int i = 0; i < dgvGestaciones.RowCount; i++)
			{
				contacto = (Service.contactoEmergencia)dgvContactos.Rows[i].DataBoundItem;
				contactos.Add(contacto);
			}
			cliente.contactos = contactos.ToArray();
			#endregion
			if (tabTipo.SelectedTab.Text.Equals("Apoderado"))
			{
				Service.apoderado cliente = new Service.apoderado();

				//guarda su lista de bebes
				cliente.bebes = bebes.ToArray();
                if (estadoObjCliente == Estado.Nuevo)
                {
                    string cod = Program.dbController.insertarApoderado(cliente, "SEDE");
                    frmMensaje mensaje = new frmMensaje("Cliente apoderado registrado", "Mensaje de confirmación", "");
                }
                else
                {
                    Program.dbController.actualizarApoderado(cliente);
                    frmMensaje mensaje = new frmMensaje("Cliente apoderado actualizado", "Mensaje de confirmación", "");
                }
				
			}
			else
			{
				Service.gestante cliente = new Service.gestante();
				cliente.numPartos = (int)udNumPartos.Value;
				cliente.cantEmbar = (int)udNumEmbarazos.Value;
				cliente.fechaNaci = dtpFechaNacimiento.Value;
				cliente.fechaNaciSpecified = true;
				//condiciones
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
				cliente.condMedicas = condicionMedicas.ToArray<Service.condicionMedica>();

				//si hay pareja
				if (!txtDNIPareja.Text.Equals(""))
				{
					Service.pareja pareja = new Service.pareja();
					pareja.nombre = txtNombrePareja.Text;
					pareja.dni = txtDNIPareja.Text;
					if (rbFemeninoPareja.Checked == true)
						pareja.sexo = 'F';
					else
						pareja.sexo = 'M';
					cliente.pareja = pareja;
				}

				//gestaciones
				List<Service.gestacion> gestaciones = new List<Service.gestacion>();
				for (int i = 0; i < dgvGestaciones.RowCount; i++)
				{
					gestacion = (Service.gestacion)dgvGestaciones.Rows[i].DataBoundItem;
					gestaciones.Add(gestacion);
				}
				cliente.gestaciones = gestaciones.ToArray();

				cliente.observMedicas = txtObservaciones.Text;
                if (estadoObjCliente == Estado.Nuevo)
                {
                    string cod = Program.dbController.insertarGestante(cliente, "SEDE");
                    frmMensaje mensaje = new frmMensaje("Cliente apoderado registrado", "Mensaje de confirmación", "");
                }
                else
                {
                    Program.dbController.actualizarGestante(cliente);
                    frmMensaje mensaje = new frmMensaje("Cliente apoderado actualizado", "Mensaje de confirmación", "");
                }
            }
		}
	 

        private void btnAddContacto_Click(object sender, EventArgs e)
        {
            Service.contactoEmergencia contacto = new Service.contactoEmergencia();
            contacto.nombre = txtNombreEmergencia.Text;
            contacto.telefono = txtTelefonoEmergencia.Text;

            contactos.Add(contacto);

            Object[] filaGestacion = new Object[2];
            filaGestacion[0] = contacto.nombre;
            filaGestacion[1] = contacto.telefono;

            dgvContactos.Rows.Add(filaGestacion);
            
        }

        private void btnAgregarGestacion_Click(object sender, EventArgs e)
        {
            frmGestionarGestacion formGestionarGestacion = new frmGestionarGestacion();
            if(formGestionarGestacion.ShowDialog() == DialogResult.OK)
            {
                gestacion = formGestionarGestacion.Gestacion;
                gestaciones.Add(gestacion);

                Object[] filaGestacion = new Object[2];
                filaGestacion[0] = gestacion.clinica;
                filaGestacion[1] = gestacion.fecha_probable_parto;

                dgvGestaciones.Rows.Add(filaGestacion);
            }
        }

        private void btnSeleccionarGestacion_Click(object sender, EventArgs e)
        {
            //si dgv no está vacío
            gestacion = gestaciones[dgvGestaciones.CurrentRow.Index];

            //la idea es que se modifique
            frmGestionarGestacion formGestionarGestacion = new frmGestionarGestacion(gestacion);
            if (formGestionarGestacion.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

		private void btnModificar_Click(object sender, EventArgs e)
		{
            estadoObjCliente = Estado.Modificar;
            estadoComponentes(Estado.Modificar);
		}

		private void dgvCondiciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			Service.condicionMedica conFila = (Service.condicionMedica)dgvCondiciones.Rows[e.RowIndex].DataBoundItem;
			if (conFila != null)
				dgvCondiciones.Rows[e.RowIndex].Cells[0].Value = conFila.nombre;
		}

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoObjCliente = Estado.Nuevo;
            dgvCondiciones.DataSource = Program.dbController.listarCondMedicasPorNombre("");
            estadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Inicial);
            dgvCondiciones.DataSource = null;
        }
    }
}

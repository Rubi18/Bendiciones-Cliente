﻿using System;
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
		private Service.cliente cliente = new Service.cliente();
		private Service.apoderado apoderado = new Service.apoderado();
		private Service.gestante gestante = new Service.gestante();
		private Service.gestacion gestacion = new Service.gestacion();
		private Service.contactoEmergencia contacto = new Service.contactoEmergencia();

		private BindingList<Service.contactoEmergencia> contactos = new BindingList<Service.contactoEmergencia>();
		private BindingList<Service.bebe> bebes = new BindingList<Service.bebe>();
		private BindingList<Service.gestacion> gestaciones = new BindingList<Service.gestacion>();
		private BindingList<Service.condicionMedica> condiciones = new BindingList<Service.condicionMedica>();

		Estado estadoObjCliente;
		public frmGestionarCliente()
		{
			InitializeComponent();
			Formateador f = new Formateador();
			f.formatearBotonListar(btnAddContacto);
			f.formatearBotonListar(btnQuitarContacto);
			cliente = new Service.cliente();
            dgvCondiciones.AutoGenerateColumns = false;
			dgvCondiciones.DataSource = Program.dbController.listarCondMedicasPorNombre("");
			f.iniFormFreddyGestionar(this, "Gestionar Cliente", pnlCtn, btnNuevo, btnBuscar, btnGuardar, btnModificar, btnCancelar, false);
			cboSedes.DataSource = new BindingList<Service.sede>(Program.dbController.listarSedes());
			cboSedes.DisplayMember = "distrito";
			cboSedes.ValueMember = "idSede";
			estadoComponentes(Estado.Inicial);
			limpiarComponentes();
        }
		#region Estados
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
					cboSedes.Enabled = false;
					dgvCondiciones.Enabled = false;
					lblCodigo.Visible = false;
					dgvContactos.Enabled = false;
					dgvCondiciones.Enabled = false;
					dgvBebes.Enabled = false;
					dgvGestaciones.Enabled = false;

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
					cboSedes.Enabled = true;
					dgvCondiciones.Enabled = true;
					lblCodigo.Visible = false;
					dgvContactos.Enabled = true;
					dgvCondiciones.Enabled = true;
					dgvBebes.Enabled = true;
					dgvGestaciones.Enabled = true;

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
					cboSedes.Enabled = false;
					dgvCondiciones.Enabled = false;
					lblCodigo.Visible = true;
					dgvContactos.Enabled = false;
					dgvCondiciones.Enabled = false;
					dgvBebes.Enabled = false;
					dgvGestaciones.Enabled = false;

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
					cboSedes.Enabled = true;
                    cboSedes.SelectedIndex = 1;
					dgvCondiciones.Enabled = true;
					lblCodigo.Visible = true;
					dgvContactos.Enabled = true;
					dgvCondiciones.Enabled = true;
					dgvBebes.Enabled = true;
					dgvGestaciones.Enabled = true;

					btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    break;

            }
        }

		public void limpiarComponentes()
		{
			txtNombreCliente.Text = "";
			txtDNI.Text = "";
			txtCorreo.Text = "";
			txtTelef.Text = "";
			rbFemenino.Checked = false;
			rbMasculino.Checked = false;
			txtAseguradora.Text = "";
			txtNumAseguradora.Text = "";
			cboSedes.SelectedIndex = -1;
			txtNombreEmergencia.Text = "";
			txtTelefonoEmergencia.Text = "";
			dgvContactos.RowCount = 0;
			dgvBebes.RowCount = 0;
			udNumPartos.Value = 0;
			udNumEmbarazos.Value = 0;
			txtObservaciones.Text = "";
			txtDNIPareja.Text = "";
			txtNombrePareja.Text = "";
			rbFemeninoPareja.Checked = false;
			rbMasculino.Checked = false;
			dgvGestaciones.RowCount = 0;
		}
		#endregion
		public bool IsValidEmail(string email)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}

		public bool verificarCampos()
		{
			int i;
			if (txtNombreCliente.Text.Equals("") || txtDNI.Text.Equals("") || cboSedes.SelectedIndex==-1)
			{
				frmMensaje mensaje = new frmMensaje("Complete los campos obligatorios","Error de Campos","");
				return false;
			}

			if(!int.TryParse(txtTelef.Text,out i))
			{
				frmMensaje mensaje = new frmMensaje("Campo TELEFONO debe ser numerico", "Error de TELEFONO", "");
				return false;
			}

			if (!IsValidEmail(txtCorreo.Text))
			{
				frmMensaje mensaje = new frmMensaje("Ingrese un correo electronico valido: example@dominio.com", "", "");
				return false;
			}

			if (rbFemenino.Checked == false && rbMasculino.Checked == false)
			{
				frmMensaje mensaje = new frmMensaje("Campo SEXO(cliente o pareja) debe ser seleccionado", "Error de SEXO", "");
				return false;
			}

			if ((!txtAseguradora.Text.Equals("") && txtNumAseguradora.Text.Equals(""))|| (txtAseguradora.Text.Equals("") && !txtNumAseguradora.Text.Equals("")))
			{
				frmMensaje mensaje = new frmMensaje("Completar Campos de Aseguradora", "Error de ASEGURADORA", "");
                if (!int.TryParse(txtNumAseguradora.Text, out i))
                {
                    frmMensaje mensaje1 = new frmMensaje("Campo Num. ASEGURADORA debe ser numerico", "Error de ASEGURADORA", "");
                    return false;
                }
            }

			if ((!txtDNIPareja.Text.Equals("") && txtNombrePareja.Text.Equals("")) || (txtDNIPareja.Text.Equals("") && !txtNombrePareja.Text.Equals("")))
			{
				frmMensaje mensaje = new frmMensaje("Completar Campos de Pareja", "Error de PAREJA", "");
                if(rbFemeninoPareja.Checked == false && rbMasculinoPareja.Checked == false)
                {
                    frmMensaje mensaje1 = new frmMensaje("Campo SEXO(cliente o pareja) debe ser seleccionado", "Error de SEXO", "");
                    return false;
                }
			}
            return true;
		}

		#region Botones
		private void btnBuscar_Click(object sender, EventArgs e)
		{
			frmBuscarCliente formCliente = new frmBuscarCliente();
			if (formCliente.ShowDialog() == DialogResult.OK)
			{
				cliente = formCliente.ClienteSeleccionado;
				lblCodigo.Text = cliente.codigo;
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
					foreach (Service.contactoEmergencia contacto in cliente.contactos)
					{
						Object[] filaContacto = new Object[2];
						filaContacto[0] = contacto.nombre;
						filaContacto[1] = contacto.telefono;
						dgvContactos.Rows.Add(filaContacto);
					}
				}

				if (cliente is Service.apoderado)
				{
					apoderado = (Service.apoderado)cliente;
					tabTipo.SelectedTab = tabApoderado;
					if (apoderado.bebes != null) {
						foreach(Service.bebe bebe in apoderado.bebes)
						{
							Object[] filaBebe = new Object[4];
							filaBebe[0] = bebe.dni;
							filaBebe[1] = bebe.nombre;
							filaBebe[2] = bebe.relacion;
							filaBebe[3] = bebe.fechaNaci.ToShortDateString();
							dgvBebes.Rows.Add(filaBebe);
						}   
                    }	
				}
				else
				{
					tabTipo.SelectedTab = tabGestante;
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
			if (verificarCampos())
			{
				if (tabTipo.SelectedTab == tabApoderado)
				{
					apoderado.nombre = txtNombreCliente.Text;
					apoderado.dni = txtDNI.Text;
					apoderado.email = txtCorreo.Text;
					apoderado.telefono = txtTelef.Text;
					
					apoderado.aseguradora = txtAseguradora.Text;
					apoderado.numSeguro = txtNumAseguradora.Text;

					if (rbFemenino.Checked == true)
						apoderado.sexo = 'F';
					else
						apoderado.sexo = 'M';
					apoderado.contactos = contactos.ToArray();
					apoderado.bebes = bebes.ToArray();
					if (estadoObjCliente == Estado.Nuevo)
					{
						string cod = Program.dbController.insertarApoderado(apoderado, ((Service.sede)cboSedes.SelectedItem).distrito);
						Console.WriteLine(cod);
						frmMensaje mensaje = new frmMensaje("Se ha registrado un nuevo Apoderado", "Mensaje de confirmación", "Confirmar");
					}
					else
					{
						Program.dbController.actualizarApoderado(apoderado);
						frmMensaje mensaje = new frmMensaje("Se han actualizado los datos", "Mensaje de confirmación", "Confirmar");
					}
				}
				else
				{
					gestante.nombre = txtNombreCliente.Text;
					gestante.dni = txtDNI.Text;
					gestante.email = txtCorreo.Text;
					gestante.telefono = txtTelef.Text;

					gestante.aseguradora = txtAseguradora.Text;
					gestante.numSeguro = txtNumAseguradora.Text;

					if (rbFemenino.Checked == true)
						gestante.sexo = 'F';
					else
						gestante.sexo = 'M';
					gestante.contactos = contactos.ToArray();
					gestante.numPartos = (int)udNumPartos.Value;
					gestante.cantEmbar = (int)udNumEmbarazos.Value;
					gestante.fechaNaci = dtpFechaNacimiento.Value;
					gestante.fechaNaciSpecified = true;

					//condiciones
					for (int i = 0; i < dgvCondiciones.Rows.Count; i++)
					{
						if (dgvCondiciones.Rows[i].Cells[1].Value == null)
						{ }
						else if ((bool)dgvCondiciones.Rows[i].Cells[1].Value == true)
						{
							Service.condicionMedica cond = new Service.condicionMedica();
							cond = (Service.condicionMedica)dgvCondiciones.Rows[i].DataBoundItem;
							condiciones.Add(cond);
						}
					}
					gestante.condMedicas = condiciones.ToArray<Service.condicionMedica>();

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
						gestante.pareja = pareja;
					}

					gestante.gestaciones = gestaciones.ToArray();
					gestante.observMedicas = txtObservaciones.Text;

					if (estadoObjCliente == Estado.Nuevo)
					{
						string cod = Program.dbController.insertarGestante(gestante, ((Service.sede)cboSedes.SelectedItem).distrito);
						frmMensaje mensaje = new frmMensaje("Cliente apoderado registrado", "Mensaje de confirmación", "");
					}
					else
					{
						Program.dbController.actualizarGestante(gestante);
						frmMensaje mensaje = new frmMensaje("Cliente apoderado actualizado", "Mensaje de confirmación", "");
					}
				}
				estadoComponentes(Estado.Inicial);
				limpiarComponentes();
			}
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			estadoObjCliente = Estado.Nuevo;
			estadoComponentes(Estado.Nuevo);
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			estadoComponentes(Estado.Inicial);
			limpiarComponentes();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			estadoObjCliente = Estado.Modificar;
			estadoComponentes(Estado.Modificar);
		}
		#endregion

		#region ContactosDeEmergencia
		private void btnAddContacto_Click(object sender, EventArgs e)
		{
			int i;
			if (int.TryParse(txtTelefonoEmergencia.Text, out i) && !txtNombreEmergencia.Text.Equals(""))
			{
				Service.contactoEmergencia cont = new Service.contactoEmergencia();
				cont.nombre = txtNombreEmergencia.Text;
				cont.telefono = txtTelefonoEmergencia.Text;

				if (estadoObjCliente == Estado.Nuevo)
					contactos.Add(cont);
				else
				{
					contactos = new BindingList<Service.contactoEmergencia>();
					foreach (Service.contactoEmergencia contacto in cliente.contactos)
						contactos.Add(contacto);
					contactos.Add(cont);
				}
				Object[] filaContacto = new Object[2];
				filaContacto[0] = cont.nombre;
				filaContacto[1] = cont.telefono;
				dgvContactos.Rows.Add(filaContacto);
			}
			else
			{
				frmMensaje mensaje = new frmMensaje("Ingrese datos del contacto de emergencia", "Error de CAMPOS", "");
			}			
		}

		private void btnQuitarContacto_Click(object sender, EventArgs e)
		{
			
			if (estadoObjCliente == Estado.Nuevo)
			{
				foreach (DataGridViewRow fila in dgvContactos.SelectedRows)
				{
				contactos.RemoveAt(fila.Index);
				dgvContactos.Rows.RemoveAt(fila.Index);
				}	
			}
			else
			{
				contactos = new BindingList<Service.contactoEmergencia>();
				foreach (Service.contactoEmergencia contacto in cliente.contactos)
					contactos.Add(contacto);
				foreach (DataGridViewRow fila in dgvContactos.SelectedRows)
				{
				contactos.RemoveAt(fila.Index);
				dgvContactos.Rows.RemoveAt(fila.Index);
				}
			}
		
		}
		#endregion

		#region Apoderado
		private void btnAgregarBebe_Click(object sender, EventArgs e)
		{
			frmGestionarBebe formGestionarBebe = new frmGestionarBebe();
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
		#endregion

		#region Gestante
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
		
		private void dgvCondiciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			Service.condicionMedica conFila = (Service.condicionMedica)dgvCondiciones.Rows[e.RowIndex].DataBoundItem;
			if (conFila != null)
				dgvCondiciones.Rows[e.RowIndex].Cells[0].Value = conFila.nombre;
		}
		#endregion
	}
}

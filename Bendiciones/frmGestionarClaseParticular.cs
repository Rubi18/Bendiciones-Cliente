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
    public partial class frmGestionarClaseParticular : Form
    {
        private Service.cliente cliente;
        private Service.colaborador docente;
        private Service.claseParticular cp;
        Estado estadoObjColab;


        public void limpiarComponentes()
        {
            txtDNICliente.Text = "";
            txtNombreCliente.Text = "";
            txtNombreServicio.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "0";
            txtObservaciones.Text = "";
            txtDireccion.Text = "";
            cboDistrito.SelectedIndex = -1;
            dtpFechaMatricula.Value = DateTime.Today;
            cboHoraIni.SelectedIndex = -1;
            cboHoraFin.SelectedIndex = -1;
            txtDNIDocente.Text = ""; ;
            txtNombreDocente.Text = "";
            cboDescuentos.SelectedIndex = -1;
            txtAbonar.Text = "0"; ;
            txtSaldo.Text = "0";
            txtTotal.Text = "0";
            cboFormaPago.SelectedIndex = -1;
        }
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                   
                    btnBuscarCliente.Enabled = false;
                    txtNombreServicio.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtObservaciones.Enabled = false;
                    txtDireccion.Enabled = false;
                    cboDistrito.Enabled = false;
                    dtpFechaMatricula.Enabled = false;
                    cboHoraIni.Enabled = false;
                    cboHoraFin.Enabled = false;
                   
                    btnBuscarDocente.Enabled = false;
                    txtTotal.Enabled = false;
                    cboDescuentos.Enabled = false;
                    txtAbonar.Enabled = false;
                    txtSaldo.Enabled = false;
                    cboFormaPago.Enabled = false;

                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnModificar.Enabled = false;
                    break;
                case Estado.Nuevo:
                    
                    btnBuscarCliente.Enabled = true;
                    txtNombreServicio.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtObservaciones.Enabled = true;
                    txtDireccion.Enabled = true;
                    cboDistrito.Enabled = true;
                    dtpFechaMatricula.Enabled = true;
                    cboHoraIni.Enabled = true;
                    cboHoraFin.Enabled = true;
                   
                    btnBuscarDocente.Enabled = true;
                    cboDescuentos.Enabled = true;
                    txtAbonar.Enabled = true;
                    cboFormaPago.Enabled = true;
                    txtSaldo.Enabled = false;
                    txtTotal.Enabled = false;


                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;

                    gbPago.Visible = true;
                    break;
                case Estado.Buscar:
                  
                    btnBuscarCliente.Enabled = false;
                    txtNombreServicio.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtObservaciones.Enabled = false;
                    txtDireccion.Enabled = false;
                    cboDistrito.Enabled = false;
                    dtpFechaMatricula.Enabled = false;
                    cboHoraIni.Enabled = false;
                    cboHoraFin.Enabled = false;
                   
                    btnBuscarDocente.Enabled = false;
                    txtTotal.Enabled = false;
                    cboDescuentos.Enabled = false;
                    txtAbonar.Enabled = false;
                    txtSaldo.Enabled = false;
                    cboFormaPago.Enabled = false;



                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    break;
                case Estado.Modificar:
                   
                    btnBuscarCliente.Enabled = true;
                    txtNombreServicio.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtObservaciones.Enabled = true;
                    txtDireccion.Enabled = true;
                    cboDistrito.Enabled = true;
                    dtpFechaMatricula.Enabled = true;
                    cboHoraIni.Enabled = true;
                    cboHoraFin.Enabled = true;
                   
                    btnBuscarDocente.Enabled = true;
                    cboDescuentos.Enabled = true;
                    txtAbonar.Enabled = true;
                    cboFormaPago.Enabled = true;
                    txtSaldo.Enabled = false;
                    txtTotal.Enabled = false;


                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    break;
            }
        }


        public bool verificarCampos()
        {
            float i;
            if (txtNombreServicio.Text.Equals("") || txtDescripcion.Text.Equals("") || txtPrecio.Text.Equals("") ||
               txtDireccion.Text.Equals("") || cboDistrito.SelectedIndex == -1 || cboHoraFin.SelectedIndex == -1 ||
               cboHoraIni.SelectedIndex == -1)
            {
                frmMensaje mensaje = new frmMensaje("Todos los campos son obligatorios","","");
               return false;
            }

            if (!float.TryParse(txtAbonar.Text, out i))
                return false;
            return true;
        }
        public frmGestionarClaseParticular()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Clase Particular", pnlCtn, btnNuevo, btnBuscar, btnGuardar, btnModificar, btnCancelar, false);
            f.formatearBotonListar(btnBuscarCliente);
            f.formatearBotonListar(btnBuscarDocente);
            cboDescuentos.DataSource = Program.dbController.listarDescuentos();
            cboDescuentos.DisplayMember = "Nombre";
            cboDescuentos.ValueMember = "idDescuento";


            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
            
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente formBuscarCliente = new frmBuscarCliente();
            if (formBuscarCliente.ShowDialog() == DialogResult.OK)
            {
                cliente = formBuscarCliente.ClienteSeleccionado;
                txtDNICliente.Text = cliente.dni;
                txtNombreCliente.Text = cliente.nombre;
            }
            
        }

        private void btnBuscarDocente_Click(object sender, EventArgs e)
        {
            frmBuscarDocente formBuscarDocente = new frmBuscarDocente();
            if (formBuscarDocente.ShowDialog() == DialogResult.OK)
            {
                docente = formBuscarDocente.DocenteSeleccionado;
                txtDNIDocente.Text = docente.dni;
                txtNombreDocente.Text = docente.nombre;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoObjColab = Estado.Nuevo;
            estadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoObjColab = Estado.Inicial;
            estadoComponentes(Estado.Inicial);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoObjColab = Estado.Modificar;
            estadoComponentes(Estado.Modificar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarClaseParticular formBuscarClaseParticular = new frmBuscarClaseParticular();
            if(formBuscarClaseParticular.ShowDialog() == DialogResult.OK)
            {
                cp = formBuscarClaseParticular.ClaseSeleccionada;
                cliente = formBuscarClaseParticular.Cliente;

                txtDNICliente.Text = cliente.dni;
                txtNombreCliente.Text = cliente.nombre;
                txtNombreServicio.Text = cp.nombre;
                txtDescripcion.Text = cp.descripcion;
                txtPrecio.Text = cp.precio.ToString();
                txtObservaciones.Text = cp.observaciones;
                txtDireccion.Text = cp.direccion;
                cboDistrito.SelectedItem = cp.distrito;
                dtpFechaMatricula.Value = cp.fecha;
                cp.fechaSpecified = true;
                cboHoraIni.SelectedItem = cp.horaIni;
                cboHoraFin.SelectedItem = cp.horaFin;
                txtDNIDocente.Text = cp.colaborador.dni;
                txtNombreDocente.Text = cp.colaborador.nombre;
                //matricula
                gbPago.Visible = false;
                cboDescuentos.SelectedIndex = -1;
                txtAbonar.Text = ""; ;
                txtSaldo.Text = "";
                cboFormaPago.SelectedIndex = -1;
                estadoComponentes(Estado.Buscar);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idClase;
            
            //validar los datos antes

            //se construye clase particular
            cp = new Service.claseParticular();
            cp.colaborador = docente;
            cp.descripcion = txtDescripcion.Text;
            cp.direccion = txtDireccion.Text;
            cp.distrito = cboDistrito.SelectedItem.ToString();
            cp.fecha = dtpFechaMatricula.Value;
            cp.fechaSpecified = true;
            //se debe revisar la hora en el DateTime

            //cp.horaIni = (DateTime.Parse(cboHoraIni.SelectedItem.ToString()));
            //cp.horaFin = (DateTime.Parse(cboHoraFin.SelectedItem.ToString()));

            cp.horaIni = DateTime.Now;
            cp.horaFin = DateTime.Now;

            cp.horaFinSpecified = true;
            cp.horaIniSpecified = true;
            cp.nombre = txtNombreServicio.Text;
            cp.observaciones = txtObservaciones.Text;
            cp.precio = float.Parse(txtPrecio.Text);
            //insertar clase particular
            idClase = Program.dbController.insertarClaseParticular(cp);
            cp.id_servicio = idClase;

            //se construye la matricula
            Service.matricula mat = new Service.matricula();
            mat.cliente = cliente;
            mat.descuento = (Service.descuento)cboDescuentos.SelectedItem;
            mat.fecha = DateTime.Today;
            mat.fechaSpecified = true;
            mat.monto = cp.precio;
            mat.saldo = float.Parse(txtSaldo.Text);
            mat.servicio = cp;

            //cuota
            if (txtAbonar.Text != "0")
            {
                Service.cuota cuota = new Service.cuota();
                cuota.fecha = DateTime.Today;
                cuota.fechaSpecified = true;
                cuota.formaPago = cboFormaPago.SelectedItem.ToString();
                cuota.monto = float.Parse(txtAbonar.Text);
                //insertar cuota
                mat.saldo = mat.saldo - cuota.monto;
            }
            Program.dbController.insertarMatricula(mat);

            frmMensaje mensaje = new frmMensaje("Clase Particular Registrada", "Mensaje de confirmación", "");

        }
    }
}

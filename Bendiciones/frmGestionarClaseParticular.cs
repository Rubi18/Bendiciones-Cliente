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
        private Service.matricula mat = new Service.matricula();
        private BindingList<Service.cuota> cuotas = null;
        private IEnumerable<Service.descuento> descuentos;
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
            cboDistrito.SelectedText = "";
            cboDistrito.SelectedIndex = -1;
            dtpFechaMatricula.Value = DateTime.Today;
            cboHoraIni.SelectedIndex = -1;
            cboHoraFin.SelectedIndex = -1;
            cboHoraFin.SelectedText ="";
            cboHoraIni.SelectedText = "";
            txtDNIDocente.Text = ""; ;
            txtNombreDocente.Text = "";
            txtSaldo.Text = "0";
            txtTotal.Text = "0";

            cboDescuentos.SelectedIndex = -1;
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

                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnModificar.Enabled = false;

                    cboDescuentos.Enabled = false;

                    btnPagarAhora.Enabled = false;
                    btnPagarAhora.Visible = false;
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
                   

                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    cboDescuentos.Enabled = true;

                    btnPagarAhora.Enabled = true;
                    btnPagarAhora.Visible = true;
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

                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    cboDescuentos.Enabled = false;

                    btnPagarAhora.Enabled = false;
                    btnPagarAhora.Visible = false;
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
                    

                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    cboDescuentos.Enabled = false;

                    btnPagarAhora.Enabled = false;
                    btnPagarAhora.Visible = false;
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
                MessageBox.Show("Todos los campos son obligatorios","",MessageBoxButtons.OK,MessageBoxIcon.Error);
               return false;
            }

            return true;
        }
        public frmGestionarClaseParticular()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormFreddyGestionar(this, "Clase Particular", pnlCtn, btnNuevo, btnBuscar, btnGuardar, btnModificar, btnCancelar, false);
            f.formatearBotonListar(btnBuscarCliente);
            f.formatearBotonListar(btnBuscarDocente);
            limpiarComponentes();
            descuentos = Program.dbController.listarDescuentos();
            if(descuentos != null)
            {
                cboDescuentos.DataSource = descuentos;
                cboDescuentos.DisplayMember = "Nombre";
            }
            
            //limpiarComponentes();
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
                cboDistrito.SelectedText = "";
                cboDistrito.SelectedText = cp.distrito;
                dtpFechaMatricula.Value = cp.fecha;
                
                cboHoraIni.SelectedIndex = -1;
                cboHoraFin.SelectedIndex = -1;
                cboHoraIni.SelectedText = "";
                cboHoraFin.SelectedText = "";
                cboHoraIni.SelectedText = cp.horaIni.ToShortTimeString();
                cboHoraFin.SelectedText = cp.horaFin.ToShortTimeString();
                txtDNIDocente.Text = cp.colaborador.dni;
                txtNombreDocente.Text = cp.colaborador.nombre;

                estadoComponentes(Estado.Buscar);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idMat;
            int idClase;
            float p;
            
            if(cliente != null)
                mat.cliente = cliente;
            else
            {
                frmMensaje m1 = new frmMensaje("Debe seleccionar un cliente", "Error de CLIENTE", "");
                return;
            }

           
            mat.fecha = DateTime.Today;
            mat.fechaSpecified = true;


            if (!verificarCampos())
                return;

            //clase particular
            cp = new Service.claseParticular();
            cp.colaborador = docente;

            cp.nombre = txtNombreServicio.Text;
            cp.descripcion = txtDescripcion.Text;
            cp.direccion = txtDireccion.Text;

            cp.distrito = cboDistrito.SelectedItem.ToString();
            

            if(dtpFechaMatricula.Value >= DateTime.Today)
            {
                cp.fecha = dtpFechaMatricula.Value;
                cp.fechaSpecified = true;
            }
            else
            {
                frmMensaje m1 = new frmMensaje("Campo fecha debe ser posterior a hoy", "Error de FECHA", "");
                return;
            }

            //se debe revisar la hora en el DateTime
            cp.horaIni = DateTime.Now;
            cp.horaFin = DateTime.Now;

            cp.horaFinSpecified = true;
            cp.horaIniSpecified = true;


            

            cp.observaciones = txtObservaciones.Text;



            if (float.TryParse(txtPrecio.Text, out p))
            {
                if(p > 0)
                    cp.precio = p;
                else
                {
                    MessageBox.Show("Ingrese una cantidad numérica mayor a cero", "Error de Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad numérica positiva", "Error de Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            mat.descuento = (Service.descuento)cboDescuentos.SelectedItem;
            mat.monto = float.Parse(txtTotal.Text);



            if (cp != null)
            {
                idClase = Program.dbController.insertarClaseParticular(cp);
                cp.id_servicio = idClase;

                mat.servicio = cp;
            }
            
            




            Program.dbController.insertarMatricula(mat);

            MessageBox.Show("Clase Particular Registrada", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            estadoComponentes(Estado.Inicial);
        }

        private void btnPagarAhora_Click(object sender, EventArgs e)
        {
            int idMat;
            float p;
            
            if(float.TryParse(txtPrecio.Text, out p))
            {
                if(p == 0)
                {
                    MessageBox.Show("Ingrese una cantidad numérica mayor a cero", "Error de Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrecio.Text = "0";
                    return;
                }
            }


            frmPagoMat formPagoMat = new frmPagoMat(mat);
            if(formPagoMat.ShowDialog() == DialogResult.OK)
            {
                if(formPagoMat.Cuota != null)
                {
                    cuotas = new BindingList<Service.cuota>();
                    cuotas.Add(formPagoMat.Cuota);
                    mat.cuotas = cuotas.ToArray();
                }
                txtSaldo.Text = (float.Parse(txtSaldo.Text) - formPagoMat.Cuota.monto).ToString();
                

                mat.saldo = float.Parse(txtSaldo.Text);
            }

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            float p;
            if (float.TryParse(txtPrecio.Text, out p))
            {
                txtTotal.Text = txtPrecio.Text;
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad numérica mayor a cero", "Error de Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Text = "0";
            }
            cboDescuentos.SelectedIndex = -1;

        }



        private void cboDescuentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Service.descuento d = (Service.descuento)cboDescuentos.SelectedItem;
            float t;
            if (d != null && txtPrecio.Text != "0")
            {
                Console.WriteLine("txtPrecio: ", txtPrecio.Text);
                if (float.TryParse(txtPrecio.Text, out t))
                {
                    t = (float.Parse(txtPrecio.Text) * (100 - d.porcentaje)/100);
                    Console.WriteLine("t: ", t);
                    txtTotal.Text = t.ToString();
                }
                else
                {
                    //frmMensaje formMensaje = new frmMensaje("Debe ingresar un número válido", "Error de PRECIO", "");

                    //txtTotal.Text = "No se puede convertir";
                }

            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtSaldo.Text = txtTotal.Text;
            mat.monto = float.Parse(txtTotal.Text);
            //mat.saldo = float.Parse(txtSaldo.Text);
        }
    }
}

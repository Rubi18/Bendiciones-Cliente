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
    public partial class frmBuscarCliente : Form
    {
        private Service.cliente clienteSeleccionado;
        private List<Service.cliente> clientes;
        //private BindingList<Service.cliente> clientes;
        
        public cliente ClienteSeleccionado { get => clienteSeleccionado; set => clienteSeleccionado = value; }

        public frmBuscarCliente()
        {
            InitializeComponent();
            dgvClientes.AutoGenerateColumns = false;

            Formateador f = new Formateador();
            f.iniFormFreddyBuscar(this, "Buscar Cliente", "Nombre o DNI:", txtNombre, dgvClientes, btnBuscar, btnSeleccionar, btnEliminar, false);
            //clientes = new BindingList<Service.cliente>(Program.dbController.listarApoderadosPorNombreDNI(""));
            clientes = Program.dbController.listarApoderadosPorNombreDNI("").ToList<Service.cliente>();
            foreach (Service.gestante g in Program.dbController.listarGestantePorNombreDNI(""))
            {
                clientes.Add((Service.cliente)g);
            }


            foreach (Service.apoderado a in Program.dbController.listarApoderadosPorNombreDNI(""))
            {
                Object[] fila = new Object[3];
                fila[0] = a.dni;
                fila[1] = a.nombre;
                fila[2] = "Apoderado";
                dgvClientes.Rows.Add(fila);
                //dgvClientes.Rows.Add(a);
            }
            foreach (Service.gestante g in Program.dbController.listarGestantePorNombreDNI(""))
            {
                Object[] fila = new Object[3];
                fila[0] = g.dni;
                fila[1] = g.nombre;
                fila[2] = "Gestante";
                dgvClientes.Rows.Add(fila);
                //dgvClientes.Rows.Add(g);
            }
            
        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvClientes.RowCount = 0;
            clientes = new List<cliente>();
            //dgvClientes.DataSource = Program.dbController.listarGestantePorNombreDNI(txtNombre.Text);
            //dgvClientes.DataSource = Program.dbController.listarApoderadosPorNombreDNI(txtNombre.Text);
            IEnumerable < Service.cliente > apoderados = Program.dbController.listarApoderadosPorNombreDNI(txtNombre.Text);
            if (apoderados != null)
            {
                List<cliente> apo = apoderados.ToList();
                clientes.AddRange(apo);
            }

            IEnumerable<Service.cliente> gestantes = Program.dbController.listarGestantePorNombreDNI(txtNombre.Text);
            if (gestantes != null)
            {
                List<cliente> gest = gestantes.ToList();
                clientes.AddRange(gest);
            }
            foreach (Service.cliente cli in clientes)
            {
                Object[] fila = new Object[3];
                fila[0] = cli.dni;
                fila[1] = cli.nombre;
                if( cli is Service.gestante)
                {
                    fila[2] = "Gestante";
                }
                else
                {
                    fila[2] = "Apoderado";
                }
                dgvClientes.Rows.Add(fila);
                //dgvClientes.Rows.Add(a);
            }

            // foreach (Service.apoderado a in Program.dbController.listarApoderadosPorNombreDNI(txtNombre.Text))
            //{
            //	Object[] fila = new Object[2];
            //	fila[0] = a.dni;
            //	fila[1] = a.nombre;
            //	dgvClientes.Rows.Add(fila);
            //	//dgvClientes.Rows.Add(a);
            //}
            //foreach (Service.gestante g in Program.dbController.listarGestantePorNombreDNI(txtNombre.Text))
            //{
            //	Object[] fila = new Object[2];
            //	fila[0] = g.dni;
            //	fila[1] = g.nombre;
            //	dgvClientes.Rows.Add(fila);
            //	//dgvClientes.Rows.Add(g);
            //}

        }



        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.RowCount == 0)
            {
                frmMensaje mensaje = new frmMensaje("No hay clientes para seleccionar", "Mensaje de advertencia", "");
            }
            else
            {
                clienteSeleccionado = clientes[dgvClientes.CurrentCell.RowIndex];
                this.DialogResult = DialogResult.OK;
            }
            //clienteSeleccionado = clientes[dgvClientes.CurrentCell.RowIndex];
            //clienteSeleccionado = (Service.cliente)dgvClientes.CurrentRow.DataBoundItem;
            //if (clienteSeleccionado != null)
            //    clienteSeleccionado = clientes[dgvClientes.CurrentCell.RowIndex];
            //this.DialogResult = DialogResult.OK;
            //else
            //{
            //    frmMensaje mensaje = new frmMensaje("No se ha seleccionado un cliente", "Mensaje de advertencia", "");
            //}
        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}

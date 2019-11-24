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
    
    public partial class frmBuscarClaseParticular : Form
    {
        private Service.claseParticular claseSeleccionada;
        private Service.cliente cliente;
        private BindingList<Service.claseParticular> clases = new BindingList<claseParticular>();
        public frmBuscarClaseParticular()
        {
            InitializeComponent();
            dgvClasesParticulares.AutoGenerateColumns = false;
        }

        public claseParticular ClaseSeleccionada { get => claseSeleccionada; set => claseSeleccionada = value; }
        public cliente Cliente { get => cliente; set => cliente = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            claseSeleccionada = clases[dgvClasesParticulares.CurrentRow.Index];
            this.DialogResult = DialogResult.OK;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            claseSeleccionada = (Service.claseParticular)dgvClasesParticulares.CurrentRow.DataBoundItem;
            Program.dbController.eliminarClaseParticular(claseSeleccionada.id_servicio);
            frmMensaje mensaje = new frmMensaje("Se ha eliminado correctamente", "Mensaje Confirmacion", "");
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //si no es vacío
            foreach ( Service.claseParticular c in Program.dbController.listarClasesParticularesPorCliente(Cliente.idPersona))
            {
                clases.Add(c);
                Object[] filaClase = new Object[3];
                filaClase[0] = c.nombre;
                filaClase[1] = c.precio;
                filaClase[2] = c.fecha;
                dgvClasesParticulares.Rows.Add(filaClase);
            }
            
        }


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente formBuscarCliente = new frmBuscarCliente();
            if (formBuscarCliente.ShowDialog() == DialogResult.OK)
            {
                Cliente = formBuscarCliente.ClienteSeleccionado;
                txtDNI.Text = Cliente.dni;
                txtNombreCliente.Text = Cliente.nombre;
            }
        }

    }
}

﻿using System;
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
    public partial class frmBuscarServicioPorCliente : Form
    {
        private Service.matricula servMat;
        private List<Service.matricula> matriculas;
        public frmBuscarServicioPorCliente(Service.cliente c)
        {
            InitializeComponent();
            dgvMatriculas.AutoGenerateColumns = false;
            Formateador f = new Formateador();
			Paleta p = new Paleta();
			this.BackColor = p.Blanco;
			f.formatearBotonNaranja(btnSeleccionar);
			btnSeleccionar.Top = dgvMatriculas.Top + dgvMatriculas.Height + 10;
			btnSeleccionar.Left = dgvMatriculas.Left + dgvMatriculas.Width - 85;

            IEnumerable<Service.matricula> mats;

            if (c is Service.apoderado)
            {
                mats = Program.dbController.listarMatriculaActivaPorApoderado(c.idPersona);
                
            } else
            {
                mats = Program.dbController.listarMatriculaActivaPorGestante(c.idPersona);
            }

            if (mats != null)
            {
                matriculas = mats.ToList();

                foreach (Service.matricula m in matriculas)
                {
                    Object[] fila = new Object[3];
                    fila[0] = m.servicio.nombre;
                    fila[1] = m.fecha.ToShortDateString();
                    fila[2] = m.saldo;
                    dgvMatriculas.Rows.Add(fila);
                }
            }
            else
            {

                frmMensaje mensaje = new frmMensaje("El cliente no tiene servicios asociados", "Mensaje de advertencia", "");
                this.DialogResult = DialogResult.OK;
                this.Hide();
                
                
            }


        }

        public matricula ServMat { get => servMat; set => servMat = value; }
        public List<matricula> Matriculas { get => matriculas; set => matriculas = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //ServMat = (Service.matricula)dgvMatriculas.CurrentRow.DataBoundItem;
            if (matriculas != null)
            {
                servMat = matriculas[dgvMatriculas.CurrentCell.RowIndex];
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

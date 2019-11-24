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
    public partial class frmAsignarHorario : Form
    {
        private Service.curso curso;
        private BindingList<Service.horario> horarios = new BindingList<Service.horario>();
        private Service.horario horario;
        public frmAsignarHorario()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            dgvHorarios.RowCount = 0;
            f.formatearBotonListar(btnbuscarCurso);
            f.formAsignarHorario(this,"Asignar Horario",pnlCtn,gbCurso,btnAddHorario,btnEliminarHorario,dgvHorarios,btnGuardar);
        }

        private void btnbuscarCurso_Click(object sender, EventArgs e)
        {
            dgvHorarios.RowCount = 0;
            frmBuscarCurso formBuscarCurso = new frmBuscarCurso();
            if (formBuscarCurso.ShowDialog() == DialogResult.OK)
            {
                curso = formBuscarCurso.CursoSeleccionado;
                txtNombreServicio.Text = curso.nombre;


                if (Program.dbController.listarHorariosPorCurso(curso.id_servicio) != null)
                {
                    foreach (Service.horario h in Program.dbController.listarHorariosPorCurso(curso.id_servicio))
                    {
                        horarios.Add(h);
                        Object[] filaHorario = new Object[6];
                        filaHorario[0] = h.horaIni;
                        filaHorario[1] = h.horaFin;
                        if (h.colaborador != null)
                            filaHorario[2] = h.colaborador.nombre;
                        else
                            filaHorario[2] = "-";

                        filaHorario[3] = h.fecha.ToShortDateString();
                        filaHorario[4] = h.sede.direccion;
                        filaHorario[5] = h.numVacantes;
                        dgvHorarios.Rows.Add(filaHorario);
                    }
                }


            }

        }

        private void btnAddHorario_Click(object sender, EventArgs e)
        {
            if (curso == null)
            {
                frmMensaje mensaje = new frmMensaje("Seleccione un curso", "Error", "");
                return;
            }
            frmGestionarHorario formGestionarHorario = new frmGestionarHorario();
            if (formGestionarHorario.ShowDialog() == DialogResult.OK)
            {
                horario = formGestionarHorario.HorarioSeleccionado;

                horarios.Add(horario);
                Object[] filaHorario = new Object[6];
                filaHorario[0] = horario.horaIni;
                filaHorario[1] = horario.horaFin;
                if (horario.colaborador != null)
                    filaHorario[2] = horario.colaborador.nombre;
                else
                    filaHorario[2] = "-";

                filaHorario[3] = horario.fecha.ToShortDateString();
                filaHorario[4] = horario.sede.direccion;
                filaHorario[5] = horario.numVacantes;
                dgvHorarios.Rows.Add(filaHorario);
            }
        }

        private void btnEliminarHorario_Click(object sender, EventArgs e)
        {
            horario = horarios[dgvHorarios.CurrentRow.Index];
            horarios.Remove(horario);
            dgvHorarios.Rows.Remove(dgvHorarios.CurrentRow);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (Service.horario h in horarios)
            {
                Console.WriteLine(h.fecha.ToShortDateString());
                Program.dbController.insertarHorario(h, curso.id_servicio);
            }
            frmMensaje mensaje = new frmMensaje("Horarios registrados", "Mensaje de confirmación", "Confirmar");
        }

        private void dgvHorarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(horarios[dgvHorarios.CurrentRow.Index].sede.direccion);
            horario = horarios[dgvHorarios.CurrentRow.Index];
            frmGestionarHorario formGestionarHorario = new frmGestionarHorario(horario);
            if (formGestionarHorario.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("entra al gestionar horario con un horario");
            }
        }
    }
}

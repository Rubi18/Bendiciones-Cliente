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
    
    public partial class frmAsistenciaCliente : Form
    {
        private BindingList<Service.asistencia> asistencias = new BindingList<Service.asistencia>();
        private BindingList<Service.curso> cursos;
        public frmAsistenciaCliente()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormAsistencia(this, "Asistencia de cliente", pnlCtn, btnRegistrar);
            cboCursos.DataSource = Program.dbController.listarCursosPorNombre("");
            cboCursos.DisplayMember = "Nombre";

            if(Program.dbController.listarClientesDelDia() != null)
            {
                cursos = new BindingList<Service.curso>(Program.dbController.listarClientesDelDia());
            }
            
            if (cursos != null)
            {
                Console.WriteLine("lista de cursos no es nulo");
                foreach (Service.curso c in cursos)
                {
                    if (c.horario != null)
                    {
                        Console.WriteLine("lista de horarios de un curso no es nulo");
                        foreach (Service.horario h in c.horario)
                        {
                            if(h.participantes != null)
                            {
                                Console.WriteLine("lista de clientes de un horario no es nulo");
                                foreach (Service.persona p in h.participantes)
                                {
                                    Object[] fila = new Object[5];
                                    fila[0] = p.dni;
                                    fila[1] = p.nombre;
                                    fila[2] = c.nombre;
                                    fila[3] = h.horaIni.ToShortTimeString();
                                    fila[4] = h.horaFin.ToShortTimeString();
                                    dgvPorAsistir.Rows.Add(fila);
                                    Service.asistencia a = new Service.asistencia();
                                    a.horario = h;
                                    a.persona = p;
                                    asistencias.Add(a);

                                    Console.WriteLine("lista de asistentes: ");
                                    Console.WriteLine(p.nombre);
                                } 

                            }
                            else
                            {
                                Console.WriteLine("lista de asistentes SÍ es nulo");
                            }
                            
                        }
                    }
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(asistencias != null)
            {
                Service.asistencia a = asistencias[dgvPorAsistir.CurrentRow.Index];
                a.asistio = true;
                Program.dbController.actualizarAsistencia(a);
                frmMensaje mensaje = new frmMensaje("Asistencia registrada", "Mensaje de confirmación", "");
            }
            else
            {
                frmMensaje mensaje = new frmMensaje("No hay asistentes el día de hoy", "Mensaje de error", "");
            }
            
        }

        private void cboCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPorAsistir.RowCount = 0;
            if (Program.dbController.listarClientesDelDiaPorCurso(((Service.curso)cboCursos.SelectedItem).id_servicio) != null)
            {
                Console.WriteLine("curso");
                Console.WriteLine(((Service.curso)cboCursos.SelectedItem).nombre);
                cursos = new BindingList<Service.curso>(Program.dbController.listarClientesDelDiaPorCurso(((Service.curso)cboCursos.SelectedItem).id_servicio));
            }
            else
            {
                cursos = null;
                Console.WriteLine("no hay curso");
            }

            if (cursos != null)
            {
                Console.WriteLine("lista de cursos no es nulo");
                foreach (Service.curso c in cursos)
                {
                    if (c.horario != null)
                    {
                        Console.WriteLine("lista de horarios de un curso no es nulo");
                        foreach (Service.horario h in c.horario)
                        {
                            if (h.participantes != null)
                            {
                                Console.WriteLine("lista de clientes de un horario no es nulo");
                                foreach (Service.persona p in h.participantes)
                                {
                                    Object[] fila = new Object[5];
                                    fila[0] = p.dni;
                                    fila[1] = p.nombre;
                                    fila[2] = c.nombre;
                                    fila[3] = h.horaIni.ToShortTimeString();
                                    fila[4] = h.horaFin.ToShortTimeString();
                                    dgvPorAsistir.Rows.Add(fila);
                                    Service.asistencia a = new Service.asistencia();
                                    a.horario = h;
                                    a.persona = p;
                                    asistencias.Add(a);

                                    Console.WriteLine("lista de asistentes: ");
                                    Console.WriteLine(p.nombre);
                                }

                            }
                            else
                            {
                                Console.WriteLine("lista de asistentes SÍ es nulo");
                            }

                        }
                    }
                }
            }
        }
    }
}

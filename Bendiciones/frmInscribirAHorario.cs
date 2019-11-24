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
    public partial class frmInscribirAHorario : Form
    {
        private Service.cliente cliente = new Service.cliente();
        private Service.curso curso;
        private Service.apoderado ap;
        private BindingList<Service.horario> horarios;
        
        public frmInscribirAHorario()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.formatearBotonListar(btnBuscarCliente);
            f.formatearBotonNaranja(btnBuscarHorarios);
            btnBuscarHorarios.Width = 150;
            f.formInscribir(this,"Inscripcion",pnlCtn,gbServicio,btnSeleccionarHorario);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            dgvHorarios.RowCount = 0;
            frmBuscarCliente formBuscarCliente = new frmBuscarCliente();
            if (formBuscarCliente.ShowDialog() == DialogResult.OK)
            {
                cliente = formBuscarCliente.ClienteSeleccionado;
                //Console.WriteLine("idCliente: ");
                //Console.WriteLine(cliente.idPersona);
                txtDNI.Text = cliente.dni;
                txtNombreCliente.Text = cliente.nombre;

                BindingList<Service.matricula> mats = new BindingList<Service.matricula>();

                //si es apoderado, muestra bebés
                if (cliente is Service.apoderado)
                {
                    lblBebe.Visible = true;
                    cboBebes.Visible = true;
                    ap = (Service.apoderado)cliente;
                    if (ap.bebes != null)
                    {
                        BindingList<Service.bebe> bebes = new BindingList<Service.bebe>(ap.bebes);
                        cboBebes.DisplayMember = "Nombre";
                        cboBebes.DataSource = bebes;
                    }

                    if (Program.dbController.listarMatriculaActivaPorApoderado(cliente.idPersona) != null)
                    {
                        Console.WriteLine("apoderado: listar no es null");
                        foreach (Service.matricula m in Program.dbController.listarMatriculaActivaPorApoderado(cliente.idPersona))
                        {
                            Service.bebe b = (Service.bebe)cboBebes.SelectedItem;
                            Console.WriteLine("id bebe seleccionado:");
                            Console.WriteLine(b.idPersona);
                            Console.WriteLine("id bebe de matricula:");
                            Console.WriteLine(m.bebe.idPersona);
                            if (((Service.bebe)cboBebes.SelectedItem).idPersona == m.bebe.idPersona)
                            {
                                mats.Add(m);
                            }
                                
                        }
                        
                        Console.WriteLine("lista mat por apoderado");
                    }

                }
                else   //si es gestante
                {
                    if (Program.dbController.listarMatriculaActivaPorGestante(cliente.idPersona) != null)
                    {
                        Console.WriteLine("gestante: listar no es null");
                        foreach(Service.matricula m in Program.dbController.listarMatriculaActivaPorGestante(cliente.idPersona))
                        {
                            mats.Add(m);
                        }                        
                    }
                    
                    
                }

                cboServicios.DataSource = mats;

                //prueba}
                foreach (Service.matricula m in mats)
                {
                    Console.WriteLine(m.servicio.nombre);
                }


            }
        }

        private void btnBuscarHorarios_Click(object sender, EventArgs e)
        {
            if(cboServicios.SelectedIndex != -1)
            {
                horarios = new BindingList<Service.horario>();
                Service.servicio curso = (Service.servicio)((Service.matricula)cboServicios.SelectedItem).servicio;

                

                if (Program.dbController.listarHorariosPorCurso(curso.id_servicio) != null)
                {
                    foreach (Service.horario h in Program.dbController.listarHorariosPorCurso(curso.id_servicio))
                    {
                        horarios.Add(h);
                        Object[] filaHorario = new Object[6];
                        filaHorario[0] = h.clase;
                        filaHorario[1] = h.sede;
                        filaHorario[2] = h.horaIni.ToShortTimeString();
                        filaHorario[3] = h.horaFin.ToShortTimeString();
                        filaHorario[4] = h.fecha.ToShortDateString();
                        filaHorario[5] = h.numVacantes;
                        dgvHorarios.Rows.Add(filaHorario);

                    }
                }

            }
        }

        private void btnSeleccionarHorario_Click(object sender, EventArgs e)
        {
            if (dgvHorarios.RowCount != 0)
            {
                Service.horario h = horarios[dgvHorarios.CurrentRow.Index];
                Service.asistencia a = new Service.asistencia();

                a.horario = h;

                if (cliente is Service.gestante)
                {
                    a.persona = cliente;
                }
                else
                {
                    a.persona = (Service.persona)cboBebes.SelectedItem;
                }


                Program.dbController.registrarClienteEnHorario(a);
                frmMensaje mensaje = new frmMensaje("Cliente registrado en horario", "Mensaje Confirmación", "");
            }
            
        }
    }
}

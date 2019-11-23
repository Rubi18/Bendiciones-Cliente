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
    public partial class frmAsistenciaColaborador : Form
    {
        private Service.colaborador colab;
        private BindingList<Service.curso> cursos;

        public frmAsistenciaColaborador()
        {
            InitializeComponent();
            Formateador f = new Formateador();
            f.iniFormAsistencia(this,"Asistencia de Colaborador",pnlCtn,btnRegistrar);
            cursos = new BindingList<Service.curso>(Program.dbController.listarDocentesDelDia());
            if(cursos != null)
            {
                Console.WriteLine("lista de cursos no es nulo");
                foreach (Service.curso c in cursos)
                {
                    if(c.horario != null)
                    {
                        Console.WriteLine("lista de horarios de un curso no es nulo");
                        foreach (Service.horario h in c.horario)
                        {
                            //if(h.participantes != null)
                            //{
                            //    Console.WriteLine("lista de clientes de un horario no es nulo");
                            //    foreach (Service.persona p in h.participantes)
                            //    {
                            //        Object[] fila = new Object[5];
                            //        fila[0] = p.dni;
                            //        fila[1] = p.nombre;
                            //        fila[2] = c.nombre;
                            //        fila[3] = h.horaIni.ToShortTimeString();
                            //        fila[4] = h.horaFin.ToShortTimeString();
                            //        dgvPorAsistir.Rows.Add(fila);


                            //        Console.WriteLine("lista de asistentes: ");
                            //        Console.WriteLine(p.nombre);
                            //    } 

                            //}
                            //else
                            //{
                            //    Console.WriteLine("lista de asistentes SÍ es nulo");
                            //}
                            Object[] fila = new Object[5];
                            fila[0] = h.colaborador.dni;
                            fila[1] = h.colaborador.nombre;
                            fila[2] = c.nombre;
                            fila[3] = h.horaIni.ToShortTimeString();
                            fila[4] = h.horaFin.ToShortTimeString();
                            dgvPorAsistir.Rows.Add(fila);
                        }
                    }
                }
            }
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //suponemos que no ingresa filtro

        }
    }
}

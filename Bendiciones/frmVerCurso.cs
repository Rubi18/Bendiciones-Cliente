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
    public partial class frmVerCurso : Form
    {
        public frmVerCurso()
        {
            InitializeComponent();

            Paleta paleta = new Paleta();
            this.BackColor = paleta.Blanco;

            Margenes mrg = new Margenes();
            lblNombreCurso.Location = new Point(mrg.MargenTituloForm, mrg.MargenTituloForm);

            lblDescripcionCurso.Location = new Point(mrg.MargenTituloForm+mrg.MargenPequeño, mrg.MargenTituloForm+ lblNombreCurso.Height+mrg.MargenPequeño * 2);

            lblDescripcionCurso.Width = 200; 

            btnMasInfo.BackColor = paleta.Naranja;
            btnMasInfo.ForeColor = paleta.Blanco;
            btnMasInfo.Height    = 40;
            btnMasInfo.Width     = 150;
            btnMasInfo.Font      = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnMasInfo.Location  = new Point(lblDescripcionCurso.Location.X + (lblDescripcionCurso.Width-btnMasInfo.Width)/2,380);

            /*
            btnAcercaProfes.BackColor = paleta.Naranja;
            btnAcercaProfes.ForeColor = paleta.Blanco;
            btnAcercaProfes.Height = 40;
            btnAcercaProfes.Width = 150;
            btnAcercaProfes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
            btnAcercaProfes.Location  = new Point(lblDescripcionCurso.Location.X + (lblDescripcionCurso.Width-btnAcercaProfes.Width)/2 ,btnMasInfo.Location.Y+btnMasInfo.Height+mrg.MargenPequeño/2);
            */

            tabCurso.Location = new Point(lblDescripcionCurso.Location.X+lblDescripcionCurso.Width + 40, lblDescripcionCurso.Location.Y);
            tabCurso.Height = 340;
            tabCurso.Width = this.Width - 30 - tabCurso.Location.X;
            
            btnRegistrarHorario.BackColor = paleta.Lila;
            btnRegistrarHorario.ForeColor = paleta.Marron;
            btnRegistrarHorario.Height = 40;
            btnRegistrarHorario.Width = 150;
            btnRegistrarHorario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
            btnRegistrarHorario.Location = new Point(dgHorarios.Location.X +dgHorarios.Width - btnRegistrarHorario.Width, tabCurso.Height - btnRegistrarHorario.Height - mrg.MargenPequeño*2);

            /*
            Form frmMdiFrame = new Form();
            frmMdiFrame.FormBorderStyle = FormBorderStyle.None;
            frmMdiFrame.StartPosition = FormStartPosition.Manual;
            frmMdiFrame.Location = new Point(0, 0);
            frmMdiFrame.Height = 540;
            frmMdiFrame.Width = 880;
            frmMdiFrame.IsMdiContainer = true; 
            frmMdiFrame.Parent = this;
            frmMdiFrame.Visible = true;
            */

            dgHorarios.BackgroundColor = paleta.Amarillo;
        }

        private void btnRegistrarHorario_Click(object sender, EventArgs e)
        {

        }

        private void dgHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblHorarios_Click(object sender, EventArgs e)
        {
               
        }


        private void btnMasInfo_Click(object sender, EventArgs e)
        {

            ___frmInfoCurso formInfoCurso = new ___frmInfoCurso();
            formInfoCurso.MdiParent = this.ParentForm;
            formInfoCurso.FormBorderStyle = FormBorderStyle.None;
            formInfoCurso.Dock = DockStyle.Fill;
            formInfoCurso.Visible = true;
        }

        private void btnRegistrarHorario_Click_1(object sender, EventArgs e)
        {
            
            frmGestionarHorario formRegistrarHorario = new frmGestionarHorario();
            formRegistrarHorario.Visible = true;
        }

        private void lblProfesores_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

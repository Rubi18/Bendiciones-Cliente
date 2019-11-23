using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bendiciones
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            byte[] arreglo
                = Program.dbController.generarReporteServicioPDF(Int32.Parse((String)cboMeses.SelectedItem), Int32.Parse((String)cboYears.SelectedItem));
            File.WriteAllBytes(saveFileDialog1.FileName
                + ".pdf", arreglo);
        }
    }
}

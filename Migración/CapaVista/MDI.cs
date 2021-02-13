using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void gestionarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuCita Boleta = new frmMenuCita(this);
            Boleta.MdiParent = this;
            Boleta.Show();
        }

        private void generarPasaporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

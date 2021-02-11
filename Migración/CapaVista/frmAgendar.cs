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
    public partial class frmAgendar : Form
    {
        static Form FormularioPadre;
        public frmAgendar(Form formularioPadre)
        {
            InitializeComponent();
            FormularioPadre = formularioPadre;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgendarCita Confirmar = new frmAgendarCita(FormularioPadre);
            Confirmar.MdiParent = FormularioPadre;
            Confirmar.Show();
        }
    }
}

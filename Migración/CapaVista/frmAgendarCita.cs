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
    public partial class frmAgendarCita : Form
    {
        static Form FormularioPadre;
        public frmAgendarCita(Form formularioPadre)
        {
            InitializeComponent();
            FormularioPadre = formularioPadre;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmConfirmacionDeCita Confirmar = new frmConfirmacionDeCita(FormularioPadre);
            Confirmar.MdiParent = FormularioPadre;
            Confirmar.Show();

        }
    }
}

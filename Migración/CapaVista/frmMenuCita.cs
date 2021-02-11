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
    public partial class frmMenuCita : Form
    {
        static Form FormularioPadre;
        public frmMenuCita(Form formularioPadre)
        {
            InitializeComponent();
            FormularioPadre = formularioPadre;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmValidarBoleta Validar = new frmValidarBoleta(FormularioPadre);
            Validar.MdiParent = FormularioPadre;
            Validar.Show();
        }
    }
}

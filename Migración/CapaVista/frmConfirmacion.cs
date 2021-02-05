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
    public partial class frmConfirmacion : Form
    {
       static Form FormularioPadre;
        public frmConfirmacion(Form formularioPadre)
        {
            InitializeComponent();
            FormularioPadre = formularioPadre;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmAgendar Confirmar = new frmAgendar(FormularioPadre);
            Confirmar.MdiParent = FormularioPadre;
            Confirmar.Show();
        }
    }
}

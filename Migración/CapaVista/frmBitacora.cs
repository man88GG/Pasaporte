using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Odbc;
using CapaControlador;

namespace CapaVista
{
    public partial class frmBitacora : Form
    {
        string emp = "BITACORA";
        ClsControlador cn = new ClsControlador();
        public frmBitacora()
        {
            InitializeComponent();
        }
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            dgvBitacora.DataSource = dt;

        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}

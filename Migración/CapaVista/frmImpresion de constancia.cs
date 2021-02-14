using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frmImpresion_de_constancia : Form
    {
        ClsControlador Cn = new ClsControlador();
        static Form FormularioPadre;
        int IDCITA = 0;
        int IDDATOSPERSONALES = 0;
        int IDBOLETABANCO = 0;
        int DOCUMENTODPI = 0;
        public frmImpresion_de_constancia(Form formularioPadre,int idCita,int idDatos,int CodigoBoleta, int DPI)
        {
            InitializeComponent();
            FormularioPadre = formularioPadre;
             IDCITA = idCita;
             IDDATOSPERSONALES = idDatos;
             IDBOLETABANCO = CodigoBoleta;
             DOCUMENTODPI = DPI;
        }

        public void actualizarData()
        {
           
            string consulta = "select P.idProgramarCita,B.numeroRecibo,B.numeroBoleta,R.nombres,R.apellidos from programarcita P,datospersonales D,boletabanco B,renap R where P.idDatosPersonales = D.idDatosPersonales and D.idBoletaBanco = B.idBoleta and D.dpi = R.dpi AND P.idProgramarCita = "+IDCITA+" and D.idDatosPersonales = "+IDDATOSPERSONALES+" and D.idBoletaBanco = "+IDBOLETABANCO+" ;";
            DataTable dt = Cn.enviar(consulta);
            dgvDatos.DataSource = dt;
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmImpresion_de_constancia_Load(object sender, EventArgs e)
        {
            actualizarData();
        }
    }
}

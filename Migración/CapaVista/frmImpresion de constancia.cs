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

        int IDCITA = 0;
        int IDDATOSPERSONALES = 0;
        int IDBOLETABANCO = 0;
        int DOCUMENTODPI = 0;
        string consulta = "";
        public frmImpresion_de_constancia(int idCita,int idDatos,int CodigoBoleta, int DPI)
        {
            InitializeComponent();
 
             IDCITA = idCita;
             IDDATOSPERSONALES = idDatos;
             IDBOLETABANCO = CodigoBoleta;
             DOCUMENTODPI = DPI;
        }

      
        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmImpresion_de_constancia_Load(object sender, EventArgs e)
        {
            actualizarData();
        }

        public void actualizarData()
        {

            consulta = "select P.idProgramarCita as CODIGO_CITA,B.numeroRecibo AS NUMERO_RECIBO,B.numeroBoleta as NUMERO_BOLETA,R.nombres as NOMBRES,R.apellidos as APELLIDOS from programarcita P,datospersonales D,boletabanco B,renap R where P.idDatosPersonales = D.idDatosPersonales and D.idBoletaBanco = B.idBoleta and D.dpi = R.dpi AND P.idProgramarCita = " + IDCITA + " and D.idDatosPersonales = " + IDDATOSPERSONALES + " and D.idBoletaBanco = " + IDBOLETABANCO + " and D.dpi = " + DOCUMENTODPI + " and P.estado = 1;";
            DataTable dt = Cn.enviar(consulta);
            dgvDatos.DataSource = dt;
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+IDCITA+""+IDDATOSPERSONALES+""+IDBOLETABANCO+""+DOCUMENTODPI);

        }
    }
}

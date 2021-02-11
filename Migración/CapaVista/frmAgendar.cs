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
    public partial class frmAgendar : Form
    {
        ClsControlador Cn = new ClsControlador();
        static Form FormularioPadre;
        string idBoleta, DocumentoDeIdentificacion;
        public frmAgendar(Form formularioPadre,string IDboletaBanco,string DPI)
        {
            InitializeComponent();
            FormularioPadre = formularioPadre;
            idBoleta = IDboletaBanco;
            DocumentoDeIdentificacion = DPI;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmAgendar_Load(object sender, EventArgs e)
        {
            actualizarData();
        }

        public void actualizarData()
        {
            int idCodigoBoleta = Int32.Parse(idBoleta);
            int Dpi = Int32.Parse(DocumentoDeIdentificacion);
            string consulta = "Select D.idDatosPersonales as Codigo,B.numeroBoleta as Numero_De_Boleta,B.numeroRecibo as Numero_De_Recibo,R.nombres as Nombres,R.apellidos as Apellidos,R.dpi as No_Documento from renap R, datospersonales D,boletabanco B WHERE B.idBoleta = D.idBoletaBanco and R.dpi = D.dpi and D.idBoletaBanco = "+idCodigoBoleta+" and D.dpi = "+Dpi+" ;";
            DataTable dt = Cn.enviar(consulta);
            dtvDatosUsuario.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgendarCita Confirmar = new frmAgendarCita(FormularioPadre);
            Confirmar.MdiParent = FormularioPadre;
            Confirmar.Show();
        }
    }
}

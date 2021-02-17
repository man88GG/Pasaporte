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
            string consulta = "Select D.idDatosPersonales as Codigo,B.numeroBoleta as Numero_De_Boleta,B.numeroRecibo as Numero_De_Recibo,R.nombres as Nombres,R.apellidos as Apellidos,R.dpi as No_Documento from renap R, datospersonales D,boletabanco B WHERE B.idBoleta = D.idBoletaBanco and R.dpi = D.dpi and D.idBoletaBanco = "+idCodigoBoleta+" and D.dpi = "+Dpi+" and estado = 1;";
            DataTable dt = Cn.enviar(consulta);
            dtvDatosUsuario.DataSource = dt;
        }

        private void dtvDatosUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigo.Text = dtvDatosUsuario.CurrentRow.Cells[0].Value.ToString();
        }

   

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lblCodigo.Text == "Codigo")
            {
                MessageBox.Show("Debe seleccionar un codigo de la tabla.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar a este usuario?, Si lo elimina debera podra volver a usar su boleta bancaria pero debera ingresar todos sus datos nuevamente.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.OK)
                {
                    int codigo = Int32.Parse(lblCodigo.Text);
                    string sql = "UPDATE DATOSPERSONALES SET ESTADO = 0 WHERE idDatosPersonales = " + codigo + ";";
                    Cn.Modificar(sql);
                    this.Close();
                    MessageBox.Show("Usuario eliminado Correctamente.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    frmMenuCita Validar = new frmMenuCita(FormularioPadre);
                    Validar.MdiParent = FormularioPadre;
                    Validar.Show();
                }
            }
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            if (lblCodigo.Text == "Codigo")
            {
                MessageBox.Show("Debe seleccionar un codigo de la tabla.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                return;
            }
            else
            {
                int CodigoBoletaBanco = Int32.Parse(idBoleta);
                int DocumentoDPI = Int32.Parse(DocumentoDeIdentificacion);
                int idDatosPersonales = Int32.Parse(lblCodigo.Text);
                frmAgendarCita Confirmar = new frmAgendarCita(FormularioPadre, idDatosPersonales,CodigoBoletaBanco,DocumentoDPI);
                Confirmar.MdiParent = FormularioPadre;
                Confirmar.Show();
                this.Close();
            }
        }

      
    }
}

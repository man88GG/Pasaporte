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
        Form formularioMDI;
        public frmImpresion_de_constancia(Form FormularioPadre,int idCita,int idDatos,int CodigoBoleta, int DPI)
        {
            InitializeComponent();
 
             IDCITA = idCita;
             IDDATOSPERSONALES = idDatos;
             IDBOLETABANCO = CodigoBoleta;
             DOCUMENTODPI = DPI;
            formularioMDI = FormularioPadre;
        }

      
        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigo.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
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
         
        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            if (lblCodigo.Text == "Codigo")
            {
                MessageBox.Show("Para cancelar debe seleccinar un registro de la tabla.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea cancelar la cita?, si la cancela debera agendar una nueva y puede que la fecha anterior sea ocupada.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.OK)
                {
                    int codigo = Int32.Parse(lblCodigo.Text);
                    string sql = "UPDATE PROGRAMARCITA SET ESTADO = 0 WHERE idProgramarCita = " + codigo + ";";
                    Cn.Modificar(sql);
                    this.Close();
                    MessageBox.Show("Cita Cancelada Exitosamente.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    frmMenuCita Validar = new frmMenuCita(formularioMDI);
                    Validar.MdiParent = formularioMDI;
                    Validar.Show();
                }
            }
        }
    }
}

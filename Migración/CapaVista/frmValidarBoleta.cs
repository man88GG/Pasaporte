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
    public partial class frmValidarBoleta : Form
    {
        ClsControlador Cn = new ClsControlador();
        static Form FormularioPadre;
        int GestionarObuscar;
        public frmValidarBoleta(Form formularioPadre,int Proceso)
        {
            InitializeComponent();
            FormularioPadre = formularioPadre;
            GestionarObuscar = Proceso;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtBoleta.Text.Length == 0 || txtRecibo.Text.Length == 0)
            {
                MessageBox.Show("No debe dejar Campos Vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if(txtBoleta.Text.Length > 10)
            {
                MessageBox.Show("El numero de la Boleta no puede Exceder los 10 Digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtRecibo.Text.Length > 10)
            {
                MessageBox.Show("El numero del Recibo no puede Exceder los 10 Digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int numeroBoleta = Int32.Parse(txtBoleta.Text);
                int numeroRecibo = Int32.Parse(txtRecibo.Text);
                int CodigoBoleta = Cn.funcObtenerCodigoBoleta(numeroRecibo,numeroBoleta);
                string sql = "SELECT D.dpi from datospersonales D, boletabanco B where D.idBoletaBanco = B.idBoleta and D.idBoletaBanco = "+CodigoBoleta+" ;";     
                string Dpi = Cn.CualquierDato(sql);
                string sqlIdPersona = "SELECT idDatosPersonales FROM datospersonales WHERE dpi = " + Dpi + " and idBoletaBanco = "+CodigoBoleta+" and estado = 1;";
                string idDatosPersona = Cn.CualquierDato(sqlIdPersona);
                if (GestionarObuscar == 1)
                {
                    if (CodigoBoleta == 0)
                    {
                        MessageBox.Show("Boleta no Valida, verifique que los datos este ingresados correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if(idDatosPersona != "")
                    {
                        MessageBox.Show("Esta Boleta ya ha sido utilizada, pruebe con la opcion de Buscar Boleta.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Boleta Valida.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmInformacion Validar = new frmInformacion(FormularioPadre, CodigoBoleta);
                        Validar.MdiParent = FormularioPadre;
                        Validar.Show();
                    }
                } else if(GestionarObuscar == 2)
                {
                    if (CodigoBoleta == 0)
                    {
                        MessageBox.Show("Boleta no Valida, verifique que los datos este ingresados correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string idBoleta = CodigoBoleta.ToString();
                        MessageBox.Show("Boleta Valida.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmAgendar Validar = new frmAgendar(FormularioPadre, idBoleta, Dpi);
                        Validar.MdiParent = FormularioPadre;
                        Validar.Show();
                    }
                }
            }


        }

        private void txtBoleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //revisa que puede ingresar letras, tecla de borrar o espacio
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //revisa que puede ingresar letras, tecla de borrar o espacio
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}

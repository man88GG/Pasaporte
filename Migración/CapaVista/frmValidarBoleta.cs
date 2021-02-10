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
        public frmValidarBoleta(Form formularioPadre)
        {
            InitializeComponent();
            FormularioPadre = formularioPadre;
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
                if (CodigoBoleta == 0)
                {
                    MessageBox.Show("Boleta no Valida, verifique que los datos este ingresados correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Boleta Valida.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmInformacion Validar = new frmInformacion(FormularioPadre,CodigoBoleta);
                    Validar.MdiParent = FormularioPadre;
                    Validar.Show();
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

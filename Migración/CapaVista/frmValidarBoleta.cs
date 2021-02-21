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
using CapaVistaSeguridad;

namespace CapaVista
{
    public partial class frmValidarBoleta : Form
    {
        ClsControlador Cn = new ClsControlador();
        static Form FormularioPadre;
        int GestionarObuscar;
        string idDatosPersona = "";
        string Dpi = "";
        string idCita = "";
        string idBoleta = "";
        int CodigoBoleta;
        clsVistaBitacora bit = new clsVistaBitacora();
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
                CodigoBoleta = Cn.funcObtenerCodigoBoleta(numeroRecibo,numeroBoleta);
                string sql = "SELECT D.dpi from datospersonales D, boletabanco B where D.idBoletaBanco = B.idBoleta and D.idBoletaBanco = "+CodigoBoleta+" and estado = 1;";
            
                Dpi = Cn.CualquierDato(sql);
                if(Dpi != "")
                {
                    string sqlIdPersona = "SELECT idDatosPersonales FROM datospersonales WHERE dpi = " + Dpi + " and idBoletaBanco = " + CodigoBoleta + " and estado = 1 ;";
                    idDatosPersona = Cn.CualquierDato(sqlIdPersona);
                  
                }
                if(idDatosPersona != "")
                {
                    string sqlidCita = "SELECT idProgramarCita from programarcita P,datospersonales D,boletabanco B where P.idDatosPersonales = D.idDatosPersonales and D.idBoletaBanco = B.idBoleta and D.idDatosPersonales = " + idDatosPersona + " and D.idBoletaBanco = " + CodigoBoleta + " and P.estado = 1";
                    idCita = Cn.CualquierDato(sqlidCita);
              
                }
                //si gestionarObuscar es igual a 1, la boleta no contiene datos del usuario, por lo que se tendran que ingresar sus datos
                if (GestionarObuscar == 1)
                {
                    bit.insert("Validacion de boleta - Gestionar cita", 12);
                    if (CodigoBoleta == 0)
                    {
                        MessageBox.Show("Boleta no Valida, verifique que los datos este ingresados correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        return;
                    }
                    if(idDatosPersona != "")
                    {
                        MessageBox.Show("Esta Boleta ya ha sido utilizada, pruebe con la opcion de Buscar.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idDatosPersona = "";
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Boleta Valida.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmInformacion Validar = new frmInformacion(FormularioPadre, CodigoBoleta);
                        Validar.MdiParent = FormularioPadre;
                        Validar.Show();
                        this.Close();
                       
                    } 
                } else if(GestionarObuscar == 2)
                //si gestionarObuscar es igual a 2, la boleta ya contiene datos del usuario, por lo que verificara si tiene cita o no

                {
                    bit.insert("Validacion de boleta - Buscar Cita o usuario", 12);
                    if (CodigoBoleta == 0)
                    {
                        MessageBox.Show("Boleta no Valida, verifique que los datos este ingresados correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (Dpi == "")
                    {
                        MessageBox.Show("Esta boleta no contiene un registro aun, verifique que los datos este ingresados correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(idCita == "")
                        {
                            idBoleta = CodigoBoleta.ToString();
                            MessageBox.Show("Boleta Valida.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmAgendar Validar = new frmAgendar(FormularioPadre, idBoleta, Dpi);
                            Validar.MdiParent = FormularioPadre;
                            Validar.Show();
                        this.Close();
                        
                    }
                    else if(idCita != "")
                        {
                            int Cita = Int32.Parse(idCita);
                            int idDatos = Int32.Parse(idDatosPersona);
                            int idCodigoBoleta = CodigoBoleta;
                            int idDpi = Int32.Parse(Dpi);
                            frmImpresion_de_constancia Nuevo = new frmImpresion_de_constancia(FormularioPadre,Cita,idDatos,idCodigoBoleta,idDpi);
                            Nuevo.MdiParent = FormularioPadre;
                            Nuevo.Show();
                        this.Close();
                       
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea cancelar la accion y regresar al menu principal?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.OK)
            {

                txtBoleta.Text = "";
                txtRecibo.Text = "";
                frmMenuCita Validar = new frmMenuCita(FormularioPadre);
                Validar.MdiParent = FormularioPadre;
                Validar.Show();
                this.Close();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaMigracionCitas/AyudaCitas.chm", "validacion.html");
        }
    }
}

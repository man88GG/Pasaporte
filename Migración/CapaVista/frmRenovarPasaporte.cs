using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaControlador;

namespace CapaVista
{
    public partial class frmRenovarPasaporte : Form
    {

        ClsControlador Cont = new ClsControlador();

        public frmRenovarPasaporte()
        {
            InitializeComponent();
            funcLlenarTipoPass();
            CmbTipoPass.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbAutoridad.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbAutoridad.SelectedIndex = +1;
        }
        //función para llenar el contenido de la tabla hacia el combo
        public void funcLlenarTipoPass()
        {
            DataTable Datos = Cont.funcCmbTipoPass();
            CmbTipoPass.DataSource = Datos;
            CmbTipoPass.DisplayMember = "TIPOPASAPORTE";
            CmbTipoPass.ResetText();
        }




        String IdPass;

        //Variables para sentencias SQL
        //Falta consultar lo de firma y foto
        string NumLibreta, FechaC, FechaV, Firma, LugarNac, Autoridad;

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (TxtIdPass.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //se desbloquean los componentes en los que se puede agregar/cambiar información
                BtnIngresar.Enabled = true;
                funcDesBloqueo();

                IdPass = TxtIdPass.Text;

                //Inicio para Busqueda
                OdbcDataReader Lector = Cont.funcBuscarPass(TxtIdPass.Text);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {

                        //Se agrega el valor del lector a los textbox dependiendo la posicion 
                        TxtNombres.Text = Lector.GetString(0);
                        TxtApellidos.Text = Lector.GetString(1);
                        DtpFechaNac.Text = Lector.GetString(2);
                        CmbDepto.Text = Lector.GetString(3);
                        CmbMuni.Text = Lector.GetString(4);
                        TxtNumPasaporte.Text = Lector.GetString(5);
                        TxtNumLibreta.Text = Lector.GetString(6);
                        TxtNumDpi.Text = Lector.GetString(7);
                        DtpCreacion.Text = Lector.GetString(8);
                        DtpVencimiento.Text = Lector.GetString(9);
                        CmbTipoPass.Text = Lector.GetString(10);
                        CmbAutoridad.Text = Lector.GetString(11);
                        TxtNacimiento.Text = Lector.GetString(12);
                    }
                }
                else
                {
                    //Mensaje de error
                    MessageBox.Show("ERROR: El Id del Pasaporte no se encuentra Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    funcBloqueo();
                    funcLimpieza();
                }

            }//fin ifelse
        }

       

        int NumPass, TipoPass, Estado = 1;


        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //segunda verificación de datos de cajas de texto vacias
            if (TxtIdPass.Text == "" ) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {


                //Mensaje de Pregunta
                if (MessageBox.Show("¿Desea Renovar este Pasaporte ?", "Pasaporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {

                    //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                    //datos Pasaporte

                    FechaC = DtpCreacion.Value.Date.ToShortDateString();
                    FechaV = DtpVencimiento.Value.Date.ToShortDateString();
                    TipoPass = CmbTipoPass.SelectedIndex + 1;
                    //Firma
                    //LugarNac
                    //revisar lo de autoridad de string o int
                    Autoridad = CmbAutoridad.SelectedItem.ToString();
                    
                    //falta lo de firma, lugar nac
                    Cont.FuncActualizarPasaporte(FechaC, FechaV, TipoPass, Autoridad, Estado);
                    MessageBox.Show("Se ha renovado el Pasaporte con Éxito", "RENOVACION PASAPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtIdPass.Text = "";
                    funcLimpieza();
                    funcBloqueo();

                    //envío de datos hacia capa Controlador


                }//fin elseif Pregunta

            }//fin elseif txt

        }

        private void funcLimpieza()
        {
            
            TxtNumDpi.Text = "";
            TxtNombres.Text = "";
            TxtApellidos.Text = "";
            CmbDepto.Text = "";
            CmbMuni.Text = "";
            DtpFechaNac.Value = DateTime.Now;
            TxtNacimiento.Text = "";
            TxtNumPasaporte.Text = "";
            TxtNumLibreta.Text = "";
            CmbTipoPass.Text = "";
            CmbAutoridad.Text = "";
            DtpCreacion.Value = DateTime.Now;
            DtpVencimiento.Value = DateTime.Now;

            //PbxFoto.Image.Dispose();
            //PbxFoto.Image = nothing;

        }

        //Función de Bloqueo
        private void funcBloqueo()
        {

           
            CmbTipoPass.Enabled = false;
            CmbAutoridad.Enabled = false;
            DtpCreacion.Enabled = false;
            DtpVencimiento.Enabled = false;
            PbxFoto.Enabled = false;

        }
        private void funcDesBloqueo()
        {

           
            CmbTipoPass.Enabled = true;
            CmbAutoridad.Enabled = true;
            DtpCreacion.Enabled = true;
            DtpVencimiento.Enabled = true;
            PbxFoto.Enabled = true;

        }

    }
}

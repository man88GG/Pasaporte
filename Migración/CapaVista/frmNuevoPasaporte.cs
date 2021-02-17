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
    public partial class frmNuevoPasaporte : Form
    {

        ClsControlador Cont = new ClsControlador();

        public frmNuevoPasaporte()
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

        String DpiCliente;
       
        
        //Variables para sentencias SQL
        
        string NumLibreta, FechaC, FechaV, Firma, LugarNac,Autoridad, LinkFotografía;
        int NumPass, TipoPass, Estado=1;

        private void BtnFoto_Click(object sender, EventArgs e)
        {

        }

        private void GbxLugarNac_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (TxtNumDpi.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //se desbloquean los componentes en los que se puede agregar/cambiar información
                BtnIngresar.Enabled = true;
                funcDesBloqueo();

                DpiCliente = TxtNumDpi.Text;

                //Inicio para Busqueda
                OdbcDataReader Lector = Cont.funcBuscarPersona(TxtNumDpi.Text);
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
                        
                    }
                }
                else
                {
                    //Mensaje de error
                    MessageBox.Show("ERROR: El DPI de esa persona no se encuentra Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    funcBloqueo();
                    funcLimpieza();
                }

            }//fin ifelse
        }

        private void funcLimpieza()
        {
            TxtNacimiento.Text = "";
            TxtNumDpi.Text = "";
            TxtNombres.Text = "";
            TxtApellidos.Text = "";
            CmbDepto.Text = "";
            CmbMuni.Text = "";
            DtpFechaNac.Value = DateTime.Now;
            TxtLinkFotografía.Text = "";
            TxtNumPasaporte.Text = "";
            TxtNumLibreta.Text = "";
            CmbTipoPass.Text = "";
            CmbAutoridad.Text = "";
            DtpCreacion.Value = DateTime.Now;
            DtpVencimiento.Value = DateTime.Now;

            

        }

        //Función de Bloqueo
        private void funcBloqueo()
        {
            TxtNacimiento.Enabled = false;
            TxtNumPasaporte.Enabled = false;
            TxtNumLibreta.Enabled = false;
            CmbTipoPass.Enabled = false;
            CmbAutoridad.Enabled = false;
            DtpCreacion.Enabled = false;
            DtpVencimiento.Enabled = false;
            
            TxtLinkFotografía.Enabled = false;

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

            
                //segunda verificación de datos de cajas de texto vacias
                if (TxtNumPasaporte.Text == "" || TxtNumLibreta.Text == "" || TxtNacimiento.Text == "" ||TxtLinkFotografía.Text =="" ) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                   

                    //Mensaje de Pregunta
                    if (MessageBox.Show("¿Desea agregar un nuevo Registro de Pasaporte ?", "Pasaporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                    else
                    {


                    //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                    //datos Pasaporte

           
                    NumPass = Convert.ToInt32(TxtNumPasaporte.Text);
                    NumLibreta = TxtNumLibreta.Text;
                    
                    FechaC = DtpCreacion.Value.Date.ToShortDateString();
                    FechaV = DtpVencimiento.Value.Date.ToShortDateString();
                    TipoPass = CmbTipoPass.SelectedIndex + 1;
                    //Firma
                    LinkFotografía = TxtLinkFotografía.Text;
                    LugarNac = TxtNacimiento.Text;
                    
                    Autoridad = CmbAutoridad.SelectedItem.ToString();

                    
                    Cont.funcInsertarPasaporte(NumPass, NumLibreta, DpiCliente, FechaC, FechaV, TipoPass, LinkFotografía,LugarNac, Autoridad, Estado);
                    MessageBox.Show("Se ha ingresado el Pasaporte con Éxito", "INGRESO PASAPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    funcLimpieza();
                    funcBloqueo();

                    //envío de datos hacia capa Controlador



                }//fin elseif Pregunta

                }//fin elseif txt
                 
        }

        private void funcDesBloqueo()
        {
            TxtLinkFotografía.Enabled = true;
            TxtNacimiento.Enabled = true;
            TxtNumPasaporte.Enabled = true;
            TxtNumLibreta.Enabled = true;
            CmbTipoPass.Enabled = true;
            CmbAutoridad.Enabled = true;
            DtpCreacion.Enabled = true;
            DtpVencimiento.Enabled = true;
            

        }


    }
}

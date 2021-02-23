using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador.Pasaporte;

namespace CapaVista
{
    public partial class frmListadoPasaportes : Form
    {
        public frmListadoPasaportes()
        {
            InitializeComponent();
            funcMostrarTabla();

        }
        
        int Estado = 0;
        ClsControladorPasaporte Cont = new ClsControladorPasaporte();

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            //Se llama a la funcion funcLimpiezaRbtn
            funcLimpiezaRbtn();
            //Se llama a la funcion funcLimpieza
            funcLimpieza();
            //Se llama a la funcion funcBloqueoTxt
            funcBloqueoTxt();
            //Se llama a la funcion funcMostrarTabla
            funcMostrarTabla();
        }
        //función que bloquea todos los txt
        public void funcBloqueoTxt()
        {
            
            TxtIdPass.Enabled = false;
            TxtNumPass.Enabled = false;
            TxtNumLib.Enabled = false;    

        }

        //función que limpia todos los texbox
        public void funcLimpieza()
        {
            
            TxtIdPass.Text = "";
            TxtNumPass.Text = "";
            TxtNumLib.Text = "";
 
        }

        //funcion que limpia todos los radiobuttons(les quita la seleccion)
        public void funcLimpiezaRbtn()
        {
            RbtnId.Checked = false;
            RbtnNumPass.Checked = false;
            RbtnNumLib.Checked = false;

        }

        //función para cambiarle el nombre a las columnas del datagrid al momento de mostrar todos los datos
        public void funcNombresEncabezados()
        {
            DgvMostrarPasaportes.Columns[0].HeaderText = "Codigo ID";
            DgvMostrarPasaportes.Columns[1].HeaderText = "Numero Pasaporte";
            DgvMostrarPasaportes.Columns[2].HeaderText = "Numero Libreta";
            DgvMostrarPasaportes.Columns[3].HeaderText = "Fecha Creacion";
            DgvMostrarPasaportes.Columns[4].HeaderText = "Fecha Vencimiento";
            DgvMostrarPasaportes.Columns[5].HeaderText = "Tipo Pasaporte";
            DgvMostrarPasaportes.Columns[6].HeaderText = "Autoridad";
   

        }

        public void funcMostrarTabla()
        {


            DataTable dt = Cont.FuncListadoPasaporte(Estado);
            DgvMostrarPasaportes.DataSource = dt;
            funcNombresEncabezados();

        }

        //se agrega una condicion if para limpiar todos los textbox con contenido, se bloquean todos excepto el correspondiente al radiobutton
        private void RbtnId_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnId.Checked == true)
            {
                //se llama a la funcion funcLimpieza
                funcLimpieza();
                //se llama a la funcion funcBloqueoTxt
                funcBloqueoTxt();
                //se desbloquea el textbox correspondiente al radiobutton
                TxtIdPass.Enabled = true;
            }
        }//
         //se agrega una condicion if para limpiar todos los textbox con contenido, se bloquean todos excepto el correspondiente al radiobutton
        private void RbtnNumPass_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnNumPass.Checked == true)
            {
                //se llama a la funcion funcLimpieza
                funcLimpieza();
                //se llama a la funcion funcBloqueoTxt
                funcBloqueoTxt();
                //se desbloquea el textbox correspondiente al radiobutton
                TxtNumPass.Enabled = true;
            }
        }//

        //se agrega una condicion if para limpiar todos los textbox con contenido, se bloquean todos excepto el correspondiente al radiobutton
        private void RbtnNumLib_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnNumLib.Checked == true)
            {
                //se llama a la funcion funcLimpieza
                funcLimpieza();
                //se llama a la funcion funcBloqueoTxt
                funcBloqueoTxt();
                //se desbloquea el textbox correspondiente al radiobutton
                TxtNumLib.Enabled = true;
            }
        }//

        private void TxtIdPass_KeyUp(object sender, KeyEventArgs e)
        {
            string Parametro = TxtIdPass.Text;
            DataTable dt = Cont.FuncListadoPasaporteId(Estado, Parametro);
            DgvMostrarPasaportes.DataSource = dt;
            funcNombresEncabezados();
        }

        private void TxtNumPass_KeyUp(object sender, KeyEventArgs e)
        {
            string Parametro = TxtNumPass.Text;
            DataTable dt = Cont.FuncListadoPasaporteNumPass(Estado, Parametro);
            DgvMostrarPasaportes.DataSource = dt;
            funcNombresEncabezados();
        }

        private void TxtNumLib_KeyUp(object sender, KeyEventArgs e)
        {
            string Parametro = TxtNumLib.Text;
            DataTable dt = Cont.FuncListadoPasaporteNumLib(Estado, Parametro);
            DgvMostrarPasaportes.DataSource = dt;
            funcNombresEncabezados();
        }

        private void LblPasaporte_Click(object sender, EventArgs e)
        {

        }

        private void FuncNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void RbtnValidados_CheckedChanged(object sender, EventArgs e)
        {

            if (RbtnValidados.Checked == true)
            {
                Estado = 1;
            }

        }

        private void RbtnExpirado_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnExpirado.Checked == true)
            {
                Estado = 0;
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaPasaporte/AyudaPasaporte.chm", "ListadoPasaporte.html");
        }
    }
}

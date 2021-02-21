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
using CapaControlador.Pasaporte;

namespace CapaVista.Pasaporte
{
    public partial class frmEntregaPasaporte : Form
    {

        ClsControladorPasaporte Cont = new ClsControladorPasaporte();

        int  EstadoEntrega;
        string FechaEntrega, IdPass;

        public frmEntregaPasaporte()
        {
            InitializeComponent();
        }

        private void BtnLista_Click(object sender, EventArgs e)
        {
            //Se llama al formulario que contiene todos una tabla de todos los empleados
            frmListadoPasaportes Listado = new frmListadoPasaportes();
            Listado.ShowDialog();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

            if (TxtIdPass.Text == ""){ MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                //Mensaje de Pregunta
                if (MessageBox.Show("¿Está seguro de realizar la entrega de este Pasaporte ?", "Pasaporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {

                    //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                    //datos Pasaporte

                    FechaEntrega = DtpEntrega.Value.Date.ToShortDateString();
                    EstadoEntrega = 1;
                    
                    Cont.funcInsertarEntregaPass(IdPass, FechaEntrega, EstadoEntrega);
                    Cont.funcHistoricoPass(IdPass, FechaEntrega);
                    MessageBox.Show("Se ha registrado la Entrega del Pasaporte con Éxito", "ENTREGA PASAPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    funcLimpieza();

                    //envío de datos hacia capa Controlador

                }//fin elseif Pregunta
  
            }//fin else if texto vacio

        }

        private void frmEntregaPasaporte_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (TxtIdPass.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                funcDesbloqueo();

                IdPass = TxtIdPass.Text;

                //Inicio para Busqueda
                OdbcDataReader Lector = Cont.funcBuscarPass(TxtIdPass.Text);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {

                        //Se agrega el valor del lector a los textbox dependiendo la posicion 
                        TxtNumLibreta.Text = Lector.GetString(6);
                        CmbTipoPass.Text = Lector.GetString(10);

                    }
                }
                else
                {
                    //Mensaje de error
                    MessageBox.Show("ERROR: El Id del Pasaporte no se encuentra Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    funcLimpieza();
                    funcBloqueo();
                }

            }//fin ifelse


        }

        private void funcLimpieza()
        {
            TxtIdPass.Text = "";
            DtpEntrega.Value = DateTime.Now;
     
        }

        private void funcBloqueo()
        {
            BtnIngresar.Enabled = false;

        }

        private void FuncNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaPasaporte/AyudasPasaporte.chm", "dato-pg_00011.html");
        }

        private void funcDesbloqueo()
        {
            BtnIngresar.Enabled = true;

        }

    }
}

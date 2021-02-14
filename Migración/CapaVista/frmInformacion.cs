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
    public partial class frmInformacion : Form
    {
        ClsControlador Cn = new ClsControlador();
        private frmConfirmacion confirmacion;
        static Form FormularioPadre;
        int CodigoBoleta = 0;
        public frmInformacion(Form formularioPadre,int Boleta)
        {
            InitializeComponent();
            FormularioPadre = formularioPadre;
            CodigoBoleta = Boleta;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cmbCodigoDepartamento.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un Departamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbCodigoMunicipio.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un Municipio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbCodigoOcupacion.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar una Ocupacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbCodigoTramite.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar el Tipo de Tramite.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbCodigoPasaporte.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar el Tipo de Pasaporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbCodigoCaso.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar el Tipo de Caso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtDPI.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar su número de Identificacion Personal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtCorreo.Text != txtCorreoDeConfirmacion.Text)
            {
                MessageBox.Show("Los Correos no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtDireccion.Text.Length == 0 || txtCorreo.Text.Length == 0 || txtTelefono.Text.Length == 0 || txtTez.Text.Length == 0 || txtCorreoDeConfirmacion.Text.Length == 0 || txtTelefono.Text.Length == 0 || txtAltura.Text.Length == 0)
            {
                MessageBox.Show("No debe dejar campos Vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
               
                DialogResult dialogResult = MessageBox.Show("Asegurese de que todos sus datos esten ingresados correctamente, Si ya los reviso precione Aceptar de lo contrario precione cancelar y vuelva a revisar los datos ingresados.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.OK)
                {
                    string idDatosPersonales, Dpi, idMunicipio, direccion, altura, tez, ojos, ocupacion, tipoTramite, tipoPasaporte, tipoCaso, idBoletaBanco, estado, fechaActual, nacionalidad;
                    string Tabla = "datospersonales";
                    List<string> DatosFormulario = new List<string>();
                    //se almacenan en variables el contenido de los controles del formulario 
                    idDatosPersonales = txtCodigo.Text;
                    Dpi = txtDPI.Text;
                    idMunicipio = cmbCodigoMunicipio.SelectedItem.ToString();
                    direccion = txtDireccion.Text;
                    altura = txtAltura.Text;
                    tez = txtTez.Text;
                    ojos = txtColorDeOjos.Text;
                    ocupacion = cmbCodigoOcupacion.SelectedItem.ToString();
                    tipoTramite = cmbCodigoTramite.SelectedItem.ToString();
                    tipoPasaporte = cmbCodigoPasaporte.SelectedItem.ToString();
                    tipoCaso = cmbCodigoCaso.SelectedItem.ToString();
                    idBoletaBanco = txtCodigoBoleta.Text;
                    estado = txtEstado.Text;
                    fechaActual = lblFecha.Text;
                    nacionalidad = txtPais.Text;
                    // se agregan en una lista para ingresarlos en la base de datos
                    DatosFormulario.Add(idDatosPersonales);
                    DatosFormulario.Add(Dpi);
                    DatosFormulario.Add(idMunicipio);
                    DatosFormulario.Add(direccion);
                    DatosFormulario.Add(altura);
                    DatosFormulario.Add(tez);
                    DatosFormulario.Add(ojos);
                    DatosFormulario.Add(ocupacion);
                    DatosFormulario.Add(tipoTramite);
                    DatosFormulario.Add(tipoPasaporte);
                    DatosFormulario.Add(tipoCaso);
                    DatosFormulario.Add(idBoletaBanco);
                    DatosFormulario.Add(estado);
                    DatosFormulario.Add(fechaActual);
                    DatosFormulario.Add(nacionalidad);
                    Cn.procDatosInsertar(Tabla,DatosFormulario);
                   
                    frmAgendar confirmacion = new frmAgendar(FormularioPadre,idBoletaBanco,Dpi);
                    confirmacion.MdiParent = FormularioPadre;    
                    confirmacion.Show();               
                }
            }           
         }

        private void frmInformacion_Load(object sender, EventArgs e)
        {
            txtCodigoBoleta.Text = CodigoBoleta.ToString();
            txtEstado.Text = "1";
            //llenado de comboBox Departamento y su Codigo
            cmbCodigoDepartamento.Items.Add("Seleccione...");
            cmbDepartamento.Items.Add("Seleccione...");
            procLlenarCmb("DEPARTAMENTO", "idDepartamento", cmbCodigoDepartamento);
            procLlenarCmb("DEPARTAMENTO", "departamento", cmbDepartamento);
            cmbDepartamento.SelectedIndex = 0;
            //llenado de ComboBox Ocupacion y su Codigo
            cmbCodigoOcupacion.Items.Add("Seleccione...");
            cmbOcupacion.Items.Add("Seleccione...");
            procLlenarCmb("OCUPACION", "idOcupacion", cmbCodigoOcupacion);
            procLlenarCmb("OCUPACION", "ocupacion", cmbOcupacion);
            cmbOcupacion.SelectedIndex = 0;
            //llenado de ComboBox Tramite y su Codigo
            cmbCodigoTramite.Items.Add("Seleccione...");
            cmbTramite.Items.Add("Seleccione...");
            procLlenarCmb("TIPOTRAMITE", "idTipoTramite", cmbCodigoTramite);
            procLlenarCmb("TIPOTRAMITE", "nombreTipoTramite", cmbTramite);
            cmbTramite.SelectedIndex = 0;
            //llenado de ComboBox Pasaporte y su Codigo
            cmbCodigoPasaporte.Items.Add("Seleccione...");
            cmbPasaporte.Items.Add("Seleccione...");
            procLlenarCmb("TIPOPASAPORTE", "idTipoPasaporte", cmbCodigoPasaporte);
            procLlenarCmb("TIPOPASAPORTE", "tipoPasaporte", cmbPasaporte);
            cmbPasaporte.SelectedIndex = 0;
            //llenado de ComboBox Caso y su Codigo
            cmbCodigoCaso.Items.Add("Seleccione...");
            cmbCaso.Items.Add("Seleccione...");
            procLlenarCmb("TIPOCASO", "idTipoCaso", cmbCodigoCaso);
            procLlenarCmb("TIPOCASO", "tipoCaso", cmbCaso);
            cmbCaso.SelectedIndex = 0;
            //funcion del codigo
            insertar("DatosPersonales", "idDatosPersonales", txtCodigo);
        }
        //procedimiento para llenar cualquier comboBox 
        public void procLlenarCmb(string Tabla, string Campo1, ComboBox CmbAgregar)
        {
            string[] Items = Cn.funcItems(Tabla, Campo1);
            for (int I = 0; I < Items.Length; I++)
            {
                if (Items[I] != null)
                {
                    if (Items[I] != "")
                    {
                        CmbAgregar.Items.Add(Items[I]);
                    }
                }
            }
        }


        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMunicipio.Items.Clear();
            cmbCodigoMunicipio.Items.Clear();
            cmbCodigoDepartamento.SelectedIndex = cmbDepartamento.SelectedIndex;
            cmbCodigoMunicipio.Items.Add("Seleccione...");
            cmbMunicipio.Items.Add("Seleccione...");
            cmbMunicipio.SelectedIndex = 0;
            if (cmbCodigoDepartamento.SelectedIndex != 0)
            {
                int Codigo = Int32.Parse(cmbCodigoDepartamento.SelectedItem.ToString());
                //llenado de ComboBox Caso y su Codigo           
                procLlenarComboBox("MUNICIPIO", "idMunicipio", Codigo, "idDepartamento", cmbCodigoMunicipio);
                procLlenarComboBox("MUNICIPIO", "Municipio", Codigo, "idDepartamento", cmbMunicipio);
            }
           
            
        }

        //procedimiento para llenar un comboBox en especifico
        public void procLlenarComboBox(string Tabla1,string Campo1, int Id, string nombreID, ComboBox CmbAgregar)
        {
            string[] Items = Cn.funcItemsComboBox(Tabla1, Campo1, Id, nombreID);
            for (int I = 0; I < Items.Length; I++)
            {
                if (Items[I] != null)
                {
                    if (Items[I] != "")
                    {
                        CmbAgregar.Items.Add(Items[I]);
                    }
                }
            }
        }
        //funcion que obtiene el codigo de la tabla y lo coloca en el textbox
        public void insertar(string tabla, string campo, TextBox txt)
        {
            string tbl = tabla;
            string cmp1 = campo;
            TextBox txt1 = txt;
            int codigo = Cn.funcCodigoMaximo(tbl, cmp1);
            txt1.Text = codigo.ToString();
            txt1.Enabled = false;
        }

        private void cmbOcupacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoOcupacion.SelectedIndex = cmbOcupacion.SelectedIndex;
        }

        private void cmbTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoTramite.SelectedIndex = cmbTramite.SelectedIndex;
        }

        private void cmbPasaporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoPasaporte.SelectedIndex = cmbPasaporte.SelectedIndex;
        }

        private void cmbCaso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoCaso.SelectedIndex = cmbCaso.SelectedIndex;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtDPI.Text.Length == 0)
            {
                MessageBox.Show("No debe dejar Campos Vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if(txtDPI.Text.Length > 10)
            {
                MessageBox.Show("El numero de Documento de identificacion No puede Exceder los 10 Digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int DPI = Int32.Parse(txtDPI.Text);
                string nombre = Cn.funcObtenerDato(DPI, "nombres", "RENAP", "dpi");
                string apellido = Cn.funcObtenerDato(DPI, "apellidos", "RENAP", "dpi");
                string nombreCompleto = nombre + " " + apellido;
                string fechaNacimiento = Cn.funcObtenerDato(DPI, "fechaNacimiento", "RENAP", "dpi");
                string sexo = Cn.funcObtenerDato(DPI, "sexo", "RENAP", "dpi");
                string estadoCivil = Cn.funcObtenerDato(DPI, "estadoCivil", "RENAP", "dpi");
                string nacionalidad = Cn.funcObtenerDato(DPI, "nacionalidad", "RENAP", "dpi");
                txtNombreCompleto.Text = nombreCompleto;
                txtEstadoCivil.Text = estadoCivil;
                txtFechaNacimiento.Text = fechaNacimiento;
                txtSexo.Text = sexo;
                txtNacionalidad.Text = nacionalidad;
            }
           
        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            cmbCodigoMunicipio.SelectedIndex = cmbMunicipio.SelectedIndex;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void cmbCodigoTramite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCodigoCaso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDPI_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTez_KeyPress(object sender, KeyPressEventArgs e)
        {
            //revisa que puede ingresar letras, tecla de borrar o espacio
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtColorDeOjos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //revisa que puede ingresar letras, tecla de borrar o espacio
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            frmConfirmacion Confirmar = new frmConfirmacion(FormularioPadre);
            Confirmar.MdiParent = FormularioPadre;
            Confirmar.Show();
        }

        private void frmInformacion_Load(object sender, EventArgs e)
        {
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

        //procedimiento para llenar un comboBox en especifico
        public void procLlenarComboBox(string Tabla1,string Tabla2,string Campo1,int Id,string nombreID, ComboBox CmbAgregar)
        {
            string[] Items = Cn.funcItemsComboBox(Tabla1,Tabla2,Campo1,Id,nombreID);
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
            cmbCodigoDepartamento.SelectedIndex = cmbDepartamento.SelectedIndex;
            int Codigo = Int32.Parse(cmbCodigoDepartamento.SelectedItem.ToString());
            //llenado de ComboBox Caso y su Codigo
            cmbCodigoMunicipio.Items.Add("Seleccione...");
            cmbMunicipio.Items.Add("Seleccione...");
            procLlenarComboBox("MUNICIPIO", "DEPARTAMENTO","idMunicipio",Codigo,"idDepartamento",cmbCodigoMunicipio);
            procLlenarComboBox("MUNICIPIO", "DEPARTAMENTO", "Municipio", Codigo, "idDepartamento", cmbMunicipio);
            cmbMunicipio.SelectedIndex = 0;
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
            int DPI = Int32.Parse(txtDPI.Text);
            string nombre = Cn.funcObtenerDato(DPI,"nombres","RENAP","dpi");
            string apellido = Cn.funcObtenerDato(DPI, "apellidos", "RENAP", "dpi");
            string nombreCompleto = nombre + " " + apellido;
            string fechaNacimiento = Cn.funcObtenerDato(DPI, "fechaNacimiento", "RENAP", "dpi");
            string sexo = Cn.funcObtenerDato(DPI, "sexo", "RENAP", "dpi");
            string estadoCivil = Cn.funcObtenerDato(DPI, "estadoCivil", "RENAP", "dpi");

            txtNombreCompleto.Text = nombreCompleto;
            txtEstadoCivil.Text = estadoCivil;
            txtFechaNacimiento.Text = fechaNacimiento;
            txtSexo.Text = sexo;
        }
    }
}

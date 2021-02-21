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
    public partial class frmAgendarCita : Form
    {
        static Form FormularioPadre;
        ClsControlador Cn = new ClsControlador();
        int Datos = 0;
        int boletaBanco = 0;
        int PersonalDPI = 0;
        string Horario = "";
        public frmAgendarCita(Form formularioPadre,int idDatosPersonales,int CodigoBoleta,int DocumentoDPI)
        {
            InitializeComponent();
            FormularioPadre = formularioPadre;
            Datos = idDatosPersonales;
            boletaBanco = CodigoBoleta;
            PersonalDPI = DocumentoDPI;
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
            else if (cmbCodigoCentro.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un centro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if (rbHora8.Checked == true || rbHora9.Checked == true || rbHora10.Checked == true || rbHora11.Checked == true)
            {
                int Cantidad = Cn.CantidadDatos("idDatosPersonales", "programarcita", "fechaparacita", Horario,"idCentro",Int32.Parse(cmbCodigoCentro.SelectedItem.ToString()));
              
                Horario = "";
                if(Cantidad == 4)
                {
                    MessageBox.Show("Este horario ya esta ocupado, pruebe con otro horario o con otro día.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rbHora8.Checked = false;
                    rbHora9.Checked = false;
                    rbHora10.Checked = false;
                    rbHora11.Checked = false;
                    Horario = "";
                    return;
                }
                else
                {
                    rbHora8.Checked = false;
                    rbHora9.Checked = false;
                    rbHora10.Checked = false;
                    rbHora11.Checked = false;
                    DateTime FechaActual = DateTime.Parse(Horario);
                    if (FechaActual < DateTime.Now || FechaActual == DateTime.Now)
                    {
                        MessageBox.Show("La fecha de su cita no puede ser menor a la de hoy.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        return;
                    }
                    else
                    { 
                    DialogResult dialogResult = MessageBox.Show("Asegurese de que todos sus datos esten ingresados correctamente, Si ya los reviso precione Aceptar de lo contrario precione cancelar y vuelva a revisar los datos ingresados.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialogResult == DialogResult.OK)
                    {
                        string Codigo = txtCodigo.Text;
                        string CodigoHistorico = txtHistorico.Text;
                        string idCentro = cmbCodigoCentro.SelectedItem.ToString();
                        string idCodigoDatosPersonales = Datos.ToString();
                        string estado = "1";
                        List<string> datos = new List<string>();
                        datos.Add(Codigo);
                        datos.Add(idCodigoDatosPersonales);
                        datos.Add(idCentro);             
                        datos.Add(Horario);
                        datos.Add(estado);
                        List<string> datosHistoricos = new List<string>();
                        datosHistoricos.Add(CodigoHistorico);
                        datosHistoricos.Add(Codigo);
                        Cn.procDatosInsertar("programarcita", datos);
                        Cn.procDatosInsertar("historicacitas", datosHistoricos);
                        int IDCITA = Int32.Parse(Codigo);
                        frmImpresion_de_constancia Confirmar = new frmImpresion_de_constancia(FormularioPadre,IDCITA,Datos,boletaBanco,PersonalDPI);
                        Confirmar.MdiParent = FormularioPadre;
                        Confirmar.Show();
                        this.Close();
                    }
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una hora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return; 
            }
           

        }

        private void frmAgendarCita_Load(object sender, EventArgs e)
        {
            //llenado de comboBox Departamento y su Codigo
            cmbCodigoDepartamento.Items.Add("Seleccione...");
            cmbDepartamento.Items.Add("Seleccione...");
            procLlenarCmb("DEPARTAMENTO", "idDepartamento", cmbCodigoDepartamento);
            procLlenarCmb("DEPARTAMENTO", "departamento", cmbDepartamento);
            cmbDepartamento.SelectedIndex = 0;
            CodigoMaximo("programarcita", "idProgramarCita", txtCodigo);
            CodigoMaximo("historicacitas", "idHistorica", txtHistorico);

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
        public void procLlenarComboBox(string Tabla1, string Campo1, int Id, string nombreID, ComboBox CmbAgregar)
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
        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoDepartamento.SelectedIndex = cmbDepartamento.SelectedIndex;
            cmbMunicipio.Items.Clear();
            cmbCodigoMunicipio.Items.Clear();
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

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoMunicipio.SelectedIndex = cmbMunicipio.SelectedIndex;
            cmbCentro.Items.Clear();
            cmbCodigoCentro.Items.Clear();
            cmbCodigoCentro.Items.Add("Seleccione...");
            cmbCentro.Items.Add("Seleccione...");
            cmbCentro.SelectedIndex = 0;
            if (cmbCodigoMunicipio.SelectedIndex != 0)
            {
                int Codigo = Int32.Parse(cmbCodigoMunicipio.SelectedItem.ToString());
                //llenado de ComboBox Caso y su Codigo           
                procLlenarComboBox("CENTROCITA", "idCentroCita", Codigo, "idMunicipio", cmbCodigoCentro);
                procLlenarComboBox("CENTROCITA", "nombreCentro", Codigo, "idMunicipio", cmbCentro);
            }
        }

        public void CodigoMaximo(string tabla, string campo, TextBox txt)
        {
            string tbl = tabla;
            string cmp1 = campo;
            TextBox txt1 = txt;
            int codigo = Cn.funcCodigoMaximo(tbl, cmp1);
            txt1.Text = codigo.ToString();
            txt1.Enabled = false;
        }

        private void cmbCentro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoCentro.SelectedIndex = cmbCentro.SelectedIndex;

            if (cmbCodigoCentro.SelectedIndex != 0)
            {
                int Codigo = Int32.Parse(cmbCodigoCentro.SelectedItem.ToString());
                string sql = "Select direccion from centrocita where idCentroCita = "+Codigo+";";
                string Centro = Cn.CualquierDato(sql);
                lblDireccionCentro.Text = Centro;
            }else
            {
                lblDireccionCentro.Text = "";
            }

        }

        private void rbHora8_CheckedChanged(object sender, EventArgs e)
        {
            Horario = "";
            Horario = dtpFecha.Value.ToString("yyyy-MM-dd 08:00:00");
          
         
        }

        private void rbHora9_CheckedChanged(object sender, EventArgs e)
        {
            Horario = "";
            Horario = dtpFecha.Value.ToString("yyyy-MM-dd 09:00:00");
         
        }

        private void rbHora10_CheckedChanged(object sender, EventArgs e)
        {
            Horario = "";
            Horario = dtpFecha.Value.ToString("yyyy-MM-dd 10:00:00");
          
        }

        private void rbHora11_CheckedChanged(object sender, EventArgs e)
        {
            Horario = "";
            Horario = dtpFecha.Value.ToString("yyyy-MM-dd 11:00:00");
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbDepartamento.SelectedIndex = 0;
            rbHora8.Checked = false;
            rbHora9.Checked = false;
            rbHora10.Checked = false;
            rbHora11.Checked = false;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaMigracionCitas/AyudaCitas.chm", "agendar.html");
        }
    }
}

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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace CapaVista
{
    public partial class frmBitacora : Form
    {
        string consulta = "";
        string emp = "BITACORA";
        ClsControlador cn = new ClsControlador();
        public frmBitacora()
        {
            InitializeComponent();

        }
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            dgvBitacora.DataSource = dt;

        }

        private void rdUsuario_CheckedChanged(object sender, EventArgs e)
        {
            dgvBitacora.DataSource = null;
            if (rdUsuario.Checked == true)
            {
                cmbUsuario.Visible = true;
                cmbAplicacion.Visible = false;
                dtpFechaInicio.Visible = false;
                dtpFechaFinal.Visible = false;
                rdInsercion.Visible = false;
                rdActualizacion.Visible = false;
                rdLogeo.Visible = false;
                cmbAplicacion.SelectedIndex = 0;
            }
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            //llenado de comboBox Departamento y su Codigo
            cmbCodigoUsuario.Items.Add("Seleccione...");
            cmbUsuario.Items.Add("Seleccione...");
            procLlenarComboBox("login", "pk_id_login", 1, "estado_login", cmbCodigoUsuario);
            procLlenarComboBox("login", "usuario_login", 1, "estado_login", cmbUsuario);
            cmbUsuario.SelectedIndex = 0;

            cmbCodigoAplicacion.Items.Add("Seleccione...");
            cmbAplicacion.Items.Add("Seleccione...");
            procLlenarComboBox("aplicacion", "pk_id_aplicacion", 1, "estado_aplicacion", cmbCodigoAplicacion);
            procLlenarComboBox("aplicacion", "nombre_aplicacion", 1, "estado_aplicacion", cmbAplicacion);
            cmbAplicacion.SelectedIndex = 0;

        }

        public void procLlenarCmb(string Tabla, string Campo1, ComboBox CmbAgregar)
        {
            string[] Items = cn.funcItems(Tabla, Campo1);
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

        public void procLlenarComboBox(string Tabla1, string Campo1, int Id, string nombreID, ComboBox CmbAgregar)
        {
            string[] Items = cn.funcItemsComboBox(Tabla1, Campo1, Id, nombreID);
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

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoUsuario.SelectedIndex = cmbUsuario.SelectedIndex;
        }

        private void rdAplicacion_CheckedChanged(object sender, EventArgs e)
        {
            dgvBitacora.DataSource = null;
            consulta = "";
            if (rdAplicacion.Checked == true)
            {
                cmbUsuario.Visible = false;
                cmbAplicacion.Visible = true;
                dtpFechaInicio.Visible = false;
                dtpFechaFinal.Visible = false;
                rdInsercion.Visible = false;
                rdActualizacion.Visible = false;
                rdLogeo.Visible = false;
                cmbUsuario.SelectedIndex = 0;
            }
        }

        private void rdFecha_CheckedChanged(object sender, EventArgs e)
        {
            dgvBitacora.DataSource = null;
            consulta = "";
            if (rdFecha.Checked == true)
            {
                rdInsercion.Visible = false;
                rdActualizacion.Visible = false;
                rdLogeo.Visible = false;
                cmbUsuario.Visible = false;
                cmbAplicacion.Visible = false;
                dtpFechaInicio.Visible = true;
                dtpFechaFinal.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dgvBitacora.DataSource = null;
            consulta = "";
            if (radioButton1.Checked == true)
            {
                rdInsercion.Visible = false;
                rdActualizacion.Visible = false;
                rdLogeo.Visible = false;
                cmbUsuario.Visible = false;
                cmbAplicacion.Visible = false;
                dtpFechaInicio.Visible = false;
                dtpFechaFinal.Visible = false;
                cmbUsuario.SelectedIndex = 0;
                cmbAplicacion.SelectedIndex = 0;
            }
        }

        private void cmbAplicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoAplicacion.SelectedIndex = cmbAplicacion.SelectedIndex;
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && rdAplicacion.Checked == false && rdFecha.Checked == false && rdUsuario.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Debe seleccionar uno de los fitros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rdUsuario.Checked == true)
                {
                    if (cmbCodigoUsuario.SelectedIndex == 0)
                    {
                        MessageBox.Show("Debe seleccionar a un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        consulta = "SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion and L.pk_id_login = " + Int32.Parse(cmbCodigoUsuario.SelectedItem.ToString()) + ";";
                        string CONSULTA = consulta;
                        DataTable dt = cn.enviar(CONSULTA);
                        dgvBitacora.DataSource = dt;

                    }
                }
                else if (rdAplicacion.Checked == true)
                {
                    if (cmbCodigoAplicacion.SelectedIndex == 0)
                    {
                        MessageBox.Show("Debe seleccionar una aplicacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        consulta = " SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion AND A.pk_id_aplicacion = " + Int32.Parse(cmbCodigoAplicacion.SelectedItem.ToString()) + ";";
                        string CONSULTA = consulta;
                        DataTable dt = cn.enviar(CONSULTA);
                        dgvBitacora.DataSource = dt;

                    }
                }
                else if (radioButton1.Checked == true)
                {
                    consulta = "SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion;";
                    string CONSULTA = consulta;
                    DataTable dt = cn.enviar(CONSULTA);
                    dgvBitacora.DataSource = dt;
                }
                else if (rdFecha.Checked == true)
                {
                    if (dtpFechaFinal.Value.Date < dtpFechaInicio.Value.Date)
                    {
                        MessageBox.Show("La fecha final no puede ser menor a la fecha inicial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dtpFechaInicio.Value.Date > dtpFechaFinal.Value.Date)

                    {
                        MessageBox.Show("La fecha inicial no puede ser mayor a la fecha Final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        string fechaInicial = "", fechaFinal = "";
                        fechaInicial = dtpFechaInicio.Value.ToString("dd-MM-yyyy");
                        fechaFinal = dtpFechaFinal.Value.ToString("dd-MM-yyyy");

                        consulta = "SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion and B.fechahora_bitacora BETWEEN '" + fechaInicial + "' and '" + fechaFinal + "' ;";
                        string CONSULTA = consulta;
                        DataTable dt = cn.enviar(CONSULTA);
                        dgvBitacora.DataSource = dt;
                    }

                }
                else if (radioButton2.Checked == true)
                {
                    if (rdInsercion.Checked == false && rdActualizacion.Checked == false && rdLogeo.Checked == false)
                    {
                        MessageBox.Show("Debe seleccionar una opcion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (rdInsercion.Checked == true)
                    {
                        consulta = " SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion and B.accion_bitacora LIKE '%INSERT%' ; ";
                        string CONSULTA = consulta;
                        DataTable dt = cn.enviar(CONSULTA);
                        dgvBitacora.DataSource = dt;
                    }
                    else if (rdActualizacion.Checked == true)
                    {
                        consulta = " SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion and B.accion_bitacora LIKE '%UPDATE%' ; ";
                        string CONSULTA = consulta;
                        DataTable dt = cn.enviar(CONSULTA);
                        dgvBitacora.DataSource = dt;
                    }
                    else if (rdLogeo.Checked == true)
                    {
                        consulta = " SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion and B.accion_bitacora LIKE '%Logeo%'; ";
                        string CONSULTA = consulta;
                        DataTable dt = cn.enviar(CONSULTA);
                        dgvBitacora.DataSource = dt;
                    }
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            rdFecha.Checked = false;
            rdAplicacion.Checked = false;
            rdUsuario.Checked = false;
            cmbAplicacion.Visible = false;
            cmbUsuario.Visible = false;
            dtpFechaInicio.Visible = false;
            dtpFechaFinal.Visible = false;
            rdInsercion.Visible = false;
            rdLogeo.Visible = false;
            rdActualizacion.Visible = false;
            radioButton2.Checked = false;
            cmbUsuario.SelectedIndex = 0;
            cmbAplicacion.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFinal.Value = DateTime.Now;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dgvBitacora.DataSource = null;
            consulta = "";
            if (radioButton2.Checked == true)
            {
                cmbUsuario.Visible = false;
                cmbAplicacion.Visible = false;
                dtpFechaInicio.Visible = false;
                dtpFechaFinal.Visible = false;
                rdInsercion.Visible = true;
                rdActualizacion.Visible = true;
                rdLogeo.Visible = true;
            }
        }

        private void dgvBitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            exportgridtopdf(dgvBitacora, "Bitacora");
        }

        public void exportgridtopdf(DataGridView dgw, string filename)
        {
            try
            {
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
                pdftable.DefaultCell.Padding = 10;
                pdftable.WidthPercentage = 100;
                pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdftable.DefaultCell.BorderWidth = 1;

                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                //add header

                foreach (DataGridViewColumn column in dgw.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdftable.AddCell(cell);
                }

                //add datarow
                foreach (DataGridViewRow row in dgw.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                    }
                }

                var savefiledialoge = new SaveFileDialog();
                savefiledialoge.FileName = filename;
                savefiledialoge.DefaultExt = ".pdf";
                if (savefiledialoge.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        pdfdoc.Add(pdftable);
                        pdfdoc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("PDF Guardado Correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

              

            }
            catch (Exception)
            {

                MessageBox.Show("Operacion Cancelada.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

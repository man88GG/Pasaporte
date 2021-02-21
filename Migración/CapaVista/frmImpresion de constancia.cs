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
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace CapaVista
{
    public partial class frmImpresion_de_constancia : Form
    {
        ClsControlador Cn = new ClsControlador();

        int IDCITA = 0;
        int IDDATOSPERSONALES = 0;
        int IDBOLETABANCO = 0;
        int DOCUMENTODPI = 0;
        string consulta = "";
        Form formularioMDI;
        public frmImpresion_de_constancia(Form FormularioPadre,int idCita,int idDatos,int CodigoBoleta, int DPI)
        {
            InitializeComponent();
 
             IDCITA = idCita;
             IDDATOSPERSONALES = idDatos;
             IDBOLETABANCO = CodigoBoleta;
             DOCUMENTODPI = DPI;
            formularioMDI = FormularioPadre;
        }

      
        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigo.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();
        }

        private void frmImpresion_de_constancia_Load(object sender, EventArgs e)
        {
            actualizarData();
        }

        public void actualizarData()
        {

            consulta = "select P.idProgramarCita as CODIGO_CITA,B.numeroRecibo AS NUMERO_RECIBO,B.numeroBoleta as NUMERO_BOLETA,R.nombres as NOMBRES,R.apellidos as APELLIDOS from programarcita P,datospersonales D,boletabanco B,renap R where P.idDatosPersonales = D.idDatosPersonales and D.idBoletaBanco = B.idBoleta and D.dpi = R.dpi AND P.idProgramarCita = " + IDCITA + " and D.idDatosPersonales = " + IDDATOSPERSONALES + " and D.idBoletaBanco = " + IDBOLETABANCO + " and D.dpi = " + DOCUMENTODPI + " and P.estado = 1;";
            DataTable dt = Cn.enviar(consulta);
            dgvDatos.DataSource = dt;
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos seleccionados: " + this.dgvDatos.CurrentRow.Cells[0].Value.ToString());
            funcCrearPdf();
        }

        private void funcCrearPdf()
        {
            PdfWriter pdfWriter = new PdfWriter("Reporte.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);
            documento.SetMargins(180, 20, 55, 20);
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            //CONTENIDO
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
            //Encabezados del DataGridView
            string[] columnas = { "Código Cita", "Número de recibo", "Número de Boleta", "Nombres", "Apellidos" };
            string texto = "VARIOS";
            //crear tabla para mostrar los datos
            float[] tamanios = { 2, 4, 4, 5, 4 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas))); //PARA ENCABEZADO DE TABLA
            }

            tabla.AddCell(new Cell().Add(new Paragraph(this.dgvDatos.CurrentRow.Cells[0].Value.ToString()).SetFont(fontContenido)));
            tabla.AddCell(new Cell().Add(new Paragraph(this.dgvDatos.CurrentRow.Cells[1].Value.ToString()).SetFont(fontContenido)));
            tabla.AddCell(new Cell().Add(new Paragraph(this.dgvDatos.CurrentRow.Cells[2].Value.ToString()).SetFont(fontContenido)));
            tabla.AddCell(new Cell().Add(new Paragraph(this.dgvDatos.CurrentRow.Cells[3].Value.ToString()).SetFont(fontContenido)));
            tabla.AddCell(new Cell().Add(new Paragraph(this.dgvDatos.CurrentRow.Cells[4].Value.ToString()).SetFont(fontContenido)));

            documento.Add(tabla);
            documento.Close();
            //
            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("migracion.jpg")).SetWidth(80);
            var plogo = new Paragraph("").Add(logo);
            var titulo = new Paragraph("CONSTANCIA DE CITAS");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(35);

            var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha de creación: " + dfecha + "\nHora de creación: " + dhora);
            fecha.SetFontSize(12);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter("ReporteConstancia.pdf"));
            Document doc = new Document(pdfDoc);

            int numeros = pdfDoc.GetNumberOfPages();
            //Posicionamiento de los elementos
            for (int i = 1; i <= numeros; i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);
                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(plogo, 60, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(titulo, 300, y - 45, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 25, y - 90, i, TextAlignment.LEFT, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)), pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() / 2 - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

            }
            doc.Close();

        }

        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            if (lblCodigo.Text == "Codigo")
            {
                MessageBox.Show("Para cancelar debe seleccinar un registro de la tabla.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea cancelar la cita?, si la cancela debera agendar una nueva y puede que la fecha anterior sea ocupada.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.OK)
                {
                    int codigo = Int32.Parse(lblCodigo.Text);
                    string sql = "UPDATE PROGRAMARCITA SET ESTADO = 0 WHERE idProgramarCita = " + codigo + ";";
                    Cn.Modificar(sql);
                    this.Close();
                    MessageBox.Show("Cita Cancelada Exitosamente.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    frmMenuCita Validar = new frmMenuCita(formularioMDI);
                    Validar.MdiParent = formularioMDI;
                    Validar.Show();
                }
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaMigracionCitas/AyudaCitas.chm", "gestion-de-cita.html");
        }
    }
}

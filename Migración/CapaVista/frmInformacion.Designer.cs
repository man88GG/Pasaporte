
namespace CapaVista
{
    partial class frmInformacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacion));
            this.btnAyuda = new System.Windows.Forms.Button();
            this.cmbCaso = new System.Windows.Forms.ComboBox();
            this.cmbPasaporte = new System.Windows.Forms.ComboBox();
            this.cmbTramite = new System.Windows.Forms.ComboBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblPasaporte = new System.Windows.Forms.Label();
            this.lblCaso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtEstadoCivil = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.lblDpi = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tabInformacionPersonal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.cmbCodigoOcupacion = new System.Windows.Forms.ComboBox();
            this.cmbOcupacion = new System.Windows.Forms.ComboBox();
            this.cmbCodigoMunicipio = new System.Windows.Forms.ComboBox();
            this.cmbCodigoDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtTez = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtColorDeOjos = new System.Windows.Forms.TextBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblTez = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblColorDeOjos = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCorreoConfirmacion = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreoDeConfirmacion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbCodigoCaso = new System.Windows.Forms.ComboBox();
            this.cmbCodigoPasaporte = new System.Windows.Forms.ComboBox();
            this.cmbCodigoTramite = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabInformacionPersonal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(1079, 30);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(72, 72);
            this.btnAyuda.TabIndex = 116;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // cmbCaso
            // 
            this.cmbCaso.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCaso.FormattingEnabled = true;
            this.cmbCaso.Location = new System.Drawing.Point(30, 242);
            this.cmbCaso.Name = "cmbCaso";
            this.cmbCaso.Size = new System.Drawing.Size(397, 28);
            this.cmbCaso.TabIndex = 106;
            this.cmbCaso.SelectedIndexChanged += new System.EventHandler(this.cmbCaso_SelectedIndexChanged);
            // 
            // cmbPasaporte
            // 
            this.cmbPasaporte.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPasaporte.FormattingEnabled = true;
            this.cmbPasaporte.Location = new System.Drawing.Point(29, 151);
            this.cmbPasaporte.Name = "cmbPasaporte";
            this.cmbPasaporte.Size = new System.Drawing.Size(397, 28);
            this.cmbPasaporte.TabIndex = 105;
            this.cmbPasaporte.SelectedIndexChanged += new System.EventHandler(this.cmbPasaporte_SelectedIndexChanged);
            // 
            // cmbTramite
            // 
            this.cmbTramite.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTramite.FormattingEnabled = true;
            this.cmbTramite.Location = new System.Drawing.Point(30, 58);
            this.cmbTramite.Name = "cmbTramite";
            this.cmbTramite.Size = new System.Drawing.Size(397, 28);
            this.cmbTramite.TabIndex = 104;
            this.cmbTramite.SelectedIndexChanged += new System.EventHandler(this.cmbTramite_SelectedIndexChanged);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTramite.Location = new System.Drawing.Point(26, 21);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(156, 22);
            this.lblTramite.TabIndex = 103;
            this.lblTramite.Text = "Tipo de tramite:";
            // 
            // lblPasaporte
            // 
            this.lblPasaporte.AutoSize = true;
            this.lblPasaporte.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasaporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPasaporte.Location = new System.Drawing.Point(30, 116);
            this.lblPasaporte.Name = "lblPasaporte";
            this.lblPasaporte.Size = new System.Drawing.Size(184, 22);
            this.lblPasaporte.TabIndex = 102;
            this.lblPasaporte.Text = "Tipo de pasaporte:";
            // 
            // lblCaso
            // 
            this.lblCaso.AutoSize = true;
            this.lblCaso.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCaso.Location = new System.Drawing.Point(30, 206);
            this.lblCaso.Name = "lblCaso";
            this.lblCaso.Size = new System.Drawing.Size(132, 22);
            this.lblCaso.TabIndex = 101;
            this.lblCaso.Text = "Tipo de caso:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(533, 556);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 61);
            this.btnCancelar.TabIndex = 125;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.Enabled = false;
            this.txtEstadoCivil.Location = new System.Drawing.Point(573, 243);
            this.txtEstadoCivil.Multiline = true;
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(240, 24);
            this.txtEstadoCivil.TabIndex = 120;
            // 
            // txtSexo
            // 
            this.txtSexo.Enabled = false;
            this.txtSexo.Location = new System.Drawing.Point(289, 243);
            this.txtSexo.Multiline = true;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(240, 24);
            this.txtSexo.TabIndex = 119;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Enabled = false;
            this.txtNacionalidad.Location = new System.Drawing.Point(16, 243);
            this.txtNacionalidad.Multiline = true;
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(240, 24);
            this.txtNacionalidad.TabIndex = 118;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Enabled = false;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(573, 157);
            this.txtFechaNacimiento.Multiline = true;
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(240, 24);
            this.txtFechaNacimiento.TabIndex = 100;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Enabled = false;
            this.txtNombreCompleto.Location = new System.Drawing.Point(16, 157);
            this.txtNombreCompleto.Multiline = true;
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(531, 24);
            this.txtNombreCompleto.TabIndex = 117;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(569, 117);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(204, 22);
            this.lblFechaNacimiento.TabIndex = 114;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNacionalidad.Location = new System.Drawing.Point(17, 206);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(139, 22);
            this.lblNacionalidad.TabIndex = 113;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSexo.Location = new System.Drawing.Point(285, 206);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(60, 22);
            this.lblSexo.TabIndex = 112;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstadoCivil.Location = new System.Drawing.Point(569, 206);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(123, 22);
            this.lblEstadoCivil.TabIndex = 111;
            this.lblEstadoCivil.Text = "Estado civil:";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreCompleto.Location = new System.Drawing.Point(14, 117);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(180, 22);
            this.lblNombreCompleto.TabIndex = 110;
            this.lblNombreCompleto.Text = "Nombre completo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(439, 45);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 47);
            this.btnBuscar.TabIndex = 109;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDPI
            // 
            this.txtDPI.Location = new System.Drawing.Point(18, 65);
            this.txtDPI.Multiline = true;
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(394, 27);
            this.txtDPI.TabIndex = 108;
            // 
            // lblDpi
            // 
            this.lblDpi.AutoSize = true;
            this.lblDpi.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDpi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDpi.Location = new System.Drawing.Point(17, 24);
            this.lblDpi.Name = "lblDpi";
            this.lblDpi.Size = new System.Drawing.Size(340, 22);
            this.lblDpi.TabIndex = 107;
            this.lblDpi.Text = "No. de documento de identificacion:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(320, 556);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(190, 61);
            this.btnAceptar.TabIndex = 123;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // tabInformacionPersonal
            // 
            this.tabInformacionPersonal.Controls.Add(this.tabPage1);
            this.tabInformacionPersonal.Controls.Add(this.tabPage2);
            this.tabInformacionPersonal.Controls.Add(this.tabPage3);
            this.tabInformacionPersonal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInformacionPersonal.Location = new System.Drawing.Point(27, 21);
            this.tabInformacionPersonal.Name = "tabInformacionPersonal";
            this.tabInformacionPersonal.SelectedIndex = 0;
            this.tabInformacionPersonal.Size = new System.Drawing.Size(1019, 521);
            this.tabInformacionPersonal.TabIndex = 126;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.tabPage1.Controls.Add(this.cmbMunicipio);
            this.tabPage1.Controls.Add(this.cmbCodigoOcupacion);
            this.tabPage1.Controls.Add(this.cmbOcupacion);
            this.tabPage1.Controls.Add(this.cmbCodigoMunicipio);
            this.tabPage1.Controls.Add(this.cmbCodigoDepartamento);
            this.tabPage1.Controls.Add(this.cmbPais);
            this.tabPage1.Controls.Add(this.lblOcupacion);
            this.tabPage1.Controls.Add(this.lblMunicipio);
            this.tabPage1.Controls.Add(this.txtAltura);
            this.tabPage1.Controls.Add(this.lblDepartamento);
            this.tabPage1.Controls.Add(this.txtTez);
            this.tabPage1.Controls.Add(this.lblPais);
            this.tabPage1.Controls.Add(this.txtColorDeOjos);
            this.tabPage1.Controls.Add(this.cmbDepartamento);
            this.tabPage1.Controls.Add(this.lblAltura);
            this.tabPage1.Controls.Add(this.lblTez);
            this.tabPage1.Controls.Add(this.lblDireccion);
            this.tabPage1.Controls.Add(this.lblColorDeOjos);
            this.tabPage1.Controls.Add(this.txtDireccion);
            this.tabPage1.Controls.Add(this.txtTelefono);
            this.tabPage1.Controls.Add(this.lblCorreoConfirmacion);
            this.tabPage1.Controls.Add(this.txtCorreo);
            this.tabPage1.Controls.Add(this.lblCorreo);
            this.tabPage1.Controls.Add(this.txtCorreoDeConfirmacion);
            this.tabPage1.Controls.Add(this.lblTelefono);
            this.tabPage1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1011, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informacion personal";
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(651, 63);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(240, 28);
            this.cmbMunicipio.TabIndex = 104;
            this.cmbMunicipio.SelectedIndexChanged += new System.EventHandler(this.cmbMunicipio_SelectedIndexChanged);
            // 
            // cmbCodigoOcupacion
            // 
            this.cmbCodigoOcupacion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoOcupacion.FormattingEnabled = true;
            this.cmbCodigoOcupacion.Location = new System.Drawing.Point(502, 428);
            this.cmbCodigoOcupacion.Name = "cmbCodigoOcupacion";
            this.cmbCodigoOcupacion.Size = new System.Drawing.Size(95, 28);
            this.cmbCodigoOcupacion.TabIndex = 103;
            // 
            // cmbOcupacion
            // 
            this.cmbOcupacion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOcupacion.FormattingEnabled = true;
            this.cmbOcupacion.Location = new System.Drawing.Point(26, 428);
            this.cmbOcupacion.Name = "cmbOcupacion";
            this.cmbOcupacion.Size = new System.Drawing.Size(453, 28);
            this.cmbOcupacion.TabIndex = 102;
            this.cmbOcupacion.SelectedIndexChanged += new System.EventHandler(this.cmbOcupacion_SelectedIndexChanged);
            // 
            // cmbCodigoMunicipio
            // 
            this.cmbCodigoMunicipio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoMunicipio.FormattingEnabled = true;
            this.cmbCodigoMunicipio.Location = new System.Drawing.Point(897, 64);
            this.cmbCodigoMunicipio.Name = "cmbCodigoMunicipio";
            this.cmbCodigoMunicipio.Size = new System.Drawing.Size(70, 28);
            this.cmbCodigoMunicipio.TabIndex = 101;
            // 
            // cmbCodigoDepartamento
            // 
            this.cmbCodigoDepartamento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoDepartamento.FormattingEnabled = true;
            this.cmbCodigoDepartamento.Location = new System.Drawing.Point(553, 63);
            this.cmbCodigoDepartamento.Name = "cmbCodigoDepartamento";
            this.cmbCodigoDepartamento.Size = new System.Drawing.Size(71, 28);
            this.cmbCodigoDepartamento.TabIndex = 100;
            // 
            // cmbPais
            // 
            this.cmbPais.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(26, 64);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(262, 28);
            this.cmbPais.TabIndex = 81;
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOcupacion.Location = new System.Drawing.Point(27, 388);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(115, 22);
            this.lblOcupacion.TabIndex = 98;
            this.lblOcupacion.Text = "Ocupacion:";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMunicipio.Location = new System.Drawing.Point(647, 18);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(108, 22);
            this.lblMunicipio.TabIndex = 78;
            this.lblMunicipio.Text = "Municipio:";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(26, 336);
            this.txtAltura.Multiline = true;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(205, 24);
            this.txtAltura.TabIndex = 97;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartamento.Location = new System.Drawing.Point(309, 18);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(147, 22);
            this.lblDepartamento.TabIndex = 79;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // txtTez
            // 
            this.txtTez.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTez.Location = new System.Drawing.Point(240, 336);
            this.txtTez.Multiline = true;
            this.txtTez.Name = "txtTez";
            this.txtTez.Size = new System.Drawing.Size(205, 24);
            this.txtTez.TabIndex = 96;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPais.Location = new System.Drawing.Point(22, 18);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(53, 22);
            this.lblPais.TabIndex = 80;
            this.lblPais.Text = "País:";
            // 
            // txtColorDeOjos
            // 
            this.txtColorDeOjos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorDeOjos.Location = new System.Drawing.Point(472, 336);
            this.txtColorDeOjos.Multiline = true;
            this.txtColorDeOjos.Name = "txtColorDeOjos";
            this.txtColorDeOjos.Size = new System.Drawing.Size(205, 24);
            this.txtColorDeOjos.TabIndex = 95;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(313, 64);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(225, 28);
            this.cmbDepartamento.TabIndex = 82;
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAltura.Location = new System.Drawing.Point(22, 301);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(204, 22);
            this.lblAltura.TabIndex = 94;
            this.lblAltura.Text = "Altura (Centimetros):";
            // 
            // lblTez
            // 
            this.lblTez.AutoSize = true;
            this.lblTez.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTez.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTez.Location = new System.Drawing.Point(236, 301);
            this.lblTez.Name = "lblTez";
            this.lblTez.Size = new System.Drawing.Size(47, 22);
            this.lblTez.TabIndex = 93;
            this.lblTez.Text = "Tez:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDireccion.Location = new System.Drawing.Point(22, 115);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(104, 22);
            this.lblDireccion.TabIndex = 84;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblColorDeOjos
            // 
            this.lblColorDeOjos.AutoSize = true;
            this.lblColorDeOjos.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorDeOjos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColorDeOjos.Location = new System.Drawing.Point(472, 301);
            this.lblColorDeOjos.Name = "lblColorDeOjos";
            this.lblColorDeOjos.Size = new System.Drawing.Size(138, 22);
            this.lblColorDeOjos.TabIndex = 92;
            this.lblColorDeOjos.Text = "Color de ojos:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(26, 154);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(676, 30);
            this.txtDireccion.TabIndex = 85;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(26, 249);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(205, 24);
            this.txtTelefono.TabIndex = 91;
            // 
            // lblCorreoConfirmacion
            // 
            this.lblCorreoConfirmacion.AutoSize = true;
            this.lblCorreoConfirmacion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoConfirmacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCorreoConfirmacion.Location = new System.Drawing.Point(607, 212);
            this.lblCorreoConfirmacion.Name = "lblCorreoConfirmacion";
            this.lblCorreoConfirmacion.Size = new System.Drawing.Size(343, 22);
            this.lblCorreoConfirmacion.TabIndex = 86;
            this.lblCorreoConfirmacion.Text = "Confirmacion de Correo electronico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(240, 249);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(357, 24);
            this.txtCorreo.TabIndex = 90;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCorreo.Location = new System.Drawing.Point(236, 212);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(186, 22);
            this.lblCorreo.TabIndex = 87;
            this.lblCorreo.Text = "Correo electronico:";
            // 
            // txtCorreoDeConfirmacion
            // 
            this.txtCorreoDeConfirmacion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoDeConfirmacion.Location = new System.Drawing.Point(611, 249);
            this.txtCorreoDeConfirmacion.Multiline = true;
            this.txtCorreoDeConfirmacion.Name = "txtCorreoDeConfirmacion";
            this.txtCorreoDeConfirmacion.Size = new System.Drawing.Size(339, 24);
            this.txtCorreoDeConfirmacion.TabIndex = 89;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefono.Location = new System.Drawing.Point(22, 212);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(94, 22);
            this.lblTelefono.TabIndex = 88;
            this.lblTelefono.Text = "Telefono:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.tabPage2.Controls.Add(this.cmbCodigoCaso);
            this.tabPage2.Controls.Add(this.cmbCodigoPasaporte);
            this.tabPage2.Controls.Add(this.cmbCodigoTramite);
            this.tabPage2.Controls.Add(this.cmbCaso);
            this.tabPage2.Controls.Add(this.lblTramite);
            this.tabPage2.Controls.Add(this.cmbPasaporte);
            this.tabPage2.Controls.Add(this.lblCaso);
            this.tabPage2.Controls.Add(this.cmbTramite);
            this.tabPage2.Controls.Add(this.lblPasaporte);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1011, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Informacion de pasaporte";
            // 
            // cmbCodigoCaso
            // 
            this.cmbCodigoCaso.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoCaso.FormattingEnabled = true;
            this.cmbCodigoCaso.Location = new System.Drawing.Point(440, 242);
            this.cmbCodigoCaso.Name = "cmbCodigoCaso";
            this.cmbCodigoCaso.Size = new System.Drawing.Size(94, 28);
            this.cmbCodigoCaso.TabIndex = 109;
            // 
            // cmbCodigoPasaporte
            // 
            this.cmbCodigoPasaporte.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoPasaporte.FormattingEnabled = true;
            this.cmbCodigoPasaporte.Location = new System.Drawing.Point(440, 151);
            this.cmbCodigoPasaporte.Name = "cmbCodigoPasaporte";
            this.cmbCodigoPasaporte.Size = new System.Drawing.Size(94, 28);
            this.cmbCodigoPasaporte.TabIndex = 108;
            // 
            // cmbCodigoTramite
            // 
            this.cmbCodigoTramite.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoTramite.FormattingEnabled = true;
            this.cmbCodigoTramite.Location = new System.Drawing.Point(440, 58);
            this.cmbCodigoTramite.Name = "cmbCodigoTramite";
            this.cmbCodigoTramite.Size = new System.Drawing.Size(94, 28);
            this.cmbCodigoTramite.TabIndex = 107;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.tabPage3.Controls.Add(this.txtFechaNacimiento);
            this.tabPage3.Controls.Add(this.txtEstadoCivil);
            this.tabPage3.Controls.Add(this.btnBuscar);
            this.tabPage3.Controls.Add(this.txtSexo);
            this.tabPage3.Controls.Add(this.lblDpi);
            this.tabPage3.Controls.Add(this.txtNacionalidad);
            this.tabPage3.Controls.Add(this.txtDPI);
            this.tabPage3.Controls.Add(this.lblNombreCompleto);
            this.tabPage3.Controls.Add(this.txtNombreCompleto);
            this.tabPage3.Controls.Add(this.lblEstadoCivil);
            this.tabPage3.Controls.Add(this.lblFechaNacimiento);
            this.tabPage3.Controls.Add(this.lblSexo);
            this.tabPage3.Controls.Add(this.lblNacionalidad);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1011, 486);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Informacion de documento de identificacion";
            // 
            // frmInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1181, 641);
            this.Controls.Add(this.tabInformacionPersonal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAyuda);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmInformacion";
            this.Text = "frmInformacion";
            this.Load += new System.EventHandler(this.frmInformacion_Load);
            this.tabInformacionPersonal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.ComboBox cmbCaso;
        private System.Windows.Forms.ComboBox cmbPasaporte;
        private System.Windows.Forms.ComboBox cmbTramite;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblPasaporte;
        private System.Windows.Forms.Label lblCaso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtEstadoCivil;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.Label lblDpi;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TabControl tabInformacionPersonal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtTez;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtColorDeOjos;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblTez;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblColorDeOjos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCorreoConfirmacion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreoDeConfirmacion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbCodigoCaso;
        private System.Windows.Forms.ComboBox cmbCodigoPasaporte;
        private System.Windows.Forms.ComboBox cmbCodigoTramite;
        private System.Windows.Forms.ComboBox cmbCodigoMunicipio;
        private System.Windows.Forms.ComboBox cmbCodigoDepartamento;
        private System.Windows.Forms.ComboBox cmbCodigoOcupacion;
        private System.Windows.Forms.ComboBox cmbOcupacion;
        private System.Windows.Forms.ComboBox cmbMunicipio;
    }
}
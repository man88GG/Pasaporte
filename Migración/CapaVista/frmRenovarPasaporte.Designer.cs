
namespace CapaVista
{
    partial class frmRenovarPasaporte
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
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TbcDatos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LblDpi = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblFechaNac = new System.Windows.Forms.Label();
            this.TxtNumDpi = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.DtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.GbxLugarNac = new System.Windows.Forms.GroupBox();
            this.CmbMuni = new System.Windows.Forms.ComboBox();
            this.CmbDepto = new System.Windows.Forms.ComboBox();
            this.LblDepto = new System.Windows.Forms.Label();
            this.LblMuni = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CmbAutoridad = new System.Windows.Forms.ComboBox();
            this.PbxFoto = new System.Windows.Forms.PictureBox();
            this.DtpCreacion = new System.Windows.Forms.DateTimePicker();
            this.DtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.LblFechaVen = new System.Windows.Forms.Label();
            this.LblFoto = new System.Windows.Forms.Label();
            this.LblFechaCre = new System.Windows.Forms.Label();
            this.LblAutoridad = new System.Windows.Forms.Label();
            this.LblNumPass = new System.Windows.Forms.Label();
            this.LblNumLib = new System.Windows.Forms.Label();
            this.TxtNumPasaporte = new System.Windows.Forms.TextBox();
            this.TxtNumLibreta = new System.Windows.Forms.TextBox();
            this.LblTipoPass = new System.Windows.Forms.Label();
            this.CmbTipoPass = new System.Windows.Forms.ComboBox();
            this.LblPasaporte = new System.Windows.Forms.Label();
            this.TxtIdPass = new System.Windows.Forms.TextBox();
            this.TxtNacimiento = new System.Windows.Forms.TextBox();
            this.LblNacimiento = new System.Windows.Forms.Label();
            this.TbcDatos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GbxLugarNac.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(600, 21);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(130, 48);
            this.BtnBuscar.TabIndex = 132;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.BtnIngresar.Enabled = false;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIngresar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIngresar.Location = new System.Drawing.Point(662, 574);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(190, 61);
            this.BtnIngresar.TabIndex = 131;
            this.BtnIngresar.Text = "Renovar Pasaporte";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TbcDatos
            // 
            this.TbcDatos.Controls.Add(this.tabPage1);
            this.TbcDatos.Controls.Add(this.tabPage2);
            this.TbcDatos.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbcDatos.Location = new System.Drawing.Point(15, 84);
            this.TbcDatos.Name = "TbcDatos";
            this.TbcDatos.SelectedIndex = 0;
            this.TbcDatos.Size = new System.Drawing.Size(837, 476);
            this.TbcDatos.TabIndex = 130;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.tabPage1.Controls.Add(this.LblDpi);
            this.tabPage1.Controls.Add(this.LblNombres);
            this.tabPage1.Controls.Add(this.LblFechaNac);
            this.tabPage1.Controls.Add(this.TxtNumDpi);
            this.tabPage1.Controls.Add(this.TxtApellidos);
            this.tabPage1.Controls.Add(this.DtpFechaNac);
            this.tabPage1.Controls.Add(this.LblApellidos);
            this.tabPage1.Controls.Add(this.TxtNombres);
            this.tabPage1.Controls.Add(this.GbxLugarNac);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Personales";
            // 
            // LblDpi
            // 
            this.LblDpi.AutoSize = true;
            this.LblDpi.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDpi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblDpi.Location = new System.Drawing.Point(11, 55);
            this.LblDpi.Name = "LblDpi";
            this.LblDpi.Size = new System.Drawing.Size(50, 22);
            this.LblDpi.TabIndex = 129;
            this.LblDpi.Text = "Dpi:";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNombres.Location = new System.Drawing.Point(11, 110);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(99, 22);
            this.LblNombres.TabIndex = 103;
            this.LblNombres.Text = "Nombres:";
            // 
            // LblFechaNac
            // 
            this.LblFechaNac.AutoSize = true;
            this.LblFechaNac.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFechaNac.Location = new System.Drawing.Point(11, 219);
            this.LblFechaNac.Name = "LblFechaNac";
            this.LblFechaNac.Size = new System.Drawing.Size(207, 22);
            this.LblFechaNac.TabIndex = 100;
            this.LblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // TxtNumDpi
            // 
            this.TxtNumDpi.Enabled = false;
            this.TxtNumDpi.Location = new System.Drawing.Point(154, 46);
            this.TxtNumDpi.Name = "TxtNumDpi";
            this.TxtNumDpi.Size = new System.Drawing.Size(288, 31);
            this.TxtNumDpi.TabIndex = 129;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Enabled = false;
            this.TxtApellidos.Location = new System.Drawing.Point(154, 155);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(362, 31);
            this.TxtApellidos.TabIndex = 106;
            // 
            // DtpFechaNac
            // 
            this.DtpFechaNac.CalendarFont = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaNac.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtpFechaNac.Enabled = false;
            this.DtpFechaNac.Location = new System.Drawing.Point(15, 261);
            this.DtpFechaNac.Name = "DtpFechaNac";
            this.DtpFechaNac.Size = new System.Drawing.Size(368, 31);
            this.DtpFechaNac.TabIndex = 99;
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblApellidos.Location = new System.Drawing.Point(11, 164);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(105, 22);
            this.LblApellidos.TabIndex = 104;
            this.LblApellidos.Text = "Apellidos:";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Enabled = false;
            this.TxtNombres.Location = new System.Drawing.Point(154, 101);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(362, 31);
            this.TxtNombres.TabIndex = 105;
            // 
            // GbxLugarNac
            // 
            this.GbxLugarNac.Controls.Add(this.CmbMuni);
            this.GbxLugarNac.Controls.Add(this.CmbDepto);
            this.GbxLugarNac.Controls.Add(this.LblDepto);
            this.GbxLugarNac.Controls.Add(this.LblMuni);
            this.GbxLugarNac.Enabled = false;
            this.GbxLugarNac.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxLugarNac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GbxLugarNac.Location = new System.Drawing.Point(547, 32);
            this.GbxLugarNac.Name = "GbxLugarNac";
            this.GbxLugarNac.Size = new System.Drawing.Size(276, 238);
            this.GbxLugarNac.TabIndex = 94;
            this.GbxLugarNac.TabStop = false;
            this.GbxLugarNac.Text = "Lugar de Nacimiento";
            // 
            // CmbMuni
            // 
            this.CmbMuni.FormattingEnabled = true;
            this.CmbMuni.Location = new System.Drawing.Point(10, 169);
            this.CmbMuni.Name = "CmbMuni";
            this.CmbMuni.Size = new System.Drawing.Size(250, 30);
            this.CmbMuni.TabIndex = 95;
            // 
            // CmbDepto
            // 
            this.CmbDepto.FormattingEnabled = true;
            this.CmbDepto.Location = new System.Drawing.Point(10, 84);
            this.CmbDepto.Name = "CmbDepto";
            this.CmbDepto.Size = new System.Drawing.Size(250, 30);
            this.CmbDepto.TabIndex = 94;
            // 
            // LblDepto
            // 
            this.LblDepto.AutoSize = true;
            this.LblDepto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblDepto.Location = new System.Drawing.Point(6, 44);
            this.LblDepto.Name = "LblDepto";
            this.LblDepto.Size = new System.Drawing.Size(147, 22);
            this.LblDepto.TabIndex = 90;
            this.LblDepto.Text = "Departamento:";
            // 
            // LblMuni
            // 
            this.LblMuni.AutoSize = true;
            this.LblMuni.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMuni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblMuni.Location = new System.Drawing.Point(6, 133);
            this.LblMuni.Name = "LblMuni";
            this.LblMuni.Size = new System.Drawing.Size(108, 22);
            this.LblMuni.TabIndex = 93;
            this.LblMuni.Text = "Municipio:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.tabPage2.Controls.Add(this.TxtNacimiento);
            this.tabPage2.Controls.Add(this.LblNacimiento);
            this.tabPage2.Controls.Add(this.CmbAutoridad);
            this.tabPage2.Controls.Add(this.PbxFoto);
            this.tabPage2.Controls.Add(this.DtpCreacion);
            this.tabPage2.Controls.Add(this.DtpVencimiento);
            this.tabPage2.Controls.Add(this.LblFechaVen);
            this.tabPage2.Controls.Add(this.LblFoto);
            this.tabPage2.Controls.Add(this.LblFechaCre);
            this.tabPage2.Controls.Add(this.LblAutoridad);
            this.tabPage2.Controls.Add(this.LblNumPass);
            this.tabPage2.Controls.Add(this.LblNumLib);
            this.tabPage2.Controls.Add(this.TxtNumPasaporte);
            this.tabPage2.Controls.Add(this.TxtNumLibreta);
            this.tabPage2.Controls.Add(this.LblTipoPass);
            this.tabPage2.Controls.Add(this.CmbTipoPass);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(829, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Pasaporte";
            // 
            // CmbAutoridad
            // 
            this.CmbAutoridad.Enabled = false;
            this.CmbAutoridad.FormattingEnabled = true;
            this.CmbAutoridad.Items.AddRange(new object[] {
            "Director",
            "Sub-Director"});
            this.CmbAutoridad.Location = new System.Drawing.Point(289, 176);
            this.CmbAutoridad.Name = "CmbAutoridad";
            this.CmbAutoridad.Size = new System.Drawing.Size(193, 30);
            this.CmbAutoridad.TabIndex = 103;
            // 
            // PbxFoto
            // 
            this.PbxFoto.Location = new System.Drawing.Point(588, 55);
            this.PbxFoto.Name = "PbxFoto";
            this.PbxFoto.Size = new System.Drawing.Size(210, 200);
            this.PbxFoto.TabIndex = 98;
            this.PbxFoto.TabStop = false;
            // 
            // DtpCreacion
            // 
            this.DtpCreacion.CalendarFont = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCreacion.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtpCreacion.Enabled = false;
            this.DtpCreacion.Location = new System.Drawing.Point(37, 318);
            this.DtpCreacion.Name = "DtpCreacion";
            this.DtpCreacion.Size = new System.Drawing.Size(368, 31);
            this.DtpCreacion.TabIndex = 94;
            // 
            // DtpVencimiento
            // 
            this.DtpVencimiento.CalendarFont = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpVencimiento.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtpVencimiento.Enabled = false;
            this.DtpVencimiento.Location = new System.Drawing.Point(37, 395);
            this.DtpVencimiento.Name = "DtpVencimiento";
            this.DtpVencimiento.Size = new System.Drawing.Size(368, 31);
            this.DtpVencimiento.TabIndex = 95;
            // 
            // LblFechaVen
            // 
            this.LblFechaVen.AutoSize = true;
            this.LblFechaVen.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaVen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFechaVen.Location = new System.Drawing.Point(33, 361);
            this.LblFechaVen.Name = "LblFechaVen";
            this.LblFechaVen.Size = new System.Drawing.Size(218, 22);
            this.LblFechaVen.TabIndex = 92;
            this.LblFechaVen.Text = "Fecha de Vencimiento:";
            // 
            // LblFoto
            // 
            this.LblFoto.AutoSize = true;
            this.LblFoto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFoto.Location = new System.Drawing.Point(642, 26);
            this.LblFoto.Name = "LblFoto";
            this.LblFoto.Size = new System.Drawing.Size(104, 22);
            this.LblFoto.TabIndex = 85;
            this.LblFoto.Text = "Fotografía";
            // 
            // LblFechaCre
            // 
            this.LblFechaCre.AutoSize = true;
            this.LblFechaCre.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaCre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFechaCre.Location = new System.Drawing.Point(33, 275);
            this.LblFechaCre.Name = "LblFechaCre";
            this.LblFechaCre.Size = new System.Drawing.Size(181, 22);
            this.LblFechaCre.TabIndex = 91;
            this.LblFechaCre.Text = "Fecha de Creación";
            // 
            // LblAutoridad
            // 
            this.LblAutoridad.AutoSize = true;
            this.LblAutoridad.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutoridad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblAutoridad.Location = new System.Drawing.Point(33, 184);
            this.LblAutoridad.Name = "LblAutoridad";
            this.LblAutoridad.Size = new System.Drawing.Size(231, 22);
            this.LblAutoridad.TabIndex = 101;
            this.LblAutoridad.Text = "Autoridad Responsable:";
            // 
            // LblNumPass
            // 
            this.LblNumPass.AutoSize = true;
            this.LblNumPass.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNumPass.Location = new System.Drawing.Point(33, 35);
            this.LblNumPass.Name = "LblNumPass";
            this.LblNumPass.Size = new System.Drawing.Size(213, 22);
            this.LblNumPass.TabIndex = 88;
            this.LblNumPass.Text = "Número de Pasaporte:";
            // 
            // LblNumLib
            // 
            this.LblNumLib.AutoSize = true;
            this.LblNumLib.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumLib.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNumLib.Location = new System.Drawing.Point(33, 84);
            this.LblNumLib.Name = "LblNumLib";
            this.LblNumLib.Size = new System.Drawing.Size(187, 22);
            this.LblNumLib.TabIndex = 89;
            this.LblNumLib.Text = "Número de Libreta:";
            // 
            // TxtNumPasaporte
            // 
            this.TxtNumPasaporte.Enabled = false;
            this.TxtNumPasaporte.Location = new System.Drawing.Point(289, 26);
            this.TxtNumPasaporte.Name = "TxtNumPasaporte";
            this.TxtNumPasaporte.Size = new System.Drawing.Size(193, 31);
            this.TxtNumPasaporte.TabIndex = 96;
            // 
            // TxtNumLibreta
            // 
            this.TxtNumLibreta.Enabled = false;
            this.TxtNumLibreta.Location = new System.Drawing.Point(289, 75);
            this.TxtNumLibreta.Name = "TxtNumLibreta";
            this.TxtNumLibreta.Size = new System.Drawing.Size(193, 31);
            this.TxtNumLibreta.TabIndex = 97;
            // 
            // LblTipoPass
            // 
            this.LblTipoPass.AutoSize = true;
            this.LblTipoPass.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTipoPass.Location = new System.Drawing.Point(33, 134);
            this.LblTipoPass.Name = "LblTipoPass";
            this.LblTipoPass.Size = new System.Drawing.Size(176, 22);
            this.LblTipoPass.TabIndex = 84;
            this.LblTipoPass.Text = "Tipo de Pasaporte";
            // 
            // CmbTipoPass
            // 
            this.CmbTipoPass.Enabled = false;
            this.CmbTipoPass.FormattingEnabled = true;
            this.CmbTipoPass.Location = new System.Drawing.Point(289, 126);
            this.CmbTipoPass.Name = "CmbTipoPass";
            this.CmbTipoPass.Size = new System.Drawing.Size(193, 30);
            this.CmbTipoPass.TabIndex = 87;
            // 
            // LblPasaporte
            // 
            this.LblPasaporte.AutoSize = true;
            this.LblPasaporte.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPasaporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPasaporte.Location = new System.Drawing.Point(51, 33);
            this.LblPasaporte.Name = "LblPasaporte";
            this.LblPasaporte.Size = new System.Drawing.Size(256, 22);
            this.LblPasaporte.TabIndex = 128;
            this.LblPasaporte.Text = "Ingrese el Id del Pasaporte";
            // 
            // TxtIdPass
            // 
            this.TxtIdPass.Location = new System.Drawing.Point(360, 35);
            this.TxtIdPass.Name = "TxtIdPass";
            this.TxtIdPass.Size = new System.Drawing.Size(193, 22);
            this.TxtIdPass.TabIndex = 133;
            // 
            // TxtNacimiento
            // 
            this.TxtNacimiento.Enabled = false;
            this.TxtNacimiento.Location = new System.Drawing.Point(289, 224);
            this.TxtNacimiento.Name = "TxtNacimiento";
            this.TxtNacimiento.Size = new System.Drawing.Size(193, 31);
            this.TxtNacimiento.TabIndex = 107;
            // 
            // LblNacimiento
            // 
            this.LblNacimiento.AutoSize = true;
            this.LblNacimiento.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNacimiento.Location = new System.Drawing.Point(33, 233);
            this.LblNacimiento.Name = "LblNacimiento";
            this.LblNacimiento.Size = new System.Drawing.Size(206, 22);
            this.LblNacimiento.TabIndex = 106;
            this.LblNacimiento.Text = "Lugar de Nacimiento:";
            // 
            // frmRenovarPasaporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(865, 646);
            this.Controls.Add(this.TxtIdPass);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TbcDatos);
            this.Controls.Add(this.LblPasaporte);
            this.Name = "frmRenovarPasaporte";
            this.Text = "frmRenovarPasaporte";
            this.TbcDatos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GbxLugarNac.ResumeLayout(false);
            this.GbxLugarNac.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TabControl TbcDatos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblFechaNac;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.DateTimePicker DtpFechaNac;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.GroupBox GbxLugarNac;
        private System.Windows.Forms.ComboBox CmbMuni;
        private System.Windows.Forms.ComboBox CmbDepto;
        private System.Windows.Forms.Label LblDepto;
        private System.Windows.Forms.Label LblMuni;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox PbxFoto;
        private System.Windows.Forms.DateTimePicker DtpCreacion;
        private System.Windows.Forms.DateTimePicker DtpVencimiento;
        private System.Windows.Forms.Label LblFechaVen;
        private System.Windows.Forms.Label LblFoto;
        private System.Windows.Forms.Label LblFechaCre;
        private System.Windows.Forms.Label LblAutoridad;
        private System.Windows.Forms.Label LblNumLib;
        private System.Windows.Forms.TextBox TxtNumLibreta;
        private System.Windows.Forms.Label LblTipoPass;
        private System.Windows.Forms.ComboBox CmbTipoPass;
        private System.Windows.Forms.TextBox TxtNumDpi;
        private System.Windows.Forms.Label LblPasaporte;
        private System.Windows.Forms.Label LblDpi;
        private System.Windows.Forms.ComboBox CmbAutoridad;
        private System.Windows.Forms.TextBox TxtNumPasaporte;
        private System.Windows.Forms.Label LblNumPass;
        private System.Windows.Forms.TextBox TxtIdPass;
        private System.Windows.Forms.TextBox TxtNacimiento;
        private System.Windows.Forms.Label LblNacimiento;
    }
}
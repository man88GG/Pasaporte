
namespace CapaVista
{
    partial class frmAgendarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendarCita));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbCodigoCentro = new System.Windows.Forms.ComboBox();
            this.cmbCodigoMunicipio = new System.Windows.Forms.ComboBox();
            this.cmbCodigoDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDireccionCentro = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cmbCentro = new System.Windows.Forms.ComboBox();
            this.lblCentro = new System.Windows.Forms.Label();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbHora11 = new System.Windows.Forms.RadioButton();
            this.rbHora9 = new System.Windows.Forms.RadioButton();
            this.rbHora10 = new System.Windows.Forms.RadioButton();
            this.rbHora8 = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.cmbCodigoCentro);
            this.groupBox1.Controls.Add(this.cmbCodigoMunicipio);
            this.groupBox1.Controls.Add(this.cmbCodigoDepartamento);
            this.groupBox1.Controls.Add(this.lblDireccionCentro);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.cmbCentro);
            this.groupBox1.Controls.Add(this.lblCentro);
            this.groupBox1.Controls.Add(this.cmbMunicipio);
            this.groupBox1.Controls.Add(this.lblMunicipio);
            this.groupBox1.Controls.Add(this.cmbDepartamento);
            this.groupBox1.Controls.Add(this.lblDepartamento);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 511);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendar Cita";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigo.Location = new System.Drawing.Point(388, 108);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(79, 22);
            this.lblCodigo.TabIndex = 109;
            this.lblCodigo.Text = "Codigo";
            this.lblCodigo.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(392, 145);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(127, 27);
            this.txtCodigo.TabIndex = 108;
            this.txtCodigo.Visible = false;
            // 
            // cmbCodigoCentro
            // 
            this.cmbCodigoCentro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoCentro.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoCentro.FormattingEnabled = true;
            this.cmbCodigoCentro.Location = new System.Drawing.Point(244, 310);
            this.cmbCodigoCentro.Name = "cmbCodigoCentro";
            this.cmbCodigoCentro.Size = new System.Drawing.Size(60, 28);
            this.cmbCodigoCentro.TabIndex = 96;
            this.cmbCodigoCentro.Visible = false;
            // 
            // cmbCodigoMunicipio
            // 
            this.cmbCodigoMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoMunicipio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoMunicipio.FormattingEnabled = true;
            this.cmbCodigoMunicipio.Location = new System.Drawing.Point(244, 212);
            this.cmbCodigoMunicipio.Name = "cmbCodigoMunicipio";
            this.cmbCodigoMunicipio.Size = new System.Drawing.Size(60, 28);
            this.cmbCodigoMunicipio.TabIndex = 95;
            this.cmbCodigoMunicipio.Visible = false;
            // 
            // cmbCodigoDepartamento
            // 
            this.cmbCodigoDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoDepartamento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoDepartamento.FormattingEnabled = true;
            this.cmbCodigoDepartamento.Location = new System.Drawing.Point(244, 108);
            this.cmbCodigoDepartamento.Name = "cmbCodigoDepartamento";
            this.cmbCodigoDepartamento.Size = new System.Drawing.Size(60, 28);
            this.cmbCodigoDepartamento.TabIndex = 94;
            this.cmbCodigoDepartamento.Visible = false;
            // 
            // lblDireccionCentro
            // 
            this.lblDireccionCentro.AutoSize = true;
            this.lblDireccionCentro.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCentro.Location = new System.Drawing.Point(150, 372);
            this.lblDireccionCentro.Name = "lblDireccionCentro";
            this.lblDireccionCentro.Size = new System.Drawing.Size(0, 20);
            this.lblDireccionCentro.TabIndex = 93;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFecha.Location = new System.Drawing.Point(17, 414);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(70, 22);
            this.lblFecha.TabIndex = 92;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(21, 459);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(494, 35);
            this.dtpFecha.TabIndex = 91;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDireccion.Location = new System.Drawing.Point(17, 370);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(104, 22);
            this.lblDireccion.TabIndex = 90;
            this.lblDireccion.Text = "Direccion:";
            // 
            // cmbCentro
            // 
            this.cmbCentro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCentro.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCentro.FormattingEnabled = true;
            this.cmbCentro.Location = new System.Drawing.Point(21, 310);
            this.cmbCentro.Name = "cmbCentro";
            this.cmbCentro.Size = new System.Drawing.Size(205, 28);
            this.cmbCentro.TabIndex = 89;
            this.cmbCentro.SelectedIndexChanged += new System.EventHandler(this.cmbCentro_SelectedIndexChanged);
            // 
            // lblCentro
            // 
            this.lblCentro.AutoSize = true;
            this.lblCentro.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCentro.Location = new System.Drawing.Point(17, 264);
            this.lblCentro.Name = "lblCentro";
            this.lblCentro.Size = new System.Drawing.Size(78, 22);
            this.lblCentro.TabIndex = 88;
            this.lblCentro.Text = "Centro:";
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMunicipio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(21, 212);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(205, 28);
            this.cmbMunicipio.TabIndex = 87;
            this.cmbMunicipio.SelectedIndexChanged += new System.EventHandler(this.cmbMunicipio_SelectedIndexChanged);
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMunicipio.Location = new System.Drawing.Point(17, 166);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(102, 22);
            this.lblMunicipio.TabIndex = 86;
            this.lblMunicipio.Text = "Municipio";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(21, 108);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(205, 28);
            this.cmbDepartamento.TabIndex = 85;
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartamento.Location = new System.Drawing.Point(17, 62);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(147, 22);
            this.lblDepartamento.TabIndex = 84;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(153, 777);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(190, 61);
            this.btnIngresar.TabIndex = 79;
            this.btnIngresar.Text = "Agendar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(554, 37);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(72, 72);
            this.btnAyuda.TabIndex = 81;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbHora11);
            this.groupBox2.Controls.Add(this.rbHora9);
            this.groupBox2.Controls.Add(this.rbHora10);
            this.groupBox2.Controls.Add(this.rbHora8);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 562);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 191);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horario";
            // 
            // rbHora11
            // 
            this.rbHora11.AutoSize = true;
            this.rbHora11.Location = new System.Drawing.Point(234, 118);
            this.rbHora11.Name = "rbHora11";
            this.rbHora11.Size = new System.Drawing.Size(136, 31);
            this.rbHora11.TabIndex = 3;
            this.rbHora11.TabStop = true;
            this.rbHora11.Text = "11:00 Hrs";
            this.rbHora11.UseVisualStyleBackColor = true;
            this.rbHora11.CheckedChanged += new System.EventHandler(this.rbHora11_CheckedChanged);
            // 
            // rbHora9
            // 
            this.rbHora9.AutoSize = true;
            this.rbHora9.Location = new System.Drawing.Point(234, 50);
            this.rbHora9.Name = "rbHora9";
            this.rbHora9.Size = new System.Drawing.Size(136, 31);
            this.rbHora9.TabIndex = 2;
            this.rbHora9.TabStop = true;
            this.rbHora9.Text = "09:00 Hrs";
            this.rbHora9.UseVisualStyleBackColor = true;
            this.rbHora9.CheckedChanged += new System.EventHandler(this.rbHora9_CheckedChanged);
            // 
            // rbHora10
            // 
            this.rbHora10.AutoSize = true;
            this.rbHora10.Location = new System.Drawing.Point(21, 106);
            this.rbHora10.Name = "rbHora10";
            this.rbHora10.Size = new System.Drawing.Size(136, 31);
            this.rbHora10.TabIndex = 1;
            this.rbHora10.TabStop = true;
            this.rbHora10.Text = "10:00 Hrs";
            this.rbHora10.UseVisualStyleBackColor = true;
            this.rbHora10.CheckedChanged += new System.EventHandler(this.rbHora10_CheckedChanged);
            // 
            // rbHora8
            // 
            this.rbHora8.AutoSize = true;
            this.rbHora8.Location = new System.Drawing.Point(21, 50);
            this.rbHora8.Name = "rbHora8";
            this.rbHora8.Size = new System.Drawing.Size(136, 31);
            this.rbHora8.TabIndex = 0;
            this.rbHora8.TabStop = true;
            this.rbHora8.Text = "08:00 Hrs";
            this.rbHora8.UseVisualStyleBackColor = true;
            this.rbHora8.CheckedChanged += new System.EventHandler(this.rbHora8_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(358, 777);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 61);
            this.btnCancelar.TabIndex = 83;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(642, 863);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgendarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Cita";
            this.Load += new System.EventHandler(this.frmAgendarCita_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cmbCentro;
        private System.Windows.Forms.Label lblCentro;
        private System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.ComboBox cmbCodigoCentro;
        private System.Windows.Forms.ComboBox cmbCodigoMunicipio;
        private System.Windows.Forms.ComboBox cmbCodigoDepartamento;
        private System.Windows.Forms.Label lblDireccionCentro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbHora11;
        private System.Windows.Forms.RadioButton rbHora9;
        private System.Windows.Forms.RadioButton rbHora10;
        private System.Windows.Forms.RadioButton rbHora8;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCancelar;
    }
}
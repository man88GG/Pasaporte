
namespace CapaVista
{
    partial class frmListadoPasaportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoPasaportes));
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.DgvMostrarPasaportes = new System.Windows.Forms.DataGridView();
            this.GbxFiltrado = new System.Windows.Forms.GroupBox();
            this.RbtnNumLib = new System.Windows.Forms.RadioButton();
            this.RbtnNumPass = new System.Windows.Forms.RadioButton();
            this.RbtnId = new System.Windows.Forms.RadioButton();
            this.TxtIdPass = new System.Windows.Forms.TextBox();
            this.TxtNumPass = new System.Windows.Forms.TextBox();
            this.TxtNumLib = new System.Windows.Forms.TextBox();
            this.LblPasaporte = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarPasaportes)).BeginInit();
            this.GbxFiltrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnActualizar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.Location = new System.Drawing.Point(628, 22);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(190, 61);
            this.BtnActualizar.TabIndex = 135;
            this.BtnActualizar.Text = "Actualizar Lista";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // DgvMostrarPasaportes
            // 
            this.DgvMostrarPasaportes.AllowUserToAddRows = false;
            this.DgvMostrarPasaportes.AllowUserToDeleteRows = false;
            this.DgvMostrarPasaportes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvMostrarPasaportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMostrarPasaportes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvMostrarPasaportes.Location = new System.Drawing.Point(0, 246);
            this.DgvMostrarPasaportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvMostrarPasaportes.Name = "DgvMostrarPasaportes";
            this.DgvMostrarPasaportes.RowHeadersVisible = false;
            this.DgvMostrarPasaportes.RowHeadersWidth = 51;
            this.DgvMostrarPasaportes.RowTemplate.Height = 24;
            this.DgvMostrarPasaportes.Size = new System.Drawing.Size(930, 354);
            this.DgvMostrarPasaportes.TabIndex = 136;
            // 
            // GbxFiltrado
            // 
            this.GbxFiltrado.Controls.Add(this.RbtnNumLib);
            this.GbxFiltrado.Controls.Add(this.RbtnNumPass);
            this.GbxFiltrado.Controls.Add(this.RbtnId);
            this.GbxFiltrado.Controls.Add(this.TxtIdPass);
            this.GbxFiltrado.Controls.Add(this.TxtNumPass);
            this.GbxFiltrado.Controls.Add(this.TxtNumLib);
            this.GbxFiltrado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GbxFiltrado.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxFiltrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GbxFiltrado.Location = new System.Drawing.Point(0, 109);
            this.GbxFiltrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbxFiltrado.Name = "GbxFiltrado";
            this.GbxFiltrado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbxFiltrado.Size = new System.Drawing.Size(930, 137);
            this.GbxFiltrado.TabIndex = 137;
            this.GbxFiltrado.TabStop = false;
            this.GbxFiltrado.Text = "Filtrado De Datos";
            // 
            // RbtnNumLib
            // 
            this.RbtnNumLib.AutoSize = true;
            this.RbtnNumLib.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnNumLib.Location = new System.Drawing.Point(628, 49);
            this.RbtnNumLib.Margin = new System.Windows.Forms.Padding(4);
            this.RbtnNumLib.Name = "RbtnNumLib";
            this.RbtnNumLib.Size = new System.Drawing.Size(184, 24);
            this.RbtnNumLib.TabIndex = 12;
            this.RbtnNumLib.TabStop = true;
            this.RbtnNumLib.Text = "Por Número Libreta";
            this.RbtnNumLib.UseVisualStyleBackColor = true;
            this.RbtnNumLib.CheckedChanged += new System.EventHandler(this.RbtnNumLib_CheckedChanged);
            // 
            // RbtnNumPass
            // 
            this.RbtnNumPass.AutoSize = true;
            this.RbtnNumPass.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnNumPass.Location = new System.Drawing.Point(329, 49);
            this.RbtnNumPass.Margin = new System.Windows.Forms.Padding(4);
            this.RbtnNumPass.Name = "RbtnNumPass";
            this.RbtnNumPass.Size = new System.Drawing.Size(207, 24);
            this.RbtnNumPass.TabIndex = 11;
            this.RbtnNumPass.TabStop = true;
            this.RbtnNumPass.Text = "Por Número Pasaporte";
            this.RbtnNumPass.UseVisualStyleBackColor = true;
            this.RbtnNumPass.CheckedChanged += new System.EventHandler(this.RbtnNumPass_CheckedChanged);
            // 
            // RbtnId
            // 
            this.RbtnId.AutoSize = true;
            this.RbtnId.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnId.Location = new System.Drawing.Point(137, 49);
            this.RbtnId.Margin = new System.Windows.Forms.Padding(4);
            this.RbtnId.Name = "RbtnId";
            this.RbtnId.Size = new System.Drawing.Size(76, 24);
            this.RbtnId.TabIndex = 10;
            this.RbtnId.TabStop = true;
            this.RbtnId.Text = "Por Id";
            this.RbtnId.UseVisualStyleBackColor = true;
            this.RbtnId.CheckedChanged += new System.EventHandler(this.RbtnId_CheckedChanged);
            // 
            // TxtIdPass
            // 
            this.TxtIdPass.Enabled = false;
            this.TxtIdPass.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdPass.Location = new System.Drawing.Point(86, 90);
            this.TxtIdPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtIdPass.Name = "TxtIdPass";
            this.TxtIdPass.Size = new System.Drawing.Size(165, 27);
            this.TxtIdPass.TabIndex = 9;
            this.TxtIdPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FuncNumero);
            this.TxtIdPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtIdPass_KeyUp);
            // 
            // TxtNumPass
            // 
            this.TxtNumPass.Enabled = false;
            this.TxtNumPass.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumPass.Location = new System.Drawing.Point(352, 90);
            this.TxtNumPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNumPass.Name = "TxtNumPass";
            this.TxtNumPass.Size = new System.Drawing.Size(167, 27);
            this.TxtNumPass.TabIndex = 5;
            this.TxtNumPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FuncNumero);
            this.TxtNumPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNumPass_KeyUp);
            // 
            // TxtNumLib
            // 
            this.TxtNumLib.Enabled = false;
            this.TxtNumLib.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumLib.Location = new System.Drawing.Point(647, 90);
            this.TxtNumLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNumLib.Name = "TxtNumLib";
            this.TxtNumLib.Size = new System.Drawing.Size(165, 27);
            this.TxtNumLib.TabIndex = 6;
            this.TxtNumLib.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNumLib_KeyUp);
            // 
            // LblPasaporte
            // 
            this.LblPasaporte.AutoSize = true;
            this.LblPasaporte.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPasaporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPasaporte.Location = new System.Drawing.Point(286, 42);
            this.LblPasaporte.Name = "LblPasaporte";
            this.LblPasaporte.Size = new System.Drawing.Size(316, 31);
            this.LblPasaporte.TabIndex = 138;
            this.LblPasaporte.Text = "Pasaportes Sin Renovar";
            this.LblPasaporte.Click += new System.EventHandler(this.LblPasaporte_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(846, 11);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(72, 72);
            this.btnAyuda.TabIndex = 139;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // frmListadoPasaportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(930, 600);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.LblPasaporte);
            this.Controls.Add(this.GbxFiltrado);
            this.Controls.Add(this.DgvMostrarPasaportes);
            this.Controls.Add(this.BtnActualizar);
            this.Name = "frmListadoPasaportes";
            this.Text = "frmListadoPasaportes";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarPasaportes)).EndInit();
            this.GbxFiltrado.ResumeLayout(false);
            this.GbxFiltrado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView DgvMostrarPasaportes;
        private System.Windows.Forms.GroupBox GbxFiltrado;
        private System.Windows.Forms.RadioButton RbtnNumLib;
        private System.Windows.Forms.RadioButton RbtnNumPass;
        private System.Windows.Forms.RadioButton RbtnId;
        private System.Windows.Forms.TextBox TxtIdPass;
        private System.Windows.Forms.TextBox TxtNumPass;
        private System.Windows.Forms.TextBox TxtNumLib;
        private System.Windows.Forms.Label LblPasaporte;
        private System.Windows.Forms.Button btnAyuda;
    }
}
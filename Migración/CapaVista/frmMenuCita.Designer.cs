
namespace CapaVista
{
    partial class frmMenuCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuCita));
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnBuscarCita = new System.Windows.Forms.Button();
            this.btnGenerarCita = new System.Windows.Forms.Button();
            this.gbOpcion = new System.Windows.Forms.GroupBox();
            this.gbOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(442, 23);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(72, 72);
            this.btnAyuda.TabIndex = 79;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCita
            // 
            this.btnBuscarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnBuscarCita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCita.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCita.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCita.Location = new System.Drawing.Point(76, 123);
            this.btnBuscarCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarCita.Name = "btnBuscarCita";
            this.btnBuscarCita.Size = new System.Drawing.Size(190, 61);
            this.btnBuscarCita.TabIndex = 78;
            this.btnBuscarCita.Text = "Buscar Cita";
            this.btnBuscarCita.UseVisualStyleBackColor = false;
            this.btnBuscarCita.Click += new System.EventHandler(this.btnBuscarCita_Click);
            // 
            // btnGenerarCita
            // 
            this.btnGenerarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnGenerarCita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarCita.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCita.ForeColor = System.Drawing.Color.White;
            this.btnGenerarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarCita.Location = new System.Drawing.Point(76, 48);
            this.btnGenerarCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarCita.Name = "btnGenerarCita";
            this.btnGenerarCita.Size = new System.Drawing.Size(190, 61);
            this.btnGenerarCita.TabIndex = 77;
            this.btnGenerarCita.Text = "Generar cita";
            this.btnGenerarCita.UseVisualStyleBackColor = false;
            this.btnGenerarCita.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // gbOpcion
            // 
            this.gbOpcion.Controls.Add(this.btnBuscarCita);
            this.gbOpcion.Controls.Add(this.btnGenerarCita);
            this.gbOpcion.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbOpcion.Location = new System.Drawing.Point(22, 23);
            this.gbOpcion.Name = "gbOpcion";
            this.gbOpcion.Size = new System.Drawing.Size(369, 215);
            this.gbOpcion.TabIndex = 80;
            this.gbOpcion.TabStop = false;
            this.gbOpcion.Text = "Seleccione una opción:";
            // 
            // frmMenuCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(534, 276);
            this.Controls.Add(this.gbOpcion);
            this.Controls.Add(this.btnAyuda);
            this.Name = "frmMenuCita";
            this.Text = "frmMenuCita";
            this.gbOpcion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnBuscarCita;
        private System.Windows.Forms.Button btnGenerarCita;
        private System.Windows.Forms.GroupBox gbOpcion;
    }
}
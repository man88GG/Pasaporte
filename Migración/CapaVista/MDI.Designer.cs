
namespace CapaVista
{
    partial class MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarPasaporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(695, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(135, 25);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarCitaToolStripMenuItem,
            this.generarPasaporteToolStripMenuItem});
            this.procesosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // gestionarCitaToolStripMenuItem
            // 
            this.gestionarCitaToolStripMenuItem.Name = "gestionarCitaToolStripMenuItem";
            this.gestionarCitaToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.gestionarCitaToolStripMenuItem.Text = "Gestionar Cita";
            this.gestionarCitaToolStripMenuItem.Click += new System.EventHandler(this.gestionarCitaToolStripMenuItem_Click);
            // 
            // generarPasaporteToolStripMenuItem
            // 
            this.generarPasaporteToolStripMenuItem.Name = "generarPasaporteToolStripMenuItem";
            this.generarPasaporteToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.generarPasaporteToolStripMenuItem.Text = "Generar Pasaporte";
            this.generarPasaporteToolStripMenuItem.Click += new System.EventHandler(this.generarPasaporteToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ayudasToolStripMenuItem
            // 
            this.ayudasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ayudasToolStripMenuItem.Name = "ayudasToolStripMenuItem";
            this.ayudasToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.ayudasToolStripMenuItem.Text = "Ayudas";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 366);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MDI";
            this.Text = "MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarPasaporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudasToolStripMenuItem;
    }
}
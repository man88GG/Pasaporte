﻿
namespace MDI
{
    partial class MDI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipocasoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePasaporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeTramiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocupacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDePasaportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPasaporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renovarPasaporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregaPasaporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeUsuriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDePerfilYAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoModuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDePerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeAplicacionAPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.bitácoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.menuStrip1.Size = new System.Drawing.Size(822, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipocasoToolStripMenuItem,
            this.tipoDePasaporteToolStripMenuItem,
            this.tipoDeTramiteToolStripMenuItem,
            this.ocupacionToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(121, 21);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // tipocasoToolStripMenuItem
            // 
            this.tipocasoToolStripMenuItem.Name = "tipocasoToolStripMenuItem";
            this.tipocasoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.tipocasoToolStripMenuItem.Text = "Tipo de Caso";
            this.tipocasoToolStripMenuItem.Click += new System.EventHandler(this.tipocasoToolStripMenuItem_Click);
            // 
            // tipoDePasaporteToolStripMenuItem
            // 
            this.tipoDePasaporteToolStripMenuItem.Name = "tipoDePasaporteToolStripMenuItem";
            this.tipoDePasaporteToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.tipoDePasaporteToolStripMenuItem.Text = "Tipo de Pasaporte";
            this.tipoDePasaporteToolStripMenuItem.Click += new System.EventHandler(this.tipoDePasaporteToolStripMenuItem_Click);
            // 
            // tipoDeTramiteToolStripMenuItem
            // 
            this.tipoDeTramiteToolStripMenuItem.Name = "tipoDeTramiteToolStripMenuItem";
            this.tipoDeTramiteToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.tipoDeTramiteToolStripMenuItem.Text = "Tipo de Tramite";
            this.tipoDeTramiteToolStripMenuItem.Click += new System.EventHandler(this.tipoDeTramiteToolStripMenuItem_Click);
            // 
            // ocupacionToolStripMenuItem
            // 
            this.ocupacionToolStripMenuItem.Name = "ocupacionToolStripMenuItem";
            this.ocupacionToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ocupacionToolStripMenuItem.Text = "Ocupacion";
            this.ocupacionToolStripMenuItem.Click += new System.EventHandler(this.ocupacionToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeCitasToolStripMenuItem,
            this.gestionDePasaportesToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // gestionDeCitasToolStripMenuItem
            // 
            this.gestionDeCitasToolStripMenuItem.Name = "gestionDeCitasToolStripMenuItem";
            this.gestionDeCitasToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.gestionDeCitasToolStripMenuItem.Text = "Gestion de Citas";
            this.gestionDeCitasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeCitasToolStripMenuItem_Click);
            // 
            // gestionDePasaportesToolStripMenuItem
            // 
            this.gestionDePasaportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPasaporteToolStripMenuItem,
            this.renovarPasaporteToolStripMenuItem,
            this.entregaPasaporteToolStripMenuItem});
            this.gestionDePasaportesToolStripMenuItem.Name = "gestionDePasaportesToolStripMenuItem";
            this.gestionDePasaportesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.gestionDePasaportesToolStripMenuItem.Text = "Gestion de Pasaportes";
            this.gestionDePasaportesToolStripMenuItem.Click += new System.EventHandler(this.gestionDePasaportesToolStripMenuItem_Click);
            // 
            // nuevoPasaporteToolStripMenuItem
            // 
            this.nuevoPasaporteToolStripMenuItem.Name = "nuevoPasaporteToolStripMenuItem";
            this.nuevoPasaporteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.nuevoPasaporteToolStripMenuItem.Text = "Nuevo Pasaporte";
            this.nuevoPasaporteToolStripMenuItem.Click += new System.EventHandler(this.nuevoPasaporteToolStripMenuItem_Click);
            // 
            // renovarPasaporteToolStripMenuItem
            // 
            this.renovarPasaporteToolStripMenuItem.Name = "renovarPasaporteToolStripMenuItem";
            this.renovarPasaporteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.renovarPasaporteToolStripMenuItem.Text = "Renovar Pasaporte";
            this.renovarPasaporteToolStripMenuItem.Click += new System.EventHandler(this.renovarPasaporteToolStripMenuItem_Click);
            // 
            // entregaPasaporteToolStripMenuItem
            // 
            this.entregaPasaporteToolStripMenuItem.Name = "entregaPasaporteToolStripMenuItem";
            this.entregaPasaporteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.entregaPasaporteToolStripMenuItem.Text = "Entrega Pasaporte";
            this.entregaPasaporteToolStripMenuItem.Click += new System.EventHandler(this.entregaPasaporteToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(106, 21);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            this.herramientasToolStripMenuItem.Click += new System.EventHandler(this.herramientasToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioDeContraseñaToolStripMenuItem,
            this.mantenimientoDeUsuriosToolStripMenuItem,
            this.mantenimientoDeAplicacionesToolStripMenuItem,
            this.asignacionDePerfilYAplicacionesToolStripMenuItem,
            this.mantenimientoModuloToolStripMenuItem,
            this.perfilToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // cambioDeContraseñaToolStripMenuItem
            // 
            this.cambioDeContraseñaToolStripMenuItem.Name = "cambioDeContraseñaToolStripMenuItem";
            this.cambioDeContraseñaToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.cambioDeContraseñaToolStripMenuItem.Text = "Cambio de Contraseña";
            this.cambioDeContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambioDeContraseñaToolStripMenuItem_Click);
            // 
            // mantenimientoDeUsuriosToolStripMenuItem
            // 
            this.mantenimientoDeUsuriosToolStripMenuItem.Name = "mantenimientoDeUsuriosToolStripMenuItem";
            this.mantenimientoDeUsuriosToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.mantenimientoDeUsuriosToolStripMenuItem.Text = "Mantenimiento de usurios";
            this.mantenimientoDeUsuriosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeUsuriosToolStripMenuItem_Click);
            // 
            // mantenimientoDeAplicacionesToolStripMenuItem
            // 
            this.mantenimientoDeAplicacionesToolStripMenuItem.Name = "mantenimientoDeAplicacionesToolStripMenuItem";
            this.mantenimientoDeAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.mantenimientoDeAplicacionesToolStripMenuItem.Text = "Mantenimiento de aplicaciones";
            this.mantenimientoDeAplicacionesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeAplicacionesToolStripMenuItem_Click);
            // 
            // asignacionDePerfilYAplicacionesToolStripMenuItem
            // 
            this.asignacionDePerfilYAplicacionesToolStripMenuItem.Name = "asignacionDePerfilYAplicacionesToolStripMenuItem";
            this.asignacionDePerfilYAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.asignacionDePerfilYAplicacionesToolStripMenuItem.Text = "Asignacion de perfil y aplicaciones";
            this.asignacionDePerfilYAplicacionesToolStripMenuItem.Click += new System.EventHandler(this.asignacionDePerfilYAplicacionesToolStripMenuItem_Click);
            // 
            // mantenimientoModuloToolStripMenuItem
            // 
            this.mantenimientoModuloToolStripMenuItem.Name = "mantenimientoModuloToolStripMenuItem";
            this.mantenimientoModuloToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.mantenimientoModuloToolStripMenuItem.Text = "Mantenimiento Modulo";
            this.mantenimientoModuloToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoModuloToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDePerfilToolStripMenuItem,
            this.asignacionDeAplicacionAPerfilToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
            this.perfilToolStripMenuItem.Text = "Perfil ";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // mantenimientoDePerfilToolStripMenuItem
            // 
            this.mantenimientoDePerfilToolStripMenuItem.Name = "mantenimientoDePerfilToolStripMenuItem";
            this.mantenimientoDePerfilToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.mantenimientoDePerfilToolStripMenuItem.Text = "Mantenimiento de perfil";
            this.mantenimientoDePerfilToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDePerfilToolStripMenuItem_Click);
            // 
            // asignacionDeAplicacionAPerfilToolStripMenuItem
            // 
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Name = "asignacionDeAplicacionAPerfilToolStripMenuItem";
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Text = "Asignacion de aplicacion a perfil";
            this.asignacionDeAplicacionAPerfilToolStripMenuItem.Click += new System.EventHandler(this.asignacionDeAplicacionAPerfilToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitácoraToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ayudasToolStripMenuItem
            // 
            this.ayudasToolStripMenuItem.Name = "ayudasToolStripMenuItem";
            this.ayudasToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.ayudasToolStripMenuItem.Text = "Ayudas";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(9, 328);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(223, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Visible = false;
            // 
            // bitácoraToolStripMenuItem
            // 
            this.bitácoraToolStripMenuItem.Name = "bitácoraToolStripMenuItem";
            this.bitácoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bitácoraToolStripMenuItem.Text = "Bitácora";
            this.bitácoraToolStripMenuItem.Click += new System.EventHandler(this.bitácoraToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 366);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDePasaportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeUsuriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeAplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDePerfilYAplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoModuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDePerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeAplicacionAPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudasToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem tipocasoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPasaporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renovarPasaporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregaPasaporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePasaporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeTramiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocupacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitácoraToolStripMenuItem;
    }
}


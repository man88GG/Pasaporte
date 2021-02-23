using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridad.Formularios;
using CapaVistaSeguridad;
using CapaVistaSeguridad.Formularios.Mantenimientos;
using CapaVista;
using CapaVista.Pasaporte;

namespace MDI
{
    public partial class MDI : Form
    {

        clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
        clsVistaBitacora bit = new clsVistaBitacora();
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioContraseña cambioContraseña= new frmCambioContraseña(txtUsuario.Text);
            cambioContraseña.MdiParent = this;
            cambioContraseña.Show();
        }

        private void mantenimientoDeUsuriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de usuarios", 2);
                frmMantenimientoUsuario asignacion = new frmMantenimientoUsuario(txtUsuario.Text);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de usuarios", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoDeAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("3", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de aplicaciones", 3);
                frmAplicativo asignacion = new frmAplicativo();
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de aplicaciones", 3);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void asignacionDePerfilYAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("6", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la asignacion de aplicaciones", 6);
                frmAsignacionDeAplicaciones asignacion = new frmAsignacionDeAplicaciones();
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a l asignacion de aplicaciones", 6);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("8", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la apliacion de Modulo", 8);
                frmModulo asignacion = new frmModulo(txtUsuario.Text);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion de Modulo", 8);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoDePerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("4", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la apliacion de mantenimiento de perfil", 4);
                frmMantenimientoPerfil asignacion = new frmMantenimientoPerfil(txtUsuario.Text);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion de mantenimiento de perfil", 4);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void asignacionDeAplicacionAPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* if (seguridad.PermisosAcceso("5", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la apliacion de mantenimiento de perfil apliaciones a perfil", 5);
                frmMantenimientoPerfil asignacion = new frmMantenimientoPerfil(txtUsuario.Text);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacione de mantenimiento de perfil apliaciones a perfil", 5);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }*/
        }

        private void tipocasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("1302", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion Tipo de caso", 1302);
                frmCaso asignacion = new frmCaso(txtUsuario.Text, this);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion tipo de caso", 1302);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void gestionDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (seguridad.PermisosAcceso("12", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la apliacion de Gestion de citas", 4);
                frmMenuCita asignacion = new frmMenuCita(this);
                asignacion.MdiParent = this;
                asignacion.Show();

            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Intento Ingreso a la apliacion de Gestion de citas", 12);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
           


        }

        private void gestionDePasaportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void nuevoPasaporteToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a creacion de Pasaporte", 2);
                frmNuevoPasaporte asignacion = new frmNuevoPasaporte();
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a crear un nuevo Pasaporte", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }

            
        }

        private void renovarPasaporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a Renovación/Vencimiento de Pasaporte", 2);
                frmRenovarPasaporte asignacion = new frmRenovarPasaporte();
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trató de ingresar a Renovación/Vencimiento de Pasaporte", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }

  
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
        }


        private void entregaPasaporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a Entrega de Pasaporte", 2);
                frmEntregaPasaporte asignacion = new frmEntregaPasaporte();
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trató de ingresar a Entrega de Pasaporte", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }


        }

        private void tipoDePasaporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("1303", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion Tipo de pasaporte", 1303);
                frmTipoPasaporte asignacion = new frmTipoPasaporte(txtUsuario.Text, this);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion tipo de pasaporte", 1303);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void tipoDeTramiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("1304", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion Tipo de tramite", 1304);
                frmTipoTramite asignacion = new frmTipoTramite(txtUsuario.Text, this);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion tipo de tramite", 1304);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void ocupacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("1305", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion Tipo de ocupacion", 1305);
                frmOcupacion asignacion = new frmOcupacion(txtUsuario.Text, this);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion tipo de ocupacion", 1305);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("1306", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion centro", 1306);
                frmCentro asignacion = new frmCentro(txtUsuario.Text, this);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion centro", 1306);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

         


        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                frmBitacora bitacora = new frmBitacora();
                bitacora.MdiParent = this;
                bitacora.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion centro", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
    }
}

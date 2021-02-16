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

namespace CapaVista
{
    public partial class frmLogin : Form
    {
        ClsControlador cn = new ClsControlador();
        public frmLogin()
        {
            InitializeComponent();
        }
        int olvidarPassword = 0;
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            //Si la bandera de olvidar credenciales no se ha activado
            if (olvidarPassword == 0)
            {
                //Verificacion del llenado de los textBox
                int error = 1;
                int ver = 1;
                if (txtUser.Text == "USUARIO" || txtUser.Text == "")
                {
                    error = 0;
                    lblUser.Text = "Ingrese su usuario";
                    lblUser.Visible = true;
                }
                else
                {
                    lblUser.Visible = false;
                }
                if (txtPassword.Text == "CONTRASEÑA" || txtPassword.Text == "")
                {
                    error = 0;
                    lblPassword.Text = "Ingrese su contraseña ";
                    lblPassword.Visible = true;
                }
                else
                {
                    lblPassword.Visible = false;
                }



                //Si los datos no son vacios en los textBox
                if (error != 0)
                {
                    int allowway=0;

                    allowway = cn.traslado(txtUser.Text.ToString(),txtPassword.Text.ToString());
                   
                    if (allowway==1)
                    {
                        frmPruebaPasaporte frm = new frmPruebaPasaporte();
                        frm.Show();
                        this.Hide();
                        ver = 3;
                        
                    }
                    else
                    {
                        MessageBox.Show("error en allowway");
                    }
                   
                }
                if (ver == 3)
                {
                    lblOlvidar.Visible = false;
                    txtPassword.Text = "";
                    txtUser.Text = "";
                }
                //Si se ha fallado en las credenciales
                else
                {
                    lblOlvidar.Text = "Usuario/Contraseña son incorrectas";
                    lblOlvidar.Visible = true;
                }
            }
            else if (olvidarPassword == 1)
            {
                int controlEncuento = 0;

                cn.trasladorecuperar(txtUser.Text.ToString(), controlEncuento);

                olvidarPassword = 0;
                lblPassword.Visible = true;
                txtUser.Text = "USUARIO";
                txtPassword.Text = "CONTRASEÑA";
                lblUser.Text = "Ingrese su usuario";
                lblPassword.Text = "Ingrese su contraseña ";
                btnIngreso.Text = "ACCEDER";

            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void linkPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            olvidarPassword = 1;
            btnIngreso.Text = "Enviar Correo";
            lblOlvidar.Text = "";

            if (txtUser.Text != "")
            {
                lblUser.Visible = true;
                lblUser.Text = "INGRESE SU CORREO PARA RECIBIR CONTRASEÑA";
                txtUser.Text = "";
                txtPassword.Text = "";
                lblPassword.Text = "";
            }
            else
            {

            }
        }
    }
}

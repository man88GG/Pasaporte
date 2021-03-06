﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridad;

namespace CapaVista
{
    public partial class frmMenuCita : Form
    {

        int gestionarObuscar = 0;
        clsVistaBitacora bit = new clsVistaBitacora();
        static Form FormularioPadre;
        public frmMenuCita(Form formularioPadre)
        {
            InitializeComponent();
            FormularioPadre = formularioPadre;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //si gestionarObuscar es = 1, se gestionara una cita
            gestionarObuscar = 1;
            frmValidarBoleta Validar = new frmValidarBoleta(FormularioPadre,gestionarObuscar);
            Validar.MdiParent = FormularioPadre;
            Validar.Show();
            this.Close();
          
        }

        private void btnBuscarCita_Click(object sender, EventArgs e)
        {
            //si gestionarObuscar es = 2, se buscara una cita una cita
            gestionarObuscar = 2;
            frmValidarBoleta Validar = new frmValidarBoleta(FormularioPadre, gestionarObuscar);
            Validar.MdiParent = FormularioPadre;
            Validar.Show();
            this.Close();
           
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,"AyudaMigracionCitas/AyudaCitas.chm","menu.html");
        }
    }
}

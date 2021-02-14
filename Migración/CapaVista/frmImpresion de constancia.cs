using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmImpresion_de_constancia : Form
    {
        static Form FormularioPadre;
        int idCita = 0;
        public frmImpresion_de_constancia(Form formularioPadre,string CodigoCita,int idDatos)
        {
            InitializeComponent();
            FormularioPadre = formularioPadre;
            idCita = Int32.Parse(CodigoCita);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data;
using System.Data.Odbc;


namespace CapaControlador
{
    public class ClsControlador
    {
        //Instanciar variable para acceder a la clase sentencias
        ClsSentencias sn = new ClsSentencias();

        public int traslado(string user, string password)
        {
            int allow = 0;
            allow = sn.VerificarLogin(user,password);
            return allow;
        }

        public void trasladorecuperar(string user, int controlEncuento)
        {
            sn.enviarPassword(user, controlEncuento);
        }

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;

        }
    }
}

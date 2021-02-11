using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using CapaModelo;
using System.Data;
using System.Data.Odbc;


namespace CapaControlador
{
    public class ClsControlador
    {
        //Instanciar variable para acceder a la clase sentencias
        ClsSentencias sn = new ClsSentencias();

        public void traslado(string user, string password)
        {
            sn.VerificarLogin(user,password);
        }

=======

namespace CapaControlador
{
    class ClsControlador
    {
>>>>>>> master
    }
}

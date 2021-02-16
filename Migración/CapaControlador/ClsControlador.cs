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

        public void traslado(string user, string password)
        {
            sn.VerificarLogin(user,password);
        }

        //consulta para la busqueda en la entidad RENAP
        public OdbcDataReader funcBuscarPersona(string IdEmpleado)
        {
            OdbcDataReader Lector = sn.FuncBuscarPersona(IdEmpleado);
            return Lector;
        }

        public DataTable funcCmbTipoPass()
        {
            DataTable Items = sn.funcCmbTipoPass();
            return Items;
        }

        //consulta para insertar a la entidad Pasaporte
        //falta lo de firma, lugar nac
        public void funcInsertarPasaporte(int NumPass, string NumLibreta, string DpiCliente,string FechaC,
            string FechaV,int TipoPass, string LugarNac,string Autoridad, int Estado)
        {
            sn.funcInsertarPasaporte(NumPass, NumLibreta, DpiCliente, FechaC, FechaV, TipoPass, LugarNac,Autoridad, Estado);
        }

        //consulta para la busqueda en la entidad PASAPORTE
        public OdbcDataReader funcBuscarPass(string NumPass)
        {
            OdbcDataReader Lector = sn.FuncBuscarPass(NumPass);
            return Lector;
        }

        //Paso de datos para consulta modificar en la entidad Reclutamiento
        public void FuncActualizarPasaporte(string FechaC, string FechaV, int TipoPass, string Autoridad,
                int Estado)
        {

            sn.funcActualizarPasaporte(FechaC, FechaV, TipoPass, Autoridad, Estado);


        }

    }
}

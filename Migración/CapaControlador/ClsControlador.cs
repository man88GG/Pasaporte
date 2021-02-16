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

<<<<<<< HEAD
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
            string FechaV,int TipoPass, string Foto, string LugarNac,string Autoridad, int Estado)
        {
            sn.funcInsertarPasaporte(NumPass, NumLibreta, DpiCliente, FechaC, FechaV, TipoPass, Foto, LugarNac,Autoridad, Estado);
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

        //Paso de datos para consulta mostrar en la entidad reclutamiento
        public DataTable FuncListadoPasaporte(int Estado)
        {
            OdbcDataAdapter dt = sn.funcListadoPasaporte(Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Paso de datos para consulta mostrar en la entidad reclutamiento por Id
        public DataTable FuncListadoPasaporteId(int Estado, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcListadoPasaporteId(Estado, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Paso de datos para consulta mostrar en la entidad reclutamiento por Numero Pasaporte
        public DataTable FuncListadoPasaporteNumPass(int Estado, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcListadoPasaporteNumPass(Estado, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Paso de datos para consulta mostrar en la entidad reclutamiento por Numero Libreta
        public DataTable FuncListadoPasaporteNumLib(int Estado, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcListadoPasaporteNumLib(Estado, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
=======
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

>>>>>>> master
        }
    }
}

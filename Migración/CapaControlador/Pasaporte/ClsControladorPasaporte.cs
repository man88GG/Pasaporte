using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo.Pasaporte;
using System.Data;
using System.Data.Odbc;



namespace CapaControlador.Pasaporte
{
    public class ClsControladorPasaporte
    {
        //Instanciar variable para acceder a la clase sentencias
        ClsSentenciasPasaporte sn = new ClsSentenciasPasaporte();

       

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

        //Paso de datos para consulta modificar en la entidad PASAPORTE
        public void FuncActualizarPasaporte(string FechaC, string FechaV, int TipoPass, string Autoridad,
                int Estado,string IdPass)
        {

            sn.funcActualizarPasaporte(FechaC, FechaV, TipoPass, Autoridad, Estado, IdPass);


        }

        //Paso de datos para consulta modificar en la entidad PASAPORTE
        public void FuncVencerPass(string IdPass,int Estado )
        {

            sn.funcVencerPass(IdPass,Estado) ;


        }

        //Paso de datos para consulta mostrar en la entidad PASAPORTE
        public DataTable FuncListadoPasaporte(int Estado)
        {
            OdbcDataAdapter dt = sn.funcListadoPasaporte(Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Paso de datos para consulta mostrar en la entidad PASAPORTE por Id
        public DataTable FuncListadoPasaporteId(int Estado, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcListadoPasaporteId(Estado, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Paso de datos para consulta mostrar en la entidad PASAPORTE por Numero Pasaporte
        public DataTable FuncListadoPasaporteNumPass(int Estado, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcListadoPasaporteNumPass(Estado, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Paso de datos para consulta mostrar en la entidad PASAPORTE por Numero Libreta
        public DataTable FuncListadoPasaporteNumLib(int Estado, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcListadoPasaporteNumLib(Estado, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //consulta para insertar a la entidad Pasaporte

        public void funcInsertarEntregaPass(string IdPass, string FechaEnt, int StatusE)
        {
            sn.FuncEntregaPass(IdPass, FechaEnt, StatusE);
        }

        public void funcHistoricoPass(string IdPass, string FechaEnt)
        {
            sn.FuncHistoricoPass(IdPass, FechaEnt);
        }
    }
}

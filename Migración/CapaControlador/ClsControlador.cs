using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
    public class ClsControlador
    {

        ClsSentencias Sn = new ClsSentencias();
        //funcion que obtiene el codigo de la boleta que se esta solicitando
        public int funcObtenerCodigoBoleta(int numeroRecibo, int numeroBoleta)
        {
            int CodigoBoleta = Sn.funcConsultarBoleta(numeroRecibo, numeroBoleta);
            return CodigoBoleta;
        }
        //funcion que retorna los todos los datos de una tabla de un campo en especifico
        public string[] funcItems(string Tabla, string Campo1)
        {
            string[] Items = Sn.funcLlenarCmb(Tabla, Campo1);
            return Items;
        }
        //funcion que permite obtener un campo en especificode una tabla por medio de su ID
        public string funcObtenerDato(int Codigo, string Campo, string Tabla, string nombreId)
        {
            string Dato = Sn.funcDatos(Codigo, Campo, Tabla, nombreId);
            return Dato;
        }
        public string[] funcItemsComboBox(string Tabla1, string Campo1, int Id, string nombreID)
        {
            string[] Items = Sn.funcLlenarComboEspecifico(Tabla1, Campo1, Id, nombreID);
            return Items;
        }
        //funcion para obtener el codigo de una tabla
        public int funcCodigoMaximo(string Tabla, string Campo)
        {
            int CodigoNuevo = Sn.funcObtenerCodigo(Tabla, Campo);
            return CodigoNuevo;
        }

        public void procDatosInsertar(string tabla, List<string> lista)
        {
            Sn.procInsertarDatos(tabla, lista);
        }
        public DataTable enviar(string consulta)
        {
            try
            {
                OdbcDataAdapter dt = Sn.obtener(consulta);
                DataTable table = new DataTable();
                dt.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Puede que los parametros seas erroneos, verifique los parametro enviados" + ex);
                return null;
            }

        }

        public string CualquierDato(string Consulta)
        {
            string sql = Sn.obtenerCualquierDato(Consulta);
            return sql;
        }

        public int CantidadDatos(string campo1, string tabla, string nombreCampo, string campo2,string nombreCampo2,int Campo3)
        {
            int Cantidad = Sn.cantidadDeDatos( campo1, tabla, nombreCampo, campo2,nombreCampo2,Campo3);
            return Cantidad;
        }
    

    }
}

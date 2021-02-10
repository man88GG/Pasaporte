using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
   public class ClsSentencias
    {
        clsConexion Con = new clsConexion();
        //funcion que retorna los elementos de una tabla para llenar los comboBox
        public string[] funcLlenarCmb(string Tabla, string Campo1)
        {
            string[] Campos = new string[100];
            int I = 0;
            string Sql = "SELECT " + Campo1 + " FROM " + Tabla + "  ;";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Campos[I] = Reader.GetValue(0).ToString();
                    I++;
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + Tabla + "\n -" + Campo1); }
            return Campos;
        }
        //funcion que retorian el numero de boleta de banco
        public int  funcConsultarBoleta(int NumeroRecibo,int NumeroBoleta)
        {
            int recibo = NumeroRecibo;
            int boleta = NumeroBoleta;
            int Campo = 0;    
            string Sql = "SELECT idBoleta FROM BOLETABANCO WHERE numeroRecibo = " + recibo + " and numeroBoleta = "+boleta+"  and  estatus = 1;";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
               while(Reader.Read())
                {
                    Campo = Reader.GetInt32(0);
                }

            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en BUSCAR LOS DATOS, revise los parametros DE BOLETABANCO -"); }
            return Campo;
        }
        //funcion que obtiene un dato es especifico de cualquier tabla
        public string funcDatos(int codigo,string campo,string tabla,string nombreId)
        {
            int numeroDeIdentificacion = codigo;
            string CampoTabla = campo;
            string  Dato = "";
            string Sql = "SELECT "+campo+" FROM "+tabla+" WHERE "+nombreId+" = "+codigo+";";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Dato = Reader.GetValue(0).ToString();
                }

            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en BUSCAR LOS DATOS, revise los parametros DE BOLETABANCO -"); }
            return Dato;
        }
        //funcion para llenar un comboBox con un codigo en especifico
        public string[] funcLlenarComboEspecifico(string Tabla1,string Tabla2, string Campo1,int Id, string nombreID)
        {
            string[] Campos = new string[100];
            int I = 0;
            string Sql = "SELECT " + Campo1 + " FROM "+Tabla1+" Tabla1, "+Tabla2+" Tabla2 WEHRE Tabla1."+nombreID+" = Tabla2."+nombreID+" and "+nombreID+" = "+Id+";";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Campos[I] = Reader.GetValue(0).ToString();
                    I++;
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + Tabla1+ "\n -" + Campo1); }
            return Campos;
        }
    }
}

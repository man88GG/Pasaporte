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
        public string[] funcLlenarComboEspecifico(string Tabla1,string Campo1,int Id,string nombreID)
        {
            string campoTabla = Campo1;
            string nombreTabla = Tabla1;
            int Codigo = Id;
            string nombreCodigo = nombreID;
            string[] Campos = new string[100];
            int I = 0;
            string Sql = "SELECT "+campoTabla+" FROM "+nombreTabla+"  WHERE  "+nombreCodigo+" = "+Codigo+"    ; ";
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
        //funcion para obtener el codigo de una tabla
        public int funcObtenerCodigo(string NombreTabla, string Campo)
        {
            int Codigo = 0;
            string Sql = "SELECT MAX(" + Campo + ") FROM " + NombreTabla + " ;";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Codigo = Reader.GetInt32(0);
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -\n -"); }
            return Codigo + 1;
        }
        //funcion que permite ingresar datos a la base de datos
        public void procInsertarDatos(string tabla, List<string> lista)
        {
            string sql = " INSERT INTO " + tabla + " VALUES (";
            string consulta = sql;
            int contador = lista.Count();
            int i = 1;
            foreach (var items in lista)
            {
                if (i != contador)
                {
                    try
                    {
                        //int 
                        int.Parse(items);
                        sql += " " + items + ", ";
                        consulta += " " + items + ", ";
                    }
                    catch (Exception e)
                    {
                        try
                        {
                            //double
                            double.Parse(items);
                            sql += " " + items + ", ";
                            consulta += " " + items + ", ";
                        }
                        catch (Exception ex)
                        {
                            try
                            {
                                //DateTimePicker
                                DateTime.Parse(items);
                                sql += " '" + items + "', ";
                                consulta += " " + items + ", ";
                            }
                            catch (Exception exx)
                            {
                                //string
                                sql += " '" + items + "', ";
                                consulta += " " + items + ", ";
                            }
                        }
                    }
                }
                else
                {
                    break;
                }

                i++;
            }
            var item = lista.Last();
            try
            {
                //int 
                int.Parse(item);
                sql += " " + item + ") ";
            }catch(Exception )
            {
                sql += " '" + item + "') ";
            }
          /*  string sqlMax = lista.Last();
            sql += " " + sqlMax + ") ";
            consulta += " " + sqlMax + ") ";*/
            try
            {

                OdbcCommand comm = new OdbcCommand(sql, Con.conexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                Console.WriteLine("Los Datos se guardaron correctamente");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo existe la tabla o los campos indicados \n -" + tabla + "\n -"+ex+" "+sql);

            }

        }

        //funcion que devuelve los datos de una consulta para colocarlos en un DataGridView
        public OdbcDataAdapter obtener(string consulta)
        {
            try
            {
                string sql = consulta;
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, Con.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Puede que los parametros seas erroneos, verifique los parametro enviados" + ex);
                return null;
            }
        }
        //funcion que obtiene cualquier dato cuando se le envia una consulta
        public string obtenerCualquierDato(string consulta)
        {
                string Dato = "";
                string Sql = consulta;
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

        public int  cantidadDeDatos(string Campo1,string tabla,string nombreCampo,string Campo2,string nombreCampo2,int Campo3)
        {
            int Dato = 0;
            string Sql = "Select COUNT("+Campo1+") FROM "+tabla+" WHERE "+nombreCampo+" = '"+Campo2+"' and "+nombreCampo2+" = "+Campo3+" and estado = 1;" ;
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Dato = Reader.GetInt32(0);
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en BUSCAR LOS DATOS, revise los parametros DE "+Sql+" -"); }
            return Dato;
        }


        public void procModificar(string sql)
        {
            string Consulta = sql;
            try
            {
                OdbcCommand comm = new OdbcCommand(Consulta, Con.conexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                Console.WriteLine("Los Datos se modificaron correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede modificar revise: \n -" + Consulta + "\n -");

            }
        }

    }
}

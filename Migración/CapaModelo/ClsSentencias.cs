using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModelo
{
    public class ClsSentencias
    {
        //Necesitamos instanciar la clase conexión
        clsConexion con = new clsConexion();

        public void VerificarLogin(string user, string password)
        {
            //Realiza la consulta para verificar las credenciale y si son correctas se procede con el sistema
            try
            {
                string cadena = "SELECT * FROM USUARIO";
                OdbcCommand cma = new OdbcCommand(cadena, con.conexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while (reader.Read())
                {
                    if (user == (Convert.ToString(reader[4])) && password == (Convert.ToString(reader[3])))
                    {
                        Console.WriteLine("It's done");
                        clsBitacora bitacora = new clsBitacora();
                        //Adicion de la bitacora
                        bitacora.obtenerIdUsuario(reader[0].ToString());
                        string proceso = "Inicio de Sesión";
                        string tabla = cadena;
                        bitacora.GuardarBitacora(proceso, tabla);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR AL OBTENER DATOS PARA INGRESO" + ex);
            }
        }



        //consulta para buscar al usuario
        public OdbcDataReader FuncBuscarPersona(string dpi)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.NOMBRES, R.APELLIDOS,R.FECHANACIMIENTO,D.DEPARTAMENTO,M.MUNICIPIO FROM RENAP AS R, DEPARTAMENTO AS D, MUNICIPIO AS M WHERE R.IDMUNICIPIO = M.IDMUNICIPIO AND M.IDDEPARTAMENTO = D.IDDEPARTAMENTO AND R.DPI = '" + dpi + "'";

                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, con.conexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        //Consulta para ingresar datos en la entidad Pasaporte
        public void funcInsertarPasaporte(int NumPass, string NumLibreta, string DpiCliente, string FechaC, 
            string FechaV, int TipoPass, string Foto, string LugarNac,string Autoridad, int Estado)
        {
            try
            {
                int IdPasaporte;
                string CorrelativoReclu = "SELECT IFNULL(MAX(IDPASAPORTE),0) +1 FROM PASAPORTE";     
                OdbcCommand QueryIdReclu = new OdbcCommand(CorrelativoReclu, con.conexion());
                IdPasaporte = Convert.ToInt32(QueryIdReclu.ExecuteScalar());
                OdbcDataReader Ejecucion1 = QueryIdReclu.ExecuteReader();
                
                //falta firma, fotografia y lugar nacimiento
                //Sentencia para insertar datos a entidad Reclutamiento
                string SentenciaRecluta = "INSERT INTO PASAPORTE (IDPASAPORTE, NUMEROPASAPORTE, NUMEROLIBRETA, " +
                    "DPI, FECHACREACION, FECHAVENCIMIENTO, IDTIPOPASAPORTE,FOTOGRAFIA,LUGARNACIMIENTO, " +
                    "AUTORIDAD, ESTADO) VALUES " + "('" + IdPasaporte + "','" + NumPass + "','" + NumLibreta + "','" + DpiCliente + "','"
                    + FechaC + "','" + FechaV + "','" + TipoPass + "','" + Foto + "','" + LugarNac + "','" + Autoridad + "','" + Estado + "')";

               
                OdbcCommand Query_IngresoRec = new OdbcCommand(SentenciaRecluta, con.conexion());
                
                Query_IngresoRec.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Muestra datos en combo TipoPasaporte
        public DataTable funcCmbTipoPass()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaTipoPass = "SELECT * FROM TIPOPASAPORTE";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaTipoPass, con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                con.desconexion(con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin



        //consulta para buscar el pasaporte
        public OdbcDataReader FuncBuscarPass(string NumPass)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.NOMBRES, R.APELLIDOS,R.FECHANACIMIENTO,D.DEPARTAMENTO,M.MUNICIPIO, P.NUMEROPASAPORTE, P.NUMEROLIBRETA,P.DPI,P.FECHACREACION,P.FECHAVENCIMIENTO,TP.TIPOPASAPORTE,P.AUTORIDAD,P.LUGARNACIMIENTO,P.FOTOGRAFIA FROM RENAP AS R, DEPARTAMENTO AS D, MUNICIPIO AS M, TIPOPASAPORTE AS TP, PASAPORTE AS P WHERE R.IDMUNICIPIO = M.IDMUNICIPIO AND M.IDDEPARTAMENTO = D.IDDEPARTAMENTO AND P.DPI = R.DPI AND P.IDTIPOPASAPORTE =TP.IDTIPOPASAPORTE AND P.IDPASAPORTE = '" + NumPass + "'";

                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, con.conexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para modificar en la entidad Reclutamiento
        public void funcActualizarPasaporte(string FechaC, string FechaV, int TipoPass, string Autoridad,
                int Estado)
        {
            try
            {
               

                string sentencia = "UPDATE PASAPORTE SET FECHACREACION='" + FechaC + "', FECHAVENCIMIENTO='" + FechaV +
                    "', IDTIPOPASAPORTE='" + TipoPass + "', AUTORIDAD='" + Autoridad + "', ESTADO='" + Estado  + "'";

                
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, con.conexion());
                
                Query_Validacion1.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //consulta para mostrar datos de la entidad Pasaporte
        public OdbcDataAdapter funcListadoPasaporte(int Estado)
        {
            try
            {
                string sentencia = "SELECT P.IDPASAPORTE, P.NUMEROPASAPORTE, P.NUMEROLIBRETA,P.FECHACREACION,P.FECHAVENCIMIENTO,TP.TIPOPASAPORTE,P.AUTORIDAD FROM RENAP AS R, DEPARTAMENTO AS D, MUNICIPIO AS M, TIPOPASAPORTE AS TP, PASAPORTE AS P WHERE R.IDMUNICIPIO = M.IDMUNICIPIO AND M.IDDEPARTAMENTO = D.IDDEPARTAMENTO AND P.DPI = R.DPI AND P.IDTIPOPASAPORTE =TP.IDTIPOPASAPORTE AND P.ESTADO = '" + Estado + "'";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, con.conexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Reclutamiento por Id
        public OdbcDataAdapter funcListadoPasaporteId(int Estado, string Parametro)
        {
            try
            {
                int SgOpcion=0;
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT P.IDPASAPORTE, P.NUMEROPASAPORTE, P.NUMEROLIBRETA,P.FECHACREACION,P.FECHAVENCIMIENTO,TP.TIPOPASAPORTE,P.AUTORIDAD FROM RENAP AS R, DEPARTAMENTO AS D, MUNICIPIO AS M, TIPOPASAPORTE AS TP, PASAPORTE AS P WHERE R.IDMUNICIPIO = M.IDMUNICIPIO AND M.IDDEPARTAMENTO = D.IDDEPARTAMENTO AND P.DPI = R.DPI AND P.IDTIPOPASAPORTE =TP.IDTIPOPASAPORTE AND P.ESTADO = '" + Estado + "' AND P.IDPASAPORTE LIKE('" + Parametro + "%')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, con.conexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        //consulta para mostrar datos de la entidad Reclutamiento por Numero Pasaporte
        public OdbcDataAdapter funcListadoPasaporteNumPass(int Estado, string Parametro)
        {
            try
            {
                int SgOpcion = 0;
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT P.IDPASAPORTE, P.NUMEROPASAPORTE, P.NUMEROLIBRETA,P.FECHACREACION,P.FECHAVENCIMIENTO,TP.TIPOPASAPORTE,P.AUTORIDAD FROM RENAP AS R, DEPARTAMENTO AS D, MUNICIPIO AS M, TIPOPASAPORTE AS TP, PASAPORTE AS P WHERE R.IDMUNICIPIO = M.IDMUNICIPIO AND M.IDDEPARTAMENTO = D.IDDEPARTAMENTO AND P.DPI = R.DPI AND P.IDTIPOPASAPORTE =TP.IDTIPOPASAPORTE AND P.ESTADO = '" + Estado + "' AND P.NUMEROPASAPORTE LIKE('" + Parametro + "%')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, con.conexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Reclutamiento por Numero Libreta
        public OdbcDataAdapter funcListadoPasaporteNumLib(int Estado, string Parametro)
        {
            try
            {
                int SgOpcion = 0;
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT P.IDPASAPORTE, P.NUMEROPASAPORTE, P.NUMEROLIBRETA,P.FECHACREACION,P.FECHAVENCIMIENTO,TP.TIPOPASAPORTE,P.AUTORIDAD FROM RENAP AS R, DEPARTAMENTO AS D, MUNICIPIO AS M, TIPOPASAPORTE AS TP, PASAPORTE AS P WHERE R.IDMUNICIPIO = M.IDMUNICIPIO AND M.IDDEPARTAMENTO = D.IDDEPARTAMENTO AND P.DPI = R.DPI AND P.IDTIPOPASAPORTE =TP.IDTIPOPASAPORTE AND P.ESTADO = '" + Estado + "' AND P.NUMEROLIBRETA LIKE('" + Parametro + "%')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, con.conexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}

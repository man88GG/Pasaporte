using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.Data;
using System.Data.Odbc;

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


=======

namespace CapaModelo
{
    class ClsSentencias
    {
>>>>>>> master
    }
}

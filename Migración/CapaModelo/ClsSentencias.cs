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

        public int  VerificarLogin(string user, string password)
        {
            int allow = 0;
            MessageBox.Show("SN.User: " + user + ", SN.Password: " + password);
            //Realiza la consulta para verificar las credenciale y si son correctas se procede con el sistema
            try
            {
                string cadena = "SELECT * FROM USUARIO";
                OdbcCommand cma = new OdbcCommand(cadena, con.conexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Reader 4: " + Convert.ToString(reader[4]) + ", Reader 3: "+ Convert.ToString(reader[3]));
                    if (user == (Convert.ToString(reader[4])) && password == (Convert.ToString(reader[3])))
                    {
                        Console.WriteLine("It's done");
                        clsBitacora bitacora = new clsBitacora();
                        //Adicion de la bitacora
                        bitacora.obtenerIdUsuario(reader[0].ToString());
                        string proceso = "Inicio de Sesión";
                        string tabla = cadena;
                        bitacora.GuardarBitacora(proceso, tabla);
                        allow = 1;
                        MessageBox.Show("Exito en capa sentencia con allow");
                    }
                    
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR AL OBTENER DATOS PARA INGRESO" + ex);
            }
            return allow;
        }


        public void enviarPassword(string user, int controlEncuento)
        {
            //Realiza la consulta para verificar si el correo para restaurar credenciales es válido
            try
            {
                string cadena = "SELECT * FROM CORREOEMP";
                OdbcCommand cma = new OdbcCommand(cadena, con.conexion());
                OdbcDataReader reader = cma.ExecuteReader();
                while (reader.Read())
                {//Si el correo es válido
                    if (user == (Convert.ToString(reader[1])))
                    {
                        controlEncuento = 1;
                        MessageBox.Show("TU CONTRASEÑA HA SIDO ENVIADA");
                        //Se envian las credenciales al correo válido

                        try
                        {
                            string correoCliente = user;
                            MessageBox.Show("correoCliente: " + correoCliente);
                            string cadenaCorreo = "SELECT U.nombreUsuario,U.contrasenia FROM USUARIO U, EMPLEADO E, CORREOEMP C WHERE U.idEmpleado = E.idEmpleado AND E.idEmpleado = C.idEmpleado  AND C.correo = '" + user + "'; ";
                            OdbcCommand cmaCorreo = new OdbcCommand(cadenaCorreo, con.conexion());
                            OdbcDataReader readerCorreo = cmaCorreo.ExecuteReader();
                            while (readerCorreo.Read())
                            {
                                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                                msg.To.Add(user);
                                msg.Subject = "CREDENCIALES MIGRACIÓN";
                                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                                msg.Bcc.Add("yavhe._.orozco@hotmail.es"); //copia del correo
                                msg.Body = "Ha recibido este correo para restaurar credenciales  <br/> USUARIO: " + (readerCorreo.GetString(0)) + " <br/> CONTRASEÑA: "
                                    + readerCorreo.GetString(1) + ". <br/> Sea cuidadoso con sus credenciales";
                                msg.BodyEncoding = System.Text.Encoding.UTF8;
                                msg.IsBodyHtml = true;
                                msg.From = new System.Net.Mail.MailAddress("grupo3sistemaso1@gmail.com");

                                //CREACION DEL CLIENTE DE CORREO
                                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                                cliente.Credentials = new System.Net.NetworkCredential("grupo3sistemaso1@gmail.com", "s1stema$2");
                                cliente.Port = 587;
                                cliente.EnableSsl = true;
                                cliente.Host = "smtp.gmail.com"; //Servidor de salida de GMAIL
                                try
                                {
                                    cliente.Send(msg);
                                    MessageBox.Show("Se han enviado las credenciales,sea cuidadoso");
                                }
                                catch (Exception error)
                                {

                                    MessageBox.Show("ERROR AL ENVIAR" + error);
                                }

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR AL OBTENER DATOS PARA EL CORREO DE RECUPERACION " + ex);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Este correo no aparece asociado a ningún empleado.");
                    }
                }
                if (controlEncuento != 1)
                {
                    MessageBox.Show("CORREO INVÁLIDO");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DENTRO DEL FORGET" + ex);
            }
        }


        ///
        public OdbcDataAdapter llenarTbl(string tabla)
        {
            string sql = "SELECT * FROM " + tabla+ " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

    }

}

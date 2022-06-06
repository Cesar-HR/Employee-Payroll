using Capa_Presentacion.Datos;
using Capa_Presentacion.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Presentacion.Modelo
{
    public class PersonaDao
    {
        /**Método GetListaPersona*/
        public List<Persona> GetListaPersona()
        {
            List<Persona> lista = new List<Persona>();
            Conexion conexion = new Conexion();
            SqlConnection conn = new SqlConnection(conexion.GetCadenaConexion());
            String query = "SELECT idPersona,nombre,apellidop,apellidom,dni,estado_civil,direccion,fecha_nacimiento,edad FROM dbo.Persona";

            using (conn)
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Persona persona = new Persona
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Paterno = reader.GetString(2),
                            Materno = reader.GetString(3),
                            Dni = reader.GetString(4),
                            EstadoCivil = reader.GetString(5),
                            Direccion = reader.GetString(6),
                            Nacimiento = reader.GetDateTime(7).ToShortDateString(),
                            Edad = reader.GetInt32(8)
                        };

                        lista.Add(persona);
                    }

                    reader.Close();
                    conn.Close();

                }
                catch(Exception ex)
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }

            return lista;
        }

        /**Método AddPersona() */
        public void AddPersona(String nombre,String apepat,String apemat,String dni,String civil,String direccion, DateTime nacimiento,int edad)
        {
            Conexion conexion = new Conexion();
            SqlConnection conn = new SqlConnection(conexion.GetCadenaConexion());
            String query = "INSERT INTO dbo.Persona (nombre,apellidop,apellidom,dni,estado_civil,direccion,fecha_nacimiento,edad) VALUES (@nombre, @apellidop, @apellidom, @dni, @estado_civil, @direccion, @fecha_nacimiento, @edad)";

            using (conn)
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellidop", apepat);
                cmd.Parameters.AddWithValue("@apellidom", apemat);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@estado_civil", civil);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", nacimiento);
                cmd.Parameters.AddWithValue("@edad", edad);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch(SqlException ex)
                {
                    throw new Exception("Error de inserción de datos: " + ex.Message);
                }
            }
        }

        /**Método UpdatePersona() */
        public void UpdatePersona(int id, String nombre, String apepat, String apemat, String dni, String civil, String direccion, DateTime nacimiento, int edad)
        {
            Conexion conexion = new Conexion();
            SqlConnection conn = new SqlConnection(conexion.GetCadenaConexion());
            String query = "UPDATE dbo.Persona SET " +
                           "nombre=@nombre,apellidop=@apellidop,apellidom=@apellidom,dni=@dni,estado_civil=@estado_civil,direccion=@direccion,fecha_nacimiento=@fecha_nacimiento,edad=@edad " +
                           "WHERE idPersona=@idPersona";

            using (conn)
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idPersona", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellidop", apepat);
                cmd.Parameters.AddWithValue("@apellidom", apemat);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@estado_civil", civil);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", nacimiento);
                cmd.Parameters.AddWithValue("@edad", edad);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error de actualización de datos: " + ex.Message);
                }
            }
        }

        /**Método GetPersonaById() */
        public Persona GetPersonaById(int? id)
        {
            Conexion conexion = new Conexion();
            SqlConnection conn = new SqlConnection(conexion.GetCadenaConexion());
            String query = "SELECT idPersona,nombre,apellidop,apellidom,dni,estado_civil,direccion,fecha_nacimiento,edad FROM dbo.Persona WHERE idPersona=@idPersona";

            using (conn)
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idPersona", id);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();

                    Persona persona = new Persona
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Paterno = reader.GetString(2),
                        Materno = reader.GetString(3),
                        Dni = reader.GetString(4),
                        EstadoCivil = reader.GetString(5),
                        Direccion = reader.GetString(6),
                        Nacimiento = reader.GetDateTime(7).ToShortDateString(),
                        Edad = reader.GetInt32(8)
                    };

                    reader.Close();
                    conn.Close();

                    return persona;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }
        }

        /**Método DeletePersona() */
        public void DeletePersona(int id)
        {
            Conexion conexion = new Conexion();
            SqlConnection conn = new SqlConnection(conexion.GetCadenaConexion());
            String query = "DELETE FROM dbo.Persona WHERE idPersona=@idPersona";

            using (conn)
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idPersona", id);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error de actualización de datos: " + ex.Message);
                }
            }
        }
    }
}

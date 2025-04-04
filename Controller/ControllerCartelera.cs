using Microsoft.Data.SqlClient;
using Model.Cartelera;
using Cartelera.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cartelera.Controller;
using Cartelera.Context;


namespace Controller.Cartelera
{
    class ControllerCartelera : IControllerCartelera
    {
       Conexion Conexion = new Conexion();

        public bool EliminarCartelera(int idpelicula)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("EliminarCartelera", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idpelicula", idpelicula); // Asegúrate que el parámetro se llama así en tu SP

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0; // Si borró al menos 1 fila, retorna true
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la pelicula: " + ex.Message);
                }
            }
        }


        public List<ModelCartelera> ObtenerCartelera()
        {
            List<ModelCartelera> personajes = new List<ModelCartelera>();

            using (SqlConnection conn = Conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("ObtenerCartelera", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personajes.Add(new ModelCartelera
                            {
                                idpelicula = reader["idpelicula"] != DBNull.Value ? Convert.ToInt32(reader["idpelicula"]) : 0, // Si es null, asigna 0
                                Nombre = reader["Nombre"] != DBNull.Value ? reader["Nombre"].ToString() : null,
                                Genero  = reader["Genero"] != DBNull.Value ? reader["Genero"].ToString() : null,
                                Añoestreno = reader["Añoestreno"] != DBNull.Value ? Convert.ToInt32(reader["Añoestreno"]) : 0, // Si es null, asigna 0
                               PersonajePrincipal = reader["PersonajePrincipal"] != DBNull.Value ? reader["PersonajePrincipal"].ToString() : null,



                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los personajes: " + ex.Message);
                }
            }

            return personajes;
        }



        public bool AgregarCartelera(ModelCartelera nuevapelicula)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("InsertarCartelera", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agrega los parámetros que espera el SP
                    cmd.Parameters.AddWithValue("@Nombre", nuevapelicula.Nombre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Genero", nuevapelicula.Genero ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Añoestreno", nuevapelicula.Añoestreno);
                    cmd.Parameters.AddWithValue("@PersonajePrincipaa", nuevapelicula.PersonajePrincipal);
               

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar la pelicula: " + ex.Message);
                }
            }
        }

    }
}
using Microsoft.Data.SqlClient;
using Model.Cartelera;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cartelera.Controller;
using peliculas.Context;



namespace Controller.Cartelera
{
    class ControllerCartelera : IControllerCartelera
    {
       Conexion conexion = new Conexion();

        public bool EliminarCartelera(int idpelicula)
        {
            using (SqlConnection conn = conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("EliminarCartelera", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idpelicula", idpelicula); 

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0; 
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la pelicula: " + ex.Message);
                }
            }
        }


        public List<ModelCartelera> ObtenerCartelera()
        {
            List<ModelCartelera> pelicula = new List<ModelCartelera>();

            using (SqlConnection conn = conexion.GetConnection())
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
                            pelicula.Add(new ModelCartelera
                            {
                                idpelicula = reader["idpelicula"] != DBNull.Value
                                             ? Convert.ToInt32(reader["idpelicula"])
                                             : 0,
                                Nombre = reader["Nombre"] != DBNull.Value
                                         ? reader["Nombre"].ToString()
                                         : null, 
                                Genero = reader["Genero"] != DBNull.Value
                                         ? reader["Genero"].ToString()
                                         : null, 
                                Añoestreno = reader["Añoestreno"] != DBNull.Value
                                            ? Convert.ToDateTime(reader["Añoestreno"])
                                            : DateTime.MinValue, 
                                PersonajePrincipal = reader["PersonajePrincipal"] != DBNull.Value
                                                     ? reader["PersonajePrincipal"].ToString()
                                                     : null 
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener las peliculas: " + ex.Message);
                }
            }

            return pelicula;
        }



        public bool AgregarCartelera(ModelCartelera nuevacartelera)
        {
            using (SqlConnection conn = conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("InsertarCartelera", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                   
                    cmd.Parameters.AddWithValue("@Nombre", nuevacartelera.Nombre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Genero", nuevacartelera.Genero ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Añoestreno", nuevacartelera.Añoestreno);  
                    cmd.Parameters.AddWithValue("@PersonajePrincipal", nuevacartelera.PersonajePrincipal ?? (object)DBNull.Value);



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
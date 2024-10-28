using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Parking;

namespace Repositorios
{
    public class PlazaRepositorio
    {
        private static PlazaRepositorio instance;
        private ConexionBD conexionBD;

        public static PlazaRepositorio GetInstance()
        {
            if (instance == null)
            {
                instance = new PlazaRepositorio();
            }
            return instance;
        }

        private PlazaRepositorio()
        {
            conexionBD = ConexionBD.GetInstance();
        }

        // Método para obtener una plaza por Id
        public PlazaDTO ObtenerPlazaPorId(int idPlaza)
        {
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Plaza WHERE idplaza = @idPlaza";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idPlaza", idPlaza);

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new PlazaDTO
                    {
                        IdPlaza = Convert.ToInt32(reader["idplaza"]),
                        Tipo = (PlazaDTO.TipoPlaza)Enum.Parse(typeof(PlazaDTO.TipoPlaza), reader["tipoplaza"].ToString())
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la plaza", ex);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para listar plazas por tipo
        public List<PlazaDTO> ListarPlazasPorTipo(PlazaDTO.TipoPlaza tipoPlaza)
        {
            List<PlazaDTO> listaPlazas = new List<PlazaDTO>();
            MySqlConnection connection = conexionBD.ConnectToDataBase();
            try
            {
                string query = "SELECT * FROM Plaza WHERE tipoplaza = @tipoPlaza";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@tipoPlaza", tipoPlaza.ToString());

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaPlazas.Add(new PlazaDTO
                    {
                        IdPlaza = Convert.ToInt32(reader["idplaza"]),
                        Tipo = (PlazaDTO.TipoPlaza)Enum.Parse(typeof(PlazaDTO.TipoPlaza), reader["tipoplaza"].ToString())
                    });
                }
                return listaPlazas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar plazas por tipo", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
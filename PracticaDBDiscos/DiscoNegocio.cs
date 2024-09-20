using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDBDiscos
{
    internal class DiscoNegocio
    {
        
        public List<Disco> listarDiscos()
        {
            List<Disco> listDiscos = new List<Disco>();
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                conn.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; Integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT Titulo, FechaLanzamiento as 'Fecha de Lanzamiento', CantidadCanciones as " +
                                    "'Cantidad de Canciones',\r\ne.Descripcion as Genero, a.Nombre as Autor, UrlImagenTapa From DISCOS, ESTILOS e, " +
                                    "ARTISTAS a WHERE IdArtista = a.Id AND IdEstilo = e.Id";
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Disco Daux = new Disco();
                    Daux.Titulo = (string)dr["Titulo"];
                    Daux.FechaLanzamiento = (DateTime)dr["Fecha de lanzamiento"];
                    Daux.CantCanciones = (int)dr["Cantidad de Canciones"];
                    Daux.Estilo = new Estilo();
                    Daux.Estilo.Genero = (string)dr["Genero"];
                    Daux.Artista = new Autor();
                    Daux.Artista.Nombre = (string)dr["Autor"];
                    Daux.urlTapa = (string)dr["UrlImagenTapa"];
                    listDiscos.Add(Daux);

                }

                return listDiscos;

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }

        public void InsertarDisco()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            
            try
            {
                conn.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; Integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "";
                cmd.Connection = conn;
                conn.Open();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }
        

    }
}

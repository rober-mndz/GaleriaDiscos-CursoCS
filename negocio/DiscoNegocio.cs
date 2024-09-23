using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class DiscoNegocio
    {
        
        public List<Disco> listarDiscos()
        {
            List<Disco> listDiscos = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("SELECT Titulo, FechaLanzamiento as 'Fecha de Lanzamiento', CantidadCanciones as " +
                                    "'Cantidad de Canciones',\r\ne.Descripcion as Genero, a.Nombre as Autor, UrlImagenTapa From DISCOS, ESTILOS e, " +
                                    "ARTISTAS a WHERE IdArtista = a.Id AND IdEstilo = e.Id");
                datos.ejecutarLectura();
                

                while (datos.Reader.Read())
                {
                    Disco Daux = new Disco();
                    Daux.Titulo = (string)datos.Reader["Titulo"];
                    Daux.FechaLanzamiento = (DateTime)datos.Reader["Fecha de lanzamiento"];
                    Daux.CantCanciones = (int)datos.Reader["Cantidad de Canciones"];
                    Daux.Estilo = new Estilo();
                    Daux.Estilo.Genero = (string)datos.Reader["Genero"];
                    Daux.Artista = new Autor();
                    Daux.Artista.Nombre = (string)datos.Reader["Autor"];
                    Daux.urlTapa = (string)datos.Reader["UrlImagenTapa"];
                    listDiscos.Add(Daux);

                }

                return listDiscos;

            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.cerrarConn(); }
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

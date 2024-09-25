using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class AutorNegocio
    {
        public List<Autor> listarAutores()
        {
            List<Autor> listAutores = new List<Autor>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setQuery("SELECT Id, Nombre FROM ARTISTAS");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Reader.Read())
                {
                    Autor autor = new Autor();
                    autor.Id = (int)accesoDatos.Reader["Id"];
                    autor.Nombre = (string)accesoDatos.Reader["Nombre"];
                    listAutores.Add(autor);
                }

                return listAutores;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { accesoDatos.cerrarConn(); }
        }

        public void insertarAutor(Autor a)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("INSERT INTO ARTISTAS VALUES (@Nombre)");
                datos.setParameters("@Nombre", a.Nombre);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConn(); }

        }
    }
}

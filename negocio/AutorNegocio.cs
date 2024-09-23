using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    internal class AutorNegocio
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
    }
}

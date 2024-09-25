using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class EstiloNegocio
    {
        public List<Estilo> listarEstilos()
        {
            List<Estilo> listEstilos =  new List<Estilo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("SELECT Id, Descripcion FROM ESTILOS");
                datos.ejecutarLectura();

                while (datos.Reader.Read())
                {
                    Estilo aux = new Estilo();
                    aux.Id = (int)datos.Reader["Id"];
                    aux.Genero = (string)datos.Reader["Descripcion"];
                    listEstilos.Add(aux);
                }

                return listEstilos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void insertarEstilo(Estilo e)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("INSERT INTO ESTILOS VALUES (@Descripcion)");
                datos.setParameters("@Descripcion", e.Genero);
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

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
                    //Validar NULL de la DB
                    if (!(datos.Reader["UrlImagenTapa"] is DBNull))
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
        EstiloNegocio en = new EstiloNegocio();
        AutorNegocio an = new AutorNegocio();   
        public void InsertarDisco(Disco d, Estilo e, Autor a)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                Estilo est = VerificarEInsercionEstilo(e);
                Autor aut = VerificarEInsercionAutor(a);
                
                datos.setQuery("INSERT INTO DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdArtista) VALUES (@Titulo, @FechaLanzamiento, @CantCanciones, @UrlTapa, @IdEstilo, @IdArtista)");

                datos.setParameters("@Titulo", d.Titulo);
                datos.setParameters("@FechaLanzamiento", d.FechaLanzamiento);
                datos.setParameters("@CantCanciones", d.CantCanciones);
                datos.setParameters("@UrlTapa", d.urlTapa);
                datos.setParameters("IdEstilo", est.Id);
                datos.setParameters("IdArtista", aut.Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConn(); }
        }

        public Estilo VerificarEInsercionEstilo(Estilo e)
        {
            List<Estilo> list = en.listarEstilos();
            Estilo est = null;

            foreach (Estilo es in list)
            {
                if (e.Genero == es.Genero)
                {
                    est = es;
                    return est;
                }
            }

            en.insertarEstilo(e);
            return VerificarEInsercionEstilo(e);
            
        }

        public Autor VerificarEInsercionAutor(Autor a)
        {
            List<Autor> list = an.listarAutores();
            Autor aut = null;

            foreach (Autor au in list)
            {
                if (a.Nombre == au.Nombre)
                {
                    aut = au;
                    return aut;
                }
            }

            an.insertarAutor(a);
            return VerificarEInsercionAutor(a);

        }

    }
}

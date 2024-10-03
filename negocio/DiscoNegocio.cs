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
        AccesoDatos datos = new AccesoDatos();
        EstiloNegocio en = new EstiloNegocio();
        AutorNegocio an = new AutorNegocio();
        public List<Disco> listarDiscos()
        {
            List<Disco> listDiscos = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("SELECT d.Id, Titulo, FechaLanzamiento as 'Fecha de Lanzamiento', CantidadCanciones as 'Cantidad de Canciones', e.Descripcion as Genero, a.Nombre as Autor, UrlImagenTapa From DISCOS d, ESTILOS e, ARTISTAS a WHERE IdArtista = a.Id AND IdEstilo = e.Id AND d.Activo = 1");
                datos.ejecutarLectura();
                

                while (datos.Reader.Read())
                {
                    Disco Daux = new Disco();
                    Daux.Id = (int)datos.Reader["id"];
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

        public List<Disco> Filtrar(string campo, string criterio, string filtro)
        {
            List<Disco> lista = new List<Disco>();

            try
            {
                string consulta = "SELECT d.Id, Titulo, FechaLanzamiento as 'Fecha de Lanzamiento', CantidadCanciones as 'Cantidad de Canciones', e.Descripcion as Genero, a.Nombre as Autor, UrlImagenTapa From DISCOS d, ESTILOS e, ARTISTAS a WHERE IdArtista = a.Id AND IdEstilo = e.Id AND d.Activo = 1 AND ";
                if (campo == "Artista")
                {
                    switch (criterio)
                    {
                        case "Comienza Con":
                            consulta += "a.Nombre LIKE '" + filtro + "%'";
                            break;
                        case "Termina Con":
                            consulta += "a.Nombre LIKE '%" + filtro + "'";
                            break;
                        case "Contiene":
                            consulta += "a.Nombre LIKE '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Estilo")
                {
                    switch (criterio)
                    {
                        case "Comienza Con":
                            consulta += "e.Descripcion LIKE '" + filtro + "%'";
                            break;
                        case "Termina Con":
                            consulta += "e.Descripcion LIKE '%" + filtro + "'";
                            break;
                        case "Contiene":
                            consulta += "e.Descripcion LIKE '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Mas De":
                            consulta += "d.CantidadCanciones > " + filtro;
                            break;
                        case "Menos De":
                            consulta += "d.CantidadCanciones < " + filtro;
                            break;
                        case "Igual A":
                            consulta += "d.CantidadCanciones = " + filtro;
                            break;
                    }
                }

                datos.setQuery(consulta);
                datos.ejecutarLectura();

                while (datos.Reader.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)datos.Reader["id"];
                    aux.Titulo = (string)datos.Reader["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Reader["Fecha de lanzamiento"];
                    aux.CantCanciones = (int)datos.Reader["Cantidad de Canciones"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Genero = (string)datos.Reader["Genero"];
                    aux.Artista = new Autor();
                    aux.Artista.Nombre = (string)datos.Reader["Autor"];
                    //Validar NULL de la DB
                    if (!(datos.Reader["UrlImagenTapa"] is DBNull))
                        aux.urlTapa = (string)datos.Reader["UrlImagenTapa"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.cerrarConn(); }
        }
        
        public void InsertarDisco(Disco d, Estilo e, Autor a)
        {
            
            try
            {
                Estilo est = VerificarEInsercionEstilo(e);
                Autor aut = VerificarEInsercionAutor(a);
                
                datos.setQuery("INSERT INTO DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdArtista, Activo) VALUES (@Titulo, @FechaLanzamiento, @CantCanciones, @UrlTapa, @IdEstilo, @IdArtista, 1)");

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

        public void ModificarDisco(Disco d, Estilo e, Autor a)
        {
            try
            {
                Estilo est = VerificarEInsercionEstilo(e);
                Autor aut = VerificarEInsercionAutor(a);

                datos.setQuery("UPDATE DISCOS SET Titulo = @Titulo, FechaLanzamiento = @FechaLanzamiento, CantidadCanciones = @CantCanciones, UrlImagenTapa= @UrlImagenTapa, IdEstilo = @IdEstilo, IdArtista=@IdArtista WHERE Id = @Id");
                
                datos.setParameters("@Titulo", d.Titulo);
                datos.setParameters("@FechaLanzamiento", d.FechaLanzamiento);
                datos.setParameters("@CantCanciones", d.CantCanciones);
                datos.setParameters("@UrlImagenTapa", d.urlTapa);
                datos.setParameters("@IdEstilo", est.Id);
                datos.setParameters("@IdArtista", aut.Id);
                datos.setParameters("@Id", d.Id);
                
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally { datos.cerrarConn(); }
        }

        public void EliminarFisico(Disco d)
        {
            try
            {
                datos.setQuery("DELETE FROM DISCOS WHERE Id = @Id");
                datos.setParameters("@Id", d.Id);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EliminarLogico(Disco d)
        {
            try
            {
                datos.setQuery("UPDATE DISCOS SET Activo = 0 WHERE Id = @Id");
                datos.setParameters("@Id", d.Id);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
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

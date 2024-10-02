using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Disco
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        [DisplayName("Fecha de Lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        [DisplayName("Cantidad de Canciones")]
        public int CantCanciones { get; set; }
        public string urlTapa { get; set; }
        public Estilo Estilo { get; set; }
        public Autor Artista { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDBDiscos
{
    internal class Disco
    {
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public int CantCanciones { get; set; }
        public string urlTapa { get; set; }
        public Estilo Estilo { get; set; }
        public Autor Artista { get; set; }
    }
}

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
        [DisplayName("Titulo            ")]
        public string Titulo { get; set; }
        
        [DisplayName("Fecha de lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        
        [DisplayName("Cantidad de canciones")]
        public int CantidadCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        public Estilo Estilo { get; set; }
        
        [DisplayName("Edición")]
        public Edicion TipoEdicion { get; set; }
    }
}

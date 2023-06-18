using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace presentacion
{
    internal class Articulo
    {
        public int Id { get; set; }

        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public string ImagenUrl { get; set; }

        public int Precio { get; set; }

        //Me copio las properties de tipo y debilidad de pokemon para orientarme
        //public Elemento Tipo { get; set; }

        //public Elemento Debilidad { get; set; }
    }
}

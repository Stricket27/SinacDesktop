using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AreaConservacion
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public byte[] Fotografia { get; set; }
        public string SitioWeb { get; set; }
        public string TipoArea { get; set; }
        public int IdUsuario { get; set; }

        public override string ToString()
        {
            return ID + " - " + Nombre;
        }


    }
}

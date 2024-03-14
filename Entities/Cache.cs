using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class Cache
    {
        //USUARIO
        public static int ID { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string CorreoElectronico { get; set; }
        public static string Estado { get; set; }
        //

        //ORDEN COMPRA
        public static int NumeroOrden { get; set; }
        //

        //Area
        public static int IDArea { get; set; }
        //


    }
}

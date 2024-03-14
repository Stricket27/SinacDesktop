using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Disponibilidad
    {
        public int ID { get; set; }
        public int IDAreaConservacion { get; set; }
        public string HoraDeInicio { get; set; }
        public string HoraFinal { get; set; }
        public int CantidadEntradas { get; set; }
        public float Precio { get; set; }
        public DateTime FechaDeReservacion { get; set; }

        public override string ToString()
        {
            return "Precio base: " + Precio +
                "\nGrupo: " + ID +
                "\nHora de inicio: " + HoraDeInicio +
                "\nHora final: " + HoraFinal +
                "\nCantidad de entradas: " + CantidadEntradas;
        }


    }
}

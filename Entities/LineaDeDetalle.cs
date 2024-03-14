using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Entities
{
    public class LineaDeDetalle
    {
        public static int Contador = 0;
        public int NumeroDeLinea { get; set; }
        public Disponibilidad disponibilidad { get; set; }
        public int Cantidad { get; set; }
        public TipoPersona persona { get; set; }

        //DATOS VISITANTE
        public string NCVisitante1 { get; set; }
        public string NCVisitante2 { get; set; }
        public string IVisitante1 { get; set; }
        public string IVisitante2 { get; set; }
        public PaisResidencia PRVisitante1 { get; set; }
        public PaisResidencia PRVisitante2 { get; set; }

        public LineaDeDetalle()
        {
            NumeroDeLinea = Contador + 1;
        }

        public float subTotal()
        {
            float subTotal = 0f;
            if (persona == TipoPersona.Niño)
            {
                subTotal = (disponibilidad.Precio + 500) * Cantidad;
            }
            if (persona == TipoPersona.Adulto)
            {
                subTotal = (disponibilidad.Precio + 750) * Cantidad;
            }
            if (persona == TipoPersona.AdultoMayor)
            {
                subTotal = (disponibilidad.Precio + 900) * Cantidad;
            }

            return subTotal;

            //return disponibilidad.Precio * Cantidad;
        }

        public override string ToString()
        {
            return "No. Linea: " + NumeroDeLinea +
                "\n" + disponibilidad.ToString() +

                "\n\nDATOS DE LOS VISITANTE" +
                "\nVisitante 1" +
                "\nNombre completo: " + NCVisitante1 +
                "\nIdentificación: " + IVisitante1 +
                "\nPais de residencia: " + PRVisitante1 +

                "\n\nVisitante 2" +
                "\nNombre completo: " + NCVisitante2 +
                "\nIdentificación: " + IVisitante2 +
                "\nPais de residencia: " + PRVisitante2;



        }


    }
}

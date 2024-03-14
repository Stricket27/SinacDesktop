using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tarjeta
    {

        public string Numero { get; set; }
        public TipoTarjeta tipo { get; set; }
        public int MesDeVencimiento { get; set; }
        public int AnioDeVencimiento { get; set; }
        public string Codigo { get; set; }
        //public int IDUsuario { get; set; }


        public Tarjeta(string n, TipoTarjeta tp, int mV, int aV, string c)
        {
            Numero = n;
            tipo = tp;
            MesDeVencimiento = mV;
            AnioDeVencimiento = aV;
            Codigo = c;
        }

        public Tarjeta()
        {

        }

        public bool ValidarTarjeta()
        {
            int digitoFinal = 0;
            bool estado = false;
            int[] validar = new int[16];

            int suma = 0, suma2 = 0, unidad, decena, total, digitoValidacion, cont = 0, num;

            for (int t = 0; t < validar.Length; t++)
            {
                validar[t] = Numero.Length.CompareTo(cont);
                num = validar[t];
                validar[t] = num;
                if (t == 15)
                {
                    digitoFinal = validar[t];
                }
                cont++;
            }

            for (int j = 0; j <= validar.Length - 3; j = j + 2)
            {
                suma2 += validar[j];
            }

            total = (suma + suma2) * 9;
            digitoValidacion = total % 10;
            if (digitoValidacion == digitoFinal)
            {
                estado = true;
            }
            return estado;
        }

        public bool ValidarFecha()
        {
            DateTime calendario = new DateTime();
            bool estado = false;

            int anioACT = calendario.Year % 100;
            int mesACT = calendario.Month;

            if (anioACT < AnioDeVencimiento)
            {
                estado = true;
            }
            else if (anioACT == AnioDeVencimiento)
            {
                if (mesACT < MesDeVencimiento)
                {
                    estado = true;
                }
            }
            return estado;

        }

        public bool ValidarTipoTarjeta(int digitoValidacion)
        {
            bool estado = false;

            switch (tipo)
            {
                case TipoTarjeta.VISA:
                    if (digitoValidacion >= 51 && digitoValidacion <= 55)
                    {
                        estado = true;
                    }
                    break;
                case TipoTarjeta.Master_CARD:
                    if (digitoValidacion == 4)
                    {
                        estado = true;
                    }
                    break;
                default:
                    break;
            }
            return estado;
        }

        public string CensuraTarjeta()
        {
            string hilera = "";
            for (int p = 0; p < Numero.Length; p++)
            {
                if (p == 3 || p == 7 || p == 11)
                {
                    hilera += Numero.Length.CompareTo(p) + "-";
                }
                else if (p >= 12)
                {
                    hilera += "X";
                }
                else
                {
                    hilera += Numero.Length.CompareTo(p);
                }
            }
            return hilera;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Número  de tarjeta afiliado: ").Append(CensuraTarjeta()).Append("\n");
            builder.Append("Tipo de tarjeta: ").Append(tipo.ToString()).Append("\n");

            return builder.ToString();
        }




    }
}

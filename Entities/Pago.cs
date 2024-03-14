using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Pago
    {
        public DateTime FechaDePago { get; set; }
        public double montoPagoEnColones { get; set; }
        public double montoPagoEnDolares { get; set; }
        public Moneda moneda { get; set; }

        

        public Pago()
        {
            FechaDePago = DateTime.Now;
        }
        public Pago(double colones, double dolares, Moneda m)
        {
            this.FechaDePago = new DateTime();
            this.montoPagoEnColones = colones;
            this.montoPagoEnDolares = dolares;
            this.moneda = m;
        }

        public void conversionColonesADolares()
        {
            if (moneda == Moneda.Colones)
            {
                montoPagoEnDolares = montoPagoEnColones / 630;
            }
        }
        public void conversionDolaresAColones()
        {
            if (moneda == Moneda.Dolares)
            {
                montoPagoEnColones = montoPagoEnDolares * 630;
            }
        }

        public string numeroALetra(int numero)
        {
            String cadena = "";

            if ((numero / 1000000) > 0)
            {
                if ((numero / 1000000) == 1)
                {
                    cadena = "UN MILLÓN" + numeroALetra(numero % 1000000);
                }
                else
                {
                    cadena = numeroALetra(numero / 1000000) + " MILLONES " + numeroALetra(numero % 1000000);
                }
            }
            else
            {
                if ((numero / 1000) > 0)
                {
                    if ((numero / 1000) == 1)
                    {
                        cadena = " MIL " + numeroALetra(numero % 1000);
                    }
                    else
                    {
                        cadena = numeroALetra(numero / 1000) + " MIL " + numeroALetra(numero % 1000);
                    }

                }
                else
                {
                    if ((numero / 100) > 0)
                    {
                        if ((numero / 100) == 1)
                        {
                            if ((numero % 100) == 0)
                            {
                                cadena = " CIEN ";
                            }
                            else
                            {
                                cadena = " CIENTO " + numeroALetra(numero % 100);
                            }

                        }
                        else
                        {
                            if ((numero / 100) == 5)
                            {
                                cadena = " QUINIENTOS " + numeroALetra(numero % 100);
                            }
                            else
                            {
                                if ((numero / 100) == 9)
                                {
                                    cadena = " NOVECIENTOS " + numeroALetra(numero % 100);
                                }
                                else
                                {
                                    if ((numero / 100) == 7)
                                    {
                                        cadena = " SETECIENTOS " + numeroALetra(numero % 100);
                                    }
                                    else
                                    {

                                        cadena = numeroALetra(numero / 100) + "CIENTOS " + numeroALetra(numero % 100);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if ((numero / 10) > 0)
                        {
                            switch ((int)(numero / 10))
                            {
                                case 1:
                                    switch ((int)(numero % 10))
                                    {
                                        case 0:
                                            cadena = " DIEZ ";
                                            break;
                                        case 1:
                                            cadena = " ONCE ";
                                            break;
                                        case 2:
                                            cadena = " DOCE ";
                                            break;
                                        case 3:
                                            cadena = " TRECE ";
                                            break;
                                        case 4:
                                            cadena = " CATORCE ";
                                            break;
                                        case 5:
                                            cadena = " QUINCE ";
                                            break;
                                        default:
                                            cadena = " DIECI" + numeroALetra(numero % 10);
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch ((int)(numero % 10))
                                    {
                                        case 0:
                                            cadena = " VEINTE ";
                                            break;
                                        default:
                                            cadena = " VEINTI" + numeroALetra(numero % 10);
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch ((int)(numero % 10))
                                    {
                                        case 0:
                                            cadena = " TREINTA ";
                                            break;
                                        default:
                                            cadena = " TREINTA Y " + numeroALetra(numero % 10);
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch ((int)(numero % 10))
                                    {
                                        case 0:
                                            cadena = " CUARENTA ";
                                            break;
                                        default:
                                            cadena = " CUARENTA Y " + numeroALetra(numero % 10);
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch ((int)(numero % 10))
                                    {
                                        case 0:
                                            cadena = " CINCUENTA ";
                                            break;
                                        default:
                                            cadena = " CINCUENTA Y " + numeroALetra(numero % 10);
                                            break;
                                    }
                                    break;
                                case 6:
                                    switch ((int)(numero % 10))
                                    {
                                        case 0:
                                            cadena = " SESENTA ";
                                            break;
                                        default:
                                            cadena = " SESENTA Y " + numeroALetra(numero % 10);
                                            break;
                                    }
                                    break;
                                case 7:
                                    switch ((int)(numero % 10))
                                    {
                                        case 0:
                                            cadena = " SETENTA ";
                                            break;
                                        default:
                                            cadena = " SETENTA Y " + numeroALetra(numero % 10);
                                            break;
                                    }
                                    break;
                                case 8:
                                    switch ((int)(numero % 10))
                                    {
                                        case 0:
                                            cadena = " OCHENTA ";
                                            break;
                                        default:
                                            cadena = " OCHENTA Y " + numeroALetra(numero % 10);
                                            break;
                                    }
                                    break;
                                case 9:
                                    switch ((int)(numero % 10))
                                    {
                                        case 0:
                                            cadena = " NOVENTA ";
                                            break;
                                        default:
                                            cadena = " NOVENTA Y" + numeroALetra(numero % 10);
                                            break;
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            switch ((int)(numero))
                            {
                                case 0:
                                    cadena = " CERO ";
                                    break;
                                case 1:
                                    cadena = " UNO ";
                                    break;
                                case 2:
                                    cadena = " DOS";
                                    break;
                                case 3:
                                    cadena = " TRES";
                                    break;
                                case 4:
                                    cadena = " CUATRO";
                                    break;
                                case 5:
                                    cadena = " CINCO";
                                    break;
                                case 6:
                                    cadena = " SEIS";
                                    break;
                                case 7:
                                    cadena = " SIETE";
                                    break;
                                case 8:
                                    cadena = " OCHO";
                                    break;
                                case 9:
                                    cadena = " NUEVE";
                                    break;
                            }
                        }
                    }
                }
            }
            return cadena;
        }

        public override string ToString()
        {

            string hilera = "Fecha de pago: " + FechaDePago.ToString() +
                "\nMoneda con la que se pagó: " + moneda;

            if (moneda == Moneda.Colones)
            {
                hilera += "\nMonto pagado en colones :" + montoPagoEnColones;
                hilera += "\n" + numeroALetra((int)montoPagoEnColones);
            }
            else
            {
                hilera += "\nMonto pagado en dólares: " + montoPagoEnDolares;
                hilera += "\n" + numeroALetra((int)montoPagoEnDolares);
            }
            return hilera;
        }



    }
}

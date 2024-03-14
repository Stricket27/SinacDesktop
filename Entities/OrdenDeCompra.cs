using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using System.IO;
using System.Threading;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;

namespace Entities
{
    public class OrdenDeCompra
    {
        public string NumeroFicha { get; set; }
        public int NumeroOrdenes = 1;
        public Usuario Usuario { get; set; }

        public List<LineaDeDetalle> LISTAlineaDeDetalles;

        public Pago pago { get; set; }
        public DateTime FechaOrden { get; set; }
        public AreaConservacion areaConservacion { get; set; }

        public OrdenDeCompra(int numero, Usuario u, Pago p, DateTime fecha)
        {
            this.NumeroOrdenes = numero;
            this.Usuario = u;
            this.pago = p;
            FechaOrden = fecha;
            LISTAlineaDeDetalles = new List<LineaDeDetalle>();
        }

        public OrdenDeCompra()
        {
            LISTAlineaDeDetalles = new List<LineaDeDetalle>();
            FechaOrden = DateTime.Now;
            this.NumeroOrdenes = +1;
        }

        public float SubTotal()
        {
            float subTotal = 0f;
            foreach (LineaDeDetalle linea in LISTAlineaDeDetalles)
            {
                subTotal += linea.subTotal();
            }
            return subTotal;
        }

        public float TotalImpuesto()
        {
            float impuesto = 0f;
            impuesto += SubTotal() * 0.13f;
            return impuesto;
        }

        public float TotalCompra()
        {
            return SubTotal() + TotalImpuesto();
        }

        public void RealizarPago(float montoPago, Moneda moneda)
        {
            pago = new Pago();
            pago.moneda = moneda;
            if (moneda == Moneda.Colones)
            {
                pago.montoPagoEnColones = montoPago;
            }
            else
            {
                pago.montoPagoEnDolares = montoPago;
            }
        }

        public void AgregarLineaDetalle(LineaDeDetalle linea)
        {
            LISTAlineaDeDetalles.Add(linea);
        }

        public void EliminarLineaDetalle(LineaDeDetalle linea)
        {
            LISTAlineaDeDetalles.Remove(linea);
        }

        public void GuardaXML()
        {
            XmlDocument document = new XmlDocument();
            XmlElement raiz = document.CreateElement("FacturaElectronica");
            document.AppendChild(raiz);

            XmlElement nNumeroOrden = document.CreateElement("NumeroOrden");
            nNumeroOrden.InnerText = NumeroOrdenes.ToString();
            raiz.AppendChild(nNumeroOrden);

            XmlElement nFecha = document.CreateElement("Fecha");
            nFecha.InnerText = FechaOrden.ToString();
            nNumeroOrden.AppendChild(nFecha);

            XmlElement nCliente = document.CreateElement("Cliente");
            nCliente.SetAttribute("Nombre", Cache.Nombre);
            nCliente.SetAttribute("Apellido", Cache.Apellido);
            nCliente.SetAttribute("CorreoElectronico", Cache.CorreoElectronico);
            nNumeroOrden.AppendChild(nCliente);

            XmlElement nParque = document.CreateElement("ParqueSeleccionado");
            nParque.InnerText = areaConservacion.Nombre;
            nNumeroOrden.AppendChild(nParque);

            XmlElement nDetalleFactura = document.CreateElement("DetalleFactura");
            foreach (var linea in LISTAlineaDeDetalles)
            {
                XmlElement nNoLineaDetalle = document.CreateElement("NoLineaDetalle");
                nNoLineaDetalle.InnerText = linea.NumeroDeLinea.ToString();
                nDetalleFactura.AppendChild(nNoLineaDetalle);

                XmlElement nDisponibilidad = document.CreateElement("Disponibilidad");
                nDisponibilidad.SetAttribute("PrecioBase", linea.disponibilidad.Precio.ToString());
                nDisponibilidad.SetAttribute("Grupo", linea.disponibilidad.ID.ToString());
                nDisponibilidad.SetAttribute("HoraInicio", linea.disponibilidad.HoraDeInicio);
                nDisponibilidad.SetAttribute("HoraFinal", linea.disponibilidad.HoraFinal);
                nDisponibilidad.SetAttribute("CantidadEntradas", linea.disponibilidad.CantidadEntradas.ToString());
                nDetalleFactura.AppendChild(nDisponibilidad);

                //DATOS VISITANTE 1
                XmlElement nVisitante1 = document.CreateElement("Visitante1");
                nVisitante1.SetAttribute("NombreCompleto", linea.NCVisitante1);
                nDetalleFactura.AppendChild(nVisitante1);

                nVisitante1.SetAttribute("Identificacion1", linea.IVisitante1);
                nDetalleFactura.AppendChild(nVisitante1);

                nVisitante1.SetAttribute("PaisResidencia1", linea.PRVisitante1.ToString());
                nDetalleFactura.AppendChild(nVisitante1);
                //

                //DATOS VISITANTE 2
                XmlElement nVisitante2 = document.CreateElement("Visitante2");
                nVisitante2.SetAttribute("NombreCompleto", linea.NCVisitante2);
                nDetalleFactura.AppendChild(nVisitante2);

                nVisitante2.SetAttribute("Identificacion2", linea.IVisitante2);
                nDetalleFactura.AppendChild(nVisitante2);

                nVisitante2.SetAttribute("PaisResidencia2", linea.PRVisitante2.ToString());
                nDetalleFactura.AppendChild(nVisitante2);
                //

            }
            nNumeroOrden.AppendChild(nDetalleFactura);

            XmlElement nSubTotal = document.CreateElement("SubTotal");
            nSubTotal.InnerText = SubTotal().ToString();
            nNumeroOrden.AppendChild(nSubTotal);

            XmlElement nImpuesto = document.CreateElement("Impuesto");
            nImpuesto.InnerText = TotalImpuesto().ToString();
            nNumeroOrden.AppendChild(nImpuesto);

            XmlElement nTotalCompra = document.CreateElement("TotalCompra");
            nTotalCompra.InnerText = TotalCompra().ToString();
            nNumeroOrden.AppendChild(nTotalCompra);

            //FIRMA DIGITAL
            CspParameters cspParams = new CspParameters();
            cspParams.KeyContainerName = "XML_DSIG_RSA_KEY";

            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(cspParams);

            document.PreserveWhitespace = true;

            SignedXml signedXml = new SignedXml(document);

            signedXml.SigningKey = RSA;

            // Create a reference to be signed.
            Reference reference = new Reference();
            reference.Uri = "";

            XmlDsigEnvelopedSignatureTransform xmlDEST = new XmlDsigEnvelopedSignatureTransform();
            reference.AddTransform(xmlDEST);

            signedXml.AddReference(reference);

            signedXml.ComputeSignature();

            XmlElement xmlDigitalSignature = signedXml.GetXml();

            document.DocumentElement.AppendChild(document.ImportNode(xmlDigitalSignature, true));

            //

            document.Save(@"Factura Electronica.xml");

        }

        //public void ConvertirXMLaPDF()
        //{
        //    //Thread thread = new Thread(ConvertirXMLaPDF);
        //    //thread.SetApartmentState(ApartmentState.STA);
        //    //thread.Start();
        //    //thread.Join();

        //    //Initialize the HtmlToPdfConverter with IE rendering engine
        //    HtmlToPdfConverter htmlToPDFConverter = new HtmlToPdfConverter(HtmlRenderingEngine.IE);

        //    //Initialize IE converter settings
        //    IEConverterSettings IEsettings = new IEConverterSettings();

        //    //Set the additional delay for conversion
        //    IEsettings.AdditionalDelay = 1000;

        //    //Assign the IEConverterSettings to ConverterSettings of HtmlToPdfConverter
        //    htmlToPDFConverter.ConverterSettings = IEsettings;

        //    //Convert the XML file to PDF
        //    PdfDocument document = htmlToPDFConverter.Convert(Path.GetFullPath("C:\\Users\\moise\\Escritorio\\Version Modificado\\Factura Electronica.xml"));

        //    //Save the PDF document
        //    document.Save("C:\\Users\\moise\\Escritorio\\Version Modificado\\Factura Electronica.pdf");

        //    //Close the instance of PdfDocument
        //    document.Close(true);
        //}

        public void GenerarPDF()
        {
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 20, 20, 35, 25);

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(
                "Factura Electronica.pdf", FileMode.Create));

            document.Open();

            Paragraph elements = new Paragraph("Factura Electronica");
            document.Add(elements);

            List list = new List(List.UNORDERED);
            list.Add(ToString());
            document.Add(list);

            //document.Close();

            //QR
            BarcodeQRCode barcodeQRCode = new BarcodeQRCode(ToString(), 1000, 1000, null);
            Image image = barcodeQRCode.GetImage();
            image.ScaleAbsolute(200, 200);

            document.Add(image);
            //

            document.Close();

        }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("No. Orden: ").Append(NumeroOrdenes).Append("\n");
            builder.Append("Fecha: ").Append(FechaOrden).Append("\n");
            builder.Append("Cliente: ").Append(Cache.Nombre).Append(" ").Append(Cache.Apellido).Append("\n");
            builder.Append("Parque seleccionado: ").Append(areaConservacion.Nombre).Append("\n");
            builder.Append("**************************************************************** \n\n");

            builder.Append("Detalle de la factura").Append("\n");
            foreach (LineaDeDetalle linea in LISTAlineaDeDetalles)
            {
                builder.Append(linea.ToString()).Append("\n");
                builder.Append("**************************************************************** \n\n");
            }
            builder.Append("Costo totales").Append("\n");
            builder.Append("SubTotal: ").Append(SubTotal()).Append("\n");
            builder.Append("Impuesto total: ").Append(TotalImpuesto()).Append("\n");
            builder.Append("Total a pagar: ").Append(TotalCompra()).Append("\n");
            builder.Append("**************************************************************** \n\n");

            builder.Append("Información de pago").Append("\n");
            builder.Append(pago.ToString());
            builder.Append("\n");
            builder.Append("**************************************************************** \n\n");

            return builder.ToString();
        }


    }
}

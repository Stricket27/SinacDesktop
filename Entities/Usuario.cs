using System.Collections.Generic;using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Entities
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Nacionalidad { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string Profesion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasenia { get; set; }
        public string Estado { get; set; }

        public override string ToString()
        {
            return ID + " - " + Nombre + " " + Apellido;
        }

        public void GuardarXML(string ruta)
        {
            XmlDocument document = new XmlDocument();

            if (File.Exists(ruta))
            {
                document.LoadXml(ruta);
            }
            else
            {
                XmlDeclaration declaration = document.CreateXmlDeclaration("1.0", null, null);
                document.AppendChild(declaration);// Se crea la raiz

                //string rutaXslt = System.Windows.Forms.Application.StartupPath + "\\Xslt\\Casillero.xslt";
                //XmlProcessingInstruction xslt = document.CreateProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" href=\"" + rutaXslt + "\"");
                //document.AppendChild(xslt);

                XmlElement root = document.CreateElement("Información de usuario");
                document.AppendChild(root);
            }

            XmlElement nCliente = document.CreateElement("Usuario");
            nCliente.SetAttribute("Nombre", Nombre);
            nCliente.SetAttribute("Apellido", Apellido);
            nCliente.SetAttribute("Contraseña", Contrasenia);

            document.DocumentElement.AppendChild(nCliente);

            document.Save(ruta);

        }






























    }
}

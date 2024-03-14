using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.ServicioEmail
{
    public class AdministradorDelSistema : Servicio
    {

        public AdministradorDelSistema()
        {
            enviarEmail = "sinacutn@gmail.com";
            contrasenia = "PSinacUTNP3";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            InicializarSmtpClent();
        }


    }
}

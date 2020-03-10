// Template: Controller Interface (ApiControllerInterface.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ServidorRAML.Utilidades.Models;


namespace ServidorRAML.Utilidades
{
    public interface IUtilidadesController
    {

        IHttpActionResult Get([FromUri] string restkey,[FromUri] string dni);
        IHttpActionResult GetValidarIBAN([FromUri] string restkey,[FromUri] string iban);
        IHttpActionResult GetValidarNAFSS([FromUri] string restkey,[FromUri] string nafss);
    }
}

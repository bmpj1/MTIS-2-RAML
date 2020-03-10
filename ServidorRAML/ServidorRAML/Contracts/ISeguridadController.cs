// Template: Controller Interface (ApiControllerInterface.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ServidorRAML.Seguridad.Models;


namespace ServidorRAML.Seguridad
{
    public interface ISeguridadController
    {

        IHttpActionResult Post([FromBody] string content,[FromUri] string restkey,[FromUri] string dni,[FromUri] string sala);
        IHttpActionResult Get([FromUri] string restkey,[FromUri] string dni,[FromUri] string sala);
        IHttpActionResult Delete([FromUri] string restkey,[FromUri] string dni,[FromUri] string sala);
        IHttpActionResult GetObtenerNiveles([FromUri] string restkey,[FromUri] string dni);
    }
}

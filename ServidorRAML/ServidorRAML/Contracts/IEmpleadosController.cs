// Template: Controller Interface (ApiControllerInterface.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ServidorRAML.Empleado.Models;


namespace ServidorRAML.Empleado
{
    public interface IEmpleadosController
    {

        IHttpActionResult Post([FromBody] ServidorRAML.Empleado.Models.Empleado empleado,[FromUri] string restkey);
        IHttpActionResult Get([FromUri] string restkey,[FromUri] string dni);
        IHttpActionResult Put([FromBody] ServidorRAML.Empleado.Models.Empleado empleado,[FromUri] string restkey);
        IHttpActionResult Delete([FromUri] string restkey,[FromUri] string dni);
    }
}

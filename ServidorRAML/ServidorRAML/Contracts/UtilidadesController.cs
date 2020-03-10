// Template: Base Controller (ApiControllerBase.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ServidorRAML.Utilidades.Models;

// Do not modify this file. This code was generated by AMF Server Scaffolder

namespace ServidorRAML.Utilidades
{
    [RoutePrefix("utilidades")]
    public partial class UtilidadesController : ApiController
    {


/// <summary>
		/// Valida un NIF - /utilidades/validarNIF
		/// </summary>
		/// <param name="restkey">Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)</param>
		/// <param name="dni">DNI a validar</param>
		/// <returns>MultipleUtilidadesValidarNIFGet</returns>
        [ResponseType(typeof(MultipleUtilidadesValidarNIFGet))]
        [HttpGet]
        [Route("validarNIF")]
        public virtual IHttpActionResult GetBase([FromUri] string restkey,[FromUri] string dni)
        {
            // Do not modify this code
                        return  ((IUtilidadesController)this).Get(restkey,dni);
                    }

/// <summary>
		/// Valida un IBAN - /utilidades/validarIBAN
		/// </summary>
		/// <param name="restkey">Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)</param>
		/// <param name="iban">IBAN a validar</param>
		/// <returns>MultipleUtilidadesValidarIBANGet</returns>
        [ResponseType(typeof(MultipleUtilidadesValidarIBANGet))]
        [HttpGet]
        [Route("validarIBAN")]
        public virtual IHttpActionResult GetValidarIBANBase([FromUri] string restkey,[FromUri] string iban)
        {
            // Do not modify this code
                        return  ((IUtilidadesController)this).GetValidarIBAN(restkey,iban);
                    }

/// <summary>
		/// Valida un NAFSS - /utilidades/validarNAFSS
		/// </summary>
		/// <param name="restkey">Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)</param>
		/// <param name="nafss">NAFSS a validar</param>
		/// <returns>MultipleUtilidadesValidarNAFSSGet</returns>
        [ResponseType(typeof(MultipleUtilidadesValidarNAFSSGet))]
        [HttpGet]
        [Route("validarNAFSS")]
        public virtual IHttpActionResult GetValidarNAFSSBase([FromUri] string restkey,[FromUri] string nafss)
        {
            // Do not modify this code
                        return  ((IUtilidadesController)this).GetValidarNAFSS(restkey,nafss);
                    }
    }
}
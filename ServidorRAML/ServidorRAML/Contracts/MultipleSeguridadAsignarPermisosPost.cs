// Template: Models (ApiModel.t4) version 5.0

// This code was generated by AMF Server Scaffolder

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using ServidorRAML.Utilidades.Models;

namespace ServidorRAML.Seguridad.Models
{
    /// <summary>
    /// Multiple Response Types Ipbool, Error
    /// </summary>
    public partial class MultipleSeguridadAsignarPermisosPost
    {
        

        /// <summary>
        /// Se han asociado la sala y el empleado correctamente. 
        /// </summary>

        public bool? Ipbool { get; set; }

        /// <summary>
        /// Ha ocurrido algun error al realizar la operacion. Objeto utilziado para transmitir un mensaje y codigo en caso de algun error.
        /// </summary>

        public Error Error { get; set; }
    } // end class

} // end Models namespace

// Template: Models (ApiModel.t4) version 5.0

// This code was generated by AMF Server Scaffolder

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using ServidorRAML.Utilidades.Models;

namespace ServidorRAML.Empleado.Models
{
    /// <summary>
    /// Multiple Response Types Ipbool, Error
    /// </summary>
    public partial class MultipleEmpleadosNuevoPost
    {
        

        /// <summary>
        /// Se ha creado un Empleado con exito. 
        /// </summary>

        public bool? Ipbool { get; set; }

        /// <summary>
        /// Ha ocurrido un error al crear el empleado. Objeto utilziado para transmitir un mensaje y codigo en caso de algun error.
        /// </summary>

        public Error Error { get; set; }
    } // end class

} // end Models namespace

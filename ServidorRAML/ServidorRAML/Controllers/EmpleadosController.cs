// Template: Controller Implementation (ApiControllerImplementation.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ServidorRAML.Empleado.Models;
using ServidorRAML.Models;
using ServidorRAML.Utilidades.Models;

namespace ServidorRAML.Empleado
{
    public partial class EmpleadosController : IEmpleadosController
    {
		private dbEmpleado empCon;
		private dbUtilidad uCon;
		/// <summary>
		/// Crear un empleado - /empleados/nuevo
		/// </summary>
		/// <param name="empleado">Objeto empleado para almacenar los datos de un empleado.</param>
		/// <param name="restkey">Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)</param>
		/// <returns>MultipleEmpleadosNuevoPost</returns>
		public IHttpActionResult Post([FromBody] ServidorRAML.Empleado.Models.Empleado empleado,[FromUri] string restkey)
        {
			// TODO: implement Post - route: empleados/nuevo
			var result = new MultipleEmpleadosNuevoPost();
			result.Error = new Error();
			result.Ipbool = false;
			result.Error.Code = 400;
			result.Error.Message = "Error al crear el empleado";
			
			try
			{
				uCon = new dbUtilidad();
				if (uCon.checkRestKey(restkey))
				{
					empCon = new dbEmpleado();
					bool allOk = empCon.nuevoEmpleado(empleado, restkey);
					result.Ipbool = allOk;
					if (allOk)
					{
						result.Error.Code = 200;
						result.Error.Message = "Usuario creado correctamente";
					} else
					{
						result.Error.Message = "Ese usuario ya existe.";
					}
				}
				else
				{ result.Error.Message = "Error al validar la soapkey."; }
			}
			catch (Exception e)
			{ result.Error.Message = "Error al acceder a la BDD: Ya hay un usuario registrado con ese DNI" /*+ e.Message */; }

			return Ok(result);
        }

/// <summary>
		/// Obtener un empleado a partir de su DNI y una RestKey - /empleados/consultar
		/// </summary>
		/// <param name="restkey">Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)</param>
		/// <param name="dni">DNI del empleado a consultar.</param>
		/// <returns>MultipleEmpleadosConsultarGet</returns>
        public IHttpActionResult Get([FromUri] string restkey,[FromUri] string dni)
        {
            // TODO: implement Get - route: empleados/consultar
			var result = new MultipleEmpleadosConsultarGet();
			result.Empleado = new Models.Empleado();
			result.Error = new Error();
			result.Error.Code = 400;
			result.Error.Message = "Error al consultar el empleado";

			try
			{
				uCon = new dbUtilidad();
				if (uCon.checkRestKey(restkey))
				{
					empCon = new dbEmpleado();
					result.Empleado = empCon.ConsultarEmpleado(dni, restkey);
					if (result.Empleado == null)
					{
						result.Error.Message = "Ese DNI no esta registrado en la bdd";
					}
					else
					{
						result.Error.Code = 200;
						result.Error.Message = "Usuario consultado correctamente";
					}
				}
				else
				{ result.Error.Message = "Error al validar la soapkey."; }
			}
			catch (Exception e)
			{ result.Error.Message = "Error al acceder a la BDD: " + e.Message; }
			
			return Ok(result);
        }

/// <summary>
		/// Actualiza los datos de un empleado tras validar una RestKey - /empleados/modificar
		/// </summary>
		/// <param name="empleado">Objeto empleado para almacenar los datos de un empleado.</param>
		/// <param name="restkey">Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)</param>
		/// <returns>MultipleEmpleadosModificarPut</returns>
        public IHttpActionResult Put([FromBody] ServidorRAML.Empleado.Models.Empleado empleado,[FromUri] string restkey)
        {
            // TODO: implement Put - route: empleados/modificar
			var result = new MultipleEmpleadosModificarPut();
			result.Error = new Error();
			result.Error.Code = 400;
			result.Error.Message = "Error al modificar el empleado";
			result.Ipbool = false;

			try
			{
				uCon = new dbUtilidad();
				if (uCon.checkRestKey(restkey))
				{
					empCon = new dbEmpleado();
					bool allOk = empCon.ModificarEmpleado(empleado, restkey);
					result.Ipbool = allOk;
					result.Error.Code = 200;
					result.Error.Message = "Usuario modificado correctamente";
				}
				else
				{ result.Error.Message = "Error al validar la soapkey."; }
			}
			catch (Exception e)
			{ result.Error.Message = "Error al acceder a la BDD: " + e.Message; }

			return Ok(result);
        }

/// <summary>
		/// Eliminar un empleado de la base de datos - /empleados/borrar
		/// </summary>
		/// <param name="restkey">Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)</param>
		/// <param name="dni">DNI del empleado a consultar.</param>
		/// <returns>MultipleEmpleadosBorrarDelete</returns>
        public IHttpActionResult Delete([FromUri] string restkey,[FromUri] string dni)
        {
            // TODO: implement Delete - route: empleados/borrar
			var result = new MultipleEmpleadosBorrarDelete();
			result.Error = new Error();
			result.Error.Code = 400;
			result.Error.Message = "Error al eliminar el empleado";
			result.Ipbool = false;

			try
			{
				uCon = new dbUtilidad();
				if (uCon.checkRestKey(restkey))
				{
					empCon = new dbEmpleado();
					bool allOk = empCon.BorrarEmpleado(dni, restkey);
					result.Ipbool = allOk;
					if (!allOk)
					{
						result.Error.Message = "Ese DNI no está registrado en la BDD";
					} else
					{
						result.Error.Code = 200;
						result.Error.Message = "Usuario eliminado correctamente";
					}
					
				}
				else
				{ result.Error.Message = "Error al validar la soapkey."; }
			}
			catch (Exception e)
			{ result.Error.Message = "Error al acceder a la BDD: " + e.Message; }
			
			return Ok(result);
        }

    }
}

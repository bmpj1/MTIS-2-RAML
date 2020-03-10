// Template: Controller Implementation (ApiControllerImplementation.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ServidorRAML.Models;
using ServidorRAML.Seguridad.Models;
using ServidorRAML.Utilidades.Models;

namespace ServidorRAML.Seguridad
{
    public partial class SeguridadController : ISeguridadController
    {
		private dbSeguridad segCon;
		// Conexxion con la bdd para validar la restkey
		private dbUtilidad uCon;
		/// <summary>
		/// Concede permisos de acceso enlazando una sala con un empleado - /seguridad/asignarPermisos
		/// </summary>
		/// <param name="content"></param>
		/// <param name="restkey">Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)</param>
		/// <param name="dni">Un DNI valido de un empleado registrado.</param>
		/// <param name="sala">Un nombre de una sala</param>
		/// <returns>MultipleSeguridadAsignarPermisosPost</returns>
		public IHttpActionResult Post([FromBody] string content,[FromUri] string restkey,[FromUri] string dni,[FromUri] string sala)
        {
            // TODO: implement Post - route: seguridad/asignarPermisos
			var result = new MultipleSeguridadAsignarPermisosPost();
			result.Error = new Error();
			result.Error.Code = 400;
			result.Error.Message = "Error al asignar permisos, verifique que el empleado existe.";
			result.Ipbool = false;

			try
			{
				uCon = new dbUtilidad();
				if (uCon.checkRestKey(restkey))
				{
					segCon = new dbSeguridad();
					bool allOk = segCon.asignarPermiso(dni, sala, restkey);
					result.Ipbool = allOk;
					result.Error.Code = 200;
					result.Error.Message = "Sala asignada correctamente";
				}
				else
				{ result.Error.Message = "Error al validar la soapkey."; }
			}
			catch (Exception e)
			{ result.Error.Message = "Error al acceder a la BDD: Ese usuario ya está asignado a esa sala." /*+ e.Message*/; }

			return Ok(result);
        }

/// <summary>
		/// Validar el acceso a una sala por parte de un usuario a partir de su DNI y el nombre de la Sala - /seguridad/validarUsuario
		/// </summary>
		/// <param name="restkey">Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)</param>
		/// <param name="dni">DNI del empleado interesado.</param>
		/// <param name="sala">Sala a comprobar</param>
		/// <returns>MultipleSeguridadValidarUsuarioGet</returns>
        public IHttpActionResult Get([FromUri] string restkey,[FromUri] string dni,[FromUri] string sala)
        {
            // TODO: implement Get - route: seguridad/validarUsuario
			var result = new MultipleSeguridadValidarUsuarioGet();
			result.Error = new Error();
			result.Error.Code = 400;
			result.Error.Message = "Error al validar el acceso, verifique los permisos del empleado";
			result.Ipbool = false;

			try
			{
				uCon = new dbUtilidad();
				if (uCon.checkRestKey(restkey))
				{
					segCon = new dbSeguridad();
					bool allOk = segCon.validarUsuario(dni, sala, restkey);
					result.Ipbool = allOk;
					if (allOk)
					{
						result.Error.Code = 200;
						result.Error.Message = "El empleado tiene acceso a la sala.";
					} else
					{
						result.Error.Message = "El empleado no esta registrado o no tiene acceso a la sala.";
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
		/// Eliminar el acceso del usuario a una sala - /seguridad/eliminarPermisos
		/// </summary>
		/// <param name="restkey">Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)</param>
		/// <param name="dni">DNI del empleado</param>
		/// <param name="sala">Nombre de la sala</param>
		/// <returns>MultipleSeguridadEliminarPermisosDelete</returns>
        public IHttpActionResult Delete([FromUri] string restkey,[FromUri] string dni,[FromUri] string sala)
        {
			// TODO: implement Delete - route: seguridad/eliminarPermisos
			var result = new MultipleSeguridadEliminarPermisosDelete();
			result.Error = new Error();
			result.Error.Code = 400;
			result.Error.Message = "Error al eliminar el permiso, verifique los datos son correctos.";
			result.Ipbool = false;

			try
			{
				uCon = new dbUtilidad();
				if (uCon.checkRestKey(restkey))
				{
					segCon = new dbSeguridad();
					bool allOk = segCon.eliminarPermiso(dni, sala, restkey);
					result.Ipbool = allOk;
					if (allOk)
					{
						result.Error.Code = 200;
						result.Error.Message = "Permisos eliminados correctamente";
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
		/// Obtiene la lista de salas a las que puede acceder un empleado. - /seguridad/obtenerNiveles
		/// </summary>
		/// <param name="restkey">Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)</param>
		/// <param name="dni">DNI del empleado a consultar.</param>
		/// <returns>MultipleSeguridadObtenerNivelesGet</returns>
        public IHttpActionResult GetObtenerNiveles([FromUri] string restkey,[FromUri] string dni)
        {
			// TODO: implement GetObtenerNiveles - route: seguridad/obtenerNiveles
			var result = new MultipleSeguridadObtenerNivelesGet();
			result.Error = new Error();
			result.Error.Code = 400;
			result.Error.Message = "Error al obtener los niveles del usuario, compruebe los datos facilitados.";
			result.Ipstring = new List<string>();

			try
			{
				uCon = new dbUtilidad();
				if (uCon.checkRestKey(restkey))
				{
					segCon = new dbSeguridad();
					List<string> salas = segCon.obtenerNiveles(dni,restkey);
					result.Ipstring = salas;
					result.Error.Code = 200;
					result.Error.Message = "Salas obtenidas correctamente";
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

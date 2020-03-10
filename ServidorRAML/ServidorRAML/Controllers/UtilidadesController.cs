// Template: Controller Implementation (ApiControllerImplementation.t4) version 5.0

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ServidorRAML.Models;
using ServidorRAML.Utilidades.Models;

namespace ServidorRAML.Utilidades
{
    public partial class UtilidadesController : IUtilidadesController
    {
		// Conexxion con la bdd para validar la restkey
		private dbUtilidad uCon;

		/// <summary>
		/// Valida un NIF - /utilidades/validarNIF
		/// </summary>
		/// <param name="restkey">Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)</param>
		/// <param name="dni">DNI a validar</param>
		/// <returns>MultipleUtilidadesValidarNIFGet</returns>
		public IHttpActionResult Get([FromUri] string restkey,[FromUri] string dni)
        {
            // TODO: implement Get - route: utilidades/validarNIF
			var result = new MultipleUtilidadesValidarNIFGet();
			result.Error = new Error();
			result.Ipbool = false;
			result.Error.Code = 400;
			result.Error.Message = "NIF NO Valido";

			try
			{
				uCon = new dbUtilidad();
				if (uCon.checkRestKey(restkey))
				{
					if(dni.Length == 9)
					{
						var letrasValidas = "TRWAGMYFPDXBNJZSQVHLCKEtrwagmyfpdxbnjzsqvhlcke";
						string letra = dni[dni.Length-1].ToString();
						if (letrasValidas.Contains(letra)
							&& int.TryParse(dni.Substring(0, dni.Length - 1), out int numeros))
						{
							int resto = numeros % 23;
							if(letrasValidas[resto].ToString().Equals(letra.ToUpper()))
							{
								result.Ipbool = true;
								result.Error.Code = 200;
								result.Error.Message = "NIF Valido";
							} else { /* La letra calculada no es valida */ }
						} else 
						{ /*NO ES VALIDO PORQUE NO TIENE SOLO NUMEROS y/o LA LETRA NO ES VALIDA*/}

					} else
					{ /* NO ES VALIDO */ }
				}
				else
				{ result.Error.Message = "Error al validar la soapkey."; }
			}
			catch (Exception e)
			{ result.Error.Message = "Error al acceder a la BDD: " + e.Message; }

			return Ok(result);
        }

/// <summary>
		/// Valida un IBAN - /utilidades/validarIBAN
		/// </summary>
		/// <param name="restkey">Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)</param>
		/// <param name="iban">IBAN a validar</param>
		/// <returns>MultipleUtilidadesValidarIBANGet</returns>
        public IHttpActionResult GetValidarIBAN([FromUri] string restkey,[FromUri] string iban)
        {
			// TODO: implement GetValidarIBAN - route: utilidades/validarIBAN
			var result = new MultipleUtilidadesValidarIBANGet();
			result.Error = new Error();
			result.Ipbool = false;
			result.Error.Code = 400;
			result.Error.Message = "IBAN NO Valido";

			try
			{
				uCon = new dbUtilidad();
				if (uCon.checkRestKey(restkey))
				{
					iban = iban.ToUpper();
					if (String.IsNullOrEmpty(iban))
						result.Ipbool = false;
					else if (System.Text.RegularExpressions.Regex.IsMatch(iban, "^[A-Z0-9]"))
					{
						iban = iban.Replace(" ", String.Empty);
						string bank = iban.Substring(4, iban.Length - 4) + iban.Substring(0, 4);
						int asciiShift = 55;
						StringBuilder sb = new StringBuilder();
						
						foreach (char c in bank)
						{
							int v;
							if (Char.IsLetter(c)) v = c - asciiShift;
							else v = int.Parse(c.ToString());
							sb.Append(v);
						}
						string checkSumString = sb.ToString();
						int checksum = int.Parse(checkSumString.Substring(0, 1));
						
						for (int i = 1; i < checkSumString.Length; i++)
						{
							int v = int.Parse(checkSumString.Substring(i, 1));
							checksum *= 10;
							checksum += v;
							checksum %= 97;
						}
						bool aux = checksum == 1;
						if (aux == true)
						{
							result.Ipbool = true;
							result.Error.Code = 200;
							result.Error.Message = "IBAN valido";
						}
					}
					else
					{ result.Ipbool = false; }
				}
				else
				{ result.Error.Message = "Error al validar la soapkey."; }
			}
			catch (Exception e)
			{
				result.Ipbool = false;
				result.Error.Message = "Error al acceder a la BDD: " + e.Message; 
			}

			return Ok(result);
		}

/// <summary>
		/// Valida un NAFSS - /utilidades/validarNAFSS
		/// </summary>
		/// <param name="restkey">Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)</param>
		/// <param name="nafss">NAFSS a validar</param>
		/// <returns>MultipleUtilidadesValidarNAFSSGet</returns>
        public IHttpActionResult GetValidarNAFSS([FromUri] string restkey,[FromUri] string nafss)
        {
			// TODO: implement GetValidarNAFSS - route: utilidades/validarNAFSS
			var result = new MultipleUtilidadesValidarNAFSSGet();
			result.Error = new Error();
			result.Ipbool = false;
			result.Error.Code = 400;
			result.Error.Message = "NAFSS NO Valido";

			try
			{
				uCon = new dbUtilidad();
				if (uCon.checkRestKey(restkey))
				{
					string regex = "(66|53|50|[0-4][0-9])-?\\d{8}-?\\d{2}";
					Regex pattern = new Regex(regex);
					
					if (pattern.IsMatch(nafss))
					{
						result.Ipbool = true;
						result.Error.Code = 200;
						result.Error.Message = "NAFSS Valido.";
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

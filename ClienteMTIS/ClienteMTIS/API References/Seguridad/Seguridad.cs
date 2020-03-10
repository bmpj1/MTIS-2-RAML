// Template: Client Proxy T4 Template (RAMLClient.t4) version 7.0

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RAML.Api.Core;
using ClienteMTIS.Seguridad.Models;

namespace ClienteMTIS.Seguridad
{
    public partial class Seguridad
    {
        private readonly SeguridadClient proxy;

        internal Seguridad(SeguridadClient proxy)
        {
            this.proxy = proxy;
        }

    }

    public partial class SeguridadAsignarPermisos
    {
        private readonly SeguridadClient proxy;

        internal SeguridadAsignarPermisos(SeguridadClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Concede permisos de acceso enlazando una sala con un empleado - /seguridad/asignarPermisos
		/// </summary>
		/// <param name="content"></param>
		/// <param name="postseguridadasignarpermisosquery">query properties</param>
        public virtual async Task<ClienteMTIS.Seguridad.Models.SeguridadAsignarPermisosPostResponse> Post(string content, ClienteMTIS.Seguridad.Models.PostSeguridadAsignarPermisosQuery postseguridadasignarpermisosquery)
        {

            var url = "/seguridad/asignarPermisos";
            if(postseguridadasignarpermisosquery != null)
            {
                url += "?";
                if(postseguridadasignarpermisosquery.RestKey != null)
					url += "&RestKey=" + Uri.EscapeDataString(postseguridadasignarpermisosquery.RestKey);
                if(postseguridadasignarpermisosquery.DNI != null)
					url += "&DNI=" + Uri.EscapeDataString(postseguridadasignarpermisosquery.DNI);
                if(postseguridadasignarpermisosquery.Sala != null)
					url += "&Sala=" + Uri.EscapeDataString(postseguridadasignarpermisosquery.Sala);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url.StartsWith("/") ? url.Substring(1) : url);
            req.Content = new StringContent(content);
	        var response = await proxy.Client.SendAsync(req);

            return new ClienteMTIS.Seguridad.Models.SeguridadAsignarPermisosPostResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Concede permisos de acceso enlazando una sala con un empleado - /seguridad/asignarPermisos
		/// </summary>
		/// <param name="request">ClienteMTIS.Seguridad.Models.SeguridadAsignarPermisosPostRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<ClienteMTIS.Seguridad.Models.SeguridadAsignarPermisosPostResponse> Post(ClienteMTIS.Seguridad.Models.SeguridadAsignarPermisosPostRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "/seguridad/asignarPermisos";
            if(request.Query != null)
            {
                url += "?";
                if(request.Query.RestKey != null)
                    url += "&RestKey=" + Uri.EscapeDataString(request.Query.RestKey);
                if(request.Query.DNI != null)
                    url += "&DNI=" + Uri.EscapeDataString(request.Query.DNI);
                if(request.Query.Sala != null)
                    url += "&Sala=" + Uri.EscapeDataString(request.Query.Sala);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url.StartsWith("/") ? url.Substring(1) : url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
            req.Content = request.Content;
	        var response = await proxy.Client.SendAsync(req);
            return new ClienteMTIS.Seguridad.Models.SeguridadAsignarPermisosPostResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }

    }

    public partial class SeguridadValidarUsuario
    {
        private readonly SeguridadClient proxy;

        internal SeguridadValidarUsuario(SeguridadClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Validar el acceso a una sala por parte de un usuario a partir de su DNI y el nombre de la Sala - /seguridad/validarUsuario
		/// </summary>
		/// <param name="getseguridadvalidarusuarioquery">query properties</param>
        public virtual async Task<ClienteMTIS.Seguridad.Models.SeguridadValidarUsuarioGetResponse> Get(ClienteMTIS.Seguridad.Models.GetSeguridadValidarUsuarioQuery getseguridadvalidarusuarioquery)
        {

            var url = "/seguridad/validarUsuario";
            if(getseguridadvalidarusuarioquery != null)
            {
                url += "?";
                if(getseguridadvalidarusuarioquery.RestKey != null)
					url += "&RestKey=" + Uri.EscapeDataString(getseguridadvalidarusuarioquery.RestKey);
                if(getseguridadvalidarusuarioquery.DNI != null)
					url += "&DNI=" + Uri.EscapeDataString(getseguridadvalidarusuarioquery.DNI);
                if(getseguridadvalidarusuarioquery.Sala != null)
					url += "&Sala=" + Uri.EscapeDataString(getseguridadvalidarusuarioquery.Sala);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url.StartsWith("/") ? url.Substring(1) : url);
	        var response = await proxy.Client.SendAsync(req);

            return new ClienteMTIS.Seguridad.Models.SeguridadValidarUsuarioGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Validar el acceso a una sala por parte de un usuario a partir de su DNI y el nombre de la Sala - /seguridad/validarUsuario
		/// </summary>
		/// <param name="request">ClienteMTIS.Seguridad.Models.SeguridadValidarUsuarioGetRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<ClienteMTIS.Seguridad.Models.SeguridadValidarUsuarioGetResponse> Get(ClienteMTIS.Seguridad.Models.SeguridadValidarUsuarioGetRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "/seguridad/validarUsuario";
            if(request.Query != null)
            {
                url += "?";
                if(request.Query.RestKey != null)
                    url += "&RestKey=" + Uri.EscapeDataString(request.Query.RestKey);
                if(request.Query.DNI != null)
                    url += "&DNI=" + Uri.EscapeDataString(request.Query.DNI);
                if(request.Query.Sala != null)
                    url += "&Sala=" + Uri.EscapeDataString(request.Query.Sala);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url.StartsWith("/") ? url.Substring(1) : url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ClienteMTIS.Seguridad.Models.SeguridadValidarUsuarioGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }

    }

    public partial class SeguridadEliminarPermisos
    {
        private readonly SeguridadClient proxy;

        internal SeguridadEliminarPermisos(SeguridadClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Eliminar el acceso del usuario a una sala - /seguridad/eliminarPermisos
		/// </summary>
		/// <param name="deleteseguridadeliminarpermisosquery">query properties</param>
        public virtual async Task<ClienteMTIS.Seguridad.Models.SeguridadEliminarPermisosDeleteResponse> Delete(ClienteMTIS.Seguridad.Models.DeleteSeguridadEliminarPermisosQuery deleteseguridadeliminarpermisosquery)
        {

            var url = "/seguridad/eliminarPermisos";
            if(deleteseguridadeliminarpermisosquery != null)
            {
                url += "?";
                if(deleteseguridadeliminarpermisosquery.RestKey != null)
					url += "&RestKey=" + Uri.EscapeDataString(deleteseguridadeliminarpermisosquery.RestKey);
                if(deleteseguridadeliminarpermisosquery.DNI != null)
					url += "&DNI=" + Uri.EscapeDataString(deleteseguridadeliminarpermisosquery.DNI);
                if(deleteseguridadeliminarpermisosquery.Sala != null)
					url += "&Sala=" + Uri.EscapeDataString(deleteseguridadeliminarpermisosquery.Sala);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Delete, url.StartsWith("/") ? url.Substring(1) : url);
	        var response = await proxy.Client.SendAsync(req);

            return new ClienteMTIS.Seguridad.Models.SeguridadEliminarPermisosDeleteResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Eliminar el acceso del usuario a una sala - /seguridad/eliminarPermisos
		/// </summary>
		/// <param name="request">ClienteMTIS.Seguridad.Models.SeguridadEliminarPermisosDeleteRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<ClienteMTIS.Seguridad.Models.SeguridadEliminarPermisosDeleteResponse> Delete(ClienteMTIS.Seguridad.Models.SeguridadEliminarPermisosDeleteRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "/seguridad/eliminarPermisos";
            if(request.Query != null)
            {
                url += "?";
                if(request.Query.RestKey != null)
                    url += "&RestKey=" + Uri.EscapeDataString(request.Query.RestKey);
                if(request.Query.DNI != null)
                    url += "&DNI=" + Uri.EscapeDataString(request.Query.DNI);
                if(request.Query.Sala != null)
                    url += "&Sala=" + Uri.EscapeDataString(request.Query.Sala);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Delete, url.StartsWith("/") ? url.Substring(1) : url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ClienteMTIS.Seguridad.Models.SeguridadEliminarPermisosDeleteResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }

    }

    public partial class SeguridadObtenerNiveles
    {
        private readonly SeguridadClient proxy;

        internal SeguridadObtenerNiveles(SeguridadClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Obtiene la lista de salas a las que puede acceder un empleado. - /seguridad/obtenerNiveles
		/// </summary>
		/// <param name="getseguridadobtenernivelesquery">query properties</param>
        public virtual async Task<ClienteMTIS.Seguridad.Models.SeguridadObtenerNivelesGetResponse> Get(ClienteMTIS.Seguridad.Models.GetSeguridadObtenerNivelesQuery getseguridadobtenernivelesquery)
        {

            var url = "/seguridad/obtenerNiveles";
            if(getseguridadobtenernivelesquery != null)
            {
                url += "?";
                if(getseguridadobtenernivelesquery.RestKey != null)
					url += "&RestKey=" + Uri.EscapeDataString(getseguridadobtenernivelesquery.RestKey);
                if(getseguridadobtenernivelesquery.DNI != null)
					url += "&DNI=" + Uri.EscapeDataString(getseguridadobtenernivelesquery.DNI);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url.StartsWith("/") ? url.Substring(1) : url);
	        var response = await proxy.Client.SendAsync(req);

            return new ClienteMTIS.Seguridad.Models.SeguridadObtenerNivelesGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Obtiene la lista de salas a las que puede acceder un empleado. - /seguridad/obtenerNiveles
		/// </summary>
		/// <param name="request">ClienteMTIS.Seguridad.Models.SeguridadObtenerNivelesGetRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<ClienteMTIS.Seguridad.Models.SeguridadObtenerNivelesGetResponse> Get(ClienteMTIS.Seguridad.Models.SeguridadObtenerNivelesGetRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "/seguridad/obtenerNiveles";
            if(request.Query != null)
            {
                url += "?";
                if(request.Query.RestKey != null)
                    url += "&RestKey=" + Uri.EscapeDataString(request.Query.RestKey);
                if(request.Query.DNI != null)
                    url += "&DNI=" + Uri.EscapeDataString(request.Query.DNI);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url.StartsWith("/") ? url.Substring(1) : url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
	        var response = await proxy.Client.SendAsync(req);
            return new ClienteMTIS.Seguridad.Models.SeguridadObtenerNivelesGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers,
	                                            Formatters = responseFormatters,
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };
        }

    }

    /// <summary>
    /// Main class for grouping root resources. Nested resources are defined as properties. The constructor can optionally receive an URL and HttpClient instance to override the default ones.
    /// </summary>
    public partial class SeguridadClient
    {

		public SchemaValidationSettings SchemaValidation { get; private set; } 

        protected readonly HttpClient client;
        public const string BaseUri = "http://api.mtis.org/";

        internal HttpClient Client { get { return client; } }




        public SeguridadClient(string endpointUrl)
        {
            SchemaValidation = new SchemaValidationSettings
			{
				Enabled = true,
				RaiseExceptions = true
			};

			if(string.IsNullOrWhiteSpace(endpointUrl))
                throw new ArgumentException("You must specify the endpoint URL", "endpointUrl");

			if (endpointUrl.Contains("{"))
			{
				var regex = new Regex(@"\{([^\}]+)\}");
				var matches = regex.Matches(endpointUrl);
				var parameters = new List<string>();
				foreach (Match match in matches)
				{
					parameters.Add(match.Groups[1].Value);
				}
				throw new InvalidOperationException("Please replace parameter/s " + string.Join(", ", parameters) + " in the URL before passing it to the constructor ");
			}

            if (!endpointUrl.EndsWith("/"))
                endpointUrl += "/";

            client = new HttpClient {BaseAddress = new Uri(endpointUrl)};
        }

        public SeguridadClient(HttpClient httpClient)
        {
            if(httpClient.BaseAddress == null)
                throw new InvalidOperationException("You must set the BaseAddress property of the HttpClient instance");

            client = httpClient;

			SchemaValidation = new SchemaValidationSettings
			{
				Enabled = true,
				RaiseExceptions = true
			};
        }

        

        public virtual Seguridad Seguridad
        {
            get { return new Seguridad(this); }
        }
                

        public virtual SeguridadAsignarPermisos SeguridadAsignarPermisos
        {
            get { return new SeguridadAsignarPermisos(this); }
        }
                

        public virtual SeguridadValidarUsuario SeguridadValidarUsuario
        {
            get { return new SeguridadValidarUsuario(this); }
        }
                

        public virtual SeguridadEliminarPermisos SeguridadEliminarPermisos
        {
            get { return new SeguridadEliminarPermisos(this); }
        }
                

        public virtual SeguridadObtenerNiveles SeguridadObtenerNiveles
        {
            get { return new SeguridadObtenerNiveles(this); }
        }
                


		public void AddDefaultRequestHeader(string name, string value)
		{
			client.DefaultRequestHeaders.Add(name, value);
		}

		public void AddDefaultRequestHeader(string name, IEnumerable<string> values)
		{
			client.DefaultRequestHeaders.Add(name, values);
		}

        // root methods



    }

} // end namespace









namespace ClienteMTIS.Seguridad.Models
{
    /// <summary>
    /// Objeto seguridad para el acceso a la gestion de la &apos;empresa&apos;.
    /// </summary>
    public partial class  Seguridad 
    {

        public string DNI { get; set; }


        public string Sala { get; set; }


    } // end class

    /// <summary>
    /// Objeto utilziado para transmitir un mensaje y codigo en caso de algun error.
    /// </summary>
    public partial class  Error 
    {

		[JsonProperty("code")]
        public int Code { get; set; }


		[JsonProperty("message")]
        public string Message { get; set; }


    } // end class

    /// <summary>
    /// Multiple Response Types Ipbool, Error
    /// </summary>
    public partial class  MultipleSeguridadAsignarPermisosPost : ApiMultipleResponse
    {
        static readonly Dictionary<string, string> schemas = new Dictionary<string, string>
        {
		};
        
		public static string GetSchema(string statusCode)
        {
            if(schemas.ContainsKey(statusCode))
                return schemas[statusCode];

            if(schemas.ContainsKey("default"))
                return schemas["default"];
                
            return string.Empty;
        }
        
        public MultipleSeguridadAsignarPermisosPost()
        {
            names.Add("200", "Ipbool");
            types.Add("200", typeof(bool?));
            names.Add("400", "Error");
            types.Add("400", typeof(Error));
        }

        /// <summary>
        /// Se han asociado la sala y el empleado correctamente. 
        /// </summary>

        public bool? Ipbool { get; set; }


        /// <summary>
        /// Ha ocurrido algun error al realizar la operacion. Objeto utilziado para transmitir un mensaje y codigo en caso de algun error.
        /// </summary>

        public Error Error { get; set; }


    } // end class

    /// <summary>
    /// Multiple Response Types Ipbool, Error
    /// </summary>
    public partial class  MultipleSeguridadValidarUsuarioGet : ApiMultipleResponse
    {
        static readonly Dictionary<string, string> schemas = new Dictionary<string, string>
        {
		};
        
		public static string GetSchema(string statusCode)
        {
            if(schemas.ContainsKey(statusCode))
                return schemas[statusCode];

            if(schemas.ContainsKey("default"))
                return schemas["default"];
                
            return string.Empty;
        }
        
        public MultipleSeguridadValidarUsuarioGet()
        {
            names.Add("200", "Ipbool");
            types.Add("200", typeof(bool?));
            names.Add("400", "Error");
            types.Add("400", typeof(Error));
        }

        /// <summary>
        /// El empleado puede acceder a la sala. 
        /// </summary>

        public bool? Ipbool { get; set; }


        /// <summary>
        /// Ha ocurrido un error o el usuario no puede acceder Objeto utilziado para transmitir un mensaje y codigo en caso de algun error.
        /// </summary>

        public Error Error { get; set; }


    } // end class

    /// <summary>
    /// Multiple Response Types Ipbool, Error
    /// </summary>
    public partial class  MultipleSeguridadEliminarPermisosDelete : ApiMultipleResponse
    {
        static readonly Dictionary<string, string> schemas = new Dictionary<string, string>
        {
		};
        
		public static string GetSchema(string statusCode)
        {
            if(schemas.ContainsKey(statusCode))
                return schemas[statusCode];

            if(schemas.ContainsKey("default"))
                return schemas["default"];
                
            return string.Empty;
        }
        
        public MultipleSeguridadEliminarPermisosDelete()
        {
            names.Add("200", "Ipbool");
            types.Add("200", typeof(bool?));
            names.Add("400", "Error");
            types.Add("400", typeof(Error));
        }

        /// <summary>
        /// Se han eliminado los permisos correctamente 
        /// </summary>

        public bool? Ipbool { get; set; }


        /// <summary>
        /// Ha ocurrido un error al modificar el empleado. Objeto utilziado para transmitir un mensaje y codigo en caso de algun error.
        /// </summary>

        public Error Error { get; set; }


    } // end class

    /// <summary>
    /// Multiple Response Types Ipstring, Error
    /// </summary>
    public partial class  MultipleSeguridadObtenerNivelesGet : ApiMultipleResponse
    {
        static readonly Dictionary<string, string> schemas = new Dictionary<string, string>
        {
		};
        
		public static string GetSchema(string statusCode)
        {
            if(schemas.ContainsKey(statusCode))
                return schemas[statusCode];

            if(schemas.ContainsKey("default"))
                return schemas["default"];
                
            return string.Empty;
        }
        
        public MultipleSeguridadObtenerNivelesGet()
        {
            names.Add("200", "Ipstring");
            types.Add("200", typeof(IList<string>));
            names.Add("400", "Error");
            types.Add("400", typeof(Error));
        }

        /// <summary>
        /// Lista de salas obtenida 
        /// </summary>

        public IList<string> Ipstring { get; set; }


        /// <summary>
        /// Ha ocurrido algún error durante la consulta. Objeto utilziado para transmitir un mensaje y codigo en caso de algun error.
        /// </summary>

        public Error Error { get; set; }


    } // end class

    public partial class  PostSeguridadAsignarPermisosQuery 
    {

        /// <summary>
        /// Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)
        /// </summary>
        [Required]
        public string RestKey { get; set; }


        /// <summary>
        /// Un DNI valido de un empleado registrado.
        /// </summary>
        [Required]
        public string DNI { get; set; }


        /// <summary>
        /// Un nombre de una sala
        /// </summary>
        [Required]
        public string Sala { get; set; }


    } // end class

    public partial class  GetSeguridadValidarUsuarioQuery 
    {

        /// <summary>
        /// Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)
        /// </summary>
        [Required]
        public string RestKey { get; set; }


        /// <summary>
        /// DNI del empleado interesado.
        /// </summary>
        [Required]
        public string DNI { get; set; }


        /// <summary>
        /// Sala a comprobar
        /// </summary>
        [Required]
        public string Sala { get; set; }


    } // end class

    public partial class  DeleteSeguridadEliminarPermisosQuery 
    {

        /// <summary>
        /// Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)
        /// </summary>
        [Required]
        public string RestKey { get; set; }


        /// <summary>
        /// DNI del empleado
        /// </summary>
        [Required]
        public string DNI { get; set; }


        /// <summary>
        /// Nombre de la sala
        /// </summary>
        [Required]
        public string Sala { get; set; }


    } // end class

    public partial class  GetSeguridadObtenerNivelesQuery 
    {

        /// <summary>
        /// Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)
        /// </summary>
        [Required]
        public string RestKey { get; set; }


        /// <summary>
        /// DNI del empleado a consultar.
        /// </summary>
        [Required]
        public string DNI { get; set; }


    } // end class

    /// <summary>
    /// Request object for method Post of class SeguridadAsignarPermisos
    /// </summary>
    public partial class SeguridadAsignarPermisosPostRequest : ApiRequest
    {
        public SeguridadAsignarPermisosPostRequest(HttpContent Content = null, MediaTypeFormatter Formatter = null, PostSeguridadAsignarPermisosQuery Query = null)
        {
            this.Content = Content;
            this.Formatter = Formatter;
            this.Query = Query;
        }


        /// <summary>
        /// Request content
        /// </summary>
        public HttpContent Content { get; set; }

        /// <summary>
        /// Request formatter
        /// </summary>
        public MediaTypeFormatter Formatter { get; set; }

        /// <summary>
        /// Request query string properties
        /// </summary>
        public PostSeguridadAsignarPermisosQuery Query { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Get of class SeguridadValidarUsuario
    /// </summary>
    public partial class SeguridadValidarUsuarioGetRequest : ApiRequest
    {
        public SeguridadValidarUsuarioGetRequest(GetSeguridadValidarUsuarioQuery Query = null)
        {
            this.Query = Query;
        }


        /// <summary>
        /// Request query string properties
        /// </summary>
        public GetSeguridadValidarUsuarioQuery Query { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Delete of class SeguridadEliminarPermisos
    /// </summary>
    public partial class SeguridadEliminarPermisosDeleteRequest : ApiRequest
    {
        public SeguridadEliminarPermisosDeleteRequest(DeleteSeguridadEliminarPermisosQuery Query = null)
        {
            this.Query = Query;
        }


        /// <summary>
        /// Request query string properties
        /// </summary>
        public DeleteSeguridadEliminarPermisosQuery Query { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Get of class SeguridadObtenerNiveles
    /// </summary>
    public partial class SeguridadObtenerNivelesGetRequest : ApiRequest
    {
        public SeguridadObtenerNivelesGetRequest(GetSeguridadObtenerNivelesQuery Query = null)
        {
            this.Query = Query;
        }


        /// <summary>
        /// Request query string properties
        /// </summary>
        public GetSeguridadObtenerNivelesQuery Query { get; set; }

    } // end class

    /// <summary>
    /// Response object for method Post of class SeguridadAsignarPermisos
    /// </summary>

    public partial class SeguridadAsignarPermisosPostResponse : ApiResponse
    {

	    private MultipleSeguridadAsignarPermisosPost typedContent;
        /// <summary>
        /// Typed response content
        /// </summary>
        public MultipleSeguridadAsignarPermisosPost Content 
	    {
	        get
	        {
		        if (typedContent != null) 
					return typedContent;

		        typedContent = new MultipleSeguridadAsignarPermisosPost();

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    var content = new XmlSerializer(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode))).Deserialize(xmlStream);
                    typedContent.SetPropertyByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode), content);
                }
                else
                {
		            var task = Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode)), Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode))).ConfigureAwait(false);
		        
		            var content = task.GetAwaiter().GetResult();
                    typedContent.SetPropertyByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode), content);
                }

		        return typedContent;
	        }
    	}  
		
		public static string GetSchema(string statusCode)
        {
            return MultipleSeguridadAsignarPermisosPost.GetSchema(statusCode);
        }      

    } // end class

    /// <summary>
    /// Response object for method Get of class SeguridadValidarUsuario
    /// </summary>

    public partial class SeguridadValidarUsuarioGetResponse : ApiResponse
    {

	    private MultipleSeguridadValidarUsuarioGet typedContent;
        /// <summary>
        /// Typed response content
        /// </summary>
        public MultipleSeguridadValidarUsuarioGet Content 
	    {
	        get
	        {
		        if (typedContent != null) 
					return typedContent;

		        typedContent = new MultipleSeguridadValidarUsuarioGet();

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    var content = new XmlSerializer(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode))).Deserialize(xmlStream);
                    typedContent.SetPropertyByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode), content);
                }
                else
                {
		            var task = Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode)), Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode))).ConfigureAwait(false);
		        
		            var content = task.GetAwaiter().GetResult();
                    typedContent.SetPropertyByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode), content);
                }

		        return typedContent;
	        }
    	}  
		
		public static string GetSchema(string statusCode)
        {
            return MultipleSeguridadValidarUsuarioGet.GetSchema(statusCode);
        }      

    } // end class

    /// <summary>
    /// Response object for method Delete of class SeguridadEliminarPermisos
    /// </summary>

    public partial class SeguridadEliminarPermisosDeleteResponse : ApiResponse
    {

	    private MultipleSeguridadEliminarPermisosDelete typedContent;
        /// <summary>
        /// Typed response content
        /// </summary>
        public MultipleSeguridadEliminarPermisosDelete Content 
	    {
	        get
	        {
		        if (typedContent != null) 
					return typedContent;

		        typedContent = new MultipleSeguridadEliminarPermisosDelete();

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    var content = new XmlSerializer(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode))).Deserialize(xmlStream);
                    typedContent.SetPropertyByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode), content);
                }
                else
                {
		            var task = Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode)), Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode))).ConfigureAwait(false);
		        
		            var content = task.GetAwaiter().GetResult();
                    typedContent.SetPropertyByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode), content);
                }

		        return typedContent;
	        }
    	}  
		
		public static string GetSchema(string statusCode)
        {
            return MultipleSeguridadEliminarPermisosDelete.GetSchema(statusCode);
        }      

    } // end class

    /// <summary>
    /// Response object for method Get of class SeguridadObtenerNiveles
    /// </summary>

    public partial class SeguridadObtenerNivelesGetResponse : ApiResponse
    {

	    private MultipleSeguridadObtenerNivelesGet typedContent;
        /// <summary>
        /// Typed response content
        /// </summary>
        public MultipleSeguridadObtenerNivelesGet Content 
	    {
	        get
	        {
		        if (typedContent != null) 
					return typedContent;

		        typedContent = new MultipleSeguridadObtenerNivelesGet();

                IEnumerable<string> values = new List<string>();
                if (RawContent != null && RawContent.Headers != null)
                    RawContent.Headers.TryGetValues("Content-Type", out values);

                if (values.Any(hv => hv.ToLowerInvariant().Contains("xml")) &&
                    !values.Any(hv => hv.ToLowerInvariant().Contains("json")))
                {
                    var task = RawContent.ReadAsStreamAsync();

                    var xmlStream = task.GetAwaiter().GetResult();
                    var content = new XmlSerializer(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode))).Deserialize(xmlStream);
                    typedContent.SetPropertyByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode), content);
                }
                else
                {
		            var task = Formatters != null && Formatters.Any() 
                                ? RawContent.ReadAsAsync(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode)), Formatters).ConfigureAwait(false)
                                : RawContent.ReadAsAsync(typedContent.GetTypeByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode))).ConfigureAwait(false);
		        
		            var content = task.GetAwaiter().GetResult();
                    typedContent.SetPropertyByStatusCode(ApiMultipleResponse.GetValueAsString(StatusCode), content);
                }

		        return typedContent;
	        }
    	}  
		
		public static string GetSchema(string statusCode)
        {
            return MultipleSeguridadObtenerNivelesGet.GetSchema(statusCode);
        }      

    } // end class


} // end Models namespace

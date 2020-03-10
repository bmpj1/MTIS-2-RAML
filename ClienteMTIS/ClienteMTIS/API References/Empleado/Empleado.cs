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
using ClienteMTIS.Empleado.Models;

namespace ClienteMTIS.Empleado
{
    public partial class Empleados
    {
        private readonly EmpleadoClient proxy;

        internal Empleados(EmpleadoClient proxy)
        {
            this.proxy = proxy;
        }

    }

    public partial class EmpleadosNuevo
    {
        private readonly EmpleadoClient proxy;

        internal EmpleadosNuevo(EmpleadoClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Crear un empleado - /empleados/nuevo
		/// </summary>
		/// <param name="empleado">Objeto empleado para almacenar los datos de un empleado.</param>
		/// <param name="postempleadosnuevoquery">query properties</param>
        public virtual async Task<ClienteMTIS.Empleado.Models.EmpleadosNuevoPostResponse> Post(ClienteMTIS.Empleado.Models.Empleado empleado, ClienteMTIS.Empleado.Models.PostEmpleadosNuevoQuery postempleadosnuevoquery)
        {

            var url = "/empleados/nuevo";
            if(postempleadosnuevoquery != null)
            {
                url += "?";
                if(postempleadosnuevoquery.RestKey != null)
					url += "&RestKey=" + Uri.EscapeDataString(postempleadosnuevoquery.RestKey);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Post, url.StartsWith("/") ? url.Substring(1) : url);
            req.Content = new ObjectContent(typeof(ClienteMTIS.Empleado.Models.Empleado), empleado, new JsonMediaTypeFormatter());                           
	        var response = await proxy.Client.SendAsync(req);

            return new ClienteMTIS.Empleado.Models.EmpleadosNuevoPostResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Crear un empleado - /empleados/nuevo
		/// </summary>
		/// <param name="request">ClienteMTIS.Empleado.Models.EmpleadosNuevoPostRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<ClienteMTIS.Empleado.Models.EmpleadosNuevoPostResponse> Post(ClienteMTIS.Empleado.Models.EmpleadosNuevoPostRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "/empleados/nuevo";
            if(request.Query != null)
            {
                url += "?";
                if(request.Query.RestKey != null)
                    url += "&RestKey=" + Uri.EscapeDataString(request.Query.RestKey);
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
            if(request.Formatter == null)
                request.Formatter = new JsonMediaTypeFormatter();

			req.Content = new ObjectContent(typeof(Empleado), request.Content, request.Formatter);
	        var response = await proxy.Client.SendAsync(req);
            return new ClienteMTIS.Empleado.Models.EmpleadosNuevoPostResponse  
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

    public partial class EmpleadosConsultar
    {
        private readonly EmpleadoClient proxy;

        internal EmpleadosConsultar(EmpleadoClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Obtener un empleado a partir de su DNI y una RestKey - /empleados/consultar
		/// </summary>
		/// <param name="getempleadosconsultarquery">query properties</param>
        public virtual async Task<ClienteMTIS.Empleado.Models.EmpleadosConsultarGetResponse> Get(ClienteMTIS.Empleado.Models.GetEmpleadosConsultarQuery getempleadosconsultarquery)
        {

            var url = "/empleados/consultar";
            if(getempleadosconsultarquery != null)
            {
                url += "?";
                if(getempleadosconsultarquery.RestKey != null)
					url += "&RestKey=" + Uri.EscapeDataString(getempleadosconsultarquery.RestKey);
                if(getempleadosconsultarquery.DNI != null)
					url += "&DNI=" + Uri.EscapeDataString(getempleadosconsultarquery.DNI);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url.StartsWith("/") ? url.Substring(1) : url);
	        var response = await proxy.Client.SendAsync(req);

            return new ClienteMTIS.Empleado.Models.EmpleadosConsultarGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Obtener un empleado a partir de su DNI y una RestKey - /empleados/consultar
		/// </summary>
		/// <param name="request">ClienteMTIS.Empleado.Models.EmpleadosConsultarGetRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<ClienteMTIS.Empleado.Models.EmpleadosConsultarGetResponse> Get(ClienteMTIS.Empleado.Models.EmpleadosConsultarGetRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "/empleados/consultar";
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
            return new ClienteMTIS.Empleado.Models.EmpleadosConsultarGetResponse  
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

    public partial class EmpleadosModificar
    {
        private readonly EmpleadoClient proxy;

        internal EmpleadosModificar(EmpleadoClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Actualiza los datos de un empleado tras validar una RestKey - /empleados/modificar
		/// </summary>
		/// <param name="empleado">Objeto empleado para almacenar los datos de un empleado.</param>
		/// <param name="putempleadosmodificarquery">query properties</param>
        public virtual async Task<ClienteMTIS.Empleado.Models.EmpleadosModificarPutResponse> Put(ClienteMTIS.Empleado.Models.Empleado empleado, ClienteMTIS.Empleado.Models.PutEmpleadosModificarQuery putempleadosmodificarquery)
        {

            var url = "/empleados/modificar";
            if(putempleadosmodificarquery != null)
            {
                url += "?";
                if(putempleadosmodificarquery.RestKey != null)
					url += "&RestKey=" + Uri.EscapeDataString(putempleadosmodificarquery.RestKey);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Put, url.StartsWith("/") ? url.Substring(1) : url);
            req.Content = new ObjectContent(typeof(ClienteMTIS.Empleado.Models.Empleado), empleado, new JsonMediaTypeFormatter());                           
	        var response = await proxy.Client.SendAsync(req);

            return new ClienteMTIS.Empleado.Models.EmpleadosModificarPutResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Actualiza los datos de un empleado tras validar una RestKey - /empleados/modificar
		/// </summary>
		/// <param name="request">ClienteMTIS.Empleado.Models.EmpleadosModificarPutRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<ClienteMTIS.Empleado.Models.EmpleadosModificarPutResponse> Put(ClienteMTIS.Empleado.Models.EmpleadosModificarPutRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "/empleados/modificar";
            if(request.Query != null)
            {
                url += "?";
                if(request.Query.RestKey != null)
                    url += "&RestKey=" + Uri.EscapeDataString(request.Query.RestKey);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Put, url.StartsWith("/") ? url.Substring(1) : url);

            if(request.RawHeaders != null)
            {
                foreach(var header in request.RawHeaders)
                {
                    req.Headers.TryAddWithoutValidation(header.Key, string.Join(",", header.Value));
                }
            }
            if(request.Formatter == null)
                request.Formatter = new JsonMediaTypeFormatter();

			req.Content = new ObjectContent(typeof(Empleado), request.Content, request.Formatter);
	        var response = await proxy.Client.SendAsync(req);
            return new ClienteMTIS.Empleado.Models.EmpleadosModificarPutResponse  
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

    public partial class EmpleadosBorrar
    {
        private readonly EmpleadoClient proxy;

        internal EmpleadosBorrar(EmpleadoClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Eliminar un empleado de la base de datos - /empleados/borrar
		/// </summary>
		/// <param name="deleteempleadosborrarquery">query properties</param>
        public virtual async Task<ClienteMTIS.Empleado.Models.EmpleadosBorrarDeleteResponse> Delete(ClienteMTIS.Empleado.Models.DeleteEmpleadosBorrarQuery deleteempleadosborrarquery)
        {

            var url = "/empleados/borrar";
            if(deleteempleadosborrarquery != null)
            {
                url += "?";
                if(deleteempleadosborrarquery.RestKey != null)
					url += "&RestKey=" + Uri.EscapeDataString(deleteempleadosborrarquery.RestKey);
                if(deleteempleadosborrarquery.DNI != null)
					url += "&DNI=" + Uri.EscapeDataString(deleteempleadosborrarquery.DNI);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Delete, url.StartsWith("/") ? url.Substring(1) : url);
	        var response = await proxy.Client.SendAsync(req);

            return new ClienteMTIS.Empleado.Models.EmpleadosBorrarDeleteResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Eliminar un empleado de la base de datos - /empleados/borrar
		/// </summary>
		/// <param name="request">ClienteMTIS.Empleado.Models.EmpleadosBorrarDeleteRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<ClienteMTIS.Empleado.Models.EmpleadosBorrarDeleteResponse> Delete(ClienteMTIS.Empleado.Models.EmpleadosBorrarDeleteRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "/empleados/borrar";
            if(request.Query != null)
            {
                url += "?";
                if(request.Query.RestKey != null)
                    url += "&RestKey=" + Uri.EscapeDataString(request.Query.RestKey);
                if(request.Query.DNI != null)
                    url += "&DNI=" + Uri.EscapeDataString(request.Query.DNI);
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
            return new ClienteMTIS.Empleado.Models.EmpleadosBorrarDeleteResponse  
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
    public partial class EmpleadoClient
    {

		public SchemaValidationSettings SchemaValidation { get; private set; } 

        protected readonly HttpClient client;
        public const string BaseUri = "http://api.mtis.org/";

        internal HttpClient Client { get { return client; } }




        public EmpleadoClient(string endpointUrl)
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

        public EmpleadoClient(HttpClient httpClient)
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

        

        public virtual Empleados Empleados
        {
            get { return new Empleados(this); }
        }
                

        public virtual EmpleadosNuevo EmpleadosNuevo
        {
            get { return new EmpleadosNuevo(this); }
        }
                

        public virtual EmpleadosConsultar EmpleadosConsultar
        {
            get { return new EmpleadosConsultar(this); }
        }
                

        public virtual EmpleadosModificar EmpleadosModificar
        {
            get { return new EmpleadosModificar(this); }
        }
                

        public virtual EmpleadosBorrar EmpleadosBorrar
        {
            get { return new EmpleadosBorrar(this); }
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









namespace ClienteMTIS.Empleado.Models
{
    /// <summary>
    /// Objeto empleado para almacenar los datos de un empleado.
    /// </summary>
    public partial class  Empleado 
    {

        public string DNI { get; set; }


		[JsonProperty("Nombre?")]
        public string Nombre { get; set; }


		[JsonProperty("Apellidos?")]
        public string Apellidos { get; set; }


		[JsonProperty("Direccion?")]
        public string Direccion { get; set; }


		[JsonProperty("Poblacion?")]
        public string Poblacion { get; set; }


		[JsonProperty("Telefono?")]
        public string Telefono { get; set; }


		[JsonProperty("Email?")]
        public string Email { get; set; }


        public string Nacimiento { get; set; }


		[JsonProperty("NSS?")]
        public string NSS { get; set; }


		[JsonProperty("IBAN?")]
        public string IBAN { get; set; }


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
    public partial class  MultipleEmpleadosNuevoPost : ApiMultipleResponse
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
        
        public MultipleEmpleadosNuevoPost()
        {
            names.Add("200", "Ipbool");
            types.Add("200", typeof(bool?));
            names.Add("400", "Error");
            types.Add("400", typeof(Error));
        }

        /// <summary>
        /// Se ha creado un Empleado con exito. 
        /// </summary>

        public bool? Ipbool { get; set; }


        /// <summary>
        /// Ha ocurrido un error al crear el empleado. Objeto utilziado para transmitir un mensaje y codigo en caso de algun error.
        /// </summary>

        public Error Error { get; set; }


    } // end class

    /// <summary>
    /// Multiple Response Types Empleado, Error
    /// </summary>
    public partial class  MultipleEmpleadosConsultarGet : ApiMultipleResponse
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
        
        public MultipleEmpleadosConsultarGet()
        {
            names.Add("200", "Empleado");
            types.Add("200", typeof(Empleado));
            names.Add("400", "Error");
            types.Add("400", typeof(Error));
        }

        /// <summary>
        /// Empleado consultado correctamente. Objeto empleado para almacenar los datos de un empleado.
        /// </summary>

        public Empleado Empleado { get; set; }


        /// <summary>
        /// Ha ocurrido un error al crear el empleado. Objeto utilziado para transmitir un mensaje y codigo en caso de algun error.
        /// </summary>

        public Error Error { get; set; }


    } // end class

    /// <summary>
    /// Multiple Response Types Ipbool, Error
    /// </summary>
    public partial class  MultipleEmpleadosModificarPut : ApiMultipleResponse
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
        
        public MultipleEmpleadosModificarPut()
        {
            names.Add("200", "Ipbool");
            types.Add("200", typeof(bool?));
            names.Add("400", "Error");
            types.Add("400", typeof(Error));
        }

        /// <summary>
        /// Se ha modificado el Empleado correctamente 
        /// </summary>

        public bool? Ipbool { get; set; }


        /// <summary>
        /// Ha ocurrido un error al modificar el empleado. Objeto utilziado para transmitir un mensaje y codigo en caso de algun error.
        /// </summary>

        public Error Error { get; set; }


    } // end class

    /// <summary>
    /// Multiple Response Types Ipbool, Error
    /// </summary>
    public partial class  MultipleEmpleadosBorrarDelete : ApiMultipleResponse
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
        
        public MultipleEmpleadosBorrarDelete()
        {
            names.Add("200", "Ipbool");
            types.Add("200", typeof(bool?));
            names.Add("400", "Error");
            types.Add("400", typeof(Error));
        }

        /// <summary>
        /// El empleado ha sido borrado de manera exitosa. 
        /// </summary>

        public bool? Ipbool { get; set; }


        /// <summary>
        /// Ha ocurrido un error al intentar borrar el empleado. Objeto utilziado para transmitir un mensaje y codigo en caso de algun error.
        /// </summary>

        public Error Error { get; set; }


    } // end class

    public partial class  PostEmpleadosNuevoQuery 
    {

        /// <summary>
        /// Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)
        /// </summary>
        [Required]
        public string RestKey { get; set; }


    } // end class

    public partial class  GetEmpleadosConsultarQuery 
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

    public partial class  PutEmpleadosModificarQuery 
    {

        /// <summary>
        /// Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)
        /// </summary>
        [Required]
        public string RestKey { get; set; }


    } // end class

    public partial class  DeleteEmpleadosBorrarQuery 
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
    /// Request object for method Post of class EmpleadosNuevo
    /// </summary>
    public partial class EmpleadosNuevoPostRequest : ApiRequest
    {
        public EmpleadosNuevoPostRequest(Empleado Content = null, MediaTypeFormatter Formatter = null, PostEmpleadosNuevoQuery Query = null)
        {
            this.Content = Content;
            this.Formatter = Formatter;
            this.Query = Query;
        }


        /// <summary>
        /// Request content
        /// </summary>
        public Empleado Content { get; set; }

        /// <summary>
        /// Request formatter
        /// </summary>
        public MediaTypeFormatter Formatter { get; set; }

        /// <summary>
        /// Request query string properties
        /// </summary>
        public PostEmpleadosNuevoQuery Query { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Get of class EmpleadosConsultar
    /// </summary>
    public partial class EmpleadosConsultarGetRequest : ApiRequest
    {
        public EmpleadosConsultarGetRequest(GetEmpleadosConsultarQuery Query = null)
        {
            this.Query = Query;
        }


        /// <summary>
        /// Request query string properties
        /// </summary>
        public GetEmpleadosConsultarQuery Query { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Put of class EmpleadosModificar
    /// </summary>
    public partial class EmpleadosModificarPutRequest : ApiRequest
    {
        public EmpleadosModificarPutRequest(Empleado Content = null, MediaTypeFormatter Formatter = null, PutEmpleadosModificarQuery Query = null)
        {
            this.Content = Content;
            this.Formatter = Formatter;
            this.Query = Query;
        }


        /// <summary>
        /// Request content
        /// </summary>
        public Empleado Content { get; set; }

        /// <summary>
        /// Request formatter
        /// </summary>
        public MediaTypeFormatter Formatter { get; set; }

        /// <summary>
        /// Request query string properties
        /// </summary>
        public PutEmpleadosModificarQuery Query { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Delete of class EmpleadosBorrar
    /// </summary>
    public partial class EmpleadosBorrarDeleteRequest : ApiRequest
    {
        public EmpleadosBorrarDeleteRequest(DeleteEmpleadosBorrarQuery Query = null)
        {
            this.Query = Query;
        }


        /// <summary>
        /// Request query string properties
        /// </summary>
        public DeleteEmpleadosBorrarQuery Query { get; set; }

    } // end class

    /// <summary>
    /// Response object for method Post of class EmpleadosNuevo
    /// </summary>

    public partial class EmpleadosNuevoPostResponse : ApiResponse
    {

	    private MultipleEmpleadosNuevoPost typedContent;
        /// <summary>
        /// Typed response content
        /// </summary>
        public MultipleEmpleadosNuevoPost Content 
	    {
	        get
	        {
		        if (typedContent != null) 
					return typedContent;

		        typedContent = new MultipleEmpleadosNuevoPost();

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
            return MultipleEmpleadosNuevoPost.GetSchema(statusCode);
        }      

    } // end class

    /// <summary>
    /// Response object for method Get of class EmpleadosConsultar
    /// </summary>

    public partial class EmpleadosConsultarGetResponse : ApiResponse
    {

	    private MultipleEmpleadosConsultarGet typedContent;
        /// <summary>
        /// Typed response content
        /// </summary>
        public MultipleEmpleadosConsultarGet Content 
	    {
	        get
	        {
		        if (typedContent != null) 
					return typedContent;

		        typedContent = new MultipleEmpleadosConsultarGet();

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
            return MultipleEmpleadosConsultarGet.GetSchema(statusCode);
        }      

    } // end class

    /// <summary>
    /// Response object for method Put of class EmpleadosModificar
    /// </summary>

    public partial class EmpleadosModificarPutResponse : ApiResponse
    {

	    private MultipleEmpleadosModificarPut typedContent;
        /// <summary>
        /// Typed response content
        /// </summary>
        public MultipleEmpleadosModificarPut Content 
	    {
	        get
	        {
		        if (typedContent != null) 
					return typedContent;

		        typedContent = new MultipleEmpleadosModificarPut();

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
            return MultipleEmpleadosModificarPut.GetSchema(statusCode);
        }      

    } // end class

    /// <summary>
    /// Response object for method Delete of class EmpleadosBorrar
    /// </summary>

    public partial class EmpleadosBorrarDeleteResponse : ApiResponse
    {

	    private MultipleEmpleadosBorrarDelete typedContent;
        /// <summary>
        /// Typed response content
        /// </summary>
        public MultipleEmpleadosBorrarDelete Content 
	    {
	        get
	        {
		        if (typedContent != null) 
					return typedContent;

		        typedContent = new MultipleEmpleadosBorrarDelete();

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
            return MultipleEmpleadosBorrarDelete.GetSchema(statusCode);
        }      

    } // end class


} // end Models namespace

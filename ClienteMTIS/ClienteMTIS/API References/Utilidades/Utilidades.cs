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
using ClienteMTIS.Utilidades.Models;

namespace ClienteMTIS.Utilidades
{
    public partial class Utilidades
    {
        private readonly UtilidadesClient proxy;

        internal Utilidades(UtilidadesClient proxy)
        {
            this.proxy = proxy;
        }

    }

    public partial class UtilidadesValidarNIF
    {
        private readonly UtilidadesClient proxy;

        internal UtilidadesValidarNIF(UtilidadesClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Valida un NIF - /utilidades/validarNIF
		/// </summary>
		/// <param name="getutilidadesvalidarnifquery">query properties</param>
        public virtual async Task<ClienteMTIS.Utilidades.Models.UtilidadesValidarNIFGetResponse> Get(ClienteMTIS.Utilidades.Models.GetUtilidadesValidarNIFQuery getutilidadesvalidarnifquery)
        {

            var url = "/utilidades/validarNIF";
            if(getutilidadesvalidarnifquery != null)
            {
                url += "?";
                if(getutilidadesvalidarnifquery.RestKey != null)
					url += "&RestKey=" + Uri.EscapeDataString(getutilidadesvalidarnifquery.RestKey);
                if(getutilidadesvalidarnifquery.DNI != null)
					url += "&DNI=" + Uri.EscapeDataString(getutilidadesvalidarnifquery.DNI);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url.StartsWith("/") ? url.Substring(1) : url);
	        var response = await proxy.Client.SendAsync(req);

            return new ClienteMTIS.Utilidades.Models.UtilidadesValidarNIFGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Valida un NIF - /utilidades/validarNIF
		/// </summary>
		/// <param name="request">ClienteMTIS.Utilidades.Models.UtilidadesValidarNIFGetRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<ClienteMTIS.Utilidades.Models.UtilidadesValidarNIFGetResponse> Get(ClienteMTIS.Utilidades.Models.UtilidadesValidarNIFGetRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "/utilidades/validarNIF";
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
            return new ClienteMTIS.Utilidades.Models.UtilidadesValidarNIFGetResponse  
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

    public partial class UtilidadesValidarIBAN
    {
        private readonly UtilidadesClient proxy;

        internal UtilidadesValidarIBAN(UtilidadesClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Valida un IBAN - /utilidades/validarIBAN
		/// </summary>
		/// <param name="getutilidadesvalidaribanquery">query properties</param>
        public virtual async Task<ClienteMTIS.Utilidades.Models.UtilidadesValidarIBANGetResponse> Get(ClienteMTIS.Utilidades.Models.GetUtilidadesValidarIBANQuery getutilidadesvalidaribanquery)
        {

            var url = "/utilidades/validarIBAN";
            if(getutilidadesvalidaribanquery != null)
            {
                url += "?";
                if(getutilidadesvalidaribanquery.RestKey != null)
					url += "&RestKey=" + Uri.EscapeDataString(getutilidadesvalidaribanquery.RestKey);
                if(getutilidadesvalidaribanquery.IBAN != null)
					url += "&IBAN=" + Uri.EscapeDataString(getutilidadesvalidaribanquery.IBAN);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url.StartsWith("/") ? url.Substring(1) : url);
	        var response = await proxy.Client.SendAsync(req);

            return new ClienteMTIS.Utilidades.Models.UtilidadesValidarIBANGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Valida un IBAN - /utilidades/validarIBAN
		/// </summary>
		/// <param name="request">ClienteMTIS.Utilidades.Models.UtilidadesValidarIBANGetRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<ClienteMTIS.Utilidades.Models.UtilidadesValidarIBANGetResponse> Get(ClienteMTIS.Utilidades.Models.UtilidadesValidarIBANGetRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "/utilidades/validarIBAN";
            if(request.Query != null)
            {
                url += "?";
                if(request.Query.RestKey != null)
                    url += "&RestKey=" + Uri.EscapeDataString(request.Query.RestKey);
                if(request.Query.IBAN != null)
                    url += "&IBAN=" + Uri.EscapeDataString(request.Query.IBAN);
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
            return new ClienteMTIS.Utilidades.Models.UtilidadesValidarIBANGetResponse  
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

    public partial class UtilidadesValidarNAFSS
    {
        private readonly UtilidadesClient proxy;

        internal UtilidadesValidarNAFSS(UtilidadesClient proxy)
        {
            this.proxy = proxy;
        }


        /// <summary>
		/// Valida un NAFSS - /utilidades/validarNAFSS
		/// </summary>
		/// <param name="getutilidadesvalidarnafssquery">query properties</param>
        public virtual async Task<ClienteMTIS.Utilidades.Models.UtilidadesValidarNAFSSGetResponse> Get(ClienteMTIS.Utilidades.Models.GetUtilidadesValidarNAFSSQuery getutilidadesvalidarnafssquery)
        {

            var url = "/utilidades/validarNAFSS";
            if(getutilidadesvalidarnafssquery != null)
            {
                url += "?";
                if(getutilidadesvalidarnafssquery.RestKey != null)
					url += "&RestKey=" + Uri.EscapeDataString(getutilidadesvalidarnafssquery.RestKey);
                if(getutilidadesvalidarnafssquery.NAFSS != null)
					url += "&NAFSS=" + Uri.EscapeDataString(getutilidadesvalidarnafssquery.NAFSS);
            }

            url = url.Replace("?&", "?");

            var req = new HttpRequestMessage(HttpMethod.Get, url.StartsWith("/") ? url.Substring(1) : url);
	        var response = await proxy.Client.SendAsync(req);

            return new ClienteMTIS.Utilidades.Models.UtilidadesValidarNAFSSGetResponse  
                                            {
                                                RawContent = response.Content,
                                                RawHeaders = response.Headers, 
                                                StatusCode = response.StatusCode,
                                                ReasonPhrase = response.ReasonPhrase,
												SchemaValidation = new Lazy<SchemaValidationResults>(() => new SchemaValidationResults(true), true)
                                            };

        }

        /// <summary>
		/// Valida un NAFSS - /utilidades/validarNAFSS
		/// </summary>
		/// <param name="request">ClienteMTIS.Utilidades.Models.UtilidadesValidarNAFSSGetRequest</param>
		/// <param name="responseFormatters">response formatters</param>
        public virtual async Task<ClienteMTIS.Utilidades.Models.UtilidadesValidarNAFSSGetResponse> Get(ClienteMTIS.Utilidades.Models.UtilidadesValidarNAFSSGetRequest request, IEnumerable<MediaTypeFormatter> responseFormatters = null)
        {

            var url = "/utilidades/validarNAFSS";
            if(request.Query != null)
            {
                url += "?";
                if(request.Query.RestKey != null)
                    url += "&RestKey=" + Uri.EscapeDataString(request.Query.RestKey);
                if(request.Query.NAFSS != null)
                    url += "&NAFSS=" + Uri.EscapeDataString(request.Query.NAFSS);
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
            return new ClienteMTIS.Utilidades.Models.UtilidadesValidarNAFSSGetResponse  
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
    public partial class UtilidadesClient
    {

		public SchemaValidationSettings SchemaValidation { get; private set; } 

        protected readonly HttpClient client;
        public const string BaseUri = "http://api.mtis.org/";

        internal HttpClient Client { get { return client; } }




        public UtilidadesClient(string endpointUrl)
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

        public UtilidadesClient(HttpClient httpClient)
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

        

        public virtual Utilidades Utilidades
        {
            get { return new Utilidades(this); }
        }
                

        public virtual UtilidadesValidarNIF UtilidadesValidarNIF
        {
            get { return new UtilidadesValidarNIF(this); }
        }
                

        public virtual UtilidadesValidarIBAN UtilidadesValidarIBAN
        {
            get { return new UtilidadesValidarIBAN(this); }
        }
                

        public virtual UtilidadesValidarNAFSS UtilidadesValidarNAFSS
        {
            get { return new UtilidadesValidarNAFSS(this); }
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









namespace ClienteMTIS.Utilidades.Models
{
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
    public partial class  MultipleUtilidadesValidarNIFGet : ApiMultipleResponse
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
        
        public MultipleUtilidadesValidarNIFGet()
        {
            names.Add("200", "Ipbool");
            types.Add("200", typeof(bool?));
            names.Add("400", "Error");
            types.Add("400", typeof(Error));
        }

        /// <summary>
        /// El DNI es valido 
        /// </summary>

        public bool? Ipbool { get; set; }


        /// <summary>
        /// El DNI o restkey no validos Objeto utilziado para transmitir un mensaje y codigo en caso de algun error.
        /// </summary>

        public Error Error { get; set; }


    } // end class

    /// <summary>
    /// Multiple Response Types Ipbool, Error
    /// </summary>
    public partial class  MultipleUtilidadesValidarIBANGet : ApiMultipleResponse
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
        
        public MultipleUtilidadesValidarIBANGet()
        {
            names.Add("200", "Ipbool");
            types.Add("200", typeof(bool?));
            names.Add("400", "Error");
            types.Add("400", typeof(Error));
        }

        /// <summary>
        /// El IBAN es valido 
        /// </summary>

        public bool? Ipbool { get; set; }


        /// <summary>
        /// El IBAN o restkey no validos Objeto utilziado para transmitir un mensaje y codigo en caso de algun error.
        /// </summary>

        public Error Error { get; set; }


    } // end class

    /// <summary>
    /// Multiple Response Types Ipbool, Error
    /// </summary>
    public partial class  MultipleUtilidadesValidarNAFSSGet : ApiMultipleResponse
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
        
        public MultipleUtilidadesValidarNAFSSGet()
        {
            names.Add("200", "Ipbool");
            types.Add("200", typeof(bool?));
            names.Add("400", "Error");
            types.Add("400", typeof(Error));
        }

        /// <summary>
        /// El NAFSS es valido 
        /// </summary>

        public bool? Ipbool { get; set; }


        /// <summary>
        /// El NAFSS o restkey no validos Objeto utilziado para transmitir un mensaje y codigo en caso de algun error.
        /// </summary>

        public Error Error { get; set; }


    } // end class

    public partial class  GetUtilidadesValidarNIFQuery 
    {

        /// <summary>
        /// Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)
        /// </summary>
        [Required]
        public string RestKey { get; set; }


        /// <summary>
        /// DNI a validar
        /// </summary>
        [Required]
        public string DNI { get; set; }


    } // end class

    public partial class  GetUtilidadesValidarIBANQuery 
    {

        /// <summary>
        /// Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)
        /// </summary>
        [Required]
        public string RestKey { get; set; }


        /// <summary>
        /// IBAN a validar
        /// </summary>
        [Required]
        public string IBAN { get; set; }


    } // end class

    public partial class  GetUtilidadesValidarNAFSSQuery 
    {

        /// <summary>
        /// Una restkey valida almacenada en la bdd (Concede permisos para realizar al operacion)
        /// </summary>
        [Required]
        public string RestKey { get; set; }


        /// <summary>
        /// NAFSS a validar
        /// </summary>
        [Required]
        public string NAFSS { get; set; }


    } // end class

    /// <summary>
    /// Request object for method Get of class UtilidadesValidarNIF
    /// </summary>
    public partial class UtilidadesValidarNIFGetRequest : ApiRequest
    {
        public UtilidadesValidarNIFGetRequest(GetUtilidadesValidarNIFQuery Query = null)
        {
            this.Query = Query;
        }


        /// <summary>
        /// Request query string properties
        /// </summary>
        public GetUtilidadesValidarNIFQuery Query { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Get of class UtilidadesValidarIBAN
    /// </summary>
    public partial class UtilidadesValidarIBANGetRequest : ApiRequest
    {
        public UtilidadesValidarIBANGetRequest(GetUtilidadesValidarIBANQuery Query = null)
        {
            this.Query = Query;
        }


        /// <summary>
        /// Request query string properties
        /// </summary>
        public GetUtilidadesValidarIBANQuery Query { get; set; }

    } // end class

    /// <summary>
    /// Request object for method Get of class UtilidadesValidarNAFSS
    /// </summary>
    public partial class UtilidadesValidarNAFSSGetRequest : ApiRequest
    {
        public UtilidadesValidarNAFSSGetRequest(GetUtilidadesValidarNAFSSQuery Query = null)
        {
            this.Query = Query;
        }


        /// <summary>
        /// Request query string properties
        /// </summary>
        public GetUtilidadesValidarNAFSSQuery Query { get; set; }

    } // end class

    /// <summary>
    /// Response object for method Get of class UtilidadesValidarNIF
    /// </summary>

    public partial class UtilidadesValidarNIFGetResponse : ApiResponse
    {

	    private MultipleUtilidadesValidarNIFGet typedContent;
        /// <summary>
        /// Typed response content
        /// </summary>
        public MultipleUtilidadesValidarNIFGet Content 
	    {
	        get
	        {
		        if (typedContent != null) 
					return typedContent;

		        typedContent = new MultipleUtilidadesValidarNIFGet();

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
            return MultipleUtilidadesValidarNIFGet.GetSchema(statusCode);
        }      

    } // end class

    /// <summary>
    /// Response object for method Get of class UtilidadesValidarIBAN
    /// </summary>

    public partial class UtilidadesValidarIBANGetResponse : ApiResponse
    {

	    private MultipleUtilidadesValidarIBANGet typedContent;
        /// <summary>
        /// Typed response content
        /// </summary>
        public MultipleUtilidadesValidarIBANGet Content 
	    {
	        get
	        {
		        if (typedContent != null) 
					return typedContent;

		        typedContent = new MultipleUtilidadesValidarIBANGet();

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
            return MultipleUtilidadesValidarIBANGet.GetSchema(statusCode);
        }      

    } // end class

    /// <summary>
    /// Response object for method Get of class UtilidadesValidarNAFSS
    /// </summary>

    public partial class UtilidadesValidarNAFSSGetResponse : ApiResponse
    {

	    private MultipleUtilidadesValidarNAFSSGet typedContent;
        /// <summary>
        /// Typed response content
        /// </summary>
        public MultipleUtilidadesValidarNAFSSGet Content 
	    {
	        get
	        {
		        if (typedContent != null) 
					return typedContent;

		        typedContent = new MultipleUtilidadesValidarNAFSSGet();

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
            return MultipleUtilidadesValidarNAFSSGet.GetSchema(statusCode);
        }      

    } // end class


} // end Models namespace

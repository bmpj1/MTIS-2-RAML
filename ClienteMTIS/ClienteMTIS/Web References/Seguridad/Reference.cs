﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ClienteMTIS.Seguridad {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SeguridadSOAP", Namespace="http://www.mtis.org/Seguridad/")]
    public partial class Seguridad : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback validarUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback obtenerNivelesOperationCompleted;
        
        private System.Threading.SendOrPostCallback asignarPermisoOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarPermisoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Seguridad() {
            this.Url = global::ClienteMTIS.Properties.Settings.Default.ClienteMTIS_localhost1_Seguridad;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event validarUsuarioCompletedEventHandler validarUsuarioCompleted;
        
        /// <remarks/>
        public event obtenerNivelesCompletedEventHandler obtenerNivelesCompleted;
        
        /// <remarks/>
        public event asignarPermisoCompletedEventHandler asignarPermisoCompleted;
        
        /// <remarks/>
        public event eliminarPermisoCompletedEventHandler eliminarPermisoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mtis.org/Seguridad/validarUsuario", RequestNamespace="http://www.mtis.org/Seguridad/", ResponseNamespace="http://www.mtis.org/Seguridad/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("allOK", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool validarUsuario([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string NIF, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string sala, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string errors) {
            object[] results = this.Invoke("validarUsuario", new object[] {
                        NIF,
                        sala,
                        SoapKey});
            errors = ((string)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void validarUsuarioAsync(string NIF, string sala, string SoapKey) {
            this.validarUsuarioAsync(NIF, sala, SoapKey, null);
        }
        
        /// <remarks/>
        public void validarUsuarioAsync(string NIF, string sala, string SoapKey, object userState) {
            if ((this.validarUsuarioOperationCompleted == null)) {
                this.validarUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnvalidarUsuarioOperationCompleted);
            }
            this.InvokeAsync("validarUsuario", new object[] {
                        NIF,
                        sala,
                        SoapKey}, this.validarUsuarioOperationCompleted, userState);
        }
        
        private void OnvalidarUsuarioOperationCompleted(object arg) {
            if ((this.validarUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.validarUsuarioCompleted(this, new validarUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mtis.org/Seguridad/obtenerNiveles", RequestNamespace="http://www.mtis.org/Seguridad/", ResponseNamespace="http://www.mtis.org/Seguridad/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("niveles", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] obtenerNiveles([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string NIF, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string errors) {
            object[] results = this.Invoke("obtenerNiveles", new object[] {
                        NIF,
                        SoapKey});
            errors = ((string)(results[1]));
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void obtenerNivelesAsync(string NIF, string SoapKey) {
            this.obtenerNivelesAsync(NIF, SoapKey, null);
        }
        
        /// <remarks/>
        public void obtenerNivelesAsync(string NIF, string SoapKey, object userState) {
            if ((this.obtenerNivelesOperationCompleted == null)) {
                this.obtenerNivelesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnobtenerNivelesOperationCompleted);
            }
            this.InvokeAsync("obtenerNiveles", new object[] {
                        NIF,
                        SoapKey}, this.obtenerNivelesOperationCompleted, userState);
        }
        
        private void OnobtenerNivelesOperationCompleted(object arg) {
            if ((this.obtenerNivelesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.obtenerNivelesCompleted(this, new obtenerNivelesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mtis.org/Seguridad/asignarPermiso", RequestNamespace="http://www.mtis.org/Seguridad/", ResponseNamespace="http://www.mtis.org/Seguridad/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("allOK", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool asignarPermiso([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string NIF, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string sala, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string errors) {
            object[] results = this.Invoke("asignarPermiso", new object[] {
                        NIF,
                        sala,
                        SoapKey});
            errors = ((string)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void asignarPermisoAsync(string NIF, string sala, string SoapKey) {
            this.asignarPermisoAsync(NIF, sala, SoapKey, null);
        }
        
        /// <remarks/>
        public void asignarPermisoAsync(string NIF, string sala, string SoapKey, object userState) {
            if ((this.asignarPermisoOperationCompleted == null)) {
                this.asignarPermisoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnasignarPermisoOperationCompleted);
            }
            this.InvokeAsync("asignarPermiso", new object[] {
                        NIF,
                        sala,
                        SoapKey}, this.asignarPermisoOperationCompleted, userState);
        }
        
        private void OnasignarPermisoOperationCompleted(object arg) {
            if ((this.asignarPermisoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.asignarPermisoCompleted(this, new asignarPermisoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.mtis.org/Seguridad/eliminarPermiso", RequestNamespace="http://www.mtis.org/Seguridad/", ResponseNamespace="http://www.mtis.org/Seguridad/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("allOK", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool eliminarPermiso([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string NIF, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string sala, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string errors) {
            object[] results = this.Invoke("eliminarPermiso", new object[] {
                        NIF,
                        sala,
                        SoapKey});
            errors = ((string)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarPermisoAsync(string NIF, string sala, string SoapKey) {
            this.eliminarPermisoAsync(NIF, sala, SoapKey, null);
        }
        
        /// <remarks/>
        public void eliminarPermisoAsync(string NIF, string sala, string SoapKey, object userState) {
            if ((this.eliminarPermisoOperationCompleted == null)) {
                this.eliminarPermisoOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarPermisoOperationCompleted);
            }
            this.InvokeAsync("eliminarPermiso", new object[] {
                        NIF,
                        sala,
                        SoapKey}, this.eliminarPermisoOperationCompleted, userState);
        }
        
        private void OneliminarPermisoOperationCompleted(object arg) {
            if ((this.eliminarPermisoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarPermisoCompleted(this, new eliminarPermisoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void validarUsuarioCompletedEventHandler(object sender, validarUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class validarUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal validarUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string errors {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void obtenerNivelesCompletedEventHandler(object sender, obtenerNivelesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class obtenerNivelesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal obtenerNivelesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string errors {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void asignarPermisoCompletedEventHandler(object sender, asignarPermisoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class asignarPermisoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal asignarPermisoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string errors {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void eliminarPermisoCompletedEventHandler(object sender, eliminarPermisoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarPermisoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarPermisoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string errors {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
}

#pragma warning restore 1591
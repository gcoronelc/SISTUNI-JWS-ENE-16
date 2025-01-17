﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.17929.
// 
#pragma warning disable 1591

namespace WSClientCS.wsmath {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WSMathPortBinding", Namespace="http://ws.egcc.pe/")]
    public partial class WSMath : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback EliminarOperationCompleted;
        
        private System.Threading.SendOrPostCallback RegistrarOperationCompleted;
        
        private System.Threading.SendOrPostCallback helloOperationCompleted;
        
        private System.Threading.SendOrPostCallback sumarOperationCompleted;
        
        private System.Threading.SendOrPostCallback restarOperationCompleted;
        
        private System.Threading.SendOrPostCallback getClientesOperationCompleted;
        
        private System.Threading.SendOrPostCallback getClientesAllOperationCompleted;
        
        private System.Threading.SendOrPostCallback ActualizarOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WSMath() {
            this.Url = global::WSClientCS.Properties.Settings.Default.WSClientCS_wsmath_WSMath;
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
        public event EliminarCompletedEventHandler EliminarCompleted;
        
        /// <remarks/>
        public event RegistrarCompletedEventHandler RegistrarCompleted;
        
        /// <remarks/>
        public event helloCompletedEventHandler helloCompleted;
        
        /// <remarks/>
        public event sumarCompletedEventHandler sumarCompleted;
        
        /// <remarks/>
        public event restarCompletedEventHandler restarCompleted;
        
        /// <remarks/>
        public event getClientesCompletedEventHandler getClientesCompleted;
        
        /// <remarks/>
        public event getClientesAllCompletedEventHandler getClientesAllCompleted;
        
        /// <remarks/>
        public event ActualizarCompletedEventHandler ActualizarCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://ws.egcc.pe/", ResponseNamespace="http://ws.egcc.pe/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Eliminar([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string dni) {
            object[] results = this.Invoke("Eliminar", new object[] {
                        dni});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void EliminarAsync(string dni) {
            this.EliminarAsync(dni, null);
        }
        
        /// <remarks/>
        public void EliminarAsync(string dni, object userState) {
            if ((this.EliminarOperationCompleted == null)) {
                this.EliminarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEliminarOperationCompleted);
            }
            this.InvokeAsync("Eliminar", new object[] {
                        dni}, this.EliminarOperationCompleted, userState);
        }
        
        private void OnEliminarOperationCompleted(object arg) {
            if ((this.EliminarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EliminarCompleted(this, new EliminarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://ws.egcc.pe/", ResponseNamespace="http://ws.egcc.pe/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Registrar([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string codigo, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string paterno, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string materno, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string nombre, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string dni, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string ciudad, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string direccion, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string telefono, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string email) {
            object[] results = this.Invoke("Registrar", new object[] {
                        codigo,
                        paterno,
                        materno,
                        nombre,
                        dni,
                        ciudad,
                        direccion,
                        telefono,
                        email});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void RegistrarAsync(string codigo, string paterno, string materno, string nombre, string dni, string ciudad, string direccion, string telefono, string email) {
            this.RegistrarAsync(codigo, paterno, materno, nombre, dni, ciudad, direccion, telefono, email, null);
        }
        
        /// <remarks/>
        public void RegistrarAsync(string codigo, string paterno, string materno, string nombre, string dni, string ciudad, string direccion, string telefono, string email, object userState) {
            if ((this.RegistrarOperationCompleted == null)) {
                this.RegistrarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegistrarOperationCompleted);
            }
            this.InvokeAsync("Registrar", new object[] {
                        codigo,
                        paterno,
                        materno,
                        nombre,
                        dni,
                        ciudad,
                        direccion,
                        telefono,
                        email}, this.RegistrarOperationCompleted, userState);
        }
        
        private void OnRegistrarOperationCompleted(object arg) {
            if ((this.RegistrarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegistrarCompleted(this, new RegistrarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://ws.egcc.pe/", ResponseNamespace="http://ws.egcc.pe/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string hello([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string name) {
            object[] results = this.Invoke("hello", new object[] {
                        name});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void helloAsync(string name) {
            this.helloAsync(name, null);
        }
        
        /// <remarks/>
        public void helloAsync(string name, object userState) {
            if ((this.helloOperationCompleted == null)) {
                this.helloOperationCompleted = new System.Threading.SendOrPostCallback(this.OnhelloOperationCompleted);
            }
            this.InvokeAsync("hello", new object[] {
                        name}, this.helloOperationCompleted, userState);
        }
        
        private void OnhelloOperationCompleted(object arg) {
            if ((this.helloCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.helloCompleted(this, new helloCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://ws.egcc.pe/", ResponseNamespace="http://ws.egcc.pe/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int sumar([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int num1, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int num2) {
            object[] results = this.Invoke("sumar", new object[] {
                        num1,
                        num2});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void sumarAsync(int num1, int num2) {
            this.sumarAsync(num1, num2, null);
        }
        
        /// <remarks/>
        public void sumarAsync(int num1, int num2, object userState) {
            if ((this.sumarOperationCompleted == null)) {
                this.sumarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsumarOperationCompleted);
            }
            this.InvokeAsync("sumar", new object[] {
                        num1,
                        num2}, this.sumarOperationCompleted, userState);
        }
        
        private void OnsumarOperationCompleted(object arg) {
            if ((this.sumarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.sumarCompleted(this, new sumarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://ws.egcc.pe/", ResponseNamespace="http://ws.egcc.pe/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int restar([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int num1, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int num2) {
            object[] results = this.Invoke("restar", new object[] {
                        num1,
                        num2});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void restarAsync(int num1, int num2) {
            this.restarAsync(num1, num2, null);
        }
        
        /// <remarks/>
        public void restarAsync(int num1, int num2, object userState) {
            if ((this.restarOperationCompleted == null)) {
                this.restarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnrestarOperationCompleted);
            }
            this.InvokeAsync("restar", new object[] {
                        num1,
                        num2}, this.restarOperationCompleted, userState);
        }
        
        private void OnrestarOperationCompleted(object arg) {
            if ((this.restarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.restarCompleted(this, new restarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://ws.egcc.pe/", ResponseNamespace="http://ws.egcc.pe/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public clienteModel[] getClientes([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string nombre) {
            object[] results = this.Invoke("getClientes", new object[] {
                        nombre});
            return ((clienteModel[])(results[0]));
        }
        
        /// <remarks/>
        public void getClientesAsync(string nombre) {
            this.getClientesAsync(nombre, null);
        }
        
        /// <remarks/>
        public void getClientesAsync(string nombre, object userState) {
            if ((this.getClientesOperationCompleted == null)) {
                this.getClientesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetClientesOperationCompleted);
            }
            this.InvokeAsync("getClientes", new object[] {
                        nombre}, this.getClientesOperationCompleted, userState);
        }
        
        private void OngetClientesOperationCompleted(object arg) {
            if ((this.getClientesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getClientesCompleted(this, new getClientesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://ws.egcc.pe/", ResponseNamespace="http://ws.egcc.pe/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public clienteModel[] getClientesAll() {
            object[] results = this.Invoke("getClientesAll", new object[0]);
            return ((clienteModel[])(results[0]));
        }
        
        /// <remarks/>
        public void getClientesAllAsync() {
            this.getClientesAllAsync(null);
        }
        
        /// <remarks/>
        public void getClientesAllAsync(object userState) {
            if ((this.getClientesAllOperationCompleted == null)) {
                this.getClientesAllOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetClientesAllOperationCompleted);
            }
            this.InvokeAsync("getClientesAll", new object[0], this.getClientesAllOperationCompleted, userState);
        }
        
        private void OngetClientesAllOperationCompleted(object arg) {
            if ((this.getClientesAllCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getClientesAllCompleted(this, new getClientesAllCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://ws.egcc.pe/", ResponseNamespace="http://ws.egcc.pe/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Actualizar([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string paterno, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string materno, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string nombre, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string dni, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string ciudad, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string direccion, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string telefono, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string email) {
            object[] results = this.Invoke("Actualizar", new object[] {
                        paterno,
                        materno,
                        nombre,
                        dni,
                        ciudad,
                        direccion,
                        telefono,
                        email});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ActualizarAsync(string paterno, string materno, string nombre, string dni, string ciudad, string direccion, string telefono, string email) {
            this.ActualizarAsync(paterno, materno, nombre, dni, ciudad, direccion, telefono, email, null);
        }
        
        /// <remarks/>
        public void ActualizarAsync(string paterno, string materno, string nombre, string dni, string ciudad, string direccion, string telefono, string email, object userState) {
            if ((this.ActualizarOperationCompleted == null)) {
                this.ActualizarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnActualizarOperationCompleted);
            }
            this.InvokeAsync("Actualizar", new object[] {
                        paterno,
                        materno,
                        nombre,
                        dni,
                        ciudad,
                        direccion,
                        telefono,
                        email}, this.ActualizarOperationCompleted, userState);
        }
        
        private void OnActualizarOperationCompleted(object arg) {
            if ((this.ActualizarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ActualizarCompleted(this, new ActualizarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.egcc.pe/")]
    public partial class clienteModel {
        
        private string ciudadField;
        
        private string codigoField;
        
        private string direccionField;
        
        private string dniField;
        
        private string emailField;
        
        private string maternoField;
        
        private string nombreField;
        
        private string paternoField;
        
        private string telefonoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ciudad {
            get {
                return this.ciudadField;
            }
            set {
                this.ciudadField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string dni {
            get {
                return this.dniField;
            }
            set {
                this.dniField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string materno {
            get {
                return this.maternoField;
            }
            set {
                this.maternoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string paterno {
            get {
                return this.paternoField;
            }
            set {
                this.paternoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void EliminarCompletedEventHandler(object sender, EliminarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EliminarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EliminarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void RegistrarCompletedEventHandler(object sender, RegistrarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RegistrarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RegistrarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void helloCompletedEventHandler(object sender, helloCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class helloCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal helloCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void sumarCompletedEventHandler(object sender, sumarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sumarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal sumarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void restarCompletedEventHandler(object sender, restarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class restarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal restarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getClientesCompletedEventHandler(object sender, getClientesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getClientesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getClientesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public clienteModel[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((clienteModel[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getClientesAllCompletedEventHandler(object sender, getClientesAllCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getClientesAllCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getClientesAllCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public clienteModel[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((clienteModel[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void ActualizarCompletedEventHandler(object sender, ActualizarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ActualizarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ActualizarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
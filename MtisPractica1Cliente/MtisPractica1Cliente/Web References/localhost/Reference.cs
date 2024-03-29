﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace MtisPractica1Cliente.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServicioPractica1SOAP", Namespace="http://www.example.org/ServicioPractica1/")]
    public partial class ServicioPractica1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ValidarNIFOperationCompleted;
        
        private System.Threading.SendOrPostCallback ValidarIBANOperationCompleted;
        
        private System.Threading.SendOrPostCallback ConsultaCodigoPostalOperationCompleted;
        
        private System.Threading.SendOrPostCallback GenerarPresupuestoOperationCompleted;
        
        private System.Threading.SendOrPostCallback SolicitarPresupuestoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServicioPractica1() {
            this.Url = global::MtisPractica1Cliente.Properties.Settings.Default.MtisPractica1Cliente_localhost_ServicioPractica1;
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
        public event ValidarNIFCompletedEventHandler ValidarNIFCompleted;
        
        /// <remarks/>
        public event ValidarIBANCompletedEventHandler ValidarIBANCompleted;
        
        /// <remarks/>
        public event ConsultaCodigoPostalCompletedEventHandler ConsultaCodigoPostalCompleted;
        
        /// <remarks/>
        public event GenerarPresupuestoCompletedEventHandler GenerarPresupuestoCompleted;
        
        /// <remarks/>
        public event SolicitarPresupuestoCompletedEventHandler SolicitarPresupuestoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/ServicioPractica1/ValidarNIF", RequestNamespace="http://www.example.org/ServicioPractica1/", ResponseNamespace="http://www.example.org/ServicioPractica1/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Validado", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ValidarNIF([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string NIF, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoadKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string Mensaje) {
            object[] results = this.Invoke("ValidarNIF", new object[] {
                        NIF,
                        SoadKey});
            Mensaje = ((string)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ValidarNIFAsync(string NIF, string SoadKey) {
            this.ValidarNIFAsync(NIF, SoadKey, null);
        }
        
        /// <remarks/>
        public void ValidarNIFAsync(string NIF, string SoadKey, object userState) {
            if ((this.ValidarNIFOperationCompleted == null)) {
                this.ValidarNIFOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidarNIFOperationCompleted);
            }
            this.InvokeAsync("ValidarNIF", new object[] {
                        NIF,
                        SoadKey}, this.ValidarNIFOperationCompleted, userState);
        }
        
        private void OnValidarNIFOperationCompleted(object arg) {
            if ((this.ValidarNIFCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidarNIFCompleted(this, new ValidarNIFCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/ServicioPractica1/ValidarIBAN", RequestNamespace="http://www.example.org/ServicioPractica1/", ResponseNamespace="http://www.example.org/ServicioPractica1/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Validado", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ValidarIBAN([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string IBAN, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string Mensaje) {
            object[] results = this.Invoke("ValidarIBAN", new object[] {
                        IBAN,
                        SoapKey});
            Mensaje = ((string)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ValidarIBANAsync(string IBAN, string SoapKey) {
            this.ValidarIBANAsync(IBAN, SoapKey, null);
        }
        
        /// <remarks/>
        public void ValidarIBANAsync(string IBAN, string SoapKey, object userState) {
            if ((this.ValidarIBANOperationCompleted == null)) {
                this.ValidarIBANOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidarIBANOperationCompleted);
            }
            this.InvokeAsync("ValidarIBAN", new object[] {
                        IBAN,
                        SoapKey}, this.ValidarIBANOperationCompleted, userState);
        }
        
        private void OnValidarIBANOperationCompleted(object arg) {
            if ((this.ValidarIBANCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidarIBANCompleted(this, new ValidarIBANCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/ServicioPractica1/ConsultaCodigoPostal", RequestNamespace="http://www.example.org/ServicioPractica1/", ResponseNamespace="http://www.example.org/ServicioPractica1/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("CodPostal", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ConsultaCodigoPostal([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string CODPOS, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string Poblacion, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string Provincia, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string Mensaje) {
            object[] results = this.Invoke("ConsultaCodigoPostal", new object[] {
                        CODPOS,
                        SoapKey});
            Poblacion = ((string)(results[1]));
            Provincia = ((string)(results[2]));
            Mensaje = ((string)(results[3]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ConsultaCodigoPostalAsync(string CODPOS, string SoapKey) {
            this.ConsultaCodigoPostalAsync(CODPOS, SoapKey, null);
        }
        
        /// <remarks/>
        public void ConsultaCodigoPostalAsync(string CODPOS, string SoapKey, object userState) {
            if ((this.ConsultaCodigoPostalOperationCompleted == null)) {
                this.ConsultaCodigoPostalOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsultaCodigoPostalOperationCompleted);
            }
            this.InvokeAsync("ConsultaCodigoPostal", new object[] {
                        CODPOS,
                        SoapKey}, this.ConsultaCodigoPostalOperationCompleted, userState);
        }
        
        private void OnConsultaCodigoPostalOperationCompleted(object arg) {
            if ((this.ConsultaCodigoPostalCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConsultaCodigoPostalCompleted(this, new ConsultaCodigoPostalCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/ServicioPractica1/GenerarPresupuesto", RequestNamespace="http://www.example.org/ServicioPractica1/", ResponseNamespace="http://www.example.org/ServicioPractica1/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("idPresupuesto", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int GenerarPresupuesto([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")] System.DateTime fechaPresupuesto, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int idCliente, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string referenciaProducto, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int cantidadProducto, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string SoapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out bool presupuestoGeneradoCorrectamente, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string Mensaje) {
            object[] results = this.Invoke("GenerarPresupuesto", new object[] {
                        fechaPresupuesto,
                        idCliente,
                        referenciaProducto,
                        cantidadProducto,
                        SoapKey});
            presupuestoGeneradoCorrectamente = ((bool)(results[1]));
            Mensaje = ((string)(results[2]));
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void GenerarPresupuestoAsync(System.DateTime fechaPresupuesto, int idCliente, string referenciaProducto, int cantidadProducto, string SoapKey) {
            this.GenerarPresupuestoAsync(fechaPresupuesto, idCliente, referenciaProducto, cantidadProducto, SoapKey, null);
        }
        
        /// <remarks/>
        public void GenerarPresupuestoAsync(System.DateTime fechaPresupuesto, int idCliente, string referenciaProducto, int cantidadProducto, string SoapKey, object userState) {
            if ((this.GenerarPresupuestoOperationCompleted == null)) {
                this.GenerarPresupuestoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGenerarPresupuestoOperationCompleted);
            }
            this.InvokeAsync("GenerarPresupuesto", new object[] {
                        fechaPresupuesto,
                        idCliente,
                        referenciaProducto,
                        cantidadProducto,
                        SoapKey}, this.GenerarPresupuestoOperationCompleted, userState);
        }
        
        private void OnGenerarPresupuestoOperationCompleted(object arg) {
            if ((this.GenerarPresupuestoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GenerarPresupuestoCompleted(this, new GenerarPresupuestoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.example.org/ServicioPractica1/SolicitarPresupuesto", RequestNamespace="http://www.example.org/ServicioPractica1/", ResponseNamespace="http://www.example.org/ServicioPractica1/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("PrecioPieza", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public float SolicitarPresupuesto([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string ReferenciaPieza, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int idProveedor, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string soapKey, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out bool DisponibilidadPieza, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")] out System.DateTime FechaDisponibilidadPieza, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out string Mensaje) {
            object[] results = this.Invoke("SolicitarPresupuesto", new object[] {
                        ReferenciaPieza,
                        idProveedor,
                        soapKey});
            DisponibilidadPieza = ((bool)(results[1]));
            FechaDisponibilidadPieza = ((System.DateTime)(results[2]));
            Mensaje = ((string)(results[3]));
            return ((float)(results[0]));
        }
        
        /// <remarks/>
        public void SolicitarPresupuestoAsync(string ReferenciaPieza, int idProveedor, string soapKey) {
            this.SolicitarPresupuestoAsync(ReferenciaPieza, idProveedor, soapKey, null);
        }
        
        /// <remarks/>
        public void SolicitarPresupuestoAsync(string ReferenciaPieza, int idProveedor, string soapKey, object userState) {
            if ((this.SolicitarPresupuestoOperationCompleted == null)) {
                this.SolicitarPresupuestoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSolicitarPresupuestoOperationCompleted);
            }
            this.InvokeAsync("SolicitarPresupuesto", new object[] {
                        ReferenciaPieza,
                        idProveedor,
                        soapKey}, this.SolicitarPresupuestoOperationCompleted, userState);
        }
        
        private void OnSolicitarPresupuestoOperationCompleted(object arg) {
            if ((this.SolicitarPresupuestoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SolicitarPresupuestoCompleted(this, new SolicitarPresupuestoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void ValidarNIFCompletedEventHandler(object sender, ValidarNIFCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidarNIFCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValidarNIFCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        public string Mensaje {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void ValidarIBANCompletedEventHandler(object sender, ValidarIBANCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidarIBANCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValidarIBANCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        public string Mensaje {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void ConsultaCodigoPostalCompletedEventHandler(object sender, ConsultaCodigoPostalCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConsultaCodigoPostalCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConsultaCodigoPostalCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public string Poblacion {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string Provincia {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
        
        /// <remarks/>
        public string Mensaje {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[3]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GenerarPresupuestoCompletedEventHandler(object sender, GenerarPresupuestoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GenerarPresupuestoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GenerarPresupuestoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public bool presupuestoGeneradoCorrectamente {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string Mensaje {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void SolicitarPresupuestoCompletedEventHandler(object sender, SolicitarPresupuestoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SolicitarPresupuestoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SolicitarPresupuestoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public float Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool DisponibilidadPieza {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public System.DateTime FechaDisponibilidadPieza {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[2]));
            }
        }
        
        /// <remarks/>
        public string Mensaje {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[3]));
            }
        }
    }
}

#pragma warning restore 1591
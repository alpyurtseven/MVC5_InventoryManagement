﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRMMVC2_.AKCurrency {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://data.altinkaynak.com/", ConfigurationName="AKCurrency.DataServiceSoap")]
    public interface DataServiceSoap {
        
        // CODEGEN: Generating message contract since message GetCurrencyRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://data.altinkaynak.com/GetCurrency", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SRMMVC2_.AKCurrency.GetCurrencyResponse GetCurrency(SRMMVC2_.AKCurrency.GetCurrencyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://data.altinkaynak.com/GetCurrency", ReplyAction="*")]
        System.Threading.Tasks.Task<SRMMVC2_.AKCurrency.GetCurrencyResponse> GetCurrencyAsync(SRMMVC2_.AKCurrency.GetCurrencyRequest request);
        
        // CODEGEN: Generating message contract since message GetGoldRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://data.altinkaynak.com/GetGold", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SRMMVC2_.AKCurrency.GetGoldResponse GetGold(SRMMVC2_.AKCurrency.GetGoldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://data.altinkaynak.com/GetGold", ReplyAction="*")]
        System.Threading.Tasks.Task<SRMMVC2_.AKCurrency.GetGoldResponse> GetGoldAsync(SRMMVC2_.AKCurrency.GetGoldRequest request);
        
        // CODEGEN: Generating message contract since message GetMainRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://data.altinkaynak.com/GetMain", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SRMMVC2_.AKCurrency.GetMainResponse GetMain(SRMMVC2_.AKCurrency.GetMainRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://data.altinkaynak.com/GetMain", ReplyAction="*")]
        System.Threading.Tasks.Task<SRMMVC2_.AKCurrency.GetMainResponse> GetMainAsync(SRMMVC2_.AKCurrency.GetMainRequest request);
        
        // CODEGEN: Generating message contract since message GetParityRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://data.altinkaynak.com/GetParity", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SRMMVC2_.AKCurrency.GetParityResponse GetParity(SRMMVC2_.AKCurrency.GetParityRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://data.altinkaynak.com/GetParity", ReplyAction="*")]
        System.Threading.Tasks.Task<SRMMVC2_.AKCurrency.GetParityResponse> GetParityAsync(SRMMVC2_.AKCurrency.GetParityRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://data.altinkaynak.com/")]
    public partial class AuthHeader : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string usernameField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
                this.RaisePropertyChanged("Username");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCurrency", WrapperNamespace="http://data.altinkaynak.com/", IsWrapped=true)]
    public partial class GetCurrencyRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://data.altinkaynak.com/")]
        public SRMMVC2_.AKCurrency.AuthHeader AuthHeader;
        
        public GetCurrencyRequest() {
        }
        
        public GetCurrencyRequest(SRMMVC2_.AKCurrency.AuthHeader AuthHeader) {
            this.AuthHeader = AuthHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCurrencyResponse", WrapperNamespace="http://data.altinkaynak.com/", IsWrapped=true)]
    public partial class GetCurrencyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://data.altinkaynak.com/", Order=0)]
        public string GetCurrencyResult;
        
        public GetCurrencyResponse() {
        }
        
        public GetCurrencyResponse(string GetCurrencyResult) {
            this.GetCurrencyResult = GetCurrencyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetGold", WrapperNamespace="http://data.altinkaynak.com/", IsWrapped=true)]
    public partial class GetGoldRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://data.altinkaynak.com/")]
        public SRMMVC2_.AKCurrency.AuthHeader AuthHeader;
        
        public GetGoldRequest() {
        }
        
        public GetGoldRequest(SRMMVC2_.AKCurrency.AuthHeader AuthHeader) {
            this.AuthHeader = AuthHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetGoldResponse", WrapperNamespace="http://data.altinkaynak.com/", IsWrapped=true)]
    public partial class GetGoldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://data.altinkaynak.com/", Order=0)]
        public string GetGoldResult;
        
        public GetGoldResponse() {
        }
        
        public GetGoldResponse(string GetGoldResult) {
            this.GetGoldResult = GetGoldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMain", WrapperNamespace="http://data.altinkaynak.com/", IsWrapped=true)]
    public partial class GetMainRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://data.altinkaynak.com/")]
        public SRMMVC2_.AKCurrency.AuthHeader AuthHeader;
        
        public GetMainRequest() {
        }
        
        public GetMainRequest(SRMMVC2_.AKCurrency.AuthHeader AuthHeader) {
            this.AuthHeader = AuthHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMainResponse", WrapperNamespace="http://data.altinkaynak.com/", IsWrapped=true)]
    public partial class GetMainResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://data.altinkaynak.com/", Order=0)]
        public string GetMainResult;
        
        public GetMainResponse() {
        }
        
        public GetMainResponse(string GetMainResult) {
            this.GetMainResult = GetMainResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetParity", WrapperNamespace="http://data.altinkaynak.com/", IsWrapped=true)]
    public partial class GetParityRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://data.altinkaynak.com/")]
        public SRMMVC2_.AKCurrency.AuthHeader AuthHeader;
        
        public GetParityRequest() {
        }
        
        public GetParityRequest(SRMMVC2_.AKCurrency.AuthHeader AuthHeader) {
            this.AuthHeader = AuthHeader;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetParityResponse", WrapperNamespace="http://data.altinkaynak.com/", IsWrapped=true)]
    public partial class GetParityResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://data.altinkaynak.com/", Order=0)]
        public string GetParityResult;
        
        public GetParityResponse() {
        }
        
        public GetParityResponse(string GetParityResult) {
            this.GetParityResult = GetParityResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DataServiceSoapChannel : SRMMVC2_.AKCurrency.DataServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataServiceSoapClient : System.ServiceModel.ClientBase<SRMMVC2_.AKCurrency.DataServiceSoap>, SRMMVC2_.AKCurrency.DataServiceSoap {
        
        public DataServiceSoapClient() {
        }
        
        public DataServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SRMMVC2_.AKCurrency.GetCurrencyResponse SRMMVC2_.AKCurrency.DataServiceSoap.GetCurrency(SRMMVC2_.AKCurrency.GetCurrencyRequest request) {
            return base.Channel.GetCurrency(request);
        }
        
        public string GetCurrency(SRMMVC2_.AKCurrency.AuthHeader AuthHeader) {
            SRMMVC2_.AKCurrency.GetCurrencyRequest inValue = new SRMMVC2_.AKCurrency.GetCurrencyRequest();
            inValue.AuthHeader = AuthHeader;
            SRMMVC2_.AKCurrency.GetCurrencyResponse retVal = ((SRMMVC2_.AKCurrency.DataServiceSoap)(this)).GetCurrency(inValue);
            return retVal.GetCurrencyResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SRMMVC2_.AKCurrency.GetCurrencyResponse> SRMMVC2_.AKCurrency.DataServiceSoap.GetCurrencyAsync(SRMMVC2_.AKCurrency.GetCurrencyRequest request) {
            return base.Channel.GetCurrencyAsync(request);
        }
        
        public System.Threading.Tasks.Task<SRMMVC2_.AKCurrency.GetCurrencyResponse> GetCurrencyAsync(SRMMVC2_.AKCurrency.AuthHeader AuthHeader) {
            SRMMVC2_.AKCurrency.GetCurrencyRequest inValue = new SRMMVC2_.AKCurrency.GetCurrencyRequest();
            inValue.AuthHeader = AuthHeader;
            return ((SRMMVC2_.AKCurrency.DataServiceSoap)(this)).GetCurrencyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SRMMVC2_.AKCurrency.GetGoldResponse SRMMVC2_.AKCurrency.DataServiceSoap.GetGold(SRMMVC2_.AKCurrency.GetGoldRequest request) {
            return base.Channel.GetGold(request);
        }
        
        public string GetGold(SRMMVC2_.AKCurrency.AuthHeader AuthHeader) {
            SRMMVC2_.AKCurrency.GetGoldRequest inValue = new SRMMVC2_.AKCurrency.GetGoldRequest();
            inValue.AuthHeader = AuthHeader;
            SRMMVC2_.AKCurrency.GetGoldResponse retVal = ((SRMMVC2_.AKCurrency.DataServiceSoap)(this)).GetGold(inValue);
            return retVal.GetGoldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SRMMVC2_.AKCurrency.GetGoldResponse> SRMMVC2_.AKCurrency.DataServiceSoap.GetGoldAsync(SRMMVC2_.AKCurrency.GetGoldRequest request) {
            return base.Channel.GetGoldAsync(request);
        }
        
        public System.Threading.Tasks.Task<SRMMVC2_.AKCurrency.GetGoldResponse> GetGoldAsync(SRMMVC2_.AKCurrency.AuthHeader AuthHeader) {
            SRMMVC2_.AKCurrency.GetGoldRequest inValue = new SRMMVC2_.AKCurrency.GetGoldRequest();
            inValue.AuthHeader = AuthHeader;
            return ((SRMMVC2_.AKCurrency.DataServiceSoap)(this)).GetGoldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SRMMVC2_.AKCurrency.GetMainResponse SRMMVC2_.AKCurrency.DataServiceSoap.GetMain(SRMMVC2_.AKCurrency.GetMainRequest request) {
            return base.Channel.GetMain(request);
        }
        
        public string GetMain(SRMMVC2_.AKCurrency.AuthHeader AuthHeader) {
            SRMMVC2_.AKCurrency.GetMainRequest inValue = new SRMMVC2_.AKCurrency.GetMainRequest();
            inValue.AuthHeader = AuthHeader;
            SRMMVC2_.AKCurrency.GetMainResponse retVal = ((SRMMVC2_.AKCurrency.DataServiceSoap)(this)).GetMain(inValue);
            return retVal.GetMainResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SRMMVC2_.AKCurrency.GetMainResponse> SRMMVC2_.AKCurrency.DataServiceSoap.GetMainAsync(SRMMVC2_.AKCurrency.GetMainRequest request) {
            return base.Channel.GetMainAsync(request);
        }
        
        public System.Threading.Tasks.Task<SRMMVC2_.AKCurrency.GetMainResponse> GetMainAsync(SRMMVC2_.AKCurrency.AuthHeader AuthHeader) {
            SRMMVC2_.AKCurrency.GetMainRequest inValue = new SRMMVC2_.AKCurrency.GetMainRequest();
            inValue.AuthHeader = AuthHeader;
            return ((SRMMVC2_.AKCurrency.DataServiceSoap)(this)).GetMainAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SRMMVC2_.AKCurrency.GetParityResponse SRMMVC2_.AKCurrency.DataServiceSoap.GetParity(SRMMVC2_.AKCurrency.GetParityRequest request) {
            return base.Channel.GetParity(request);
        }
        
        public string GetParity(SRMMVC2_.AKCurrency.AuthHeader AuthHeader) {
            SRMMVC2_.AKCurrency.GetParityRequest inValue = new SRMMVC2_.AKCurrency.GetParityRequest();
            inValue.AuthHeader = AuthHeader;
            SRMMVC2_.AKCurrency.GetParityResponse retVal = ((SRMMVC2_.AKCurrency.DataServiceSoap)(this)).GetParity(inValue);
            return retVal.GetParityResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SRMMVC2_.AKCurrency.GetParityResponse> SRMMVC2_.AKCurrency.DataServiceSoap.GetParityAsync(SRMMVC2_.AKCurrency.GetParityRequest request) {
            return base.Channel.GetParityAsync(request);
        }
        
        public System.Threading.Tasks.Task<SRMMVC2_.AKCurrency.GetParityResponse> GetParityAsync(SRMMVC2_.AKCurrency.AuthHeader AuthHeader) {
            SRMMVC2_.AKCurrency.GetParityRequest inValue = new SRMMVC2_.AKCurrency.GetParityRequest();
            inValue.AuthHeader = AuthHeader;
            return ((SRMMVC2_.AKCurrency.DataServiceSoap)(this)).GetParityAsync(inValue);
        }
    }
}

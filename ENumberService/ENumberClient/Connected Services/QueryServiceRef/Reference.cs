﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENumberClient.QueryServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QueryServiceRef.IQueryService")]
    public interface IQueryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQueryService/QueryENumber", ReplyAction="http://tempuri.org/IQueryService/QueryENumberResponse")]
        string QueryENumber(string eNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQueryService/QueryENumber", ReplyAction="http://tempuri.org/IQueryService/QueryENumberResponse")]
        System.Threading.Tasks.Task<string> QueryENumberAsync(string eNumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQueryServiceChannel : ENumberClient.QueryServiceRef.IQueryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QueryServiceClient : System.ServiceModel.ClientBase<ENumberClient.QueryServiceRef.IQueryService>, ENumberClient.QueryServiceRef.IQueryService {
        
        public QueryServiceClient() {
        }
        
        public QueryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QueryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QueryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QueryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string QueryENumber(string eNumber) {
            return base.Channel.QueryENumber(eNumber);
        }
        
        public System.Threading.Tasks.Task<string> QueryENumberAsync(string eNumber) {
            return base.Channel.QueryENumberAsync(eNumber);
        }
    }
}

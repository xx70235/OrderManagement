﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagement.TPOrderQueryService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://thematic.order.connector.dataservice.gov.org/", ConfigurationName="TPOrderQueryService.ITPOrderQuery")]
    public interface ITPOrderQuery {
        
        // CODEGEN: 命名空间  的元素名称 paramXml 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        TPOrderQueryService.thematicProductOrderQueryResponse thematicProductOrderQuery(TPOrderQueryService.thematicProductOrderQuery request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class thematicProductOrderQuery {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="thematicProductOrderQuery", Namespace="http://thematic.order.connector.dataservice.gov.org/", Order=0)]
        public TPOrderQueryService.thematicProductOrderQueryBody Body;
        
        public thematicProductOrderQuery() {
        }
        
        public thematicProductOrderQuery(TPOrderQueryService.thematicProductOrderQueryBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class thematicProductOrderQueryBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string paramXml;
        
        public thematicProductOrderQueryBody() {
        }
        
        public thematicProductOrderQueryBody(string paramXml) {
            this.paramXml = paramXml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class thematicProductOrderQueryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="thematicProductOrderQueryResponse", Namespace="http://thematic.order.connector.dataservice.gov.org/", Order=0)]
        public TPOrderQueryService.thematicProductOrderQueryResponseBody Body;
        
        public thematicProductOrderQueryResponse() {
        }
        
        public thematicProductOrderQueryResponse(TPOrderQueryService.thematicProductOrderQueryResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class thematicProductOrderQueryResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public thematicProductOrderQueryResponseBody() {
        }
        
        public thematicProductOrderQueryResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITPOrderQueryChannel : TPOrderQueryService.ITPOrderQuery, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TPOrderQueryClient : System.ServiceModel.ClientBase<TPOrderQueryService.ITPOrderQuery>, TPOrderQueryService.ITPOrderQuery {
        
        public TPOrderQueryClient() {
        }
        
        public TPOrderQueryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TPOrderQueryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TPOrderQueryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TPOrderQueryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TPOrderQueryService.thematicProductOrderQueryResponse TPOrderQueryService.ITPOrderQuery.thematicProductOrderQuery(TPOrderQueryService.thematicProductOrderQuery request) {
            return base.Channel.thematicProductOrderQuery(request);
        }
        
        public string thematicProductOrderQuery(string paramXml) {
            TPOrderQueryService.thematicProductOrderQuery inValue = new TPOrderQueryService.thematicProductOrderQuery();
            inValue.Body = new TPOrderQueryService.thematicProductOrderQueryBody();
            inValue.Body.paramXml = paramXml;
            TPOrderQueryService.thematicProductOrderQueryResponse retVal = ((TPOrderQueryService.ITPOrderQuery)(this)).thematicProductOrderQuery(inValue);
            return retVal.Body.@return;
        }
    }
}
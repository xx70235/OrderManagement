﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagement.TPOrderRegisterService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://thematic.order.connector.dataservice.gov.org/", ConfigurationName="TPOrderRegisterService.ITPOrderRegister")]
    public interface ITPOrderRegister {
        
        // CODEGEN: 命名空间  的元素名称 paramXml 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        TPOrderRegisterService.thematicProductOrderRegisterResponse thematicProductOrderRegister(TPOrderRegisterService.thematicProductOrderRegister request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class thematicProductOrderRegister {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="thematicProductOrderRegister", Namespace="http://thematic.order.connector.dataservice.gov.org/", Order=0)]
        public TPOrderRegisterService.thematicProductOrderRegisterBody Body;
        
        public thematicProductOrderRegister() {
        }
        
        public thematicProductOrderRegister(TPOrderRegisterService.thematicProductOrderRegisterBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class thematicProductOrderRegisterBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string paramXml;
        
        public thematicProductOrderRegisterBody() {
        }
        
        public thematicProductOrderRegisterBody(string paramXml) {
            this.paramXml = paramXml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class thematicProductOrderRegisterResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="thematicProductOrderRegisterResponse", Namespace="http://thematic.order.connector.dataservice.gov.org/", Order=0)]
        public TPOrderRegisterService.thematicProductOrderRegisterResponseBody Body;
        
        public thematicProductOrderRegisterResponse() {
        }
        
        public thematicProductOrderRegisterResponse(TPOrderRegisterService.thematicProductOrderRegisterResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class thematicProductOrderRegisterResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public thematicProductOrderRegisterResponseBody() {
        }
        
        public thematicProductOrderRegisterResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITPOrderRegisterChannel : TPOrderRegisterService.ITPOrderRegister, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TPOrderRegisterClient : System.ServiceModel.ClientBase<TPOrderRegisterService.ITPOrderRegister>, TPOrderRegisterService.ITPOrderRegister {
        
        public TPOrderRegisterClient() {
        }
        
        public TPOrderRegisterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TPOrderRegisterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TPOrderRegisterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TPOrderRegisterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TPOrderRegisterService.thematicProductOrderRegisterResponse TPOrderRegisterService.ITPOrderRegister.thematicProductOrderRegister(TPOrderRegisterService.thematicProductOrderRegister request) {
            return base.Channel.thematicProductOrderRegister(request);
        }
        
        public string thematicProductOrderRegister(string paramXml) {
            TPOrderRegisterService.thematicProductOrderRegister inValue = new TPOrderRegisterService.thematicProductOrderRegister();
            inValue.Body = new TPOrderRegisterService.thematicProductOrderRegisterBody();
            inValue.Body.paramXml = paramXml;
            TPOrderRegisterService.thematicProductOrderRegisterResponse retVal = ((TPOrderRegisterService.ITPOrderRegister)(this)).thematicProductOrderRegister(inValue);
            return retVal.Body.@return;
        }
    }
}

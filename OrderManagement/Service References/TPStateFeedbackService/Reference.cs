﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagement.TPStateFeedbackService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://thematic.order.connector.dataservice.gov.org/", ConfigurationName="TPStateFeedbackService.ITPStateFeedback")]
    public interface ITPStateFeedback {
        
        // CODEGEN: 命名空间  的元素名称 paramXml 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        TPStateFeedbackService.thematicProductStateFeedbackResponse thematicProductStateFeedback(TPStateFeedbackService.thematicProductStateFeedback request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class thematicProductStateFeedback {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="thematicProductStateFeedback", Namespace="http://thematic.order.connector.dataservice.gov.org/", Order=0)]
        public TPStateFeedbackService.thematicProductStateFeedbackBody Body;
        
        public thematicProductStateFeedback() {
        }
        
        public thematicProductStateFeedback(TPStateFeedbackService.thematicProductStateFeedbackBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class thematicProductStateFeedbackBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string paramXml;
        
        public thematicProductStateFeedbackBody() {
        }
        
        public thematicProductStateFeedbackBody(string paramXml) {
            this.paramXml = paramXml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class thematicProductStateFeedbackResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="thematicProductStateFeedbackResponse", Namespace="http://thematic.order.connector.dataservice.gov.org/", Order=0)]
        public TPStateFeedbackService.thematicProductStateFeedbackResponseBody Body;
        
        public thematicProductStateFeedbackResponse() {
        }
        
        public thematicProductStateFeedbackResponse(TPStateFeedbackService.thematicProductStateFeedbackResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class thematicProductStateFeedbackResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public thematicProductStateFeedbackResponseBody() {
        }
        
        public thematicProductStateFeedbackResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITPStateFeedbackChannel : TPStateFeedbackService.ITPStateFeedback, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TPStateFeedbackClient : System.ServiceModel.ClientBase<TPStateFeedbackService.ITPStateFeedback>, TPStateFeedbackService.ITPStateFeedback {
        
        public TPStateFeedbackClient() {
        }
        
        public TPStateFeedbackClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TPStateFeedbackClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TPStateFeedbackClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TPStateFeedbackClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TPStateFeedbackService.thematicProductStateFeedbackResponse TPStateFeedbackService.ITPStateFeedback.thematicProductStateFeedback(TPStateFeedbackService.thematicProductStateFeedback request) {
            return base.Channel.thematicProductStateFeedback(request);
        }
        
        public string thematicProductStateFeedback(string paramXml) {
            TPStateFeedbackService.thematicProductStateFeedback inValue = new TPStateFeedbackService.thematicProductStateFeedback();
            inValue.Body = new TPStateFeedbackService.thematicProductStateFeedbackBody();
            inValue.Body.paramXml = paramXml;
            TPStateFeedbackService.thematicProductStateFeedbackResponse retVal = ((TPStateFeedbackService.ITPStateFeedback)(this)).thematicProductStateFeedback(inValue);
            return retVal.Body.@return;
        }
    }
}

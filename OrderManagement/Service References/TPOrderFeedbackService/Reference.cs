﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagement.TPOrderFeedbackService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://thematic.order.connector.dataservice.gov.org/", ConfigurationName="TPOrderFeedbackService.ITPOrderFeedback")]
    public interface ITPOrderFeedback {
        
        // CODEGEN: 命名空间  的元素名称 paramXml 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        TPOrderFeedbackService.thematicProductOrderFeedbackResponse thematicProductOrderFeedback(TPOrderFeedbackService.thematicProductOrderFeedback request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class thematicProductOrderFeedback {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="thematicProductOrderFeedback", Namespace="http://thematic.order.connector.dataservice.gov.org/", Order=0)]
        public TPOrderFeedbackService.thematicProductOrderFeedbackBody Body;
        
        public thematicProductOrderFeedback() {
        }
        
        public thematicProductOrderFeedback(TPOrderFeedbackService.thematicProductOrderFeedbackBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class thematicProductOrderFeedbackBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string paramXml;
        
        public thematicProductOrderFeedbackBody() {
        }
        
        public thematicProductOrderFeedbackBody(string paramXml) {
            this.paramXml = paramXml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class thematicProductOrderFeedbackResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="thematicProductOrderFeedbackResponse", Namespace="http://thematic.order.connector.dataservice.gov.org/", Order=0)]
        public TPOrderFeedbackService.thematicProductOrderFeedbackResponseBody Body;
        
        public thematicProductOrderFeedbackResponse() {
        }
        
        public thematicProductOrderFeedbackResponse(TPOrderFeedbackService.thematicProductOrderFeedbackResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class thematicProductOrderFeedbackResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public thematicProductOrderFeedbackResponseBody() {
        }
        
        public thematicProductOrderFeedbackResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITPOrderFeedbackChannel : TPOrderFeedbackService.ITPOrderFeedback, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TPOrderFeedbackClient : System.ServiceModel.ClientBase<TPOrderFeedbackService.ITPOrderFeedback>, TPOrderFeedbackService.ITPOrderFeedback {
        
        public TPOrderFeedbackClient() {
        }
        
        public TPOrderFeedbackClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TPOrderFeedbackClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TPOrderFeedbackClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TPOrderFeedbackClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TPOrderFeedbackService.thematicProductOrderFeedbackResponse TPOrderFeedbackService.ITPOrderFeedback.thematicProductOrderFeedback(TPOrderFeedbackService.thematicProductOrderFeedback request) {
            return base.Channel.thematicProductOrderFeedback(request);
        }
        
        public string thematicProductOrderFeedback(string paramXml) {
            TPOrderFeedbackService.thematicProductOrderFeedback inValue = new TPOrderFeedbackService.thematicProductOrderFeedback();
            inValue.Body = new TPOrderFeedbackService.thematicProductOrderFeedbackBody();
            inValue.Body.paramXml = paramXml;
            TPOrderFeedbackService.thematicProductOrderFeedbackResponse retVal = ((TPOrderFeedbackService.ITPOrderFeedback)(this)).thematicProductOrderFeedback(inValue);
            return retVal.Body.@return;
        }
    }
}

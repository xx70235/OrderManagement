﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagement.TPPublishService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://thematic.connector.dataservice.gov.org/", ConfigurationName="TPPublishService.ITPPublish")]
    public interface ITPPublish {
        
        // CODEGEN: 命名空间  的元素名称 paramXml 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        TPPublishService.thematicProductsPublishResponse thematicProductsPublish(TPPublishService.thematicProductsPublish request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class thematicProductsPublish {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="thematicProductsPublish", Namespace="http://thematic.connector.dataservice.gov.org/", Order=0)]
        public TPPublishService.thematicProductsPublishBody Body;
        
        public thematicProductsPublish() {
        }
        
        public thematicProductsPublish(TPPublishService.thematicProductsPublishBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class thematicProductsPublishBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string paramXml;
        
        public thematicProductsPublishBody() {
        }
        
        public thematicProductsPublishBody(string paramXml) {
            this.paramXml = paramXml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class thematicProductsPublishResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="thematicProductsPublishResponse", Namespace="http://thematic.connector.dataservice.gov.org/", Order=0)]
        public TPPublishService.thematicProductsPublishResponseBody Body;
        
        public thematicProductsPublishResponse() {
        }
        
        public thematicProductsPublishResponse(TPPublishService.thematicProductsPublishResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class thematicProductsPublishResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public thematicProductsPublishResponseBody() {
        }
        
        public thematicProductsPublishResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITPPublishChannel : TPPublishService.ITPPublish, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TPPublishClient : System.ServiceModel.ClientBase<TPPublishService.ITPPublish>, TPPublishService.ITPPublish {
        
        public TPPublishClient() {
        }
        
        public TPPublishClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TPPublishClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TPPublishClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TPPublishClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TPPublishService.thematicProductsPublishResponse TPPublishService.ITPPublish.thematicProductsPublish(TPPublishService.thematicProductsPublish request) {
            return base.Channel.thematicProductsPublish(request);
        }
        
        public string thematicProductsPublish(string paramXml) {
            TPPublishService.thematicProductsPublish inValue = new TPPublishService.thematicProductsPublish();
            inValue.Body = new TPPublishService.thematicProductsPublishBody();
            inValue.Body.paramXml = paramXml;
            TPPublishService.thematicProductsPublishResponse retVal = ((TPPublishService.ITPPublish)(this)).thematicProductsPublish(inValue);
            return retVal.Body.@return;
        }
    }
}

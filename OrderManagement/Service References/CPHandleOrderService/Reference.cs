﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagement.CPHandleOrderService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://common.order.connector.dataservice.gov.org/", ConfigurationName="CPHandleOrderService.ICPHandleOrder")]
    public interface ICPHandleOrder {
        
        // CODEGEN: 命名空间  的元素名称 paramXml 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        CPHandleOrderService.handleProductOrderResponse handleProductOrder(CPHandleOrderService.handleProductOrder request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class handleProductOrder {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="handleProductOrder", Namespace="http://common.order.connector.dataservice.gov.org/", Order=0)]
        public CPHandleOrderService.handleProductOrderBody Body;
        
        public handleProductOrder() {
        }
        
        public handleProductOrder(CPHandleOrderService.handleProductOrderBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class handleProductOrderBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string paramXml;
        
        public handleProductOrderBody() {
        }
        
        public handleProductOrderBody(string paramXml) {
            this.paramXml = paramXml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class handleProductOrderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="handleProductOrderResponse", Namespace="http://common.order.connector.dataservice.gov.org/", Order=0)]
        public CPHandleOrderService.handleProductOrderResponseBody Body;
        
        public handleProductOrderResponse() {
        }
        
        public handleProductOrderResponse(CPHandleOrderService.handleProductOrderResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class handleProductOrderResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public handleProductOrderResponseBody() {
        }
        
        public handleProductOrderResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICPHandleOrderChannel : CPHandleOrderService.ICPHandleOrder, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CPHandleOrderClient : System.ServiceModel.ClientBase<CPHandleOrderService.ICPHandleOrder>,CPHandleOrderService.ICPHandleOrder {
        
        public CPHandleOrderClient() {
        }
        
        public CPHandleOrderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CPHandleOrderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CPHandleOrderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CPHandleOrderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CPHandleOrderService.handleProductOrderResponse CPHandleOrderService.ICPHandleOrder.handleProductOrder(CPHandleOrderService.handleProductOrder request) {
            return base.Channel.handleProductOrder(request);
        }
        
        public string handleProductOrder(string paramXml) {
            CPHandleOrderService.handleProductOrder inValue = new CPHandleOrderService.handleProductOrder();
            inValue.Body = new CPHandleOrderService.handleProductOrderBody();
            inValue.Body.paramXml = paramXml;
            //CPHandleOrderService.handleProductOrderResponse retVal = ((CPHandleOrderService.handleProductOrderResponse)(this))handleProductOrder(inValue);
            CPHandleOrderService.handleProductOrderResponse retVal = ((CPHandleOrderService.ICPHandleOrder)(this)).handleProductOrder(inValue);
            return retVal.Body.@return;
        }
    }
}

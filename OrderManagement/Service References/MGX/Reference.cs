﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagement.MGX {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MGX.IMGX")]
    public interface IMGX {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMGX/Add", ReplyAction="http://tempuri.org/IMGX/AddResponse")]
        double Add(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMGX/Model_MGX", ReplyAction="http://tempuri.org/IMGX/Model_MGXResponse")]
        string Model_MGX(string btnInFileNPP, string btnOutFile);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMGXChannel : OrderManagement.MGX.IMGX, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MGXClient : System.ServiceModel.ClientBase<OrderManagement.MGX.IMGX>, OrderManagement.MGX.IMGX {
        
        public MGXClient() {
        }
        
        public MGXClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MGXClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MGXClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MGXClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double n1, double n2) {
            return base.Channel.Add(n1, n2);
        }
        
        public string Model_MGX(string btnInFileNPP, string btnOutFile) {
            return base.Channel.Model_MGX(btnInFileNPP, btnOutFile);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManagement.EcoSystemServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EcoSystemServices.IEcoSystemServices")]
    public interface IEcoSystemServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEcoSystemServices/HelloWorld", ReplyAction="http://tempuri.org/IEcoSystemServices/HelloWorldResponse")]
        string HelloWorld(int value);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IEcoSystemServices/HelloWorld", ReplyAction="http://tempuri.org/IEcoSystemServices/HelloWorldResponse")]
        System.IAsyncResult BeginHelloWorld(int value, System.AsyncCallback callback, object asyncState);
        
        string EndHelloWorld(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEcoSystemServices/Model_Invoke", ReplyAction="http://tempuri.org/IEcoSystemServices/Model_InvokeResponse")]
        string Model_Invoke(string inputXml);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IEcoSystemServices/Model_Invoke", ReplyAction="http://tempuri.org/IEcoSystemServices/Model_InvokeResponse")]
        System.IAsyncResult BeginModel_Invoke(string inputXml, System.AsyncCallback callback, object asyncState);
        
        string EndModel_Invoke(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEcoSystemServicesChannel : OrderManagement.EcoSystemServices.IEcoSystemServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Model_InvokeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public Model_InvokeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EcoSystemServicesClient : System.ServiceModel.ClientBase<OrderManagement.EcoSystemServices.IEcoSystemServices>, OrderManagement.EcoSystemServices.IEcoSystemServices {
        
        private BeginOperationDelegate onBeginHelloWorldDelegate;
        
        private EndOperationDelegate onEndHelloWorldDelegate;
        
        private System.Threading.SendOrPostCallback onHelloWorldCompletedDelegate;
        
        private BeginOperationDelegate onBeginModel_InvokeDelegate;
        
        private EndOperationDelegate onEndModel_InvokeDelegate;
        
        private System.Threading.SendOrPostCallback onModel_InvokeCompletedDelegate;
        
        public EcoSystemServicesClient() {
        }
        
        public EcoSystemServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EcoSystemServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EcoSystemServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EcoSystemServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<HelloWorldCompletedEventArgs> HelloWorldCompleted;
        
        public event System.EventHandler<Model_InvokeCompletedEventArgs> Model_InvokeCompleted;
        
        public string HelloWorld(int value) {
            return base.Channel.HelloWorld(value);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginHelloWorld(int value, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginHelloWorld(value, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndHelloWorld(System.IAsyncResult result) {
            return base.Channel.EndHelloWorld(result);
        }
        
        private System.IAsyncResult OnBeginHelloWorld(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int value = ((int)(inValues[0]));
            return this.BeginHelloWorld(value, callback, asyncState);
        }
        
        private object[] OnEndHelloWorld(System.IAsyncResult result) {
            string retVal = this.EndHelloWorld(result);
            return new object[] {
                    retVal};
        }
        
        private void OnHelloWorldCompleted(object state) {
            if ((this.HelloWorldCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void HelloWorldAsync(int value) {
            this.HelloWorldAsync(value, null);
        }
        
        public void HelloWorldAsync(int value, object userState) {
            if ((this.onBeginHelloWorldDelegate == null)) {
                this.onBeginHelloWorldDelegate = new BeginOperationDelegate(this.OnBeginHelloWorld);
            }
            if ((this.onEndHelloWorldDelegate == null)) {
                this.onEndHelloWorldDelegate = new EndOperationDelegate(this.OnEndHelloWorld);
            }
            if ((this.onHelloWorldCompletedDelegate == null)) {
                this.onHelloWorldCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnHelloWorldCompleted);
            }
            base.InvokeAsync(this.onBeginHelloWorldDelegate, new object[] {
                        value}, this.onEndHelloWorldDelegate, this.onHelloWorldCompletedDelegate, userState);
        }
        
        public string Model_Invoke(string inputXml) {
            return base.Channel.Model_Invoke(inputXml);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginModel_Invoke(string inputXml, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginModel_Invoke(inputXml, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndModel_Invoke(System.IAsyncResult result) {
            return base.Channel.EndModel_Invoke(result);
        }
        
        private System.IAsyncResult OnBeginModel_Invoke(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string inputXml = ((string)(inValues[0]));
            return this.BeginModel_Invoke(inputXml, callback, asyncState);
        }
        
        private object[] OnEndModel_Invoke(System.IAsyncResult result) {
            string retVal = this.EndModel_Invoke(result);
            return new object[] {
                    retVal};
        }
        
        private void OnModel_InvokeCompleted(object state) {
            if ((this.Model_InvokeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.Model_InvokeCompleted(this, new Model_InvokeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void Model_InvokeAsync(string inputXml) {
            this.Model_InvokeAsync(inputXml, null);
        }
        
        public void Model_InvokeAsync(string inputXml, object userState) {
            if ((this.onBeginModel_InvokeDelegate == null)) {
                this.onBeginModel_InvokeDelegate = new BeginOperationDelegate(this.OnBeginModel_Invoke);
            }
            if ((this.onEndModel_InvokeDelegate == null)) {
                this.onEndModel_InvokeDelegate = new EndOperationDelegate(this.OnEndModel_Invoke);
            }
            if ((this.onModel_InvokeCompletedDelegate == null)) {
                this.onModel_InvokeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnModel_InvokeCompleted);
            }
            base.InvokeAsync(this.onBeginModel_InvokeDelegate, new object[] {
                        inputXml}, this.onEndModel_InvokeDelegate, this.onModel_InvokeCompletedDelegate, userState);
        }
    }
}

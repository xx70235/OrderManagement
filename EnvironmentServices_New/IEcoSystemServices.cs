using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EnvironmentServices_New
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IEcoSystemServices
    {

        [OperationContract]
        string HelloWorld(int value);

        [OperationContract(AsyncPattern = true)]
        //string Model_CDTH(string btnInFile1, string btnInFile2, string btnOutFile, double txtParaValue);
        IAsyncResult BeginModel_Invoke(string inputXml,AsyncCallback callback, object state);
        string EndModel_Invoke(IAsyncResult ar);
        

        // TODO: 在此添加您的服务操作
    }


   
}

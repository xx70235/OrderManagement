
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.ServiceModel;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace EnvironmentServices_New
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class EcoSystemServices:IEcoSystemServices
    {
        
        public IAsyncResult BeginModel_Invoke(string inputXml, AsyncCallback callback, object state)
        {
            Console.WriteLine("Asynchronous call:BeginModel_CDTH on ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
            return new Model_Invoke_Result(new Invoke_Produce(inputXml), callback, state);
            
        }

        public string EndModel_Invoke(IAsyncResult ar)
        {
            Model_Invoke_Result result = ar as Model_Invoke_Result;
            Console.WriteLine("EndModel_CDTH called with:{0}", Thread.CurrentThread.ManagedThreadId);
            return Model_Invoke_Result.End(ar);
        }

        public string HelloWorld(int value)
        {
            return "服务调用成功，返回值："+value;
        }
    }
     class Model_Invoke_Result : TypedAsyncResult<string>
    {
        Invoke_Produce produce;

        //List<string> stateList;

        private string functionName;
        public Model_Invoke_Result(Invoke_Produce produce, AsyncCallback callback, object state)
            : base(callback, state)
        {
            this.produce = produce;
            //this.State=new List<string>();
            //stateList = this.State as List<string>;
            //Turn the expression into an array of bytes
            produce.RunWork();
            //string sta1 = "开始执行";
            //stateList.Add(sta1);
            ProductDelegate del=new ProductDelegate(produce.Product);
            AsyncCallback callBack=new AsyncCallback(OnProduceComplete);
            //string currentState = "kaishi";
            IAsyncResult asyncResult = del.BeginInvoke(callBack, this);
            
            if (!produce.Finish)
            {
                return;
            }
            base.Complete(produce.Result,true);
            //begin writing asynchronously
            
            //IAsyncResult result = fs.BeginWrite(bytes, 0, bytes.Length, new AsyncCallback(OnWrite), thi
        }
        public delegate string ProductDelegate();

        public void OnProduceComplete(IAsyncResult asyncResult) 
        {
            
            //stateList.Add("执行中");
            AsyncResult result = (AsyncResult)asyncResult;
            ProductDelegate del = (ProductDelegate)result.AsyncDelegate;
            string product=del.EndInvoke(asyncResult);
            base.Complete(produce.Result,false);
            //stateList.Add("执行结束");
        }
    }
     public class Invoke_Produce
     {
         private string commonPath = @"C:\服务部署环境\生产模型部署";
         
         private bool finish = false;
         private bool result;
     
         private string remoteFile = null;
         private string executeDir = @"C:\服务部署环境\服务执行临时目录\";
         private string guid = null;
         private string xmlPath = null;
         private int endTime;
         private string xmlContent;

         private string functionName;
         private string category;
         public Invoke_Produce(string xml)
         {
             guid = System.Guid.NewGuid().ToString();
             this.xmlContent = xml;

             executeDir += "服务执行目录" + guid;

             //if (!File.Exists(executeDir))
             //{
             //    Directory.CreateDirectory(executeDir);
             //    executeDir += "/";
             //}
             //if (btnInFilePD.ToLower().StartsWith("ftp"))
             //{
             //    FtpHelper.Instance.DownloadMultiple(FtpHelper.userId, FtpHelper.pwd, btnInFilePD.Substring(0, btnInFilePD.LastIndexOf("/") + 1), executeDir, btnInFilePD.Substring(btnInFilePD.LastIndexOf("/") + 1));
             //    FtpHelper.Instance.DownloadMultiple(FtpHelper.userId, FtpHelper.pwd, btnInFileZBFGD.Substring(0, btnInFileZBFGD.LastIndexOf("/") + 1), executeDir, btnInFileZBFGD.Substring(btnInFileZBFGD.LastIndexOf("/") + 1));
             //    this.btnInFilePD = executeDir + btnInFilePD.Substring(btnInFilePD.LastIndexOf("/") + 1);
             //    this.btnInFileZBFGD = executeDir + btnInFileZBFGD.Substring(btnInFileZBFGD.LastIndexOf("/") + 1);
             //}
             //else
             //{
             //    this.btnInFilePD = btnInFilePD;
             //    this.btnInFileZBFGD = btnInFileZBFGD;
             //}
             //if (btnOutFile.ToLower().StartsWith("ftp"))
             //{
             //    remoteFile = btnOutFile;
             //    this.btnOutFile = executeDir + btnOutFile.Substring(btnOutFile.LastIndexOf("/") + 1);

             //}
             //else
             //{
             //    this.btnOutFile = btnOutFile;
             //}
             
         }
         public bool Finish
         {
             get
             {
                 return finish;
             }
         }
         public string Product()
         {
             while (finish == false)
             {
                 Thread.Sleep(5000);
             }
             endTime = System.Environment.TickCount;
             //Console.WriteLine("结束时间：" + endTime + "\n共计耗时：" + (endTime - startTime));
             return Result;
         }
         public void RunWork()
         {
             BackgroundWorker bg = new BackgroundWorker();
             bg.DoWork += new DoWorkEventHandler(bg_DoWork);
             bg.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_RunworkerCompleted);
             bg.RunWorkerAsync();             
         }
         public string Result
         {
             get
             {
                 if (result == true)
                 {
                     return "Success!";
                 }
                 else
                 {
                     return "Failed!";
                 }
             }
         }

         private void bg_RunworkerCompleted(object sender, RunWorkerCompletedEventArgs e)
         {
             //3、返回执行结果
             if (e.Error != null)
             {
                 result = false;
             }
             else if (e.Cancelled)
             {
                 result = false;
             }
             else
             {
                 //if (File.Exists(btnOutFile))
                 //{
                 //    if (remoteFile != null)
                 //    {
                 //        FtpHelper.Instance.Upload(FtpHelper.userId, FtpHelper.pwd, this.btnOutFile, remoteFile.Substring(0, remoteFile.LastIndexOf("/") + 1));
                 //    }
                 //    result = true;
                 //}
                 //else
                 //{

                 //    result = false;
                 //}
                 result = true;
             }
             finish = true;

         }

         void bg_DoWork(object sender, DoWorkEventArgs e)
         {
             //0、解析XML，获取产品名称-服务路径
             XmlDocument xmlDocument = new XmlDocument();
             xmlDocument.LoadXml(xmlContent);
             XmlNode lastChild = xmlDocument.LastChild;
             if (lastChild != null)
             {
                 functionName = GetAttributeValue(lastChild, "FunctionName");
                 //category = XmlManager.GetAttributeValue(lastChild, "Category");
                                 
             }
             //1、根据输入数据构建指定的防风固沙风蚀流失量xml  
                      
             WriteXml(xmlContent,functionName);
             //2、根据xml,调用指定的exe文件，执行服务

             string programPath = commonPath +"/"+functionName+"/"+functionName+".exe";
             Process p = null;
             try
             {
                 p = new Process();
                 p.StartInfo.UserName = "severus";
                 System.Security.SecureString password = new System.Security.SecureString();
                 password.AppendChar('0');
                 p.StartInfo.Password = password;
                 p.StartInfo.FileName = @programPath;
                 p.StartInfo.UseShellExecute = false;
                 p.StartInfo.Verb = "runas";
                 p.StartInfo.Arguments =xmlPath;
                 p.Start();
                 p.WaitForExit();
                                  
             }
             catch (Exception)
             {
                 if (!p.HasExited)
                 {
                     p.Kill();
                 }
             }
             finally
             {

             }
         }
         private string GetAttributeValue(XmlNode nodeRoot, string attrName)
         {
             string result;
             try
             {
                 result = ((nodeRoot.Attributes[attrName] == null) ? "" : nodeRoot.Attributes[attrName].Value);
             }
             catch (Exception ex)
             {

                 result = "";
             }
             return result;
         }
         private void WriteXml(string xmlContent,string xmlFileName)
         {
             try
             {
                 xmlPath = executeDir + guid +xmlFileName+".xml";
                 if (File.Exists(xmlPath))
                 {
                     try
                     {
                         File.Delete(xmlPath);
                     }
                     catch (Exception)
                     {
                         throw;
                     }
                 }
                                 
                 StringBuilder stringBuilder = new StringBuilder();
                 stringBuilder.Append(xmlContent);                
                 using (StreamWriter sw = File.CreateText(xmlPath))
                 {
                     sw.Write(stringBuilder.ToString());
                 }
                 
                 //Console.WriteLine("写入XML耗时：" + (fileTime - startTime));
             }
             catch (Exception)
             {
                 throw;
             }
         }
     }
}
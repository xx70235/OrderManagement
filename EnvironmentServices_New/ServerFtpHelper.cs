using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace EnvironmentServices_New
{
    public class ServerFtpHelper
    {
        public static readonly ServerFtpHelper Instance = new ServerFtpHelper();
        public static string userId=@"yg";
        public static string pwd=@"yg";
        public static string ftpPath=@"ftp://202.205.84.114/结果数据/";
        public bool CheckFtpConn(string DomainName, String address, string FtpUserName, string FtpUserPwd)
        {
            try
            {
                FtpWebRequest ftprequest = (FtpWebRequest)WebRequest.Create("ftp://" + DomainName + "//" + address);
                //WebRequest.Create(s);

                ftprequest.Credentials = new NetworkCredential(FtpUserName, FtpUserPwd);
                ftprequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftprequest.Timeout = 3000;

                FtpWebResponse ftpResponse = (FtpWebResponse)ftprequest.GetResponse();

                ftpResponse.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 取得文件名列表
        /// </summary>
        /// <param name="ftpPath">ftp路径</param>
        /// <returns></returns>
        public string[] GetFilePath(string userId, string pwd, string ftpPath)
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpPath));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(userId, pwd);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                reqFTP.UsePassive = false;
                WebResponse response = reqFTP.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch (Exception ex)
            {
                downloadFiles = null;
                return downloadFiles;
            }
        }

        //ftp的上传功能
        public void Upload(string userId, string pwd, string filename, string ftpPath)
        {
            FileInfo fileInf = new FileInfo(filename);
            FtpWebRequest reqFTP;
            // 根据uri创建FtpWebRequest对象 
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpPath + fileInf.Name));
            // ftp用户名和密码
            reqFTP.Credentials = new NetworkCredential(userId, pwd);

            reqFTP.UsePassive = false;
            // 默认为true，连接不会被关闭
            // 在一个命令之后被执行
            reqFTP.KeepAlive = false;
            // 指定执行什么命令
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            // 指定数据传输类型
            reqFTP.UseBinary = true;
            // 上传文件时通知服务器文件的大小
            reqFTP.ContentLength = fileInf.Length;
            // 缓冲大小设置为2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;
            // 打开一个文件流 (System.IO.FileStream) 去读上传的文件
            FileStream fs = fileInf.OpenRead();
            try
            {
                // 把上传的文件写入流
                Stream strm = reqFTP.GetRequestStream();
                // 每次读文件流的2kb
                contentLen = fs.Read(buff, 0, buffLength);
                // 流内容没有结束
                while (contentLen != 0)
                {
                    // 把内容从file stream 写入 upload stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }
                // 关闭两个流
                strm.Close();
                fs.Close();
            }
            catch (Exception ex)
            {

            }
        }
        //public void MakeDir(string dirName)
        //{
        //    try
        //    {
        //        string uri = ftpPath + dirName;

        //        Connect(uri);//连接      

        //        reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;

        //        FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();

        //        response.Close();

        //    }

        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);

        //    }

        //}


        public void UploadMultiple(string userId, string pwd, string filename, string ftpPath)
        {
          
           
            // 缓冲大小设置为2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;                                    
            try
            {
                if (filename.Contains(".")) {
                    // 打开一个文件流 (System.IO.FileStream) 去读上传的文件
                    FileInfo fileInf = new FileInfo(filename);
                    string path = fileInf.DirectoryName;
                    DirectoryInfo folder = new DirectoryInfo(fileInf.DirectoryName);
                    string fileNameBefore = fileInf.Name.Substring(0, fileInf.Name.LastIndexOf("."));
                    folder.GetFiles(fileNameBefore + ".*");
                    foreach (FileInfo file in folder.GetFiles(fileNameBefore + ".*"))
                    {
                        FtpWebRequest reqFTP;
                        // 根据uri创建FtpWebRequest对象 
                        reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpPath + file.Name));
                        // ftp用户名和密码
                        reqFTP.Credentials = new NetworkCredential(userId, pwd);

                        reqFTP.UsePassive = false;
                        // 默认为true，连接不会被关闭
                        // 在一个命令之后被执行
                        reqFTP.KeepAlive = false;
                        // 指定执行什么命令
                        reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
                        // 指定数据传输类型
                        reqFTP.UseBinary = true;
                        // 上传文件时通知服务器文件的大小
                        reqFTP.ContentLength = file.Length;

                        FileStream fs = file.OpenRead();
                        // 把上传的文件写入流
                        Stream strm = reqFTP.GetRequestStream();
                        // 每次读文件流的2kb
                        contentLen = fs.Read(buff, 0, buffLength);
                        // 流内容没有结束
                        while (contentLen != 0)
                        {
                            // 把内容从file stream 写入 upload stream
                            strm.Write(buff, 0, contentLen);
                            contentLen = fs.Read(buff, 0, buffLength);
                        }
                        // 关闭两个流
                        strm.Close();
                        fs.Close();
                    }
                }
                else//上传整个目录
                {

                }
                     



               
            }
            catch (Exception ex)
            {

            }
        }
        public void Delete(string userId, string pwd, string ftpPath, string fileName)
        {
            FtpWebRequest reqFTP;
            try
            {
                
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpPath + fileName));
                reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(userId, pwd);
                reqFTP.UsePassive = false;
                FtpWebResponse listResponse = (FtpWebResponse)reqFTP.GetResponse();
                string sStatus = listResponse.StatusDescription;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //从ftp服务器上下载文件的功能
        public void Download(string userId, string pwd, string ftpPath, string filePath, string fileName)
        {
            FtpWebRequest reqFTP;
            try
            {
                FileStream outputStream = new FileStream(filePath + "\\" + fileName, FileMode.Create);
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpPath + fileName));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(userId, pwd);
                reqFTP.UsePassive = false;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];
                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }
                ftpStream.Close();
                outputStream.Close();
                response.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //从ftp服务器上下载文件的功能
        public void DownloadMultiple(string userId, string pwd, string ftpPath, string filePath, string fileName)
        {
            FtpWebRequest reqFTP;
            try
            {
                string[] fileNames = GetFilePath(userId, pwd, ftpPath);
                string s=fileName.Substring(fileName.LastIndexOf("/")+1);
                s = s.Substring(0,s.LastIndexOf("."));
                foreach (var item in fileNames)
                {
                    if (item.Contains(s))
                    {
                        FileStream outputStream = new FileStream(filePath + "\\" + item, FileMode.Create);
                        reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpPath + item));
                        reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                        reqFTP.UseBinary = true;
                        reqFTP.Credentials = new NetworkCredential(userId, pwd);
                        reqFTP.UsePassive = false;
                        FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                        Stream ftpStream = response.GetResponseStream();
                        long cl = response.ContentLength;
                        int bufferSize = 2048;
                        int readCount;
                        byte[] buffer = new byte[bufferSize];
                        readCount = ftpStream.Read(buffer, 0, bufferSize);
                        while (readCount > 0)
                        {
                            outputStream.Write(buffer, 0, readCount);
                            readCount = ftpStream.Read(buffer, 0, bufferSize);
                        }
                        ftpStream.Close();
                        outputStream.Close();
                        response.Close();
                    }                   
                }         
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

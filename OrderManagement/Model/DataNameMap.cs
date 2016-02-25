using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OrderManagement.Model
{
    public class DataNameMap
    {

        public Dictionary<string, string> ThematicNameMap = new Dictionary<string, string>();
        public Dictionary<string, string> CommonNameMap = new Dictionary<string, string>();
        public Dictionary<string, string> CommonCategoryMap = new Dictionary<string, string>();

        public DataNameMap()
        {
            addThematicName();
            addCommonName();
            addCommonCategory();
        }

        private void addThematicName()
        {
           

            FileStream fs = new FileStream("thematicdatanamemap.txt", FileMode.Open, FileAccess.Read);
            //仅 对文本 执行  读写操作     
            StreamReader sr = new StreamReader(fs);
            //定位操作点,begin 是一个参考点     
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            //读一下，看看文件内有没有内容，为下一步循环 提供判断依据     
            //sr.ReadLine() 这里是 StreamReader的要领  可不是 console 中的~      
            string str = sr.ReadLine();//假如  文件有内容      
            while (str != null)
            {
               string[] tmp = str.Split(':');
               ThematicNameMap.Add(tmp[0], tmp[1]);
               str = sr.ReadLine();

            }
            //C#读取TXT文件之关上文件，留心顺序，先对文件内部执行 关上，然后才是文件~     
            sr.Close();
            fs.Close();
        }

        private void addCommonName()
        {


            FileStream fs = new FileStream("commondatanamemap.txt", FileMode.Open, FileAccess.Read);
            //仅 对文本 执行  读写操作     
            StreamReader sr = new StreamReader(fs);
            //定位操作点,begin 是一个参考点     
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            //读一下，看看文件内有没有内容，为下一步循环 提供判断依据     
            //sr.ReadLine() 这里是 StreamReader的要领  可不是 console 中的~      
            string str = sr.ReadLine();//假如  文件有内容      
            while (str != null)
            {
                string[] tmp = str.Split(':');
                CommonNameMap.Add(tmp[0], tmp[1]);
                str = sr.ReadLine();

            }
            //C#读取TXT文件之关上文件，留心顺序，先对文件内部执行 关上，然后才是文件~     
            sr.Close();
            fs.Close();
        }


        private void addCommonCategory()
        {


            FileStream fs = new FileStream("commoncategorymap.txt", FileMode.Open, FileAccess.Read);
            //仅 对文本 执行  读写操作     
            StreamReader sr = new StreamReader(fs);
            //定位操作点,begin 是一个参考点     
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            //读一下，看看文件内有没有内容，为下一步循环 提供判断依据     
            //sr.ReadLine() 这里是 StreamReader的要领  可不是 console 中的~      
            string str = sr.ReadLine();//假如  文件有内容      
            while (str != null)
            {
                string[] tmp = str.Split(':');
                CommonCategoryMap.Add(tmp[0], tmp[1]);
                str = sr.ReadLine();

            }
            //C#读取TXT文件之关上文件，留心顺序，先对文件内部执行 关上，然后才是文件~     
            sr.Close();
            fs.Close();
        }
        public string GetThematicEnglishName(string thematicName)
        {
            try
            {
                string name = ThematicNameMap[thematicName];
                return name;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string GetCommonEnglishName(string commonName)
        {
            return CommonNameMap[commonName];
        }

        public string GetCommonCategory(string commonName)
        {
            return CommonCategoryMap[commonName];
        }
    }
}





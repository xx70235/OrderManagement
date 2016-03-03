using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace OrderManagement.Utilities
{
    class HardwareMonitor
    {
       // Sensors targetSensor = null;
        public Sensors TargetSensor { get; set; }
        public String GetMonitorResult(string ip)
        {
           HttpWebResponse response = HttpHelper.CreateGetHttpResponse(@"http://"+ip+":8085/data.json", 1000, "", null);
           if (response == null)
               return null;
           System.IO.StreamReader myreader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8);
           string responseText = myreader.ReadToEnd();
           myreader.Close();
           return responseText;
        }

        public void GetChildrenById(Sensors sensor, int id)
        {
            // Sensors target;
            if (sensor.Children.Length == 0)
                return;
            else
                for (int i = 0; i < sensor.Children.Length; i++)
                {
                    if (sensor.Children[i].Id == id)
                       // return sensor.Children[i];
                        this.TargetSensor = sensor.Children[i];
                    else if (sensor.Children[i].Children.Length != 0)
                    {

                        GetChildrenById(sensor.Children[i], id);
                    }

                }
            return;

        }
    }
}

using Newtonsoft.Json;
using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OrderManagement.Utilities
{
    class JsonUtility
    {
        public static Sensors GetSensors(string jsonText)
        {

            JsonSerializer serializer = new JsonSerializer();
            //StringWriter sw = new StringWriter();
            //serializer.Serialize(new JsonTextWriter(sw), p);
            //Console.WriteLine(sw.GetStringBuilder().ToString());

            StringReader sr = new StringReader(jsonText);  
            JsonReader reader = new JsonTextReader(new StringReader(jsonText));
            Sensors sensor = (Sensors)serializer.Deserialize(new JsonTextReader(sr), typeof(Sensors));

            return sensor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.IO;
using System.Text;

namespace WebXinRobot.Models
{
    public class Commont
    {
        public static T GetModels<T>(string PostText)
        {
            XmlSerializer Doc = new XmlSerializer(typeof(T));
            using(MemoryStream Memory = new MemoryStream(Encoding.UTF8.GetBytes(PostText)))
            {
                T Obj = (T)Doc.Deserialize(Memory);
                return Obj;
            }           
        }
    }
}
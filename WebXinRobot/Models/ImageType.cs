using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebXinRobot.Models
{
    public class ImageType
    {
        public string ToUserName { get; set; }

        public string FromUserName { get; set; }

        public string CreateTime { get; set; }

        public string MsgType { get; set; }

        public string MediaId { get; set; }
    }
}
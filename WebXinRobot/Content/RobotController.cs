using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebXinRobot.DataModels;
using WebXinRobot.Models;

namespace WebXinRobot.Content
{
    public class RobotController : Controller
    {
        //
        // GET: /Robot/

        public ActionResult Index()
        {
            /*if (Request.HttpMethod.ToLower() == "get")
            {
                string signature = Request["signature"].ToString();
                string timestamp = Request["timestamp"].ToString();
                string nonce = Request["nonce"].ToString();
                string echostr = Request["echostr"].ToString();

                return Content(echostr);

            }
            else if (Request.HttpMethod.ToLower() == "post")
            {
                WeiXinDBDataContext Data = new WeiXinDBDataContext();

                TestTable t = new TestTable();
                StreamReader sr = new StreamReader(Request.InputStream);
                t.Massage = sr.ReadToEnd();
                sr.Close();

                Data.TestTable.InsertOnSubmit(t);
                Data.SubmitChanges();

            }*/

            string postText = @"  <xml>
  <ToUserName>111</ToUserName> 
  <FromUserName>222</FromUserName>
  <CreateTime>1401460406</CreateTime> 
  <MsgType>3333</MsgType> 
  <Content>444</Content> 
  <MsgId>6019226610609209468</MsgId> 
  </xml>";
            TextType xml = Commont.GetModels<TextType>(postText);
            if(xml != null)
            {
                return View();
            }

            /*try
            {
                WeiXinDBDataContext Data = new WeiXinDBDataContext();

                TestTable t = new TestTable();
                t.Massage = "fdsfsdfasdfa";

                Data.TestTable.InsertOnSubmit(t);
                Data.SubmitChanges();
            }
            catch(Exception e)
            {
                return Content(e.Message);
            }*/

            return Content("");
        }

    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;

//namespace SpeedPay.FindIp
//{
//    public class Ip : Controller
//    {
//        public static string GetIPAddress()
//        {
//            System.Web.HttpUtility context = System.Web.HttpContext.Current;
//            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

//            if (!string.IsNullOrEmpty(ipAddress))
//            {
//                string[] addresses = ipAddress.Split(',');
//                if (addresses.Length != 0)
//                {
//                    return addresses[0];
//                }
//            }

//            return context.Request.ServerVariables["REMOTE_ADDR"];
//        }
//    }
//}

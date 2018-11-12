using FNet.Settings.Models;
using Nskd;
using System;
using System.Web.Mvc;

namespace FNet.Settings.Controllers
{
    public class F0Controller : Controller
    {
        public Object Index()
        {
            if (Request.RequestType != "POST") { return ""; }
            RequestPackage rqp = RequestPackage.ParseRequest(Request.InputStream, Request.ContentEncoding);
            String settingsDsAsJsonString = F0Model.Get(rqp.SessionId);
            return PartialView("~/Views/F0/Index.cshtml", settingsDsAsJsonString);
        }
        /*
        public Object Save()
        {
            RequestPackage rqp = RequestPackage.ParseRequest(Request.InputStream, Request.ContentEncoding);
            String settingsDsAsJsonString = F0Model.Set(rqp);
            return settingsDsAsJsonString;
        }
        */
    }
}
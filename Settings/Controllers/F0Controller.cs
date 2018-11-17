using FNet.Settings.Models;
using Nskd;
using System;
using System.Web.Mvc;

namespace FNet.Settings.Controllers
{
    public class F0Controller : Controller
    {
        public Object Index(Guid sessionId)
        {
            Object v = null;
            if (Request.RequestType != "POST") { return ""; }
            //RequestPackage rqp = RequestPackage.ParseRequest(Request.InputStream, Request.ContentEncoding);
            String settingsDsAsJsonString = F0Model.Get(sessionId);
            v = PartialView("~/Views/F0/Index.cshtml", settingsDsAsJsonString);
            return v;
        }
        public Object Save()
        {
            RequestPackage rqp = RequestPackage.ParseRequest(Request.InputStream, Request.ContentEncoding);
            F0Model.Set(rqp);
            String settingsDsAsJsonString = F0Model.Get(rqp.SessionId);
            return settingsDsAsJsonString;
        }
    }
}
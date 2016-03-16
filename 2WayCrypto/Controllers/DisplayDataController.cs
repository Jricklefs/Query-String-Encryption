using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace _2WayCrypto.Controllers
{
    public class DisplayDataController : Controller
    {
        // GET: DisplayData
        public ActionResult Index(string value)
        {
            var qstringObj = Crypto.Decrypt_URLSafe(value, ConfigurationManager.AppSettings["cryptoKey"]);

            var javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var jsonOIN = javaScriptSerializer.Deserialize<CryptoObj>(qstringObj);


            return View();
        }
    }
}
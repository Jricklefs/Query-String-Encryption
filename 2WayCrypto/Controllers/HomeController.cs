using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;


namespace _2WayCrypto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var cO = new CryptoObj();
            return View(cO);
        }

        [HttpPost]
        public ActionResult Index(CryptoObj cryptoObj)
        {
            var sharedKey = ConfigurationManager.AppSettings["cryptoKey"];

            var javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            string jsonString = javaScriptSerializer.Serialize(cryptoObj);
           
            var EncryptedStuff = Crypto.Encrypt_URLSafe(jsonString, sharedKey);

                            

            return  Redirect("DisplayData/Index?value=" + EncryptedStuff);
        }

    }
}
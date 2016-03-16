using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2WayCrypto
{
    public class CryptoObj
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string CompanyGuid { get; set; }
        public string UserGuid { get; set; }
        public string AccessKey { get; set; }
        public string Created { get; set; }
        public string Password { get; set; }
        public string Licence { get; set; }
        public string  CompanyName { get; set; }
        public string OriginatingURL { get; set; }

        public CryptoObj(string userName = "",string email = "", string companyGuid = "", string userGuid = "", string accessKey = "", string created = "", string licence = "", string password = ""  , string companyName = "", string originatingURL = "")
        {
            Email = email;
            UserName = userName;
            CompanyGuid = companyGuid;
            UserGuid = userGuid;
            AccessKey = accessKey;
            Created = created;
            Password = password;
            Licence = licence;
            CompanyName = companyName;
            OriginatingURL = originatingURL;
        }
        public CryptoObj()
        {

        }
    }
}
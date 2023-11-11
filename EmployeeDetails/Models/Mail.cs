using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDetails.Models
{
   
    
        public class MailCredentails
        {
            public string UserName = "sandujaya8@gmail.com";
            //public string Password = "Pragati@1949";
            public string Password = "afagawuitsyvsrxs";
            //App generated password
            public string Host = "smtp.gmail.com";
            public int Port = 587;

        }
    public class MailModel
    {
        public string From
        {
            get;
            set;
        }
        public string To
        {
            get;
            set;
        }
        public string Subject
        {
            get;
            set;
        }
        public string Body
        {
            get;
            set;
        }
    }
}
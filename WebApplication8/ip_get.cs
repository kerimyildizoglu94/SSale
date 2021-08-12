using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8
{
    public class ip_get
    {
         public static string Get_ip()
        {
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            string ipadress = context.Request.UserHostAddress;
            return ipadress;

        }
    }
}

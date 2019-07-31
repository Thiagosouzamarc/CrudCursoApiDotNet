using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ApiDevMedia
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings =
                new JsonSerializerSettings
                {
                    Culture = CultureInfo.GetCultureInfo("pt-br"),
                    DateFormatString = "dd/MM/yyyy"
                };
        }
    }
}

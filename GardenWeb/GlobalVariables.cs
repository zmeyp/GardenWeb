using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GardenWeb
{
    public static class GlobalVariables
    {
        // read-write variable
        public static string Location
        {
            get
            {
                return HttpContext.Current.Session["Location"] as string;
            }
            set
            {
                HttpContext.Current.Session["Location"] = value;
            }
        }

        public static string GeoUrl
        {
            get
            {
                var license = HttpContext.Current.Application["GeoUrl"] as string;
                if (string.IsNullOrEmpty(license))
                {
                    license = ConfigurationManager.AppSettings["GeoUrl"];
                }
                return license;
            }
        }

        public static List<string> TucsonMetro
        {
            get
            {
                var tucsonMetro = HttpContext.Current.Application["TucsonMetro"] as List<string>;
                if (tucsonMetro == null)
                {
                    var tucsonMetroStr = ConfigurationManager.AppSettings["TucsonMetro"];
                    tucsonMetro = tucsonMetroStr.Split('|').ToList();
                }
                return tucsonMetro;
            }
        }
    }
}
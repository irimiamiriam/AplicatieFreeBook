using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieFreeBook.DataAcces
{
     class SqlDataAccess
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        public static string GetCartiFile()
        {
            return ConfigurationManager.AppSettings["CartiFile"];
        }
        public static string GetImprumuturiFile()
        {
            return ConfigurationManager.AppSettings["ImprumuturiFile"];
        }
        public static string GetUtilizatoriFile()
        {
            return ConfigurationManager.AppSettings["UtilizatoriFile"];
        }
        public static string GetPdfFolder()
        {
            return ConfigurationManager.AppSettings["CartiPdfFolder"];
        }
    }
}

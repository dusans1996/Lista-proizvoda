using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Proizvodi.Controllers
{
    static class Konekcija
    {
        public static string cnnProizvodi = KreirajKonekciju();

        public static string KreirajKonekciju()
        {
            SqlConnectionStringBuilder cnnSb = new SqlConnectionStringBuilder();
            cnnSb.DataSource = @"(localdb)\MSSQLLocalDB";
            cnnSb.InitialCatalog = "Proizvodi";
            cnnSb.IntegratedSecurity = true;
            return cnnSb.ToString();
        }
    }
}

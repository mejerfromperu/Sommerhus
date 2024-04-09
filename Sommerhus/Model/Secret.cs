using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommerhus.Model
{
    public class Secret
    {

        public static string GetConnectionString

        {

            get { return "Data Source=mssql16.unoeuro.com;User ID=isakgm_dk;Password=f2t9wHmFRDenbEA53ghp;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; }

        }
    }
}

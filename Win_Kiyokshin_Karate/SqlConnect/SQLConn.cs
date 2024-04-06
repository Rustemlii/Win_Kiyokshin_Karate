using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Kiyokshin_Karate.SqlConnect
{
    public class SQLConn
    {
        public static string ConSql = @"Server=DESKTOP-L12NAJ2\SQLEXPRESS;DataBase=KIYOKSHINDb;
        Trusted_Connection=true;Encrypt=false;";//aralarindaki " ; " mutleqdir yoxsa iwlemiyecek...
    }
}

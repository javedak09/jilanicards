using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Configuration;

namespace Jilani_Cards
{
    internal class CConnection
    {
        public SqlConnection cn;
        public SQLiteConnection cn1;

        public CConnection()
        {
            cn = new SqlConnection(ConfigurationSettings.AppSettings["cnStr"]);
            cn1 = new SQLiteConnection(ConfigurationSettings.AppSettings["cnStr1"]);
        }

        public void MConnOpen()
        {
            cn.Open();
        }

        public void MConnClose()
        {
            cn.Close();
        }


        public void MConn1Open()
        {
            cn1.Open();
        }

        public void MConn1Close()
        {
            cn1.Close();
        }

    }
}

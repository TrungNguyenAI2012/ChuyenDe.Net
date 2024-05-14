using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Database
    {
        string strCon = @"Data Source=DESKTOP-KT38O65\TNGUYEN;Initial Catalog=LifeManager;Integrated Security=True";
        protected SqlConnection sqlCon = null;
        public void OpenConnection()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }
        public void CloseConnection()
        {
            if (sqlCon.State == ConnectionState.Open && sqlCon != null)
                sqlCon.Close();
        }
    }
}

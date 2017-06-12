using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class Connect_Helper
    {
        public SqlConnection connect = null;
        public const string connectionString = "Data Source=KTJ\\SQLEXPRESS;Initial Catalog=\"project registration\";Integrated Security=True";
        //public const string connectionString = ConfigurationManager.ConnectionStrings[""].ConnectionString
        public void OpenSection()
        {
            if (connect == null)
                connect = new SqlConnection(connectionString);
            if (connect.State != ConnectionState.Open)
                connect.Open();
        }
        public void CloseSection()
        {
            if (connect != null)
                if (connect.State == ConnectionState.Open)
                    connect.Close();
        }
        public bool executeIDU(string strSQL)
        {
            try
            {
                OpenSection();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                int KQ = sqlcmd.ExecuteNonQuery();
                CloseSection();
                return KQ > 0;
            }
            catch
            {
                return false;
            }
        }
        public DataTable GetDataTable(string strSQL)//SELECT,...
        {
            try
            {
                OpenSection();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                CloseSection();
                return dt;
            }
            catch
            {
                return null;
            }

        }
    }
}

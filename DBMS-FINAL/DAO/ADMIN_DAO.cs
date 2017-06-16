using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class ADMIN_DAO
    {
        public static bool XacMinh(string username, string password)
        {
            try
            {
                Connect_Helper cnn = new Connect_Helper();
                cnn.OpenSection();
                string procedureName = "ADMIN_LOGIN";
                SqlCommand cmd = new SqlCommand(procedureName, cnn.connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ad_name", SqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = password;
                cmd.Parameters.Add("@KQ", SqlDbType.Int).Direction = ParameterDirection.Output;
                int KQ = cmd.ExecuteNonQuery();
                bool isad = false;
                if(KQ > 0)
                {
                    if (Convert.ToInt32(cmd.Parameters["@KQ"].Value) == 1)
                        isad = true;

                }
                return isad;
            }
            catch
            {
                // throw ex;
                return false;
            }
            //finally
            //{

            //}


        }
        

    }
}

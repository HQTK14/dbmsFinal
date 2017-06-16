using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;
namespace BUS
{
    public class ADMIN_BUS
    {
        public static bool XacMinh(string username, string password)
        {
            return ADMIN_DAO.XacMinh(username, password);
        }
    }
}

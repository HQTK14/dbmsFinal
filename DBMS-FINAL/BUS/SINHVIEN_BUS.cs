﻿using System;
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
    public class SINHVIEN_BUS
    {
        public static string LoginStyleStoreProcedure(string mssv, string pass)
        {
            return SINHVIEN_DAO.LoginStyleStoreProcedure(mssv, pass);
        }
        public static DataTable laySV(string mssv)
        {
            return SINHVIEN_DAO.laySV(mssv);
        }
        public static DataTable laytatcaSV()
        {
            return SINHVIEN_DAO.laytatcaSV();
        }

        public static SINHVIENDTO laySinhVien(string username, string password)
        {
            return SINHVIEN_DAO.laySinhVien(username, password);
        }
        //public static int dangkiNhom(int maNhom)
        //{
        //    return SINHVIEN_DAO.dangkiNhom(maNhom);
        //}

        //public static int huyNhom(int maNhom)
        //{
        //    return SINHVIEN_DAO.huyNhom(maNhom);
        //}

        //public static int dangkiDA(int maNhom, int maDA, int maDe)
        //{
        //    return SINHVIEN_DAO.dangkiDA(maNhom, maDA, maDe);
        //}

        //public static int huyDKDA(int maNhom, int maDA, int maDe)
        //{
        //    return SINHVIEN_DAO.huyDKDA(maNhom, maDA, maDe);
        //}
    }
}

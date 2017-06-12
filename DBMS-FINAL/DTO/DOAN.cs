using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DOAN
    {
        private int MaDA;
        private string TenDA;
        private int SLSV_ToiDa;
        private DateTime NgayKTDK;
        private DateTime NgayNop;
        private string MaMon;

        public int MaDA1
        {
            get
            {
                return MaDA;
            }

            set
            {
                MaDA = value;
            }
        }

        public int SLSV_ToiDa1
        {
            get
            {
                return SLSV_ToiDa;
            }

            set
            {
                SLSV_ToiDa = value;
            }
        }

        public DateTime NgayKTDK1
        {
            get
            {
                return NgayKTDK;
            }

            set
            {
                NgayKTDK = value;
            }
        }

        public DateTime NgayNop1
        {
            get
            {
                return NgayNop;
            }

            set
            {
                NgayNop = value;
            }
        }

        public string MaMon1
        {
            get
            {
                return MaMon;
            }

            set
            {
                MaMon = value;
            }
        }

        public string TenDA1
        {
            get
            {
                return TenDA;
            }

            set
            {
                TenDA = value;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MONHOC
    {
        private string MaMon;
        private string TenMon;
        private int SoTinChi;
        private DateTime NgayBD;
        private DateTime NgayKT;

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

        public string TenMon1
        {
            get
            {
                return TenMon;
            }

            set
            {
                TenMon = value;
            }
        }

        public int SoTinChi1
        {
            get
            {
                return SoTinChi;
            }

            set
            {
                SoTinChi = value;
            }
        }

        public DateTime NgayBD1
        {
            get
            {
                return NgayBD;
            }

            set
            {
                NgayBD = value;
            }
        }

        public DateTime NgayKT1
        {
            get
            {
                return NgayKT;
            }

            set
            {
                NgayKT = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SINHVIENDTO
    {
        private string MSSV;
        private string TenSV;
        private string STD;

        public string MSSV1
        {
            get
            {
                return MSSV;
            }

            set
            {
                MSSV = value;
            }
        }

        public string TenSV1
        {
            get
            {
                return TenSV;
            }

            set
            {
                TenSV = value;
            }
        }

        public string STD1
        {
            get
            {
                return STD;
            }

            set
            {
                STD = value;
            }
        }
    }
}

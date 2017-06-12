using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GIAOVIEN
    {
        private string MaGV;
        private string TenGV;
        private string STD;

        public string MaGV1
        {
            get
            {
                return MaGV;
            }

            set
            {
                MaGV = value;
            }
        }

        public string TenGV1
        {
            get
            {
                return TenGV;
            }

            set
            {
                TenGV = value;
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

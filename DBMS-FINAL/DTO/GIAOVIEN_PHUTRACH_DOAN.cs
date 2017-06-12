using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class GIAOVIEN_PHUTRACH_DOAN
    {
        private string MaGV;
        private int MaDA;

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
    }
}

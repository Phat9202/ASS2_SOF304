using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS
{
    public class TruyXuatPhanTu
    {
        public int TruyXuat(int n, int[] arr)
        {
            if (n < 0 || n >= arr.Length)
            {
                throw new IndexOutOfRangeException("Chỉ số nằm ngoài phạm vi.");
            }
            return arr[n];
        }
    }
}

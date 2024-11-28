using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS
{
    public class TrungBinhCong
    {
        public double TrungBinh(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArithmeticException("Không thể tính trung bình của một danh sách rỗng.");
            }
            return numbers.Average();
        }
    }
}

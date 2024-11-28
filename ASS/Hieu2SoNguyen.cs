using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS
{
    public class Hieu2SoNguyen
    {
        public int PhepTru(double a, double b)
        {
            try
            {
                if (a % 1 != 0 || b % 1 != 0)
                {
                    throw new ArgumentException("Giá trị phải là số nguyên.");
                }
                int tuso = Convert.ToInt32(a);
                int phanso = Convert.ToInt32(b);

                return tuso - phanso;
            }
            catch (OverflowException)
            {
                throw new ArgumentException("Giá trị quá lớn để chuyển đổi thành số nguyên.");
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Lỗi không xác định: {ex.Message}");
            }
        }
    }
}

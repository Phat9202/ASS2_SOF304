using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS
{
    public class Sinhvienpoly
    {
        public static bool ContainsSpecialCharacter(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            foreach (char c in input)
            {
                if (!Char.IsLetterOrDigit(c) && !Char.IsWhiteSpace(c))
                {
                    return true; // Nếu tìm thấy ký tự không phải chữ cái, số hoặc khoảng trắng
                }
            }

            return false; // Nếu không có ký tự đặc biệt
        }
        public void AddSV(string id, string hoten, string masv, string malop, string tenlop, List<Sinhvien> listSv)
        {
            if (id.Length < 1 || id.Length > 5)
            {
                throw new Exception("Id Sinh Viên phải có độ dài từ 1 đến 5 ký tự!");
            }
            if (listSv.Any(x => x.id == id))
            {
                throw new Exception("Id Sinh Viên Đã Tồn Tại!");
            }
            if (hoten.Length < 1 || hoten.Length > 100)
            {
                throw new Exception("HoTen Sinh Viên phải có độ dài từ 1 đến 100 ký tự!");
            }
            if (masv.Length < 1 || masv.Length > 10)
            {
                throw new Exception("MaSV phải có độ dài từ 1 đến 10 ký tự!");
            }
            if (listSv.Any(x => x.masv == masv))
            {
                throw new Exception("MaSV đã tồn tại!");
            }
            if (malop.Length < 1 || malop.Length > 10)
            {
                throw new Exception("MaLop phải có độ dài từ 1 đến 10 ký tự!");
            }
            if (tenlop.Length < 1 || tenlop.Length > 100 || ContainsSpecialCharacter(tenlop))
            {
                throw new Exception("TenLop không được chứa ký tự đặc biệt và phải có độ dài từ 1 đến 100 ký tự!");
            }
            Sinhvien sv = new Sinhvien() { id = id, hoten = hoten, masv = masv, malop = malop, tenlop = tenlop };
            listSv.Add(sv);
        }


        public Sinhvien SearchSv(string masv, List<Sinhvien> listSv)
        {
            if (!listSv.Any(x => x.masv == masv) || masv == null)
            {
                throw new Exception("Mã Sinh Viên Không Tồn Tại!");
            }
            return listSv.FirstOrDefault(x=>x.masv==masv);
        }
    }
}

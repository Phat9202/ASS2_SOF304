using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS
{
    public class Sinhvien
    {
        public Sinhvien()
        {
        }

        public string id {  get; set; } //id không được trùng,giới hạn 5 ký tự
        public string hoten { get; set; } //hoten giới hạn 100 ký tự
        public string masv { get; set; } //masv không được trùng,giới hạn 10 ký tự
        public string malop { get; set; } //malop giới hạn 10 ký tự
        public string tenlop { get; set; } //ten lop giới hạn 100 ký tự

    }
}

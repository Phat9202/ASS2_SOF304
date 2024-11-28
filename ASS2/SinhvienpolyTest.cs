using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASS;

namespace ASS2Test
{
    public class SinhvienpolyTest
    {
        Sinhvienpoly sinhvienpoly = new Sinhvienpoly();

        List<Sinhvien> listSv = new List<Sinhvien>()
        {
           new Sinhvien() { id = "1" ,hoten = "Phat1", masv = "Ph47221", malop = "SD19201", tenlop = "PTCN1"},
           new Sinhvien() { id = "2" ,hoten = "Phat2", masv = "Ph47222", malop = "SD19202", tenlop = "PTCN2"},
           new Sinhvien() { id = "3" ,hoten = "Phat3", masv = "Ph47223", malop = "SD19203", tenlop = "PTCN3"},
           new Sinhvien() { id = "4" ,hoten = "Phat4", masv = "Ph47224", malop = "SD19204", tenlop = "PTCN4"},
           new Sinhvien() { id = "5" ,hoten = "Phat5", masv = "Ph47225", malop = "SD19205", tenlop = "PTCN5"},
        };
        [Test]
        [TestCase("12345", "Phat1", "Ph47226", "SD19201", "PTCN1")]  // id 5 ký tự hợp lệ
        [TestCase("123", "Phat2", "Ph47227", "SD19202", "PTCN2")]    // id 3 ký tự hợp lệ
        [TestCase("9", "Phat3", "Ph47228", "SD19203", "PTCN3")]      // id 1 ký tự hợp lệ
        [TestCase("421", "Phat12345678901", "Ph47229", "SD19204", "PTCN4")]  // id 15 ký tự
        [TestCase("123456", "Phat5", "Ph47244", "SD19205", "PTCN5")]  // id dài hơn 5 ký tự

        [TestCase("Phat6", "Phat6", "Ph47241", "SD19206", "PTCN6")]    // HoTen hợp lệ, 5 ký tự
        [TestCase("P", "P", "Ph472223", "SD19207", "PTCN7")]        // HoTen 1 ký tự hợp lệ
        [TestCase("22", "Phat8", "Ph472234", "Phat12345678901", "PTCN8")]  // malop 15
        [TestCase("12345", "Phat1", "Ph472245", "Phat1234567890", "PTCN9")]  // malop 14
        [TestCase("Ph47", "Phat10", "Ph472211", "SD19210", "PTCN10")]  // id 4
        [TestCase("223", "Phat11", "Ph472221234567", "SD19211", "PTCN11")]  // Masv 14


        public void AddSVTest(string id, string hoten, string masv, string malop, string tenlop)
        {
            sinhvienpoly.AddSV(id, hoten, masv, malop, tenlop, listSv);
            Assert.That(listSv.Any(x=>x.id==id),Is.True);
        }


        [Test]
        [TestCase("16", "Phat16", "Ph47236", "SD19216", "PTCN#16")]  // Chứa ký tự đặc biệt #
        [TestCase("17", "Phat17", "Ph47237", "SD19217", "PTCN@17")]  // Chứa ký tự đặc biệt @
        [TestCase("18", "Phat18", "Ph47238", "SD19218", "PTCN!18")]  // Chứa ký tự đặc biệt !
        [TestCase("19", "Phat19", "Ph47239", "SD19219", "PTCN*19")]  // Chứa ký tự đặc biệt *
        [TestCase("20", "Phat20", "Ph47240", "SD19220", "PTCN$20")]  // Chứa ký tự đặc biệt $
        public void AddSVTest_Exception(string id, string hoten, string masv, string malop, string tenlop)
        {
            Assert.Throws<Exception>(() => sinhvienpoly.AddSV(id, hoten, masv, malop, tenlop, listSv));
        }

        [Test]
        [TestCase("Ph47226")]
        [TestCase("Ph472211")]
        [TestCase("Ph47221")]
        [TestCase("Ph47222")]
        [TestCase("Ph47230")]
        public void SearchSvTest(string masv)
        {
            Assert.That(listSv.Any(x => x.masv == masv), Is.True);
        }
    }
}

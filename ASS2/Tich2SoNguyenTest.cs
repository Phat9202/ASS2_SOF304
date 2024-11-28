using ASS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS2Test
{
    internal class Tich2SoNguyenTest
    {
        Tich2SoNguyen _math = new Tich2SoNguyen();

        [Test]
        [TestCase(12, 1, 12)]
        [TestCase(10, 2, 20)]                   // 10 / 2 = 5
        [TestCase(-8, -4, 32)]                  // -8 / -4 = 2
        [TestCase(15, -3, -45)]                 // 15 / -3 = -5
        [TestCase(-20, 4, -80)]                 // -20 / 4 = -5
        [TestCase(0, 1, 0)]                     // 0 / 1 = 0
        [TestCase(100, 25, 2500)]                 // 100 / 25 = 4
        [TestCase(7, 2, 14)]                    // 7 / 2 = 3 (phần nguyên)
        [TestCase(int.MaxValue - 1, 1, int.MaxValue - 1)]                  // 9 / -3 = -3
        [TestCase(int.MinValue, 0, 0)]                  // 9 / -3 = -3

        public void PhepTruTest(double a, double b, double kq)
        {
            var result = _math.PhepNhan(a, b);
            Assert.That(result, Is.EqualTo(kq));
        }

        [Test]
        [TestCase(9.4, 8)]
        [TestCase(9.4, 8)]
        public void SoNguyenTest(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => _math.PhepNhan(a, b));
        }

        [Test]
        [TestCase(double.MaxValue, double.MinValue)]
        public void SoNguyenTest1(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => _math.PhepNhan(a, b));
        }
    }
}

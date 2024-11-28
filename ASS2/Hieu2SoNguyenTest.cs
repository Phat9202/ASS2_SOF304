using ASS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS2Test
{
    internal class Hieu2SoNguyenTest
    {
        Hieu2SoNguyen _math = new Hieu2SoNguyen();

        [Test]
        [TestCase(12, 1, 11)]
        [TestCase(10, 2, 8)]                   // 10 / 2 = 5
        [TestCase(-8, -4, -4)]                  // -8 / -4 = 2
        [TestCase(15, -3, 18)]                 // 15 / -3 = -5
        [TestCase(-20, 4, -24)]                 // -20 / 4 = -5
        [TestCase(0, 1, -1)]                     // 0 / 1 = 0
        [TestCase(100, 25, 75)]               // 100 / 25 = 4
        [TestCase(int.MaxValue - 1, int.MaxValue, -1)]                  // 9 / -3 = -3
        [TestCase(int.MinValue, int.MinValue + 1, -1)]                  // 9 / -3 = -3

        public void PhepTruTest(double a, double b, double kq)
        {
            var result = _math.PhepTru(a, b);
            Assert.That(result, Is.EqualTo(kq));
        }

        [Test]
        [TestCase(9.4, 8)]
        [TestCase(9.4, 8)]
        public void SoNguyenTest(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => _math.PhepTru(a, b));
        }

        [Test]
        [TestCase(double.MaxValue, double.MinValue)]
        public void SoNguyenTest1(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => _math.PhepTru(a, b));
        }
    }
}

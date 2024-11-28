using ASS;
using System.Runtime.Intrinsics.X86;

namespace ASS2Test
{
    public class Tong2SoNguyenTest
    {
        Tong2SoNguyen _math = new Tong2SoNguyen();

        [Test]
        [TestCase(12, 1, 13)]
        [TestCase(10, 2, 12)]                   // 10 / 2 = 5
        [TestCase(-8, -4, -12)]                  // -8 / -4 = 2
        [TestCase(15, -3, 12)]                 // 15 / -3 = -5
        [TestCase(-20, 4, -16)]                 // -20 / 4 = -5
        [TestCase(0, 1, 1)]                     // 0 / 1 = 0
        [TestCase(100, 25, 125)]               // 100 / 25 = 4
        [TestCase(int.MaxValue -1, int.MinValue, -2)]                  // 9 / -3 = -3
        [TestCase(int.MaxValue - 1, 0, int.MaxValue - 1)]                  // 9 / -3 = -3

        public void PhepCongTest(double a, double b, double kq)
        {
            var result = _math.PhepCong(a, b);
            Assert.That(result, Is.EqualTo(kq));
        }

        [Test]
        [TestCase(9.4, 8)]
        [TestCase(9.4, 8)]
        public void SoNguyenTest(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => _math.PhepCong(a, b));
        }

        [Test]
        [TestCase(double.MaxValue, double.MinValue)]
        public void SoNguyenTest1(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => _math.PhepCong(a, b));
        }
    }
}
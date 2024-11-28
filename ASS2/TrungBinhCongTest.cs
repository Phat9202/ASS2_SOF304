using ASS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS2Test
{
    public class TrungBinhCongTest
    {
        TrungBinhCong _math = new TrungBinhCong();

        [Test]
        [TestCase(new int[] { 1,2,3 }, 2)]
        [TestCase(new int[] { 5 }, 5)]
        [TestCase(new int[] { 10, 10 }, 10)]
        [TestCase(new int[] { -10, 20 }, 5)]
        [TestCase(new int[] { -3, -6, -9 }, -6)]
        [TestCase(new int[] { -10, 0, 10 }, 0)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { int.MaxValue, int.MinValue, 1 }, 0)]
        [TestCase(new int[] { 1000000, 2000000, 3000000 }, 2000000)]
        [TestCase(new int[] { int.MaxValue, int.MinValue + 1 }, 0)]
        public void TrungBinhTest(int[] arr, double kq)
        {
            var result = _math.TrungBinh(arr);
            Assert.That(result, Is.EqualTo(kq));
        }

        [Test]
        [TestCase(new int[] { })]
        public void TrungBinh_ArithmeticException(int[] arr)
        {
            Assert.Throws<ArithmeticException>(() => _math.TrungBinh(arr));
        }

        [Test]
        public void TrungBinh_RaisesExceptionForNullArray()
        {
            Assert.Throws<ArithmeticException>(() => _math.TrungBinh(null));
        }
    }
}

using ASS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS2Test
{
    internal class TruyXuatPhanTuTest
    {
        TruyXuatPhanTu _math = new TruyXuatPhanTu();


        [Test]
        [TestCase(new int[] { 1, 2, 3 }, 2,3)]
        [TestCase(new int[] { 5 }, 0,5)]
        [TestCase(new int[] { 10, 10 }, 1,10)]
        [TestCase(new int[] { -10, 20 }, 1,20)]
        [TestCase(new int[] { -3, -6, -9 }, 2,-9)]
        [TestCase(new int[] { -10, 0, 10 }, 0,-10)]
        [TestCase(new int[] { 0, 0, 0 }, 0,0)]
        [TestCase(new int[] { int.MaxValue, int.MinValue, 1 }, 0, int.MaxValue)]
        [TestCase(new int[] { 1000000, 2000000, 3000000 }, 2, 3000000)]
        [TestCase(new int[] { int.MaxValue, int.MinValue + 1 }, 0, int.MaxValue)]


        public void TruyXuatTest(int[] arr, int a, int kq)
        {
            var result = _math.TruyXuat(a, arr);
            Assert.That(result, Is.EqualTo(kq));
        }


        [Test]
        [TestCase(4, new int[] { 1, 2, 4 })]
        public void TruyXuatTest_IndexOutOfRangeException(int a, int[] arr)
        {
            Assert.Throws<IndexOutOfRangeException>(() => _math.TruyXuat(a, arr));
        }
    }
}

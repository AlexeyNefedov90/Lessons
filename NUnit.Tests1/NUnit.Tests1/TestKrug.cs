using GeometricFigures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestKrug
    {
        [Test]
        public void Test_Krug_Length()
        {
            Circle krug = new Circle(10);

            krug.getLengthCircle();

            object a = 62.8;

            Assert.AreEqual(a, krug.getLengthCircle());
        }

        [Test]
        public void Test_Krug_Area()
        {
            Circle krug = new Circle(3);

            krug.getAreaCircle();

            object b = 52.56;

            Assert.AreEqual(b, krug.getAreaCircle());
        }

        [Test, TestCaseSource("Kru")]
        public void Test_Krug_Data_in(int dlina, double Area, double Leght)
        {
            Circle krug = new Circle(dlina);

            Assert.AreEqual(krug.getAreaCircle(), Area);
            Assert.AreEqual(krug.getLengthCircle(), Leght);
        }

        static object[] Kru =
        {
            new object[] {3, 28.26, 18.64},
            new object[] {5, 78.5, 31.4},
            new object[] {8, 200.96, 50.24}
        };
    }
}
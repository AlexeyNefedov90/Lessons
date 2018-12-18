using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigures;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestKvadrat
    {

        [Test]
        public void Test_Kvadrat_Area()
        {
            Square kvadrat = new Square(4);

            kvadrat.getAreaSquare();

            int c = 16;

            Assert.AreEqual(c, kvadrat.getAreaSquare());
        }

        [Test]
        public void Test_Kvadrat_Lenght()
        {
            Square kvadrat = new Square(6);

            kvadrat.getLengthSquare();

            int d = 24;

            Assert.AreEqual(d, kvadrat.getLengthSquare());
        }

        [Test, TestCaseSource("Kvad")]
        public void Test_Kvadrat_Data_in(int storona, int Area, int Lenght)
        {
            Square kvadrat = new Square(storona);

            Assert.AreEqual(kvadrat.getAreaSquare(), Area);
            Assert.AreEqual(kvadrat.getLengthSquare(), Lenght);
        }

        static object[] Kvad =
        {
             new object[] {2, 4, 8},
             new object[] {5, 25, 20},
             new object[] {8, 64, 32},
             new object[] {10, 100, 40},
             new object[] {13, 169, 52},
             new object[] {18, 324, 72},
        };
    }
}

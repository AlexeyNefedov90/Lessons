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
    public class TestTreygolnik
    {

        [Test]
        public void Test_Tringle_Lenght()
        {
            Triangle treygolnik = new Triangle(6, 2, 3);

            treygolnik.getLengthTriangle();

            int d = 11;

            Assert.AreEqual(d, treygolnik.getLengthTriangle());
        }

        [Test]
        public void Test_Tringle_Area()
        {
            Triangle treygolnik = new Triangle(5, 5, 6);

            treygolnik.getAreaTriangle();

            int d = 12;

            Assert.AreEqual(d, treygolnik.getAreaTriangle());
        }

        [Test, TestCaseSource("Trin")]
        public void Test_Treygolnik_Data_in(int storona1, int storona2, int storona3, double Area, int Lenght)
        {
            Triangle treygolnik = new Triangle(storona1, storona2, storona3);

            Assert.AreEqual(treygolnik.getAreaTriangle(), Area);
            Assert.AreEqual(treygolnik.getLengthTriangle(), Lenght);
        }

        static object[] Trin =
            {
             new object[] { 3, 3, 3, 3.9, 9 },
             new object[] { 5, 9, 12, 20.4, 26 },
             new object[] { 10, 12, 17, 58.9, 39 },
             new object[] { 7, 10, 4, 10.9, 21 },
            };
    }
}

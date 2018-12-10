using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Test_Krug_Length()
        {
            GeometricFigures.Circle krug = new GeometricFigures.Circle(10);

            krug.getLengthCircle();

            object a = 62.8;

            Assert.AreEqual(a, krug.getLengthCircle());
        }

        [Test]
        public void Test_Krug_Area()
        {
            GeometricFigures.Circle krug = new GeometricFigures.Circle(3);

            krug.getAreaCircle();

            object b = 52.56;

            Assert.AreEqual(b,krug.getAreaCircle());
        }

        [Test]
        public void Test_Kvadrat_Square()
        {
            GeometricFigures.Square kvadrat = new GeometricFigures.Square(4);

            kvadrat.getAreaSquare();

            int c = 16;

            Assert.AreEqual(c, kvadrat.getAreaSquare());
        }

        [Test]
        public void Test_Kvadrat_Lenght()
        {
            GeometricFigures.Square kvadrat = new GeometricFigures.Square(6);

            kvadrat.getLengthSquare();

            int d = 24;

            Assert.AreEqual(d,kvadrat.getLengthSquare());
        }

        [Test]
        public void Test_Tringle_Lenght()
        {
            GeometricFigures.Triangle treygolnik = new GeometricFigures.Triangle(6,2,3);

            treygolnik.getLengthTriangle();

            int d = 11;

            Assert.AreEqual(d, treygolnik.getLengthTriangle());
        }

        [Test]
        public void Test_Tringle_Area()
        {
            GeometricFigures.Triangle treygolnik = new GeometricFigures.Triangle(5, 5, 6);

            treygolnik.getAreaTriangle();

            int d = 12; 

            Assert.AreEqual(d, treygolnik.getAreaTriangle());
        }
    }
}

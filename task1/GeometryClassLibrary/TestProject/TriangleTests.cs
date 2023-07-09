using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestMethodA1B1C1()
        {
            Triangle t = new Triangle(1, 1, 1);
            Assert.AreEqual(0.433013, t.Square, 0.1);
        }

        [TestMethod]
        public void TestMethodA4B7C5()
        {
            Triangle t = new Triangle(4, 7, 5);
            Assert.AreEqual(9.797959, t.Square, 0.1);
        }

        [TestMethod]
        public void IsItRightTriangleFalse()
        {
            Triangle t = new Triangle(4, 7, 5);
            Assert.AreEqual(false, t.IsItRightTriangle());
        }

        [TestMethod]
        public void IsItRightTriangleTrue()
        {
            Triangle t = new Triangle(145, 105, 100);
            Assert.AreEqual(true, t.IsItRightTriangle());
        }
    }
}

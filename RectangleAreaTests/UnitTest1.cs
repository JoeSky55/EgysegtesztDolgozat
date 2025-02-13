using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EgysegtesztGalJozsef;

namespace RectangleAreaTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateArea_PositiveNumbers()
        {
            var terulet = new Rectangle();
            int width = 5;
            int height = 10;
            int result = 50;

            int eredmeny = terulet.CalculateArea(width, height);

            Assert.AreEqual(result, eredmeny);
        }
        [TestMethod]
        public void CalculateArea_ZeroWidth()
        {
            var terulet = new Rectangle();
            int width = 0;
            int height = 10;
            int result = 0;

            int eredmeny = terulet.CalculateArea(width, height);

            Assert.AreEqual(result, eredmeny);
        }
        [TestMethod]
        public void CalculateArea_ZeroHeight()
        {
            var terulet = new Rectangle();
            int width = 10;
            int height = 0;
            int result = 0;

            int eredmeny = terulet.CalculateArea(width, height);

            Assert.AreEqual(result, eredmeny);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateArea_NegativeWidth_ThrowException()
        {

            var terulet = new Rectangle();
            int width = -5;
            int height = 10;
            //int result = 0;

            int eredmeny = terulet.CalculateArea(width, height);

            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateArea_NegativeHeight_ThrowException()
        {
            var terulet = new Rectangle();
            int width = 10;
            int height = -5;
            //int result = 0;

            int eredmeny = terulet.CalculateArea(width, height);


        }
        [TestMethod]
        public void CalculateArea_BigNumbers()
        {
            var terulet = new Rectangle();
            long width = 1000000;
            long height = 2000000;
            long result = 2000000000000;

            long eredmeny = terulet.CalculateArea(Convert.ToInt32(width), Convert.ToInt32(height));
            Assert.AreEqual(eredmeny, result);

        }
        [TestMethod]
        public void CalculateArea_DoubleNumbers()
        {
            var terulet = new Rectangle();
            int width = 4;
            int height = 2;
            //int result = 0;

            int eredmeny = terulet.CalculateArea(width,height);


        }
    }
}

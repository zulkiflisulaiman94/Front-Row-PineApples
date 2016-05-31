using NUnit.Framework;
using MyGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGame.Tests
{
    [TestFixture()]
    public class ChrisTest
    {
        [Test()]
        public void TestTTL()
        {
            GameBoard b = new GameBoard();
            b.AddImage(1);

            Assert.AreEqual(1, b.CoffeeCount);
        }

        [Test()]
        public void TestTTL2()
        {
            GameBoard b = new GameBoard();
            b.AddImage(1);

            b.CheckTTL(5);
            b.DestroyImages();
            Assert.AreEqual(0, b.CoffeeCount);
        }

        [Test()]
        public void TestTTL3()
        {
            GameBoard b = new GameBoard();
            b.AddImage(1);
            b.AddImage(2);

            b.CheckTTL(2);
            b.DestroyImages();
            Assert.AreEqual(1, b.CoffeeCount);
        }

        [Test()]
        public void TestTTL4()
        {
            GameBoard b = new GameBoard();
            b.AddImage(1);
            b.AddImage(2);

            b.CheckTTL(3);
            b.DestroyImages();
            Assert.AreEqual(0, b.CoffeeCount);
        }
    }
}

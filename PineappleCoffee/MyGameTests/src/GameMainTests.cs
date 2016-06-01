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
            int i = 1;

            Assert.AreEqual(1, i);
        }

        [Test()]
        public void TestTTL1()
        {
            GameBoard b = new GameBoard();
            b.AddImage(1);
            //asdf
            Assert.AreEqual(1, b.CoffeeCount);
        }


    }
}

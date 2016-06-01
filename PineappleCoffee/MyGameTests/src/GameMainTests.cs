using NUnit.Framework;
using MyGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwinGameSDK;


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
            //GameBoard b = new GameBoard();
           // b.AddImage(1);
            //asdfasd
            
            //Assert.AreEqual(1, b.CoffeeCount);
            Latte _newLt = new Latte(1);
            _newLt.Draw();
            Assert.AreEqual(_newLt, null);
        }


    }
}

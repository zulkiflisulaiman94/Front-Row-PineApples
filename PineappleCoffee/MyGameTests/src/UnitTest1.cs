using NUnit.Framework;
using MyGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyGame.Tests
{
    [TestFixture()]
    public class ChrisTest2
    {
        [Test()]
        public void TestScoreCtrl()
        {
            ScoreControler s = new ScoreControler();
            int i = s.FetchScore();

            Assert.AreEqual(1, i);
        }
        [Test()]
        public void TestScoreCtrl2()
        {
            ScoreControler s = new ScoreControler();

            s.add(2);

            int i = s.FetchScore();

            Assert.AreEqual(3, i);
        }
        [Test()]
        public void TestScoreCtrl3()
        {
            ScoreControler s = new ScoreControler();

            s.add(2);

            int i = s.FetchScore();

            Assert.AreEqual(3, i);
        }
        [Test()]
        public void TestScoreCtrl4()
        {
            ScoreControler s = new ScoreControler();

            s.add(2);
            s.add(-1);

            int i = s.FetchScore();

            Assert.AreEqual(2, i);
        }
      




    }
}

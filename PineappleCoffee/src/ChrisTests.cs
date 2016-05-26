using System;
using NUnit.Framework;
using SwinGameSDK;

namespace MyGame
{
	[TestFixture ()]
	public class ChrisTest
	{
		[Test()]
		public void TestTTL ()
		{
			GameBoard b = new GameBoard ();
			b.AddImage(1);

			Assert.AreEqual(1, b.CoffeeCount);
		}

		[Test()]
		public void TestTTL2 ()
		{
			GameBoard b = new GameBoard ();
			b.AddImage(1);

			b.CheckTTL(1);

			Assert.AreEqual(0, b.CoffeeCount);
		}

		[Test()]
		public void TestTTL3 ()
		{
			GameBoard b = new GameBoard ();
			b.AddImage(1);
			b.AddImage(2);

			b.CheckTTL(1);

			Assert.AreEqual(1, b.CoffeeCount);
		}

		[Test()]
		public void TestTTL4 ()
		{
			GameBoard b = new GameBoard ();
			b.AddImage(1);
			b.AddImage(2);

			b.CheckTTL(2);

			Assert.AreEqual(0, b.CoffeeCount);
		}
	}
}


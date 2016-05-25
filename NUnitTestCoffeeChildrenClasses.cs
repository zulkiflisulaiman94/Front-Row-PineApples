using NUnit.Framework;
using System;
using SwinGameSDK;

namespace MyGame
{
	[TestFixture ()]
	public class NUnitTestCoffeeChildrenClasses
	{
		[Test ()]
		public void TestLatteDraws ()
		{
			// ARRANGE //
			Point2D t = new Point2D();
			Latte l = new Latte(30);
			// ACT //
			l.Draw();
			t = SwinGame.PointAt (351, 351);
			// ASSERT //
			Assert.True(l.IsAt(t));
		}

		[Test ()]
		public void TestCapDraws ()
		{
			// ARRANGE //
			// ACT //
			// ASSERT //
		}

	}
}


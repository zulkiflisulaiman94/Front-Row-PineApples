using NUnit.Framework;
using System;
using SwinGameSDK;

namespace MyGame
{
	[TestFixture ()]
	public class MoniisTest
	{
		[Test ()]
		public void TestLatteDraws ()
		{
			// ARRANGE //
			Point2D p 	= new Point2D();
			Latte l 	= new Latte(30);
			// ACT //
			l.Draw();
			p = SwinGame.PointAt(351, 351);
			// ASSERT //
			Assert.IsTrue(l.IsAt(p));
		}
	}
}


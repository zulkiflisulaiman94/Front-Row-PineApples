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
			p = SwinGame.PointAt(300, 300);
			l.Draw();
			// ASSERT //
			Assert.IsTrue(l.IsAt(p));
		}

		[Test ()]
		public void TestCapDraws ()
		{
			// ARRANGE //
			Point2D p 	= new Point2D();
			Capp c 	= new Capp(30);
			// ACT //
			c.Draw();
			p = SwinGame.PointAt(300, 300);
			// ASSERT //
			Assert.IsTrue(c.IsAt(p));
		}

		[Test ()]
		public void TestExtraShotDraws ()
		{
			// ARRANGE //
			Point2D p 	= new Point2D();
			ExtraShot es 	= new ExtraShot(30);
			// ACT //
			es.Draw();
			p = SwinGame.PointAt(300, 300);
			// ASSERT //
			Assert.IsTrue(es.IsAt(p));
		}

		[Test ()]
		public void TestSpiltDraws ()
		{
			// ARRANGE //
			Point2D p 	= new Point2D();
			SpiltCof sc 	= new SpiltCof(30);
			// ACT //
			sc.Draw();
			p = SwinGame.PointAt(300, 300);
			// ASSERT //
			Assert.IsTrue(sc.IsAt(p));
		}
	}
} 	


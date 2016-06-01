using System;
using SwinGameSDK;

namespace MyGame
{
	public class Capp : Coffee
	{
		public Capp (int t) : base(t)
		{
			cImg = SwinGame.LoadBitmapNamed("cappuccino", "cappuccino.png");
		}

		public override void Draw()
		{
			Point2D pt = SwinGame.PointAt(posX, posY);
			SwinGame.DrawBitmap(cImg, pt);
		}

		public override bool IsAt (Point2D pt)
		{
			return SwinGame.PointInRect(pt, posX, posY, (posX + 20), (posY + 20));
		}
	}
}


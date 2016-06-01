using System;
using SwinGameSDK;

namespace MyGame
{
	public class Latte : Coffee
	{
		public Latte (int t) : base(t,  350,  350)
		{
			cImg = SwinGame.LoadBitmapNamed("latte", "latte.png");
		}

		public override void Draw()
		{
			Point2D p = default (Point2D);
			p = SwinGame.PointAt (posX, posY);
			SwinGame.DrawBitmapOnScreen(cImg, p);	
		}
		public override bool IsAt(Point2D pt)
		{
			return SwinGame.PointInRect (pt ,posX, posY, (posX + 20), (posY + 20));
		}
	}
}


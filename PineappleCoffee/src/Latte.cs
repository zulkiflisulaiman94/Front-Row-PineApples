using System;
using SwinGameSDK;

namespace MyGame
{
	public class Latte : Coffee
	{
        private Bitmap _Cimg; 

		public Latte (int t) : base(t,  350,  350)
		{
			_Cimg = SwinGame.LoadBitmapNamed("latte", "latte.png");
		}

		public override void Draw()
		{
			Point2D p = default (Point2D);
			p = SwinGame.PointAt (posX, posY);
			SwinGame.DrawBitmapOnScreen(_Cimg, p);	
		}

		public override bool IsAt(Point2D pt)
		{
			return SwinGame.PointInRect (pt ,posX, posY, (posX + 20), (posY + 20));
		}
	}
}


using System;
using SwinGameSDK;

namespace MyGame
{
	public class SpiltCof : Coffee
	{
		public SpiltCof (int t) : base (t)
		{
			cImg = SwinGame.LoadBitmapNamed("spilt", "spilt.jpg");
		}

		public override void Draw()
		{
			Random rnd = new Random();
			posX = rnd.Next(400); 
			posY = rnd.Next(2, 450);

			Point2D pt = SwinGame.PointAt(posX, posY);
			SwinGame.DrawBitmap(cImg, pt);
		}

		public override bool IsAt (Point2D pt)
		{
			return SwinGame.PointInRect (pt ,posX, posY, (posX + 20), (posY + 20));
		}
	}
}


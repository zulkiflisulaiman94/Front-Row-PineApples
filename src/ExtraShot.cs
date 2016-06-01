using System;
using SwinGameSDK;

namespace MyGame
{
	public class ExtraShot : Coffee
	{
		public ExtraShot (int t) : base (t)
		{
			cImg = SwinGame.LoadBitmapNamed("extrashot", "extrashot.png");
		}

		public override void Draw()
		{
			Random rnd = new Random();
			posX = rnd.Next(500); 
			posY = rnd.Next(10, 450);

			Point2D pt = SwinGame.PointAt(posX, posY);
			SwinGame.DrawBitmap(cImg, pt);	
		}

		public override bool IsAt (Point2D pt)
		{
			return SwinGame.PointInRect (pt ,posX, posY, (posX + 20), (posY + 20));
		}
	}
}



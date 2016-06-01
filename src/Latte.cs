using System;
using SwinGameSDK;

namespace MyGame
{
	public class Latte : Coffee
	{
		public Latte (int t) : base(t)
		{
			cImg = SwinGame.LoadBitmapNamed("latte", "latte.png");
		}
			
		public override void Draw()
		{
			Random rnd = new Random();
			posX = rnd.Next(400); 
			posY = rnd.Next(2, 450);

			Point2D ptt = SwinGame.PointAt (posX, posY);
			SwinGame.DrawBitmap(cImg, ptt);	
		}

		public override bool IsAt (Point2D pt)
		{
			return SwinGame.PointInRect (pt ,posX, posY, (posX + 20), (posY + 20));
		}
	}
}


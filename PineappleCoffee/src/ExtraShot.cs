using System;
using SwinGameSDK;

namespace MyGame
{
	public class ExtraShot : Coffee
	{
		public ExtraShot (int t) : base (t,  350,  350, 3)
		{
			cImg = SwinGame.LoadBitmapNamed("extrashot", "extrashot.png");
		}

		public override void Draw()
		{
			Point2D pt = SwinGame.PointAt(posX, posY);
			SwinGame.DrawBitmap(cImg, pt);	
		}

        public override bool IsAt(Point2D pt)
        {
            if (pt.InRect(posX, posY, (posX + 100), (posY + 100)))
                return true;
            else
                return false;
        }
    }
}



using System;
using SwinGameSDK;

namespace MyGame
{
	public class Prizes
	{

		private int _score;


		public Prizes (int s)
		{
			_score = s;
		}

		public void returnPrize()
		{
			if ((int)_score < 50)
			{
				Text.DrawText ("Better luck next time!", Color.Black, 300, 250);
			}
			else if ((int)_score < 100)
			{
				Text.DrawText ("Buy one regular Coffee", Color.Black, 300, 250);
				Text.DrawText ("Get one free", Color.Black, 320, 300);
			}
			else if ((int)_score < 150)
			{
				Text.DrawText ("One free regular Coffee", Color.Black, 300, 250);
			}
		}
	}
}


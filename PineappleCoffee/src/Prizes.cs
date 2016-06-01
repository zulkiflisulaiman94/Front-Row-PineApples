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
			if ((int)_score < 500000)
			{
				Text.DrawText ("Better luck next time!", Color.Black, 300, 250);
			}
			else if ((int)_score < 1000000)
			{
				Text.DrawText ("Buy one regular Coffee", Color.Black, 300, 250);
				Text.DrawText ("Get one free", Color.Black, 320, 300);
			}
			else if ((int)_score < 1500000)
			{
				Text.DrawText ("One free regular Coffee", Color.Black, 300, 250);
			}
		}
	}
}


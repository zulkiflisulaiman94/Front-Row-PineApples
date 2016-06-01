using System;
using SwinGameSDK;

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
            //Open the game window
			SwinGame.OpenGraphicsWindow("GameMain", 800, 600);
			//SwinGame.ShowSwinGameSplashScreen();
			GameSounds.LoadSounds();
			GameBoard b = new GameBoard ();
			Timer t = SwinGame.CreateTimer();
			//int coffeeAmount = 1;
			int timeLeft = 120;
			int timerGameTimeConversion = 0;
			string scoreDisplay = " ";
			int currentTime = 0;

			t.Start ();
            
            //Run the game loop
            while(false == SwinGame.WindowCloseRequested())
			{

				//Clear the screen and draw the framerate
				SwinGame.ClearScreen(Color.White);

				if (timeLeft > 0)
				{
					currentTime = checked((int)SwinGame.TimerTicks (t));

					if (currentTime > timerGameTimeConversion)
					{
						timerGameTimeConversion = timerGameTimeConversion + 1000;
						timeLeft--;
					}

					string timeLeftDisply = "Time Remaining: " + timeLeft;
					Text.DrawText (timeLeftDisply, Color.Black, 50, 30);

					scoreDisplay = "Score: " + currentTime / 100;
					Text.DrawText (scoreDisplay, Color.Black, 600, 30);

					b.DrawImages ();

					int timeAjustment = 0;

					if (SwinGame.MouseClicked (MouseButton.LeftButton))
					{
						Audio.PlaySoundEffect (GameSounds._TheGameSound("Click_On"));
						float x = SwinGame.MouseX ();
						float y = SwinGame.MouseY ();

						Point2D p = SwinGame.PointAt (x, y);

						timeAjustment = (timeAjustment + b.HandleInput (p));
						b.DestroyImages ();

					}

					int coffeeAmount = b.CoffeeCount;
				

					b.CheckTTL(currentTime / 10000);

					while (coffeeAmount < 3)
					{
						
						b.AddImage((currentTime / 10000));
						coffeeAmount = b.CoffeeCount;
					}

			}
				else{
				t.Pause ();

				scoreDisplay = "Score: " + currentTime / 100;
				Text.DrawText (scoreDisplay, Color.Black, 300, 200);
				
					if ((int)currentTime < 500000)
					{
						Text.DrawText ("Better luck next time!", Color.Black, 300, 250);
						Audio.PlaySoundEffect (GameSounds._TheGameSound("Lose"));
					}
					else if ((int)currentTime < 1000000)
					{
						Text.DrawText ("Buy one regular Coffee", Color.Black, 300, 250);
						Text.DrawText ("Get one free", Color.Black, 320, 300);
						Audio.PlaySoundEffect (GameSounds._TheGameSound("Kids_Cheering"));
					}
					else if ((int)currentTime < 1500000)
					{
						Text.DrawText ("One free regular Coffee", Color.Black, 300, 250);
						Audio.PlaySoundEffect (GameSounds._TheGameSound("Kids_Cheering"));
					}	
				}
				//Latte l = new Latte (50);
				//l.Draw ();

				SwinGame.RefreshScreen(60);

				//Fetch the next batch of UI interaction
				SwinGame.ProcessEvents();

            }
			GameSounds.FreeSounds();
        }

    }
}
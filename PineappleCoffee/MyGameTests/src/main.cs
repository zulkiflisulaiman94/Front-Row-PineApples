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
            SwinGame.ShowSwinGameSplashScreen();

			GameBoard b = new GameBoard ();
			Timer t = SwinGame.CreateTimer();

			//int coffeeAmount = 1;
			int timeLeft = 60;
			int timerGameTimeConversion = 0;

			string scoreDisplay = " ";
			int currentTime = 0;

			t.Start ();
            
			Bitmap img;
			Bitmap img2;
			img = SwinGame.LoadBitmapNamed("ribbon", "ribbon.jpg");
			img2 = SwinGame.LoadBitmapNamed("bg", "bg.gif");

            //Run the game loop
            while(false == SwinGame.WindowCloseRequested())
            {
                //Fetch the next batch of UI interaction
                SwinGame.ProcessEvents();
                
                //Clear the screen and draw the framerate
                SwinGame.ClearScreen(Color.White);
				Point2D pointbg = new Point2D();
				pointbg.X = 0;
				pointbg.Y = 0;
				SwinGame.DrawBitmapOnScreen(img2, pointbg);
				Point2D pointR = new Point2D();
				pointR.X = 0;
				pointR.Y = 0;
				SwinGame.DrawBitmapOnScreen(img, pointR);
		
				if (timeLeft > 0)
				{
					currentTime = checked((int)SwinGame.TimerTicks (t));

					if (currentTime > timerGameTimeConversion)
					{
						timerGameTimeConversion = timerGameTimeConversion + 1000;
						timeLeft--;
					}

					string timeLeftDisply = "Time Remaining: " + timeLeft;
					Text.DrawText (timeLeftDisply, Color.White, 50, 30);

					scoreDisplay = "Score: " + currentTime / 100;
					Text.DrawText (scoreDisplay, Color.White, 600, 30);

					b.DrawImages ();

					int timeAjustment = 0;

					if (SwinGame.MouseClicked (MouseButton.LeftButton))
					{
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

					Prizes p = new Prizes ((int)currentTime);
					p.returnPrize ();


				}
				//Latte l = new Latte (50);
				//l.Draw ();
                SwinGame.RefreshScreen(60);
            }
        }
    }
}
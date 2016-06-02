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
			GameSounds.LoadSounds();
			GameBoard b = new GameBoard ();
			Timer t = SwinGame.CreateTimer();
            ScoreControler s = new ScoreControler();

            //int coffeeAmount = 1;
            int timeLeft = 5;
			int timerGameTimeConversion = 0;

			string scoreDisplay = " ";
			int currentTime = 0;

			t.Start ();
            
			Bitmap img;
			Bitmap img2;
			img = SwinGame.LoadBitmapNamed("ribbon", "ribbon.jpg");
			img2 = SwinGame.LoadBitmapNamed("bg", "bg.gif");
            int tl = 0;
            //Run the game loop
			Audio.PlaySoundEffect (GameSounds._TheGameSound("Ta_Da"));
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
                    
					scoreDisplay = "Score: " + s.FetchScore();
					Text.DrawText (scoreDisplay, Color.White, 600, 30);
                    
                                        b.DrawImages ();
                        


                    if (SwinGame.MouseDown(MouseButton.LeftButton))
					{
						Audio.PlaySoundEffect (GameSounds._TheGameSound("Button"));
						float x = SwinGame.MouseX ();
						float y = SwinGame.MouseY ();

						Point2D p = SwinGame.PointAt (x, y);

					    int scoreAd = 0;
					 	scoreAd = scoreAd + b.HandleInput(p);
                        s.add(scoreAd);

                        b.DestroyImages();
                        b.Empty();
					}


				    
					b.CheckTTL(timeLeft);

					while (b.CoffeeCount < 3)
					{
						
						b.AddImage(timeLeft - 3);
					
					}

			}
				else{
					t.Pause ();

					scoreDisplay = "Score: " + s.FetchScore();
                    Text.DrawText (scoreDisplay, Color.Black, 300, 200);

					Prizes p = new Prizes (s.FetchScore());
					p.returnPrize ();
				}
				//Latte l = new Latte (50);
				//l.Draw ();
                SwinGame.RefreshScreen(60);

            }

			GameSounds.FreeSounds();
        }
    }
}
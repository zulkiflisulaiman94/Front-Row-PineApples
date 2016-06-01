using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace MyGame
{
	public class GameBoard
	{
		private List<Coffee> _Coffee;
		private List<Coffee> _DCoffee;

		public GameBoard ()
		{
			_Coffee = new List<Coffee>();
			_DCoffee = new List<Coffee>();
		}

		//draw images or background image?
		public void DrawImages()
		{
			foreach (Coffee cf in _Coffee)
			{
			cf.Draw();
			}
			SwinGame.Delay(1000);
		}

		//heavy lifting
		public int HandleInput(Point2D pt)
		{
			//checks if there's an object at the mouse position mouse position
			//if true/false, remove image, plays music, add scores
			int v = 0;
			/*
			foreach (Coffee cf in _Coffee)
			{
				
			if (cf.IsAt (pt) == true)
			{
					v = v + cf.Value;
					AddDest (cf);

				}
			
			}
*/
			return v;


		}

		public void DestroyImages()
		{
			foreach(Coffee cf in _DCoffee)
			{
				_Coffee.Remove (cf);
			}
		}

		public void Empty()
		{
			_DCoffee.Clear ();
		}

		public void AddDest(Coffee cf)
		{
			_DCoffee.Add (cf);
		}

		public void AddImage(int i)
		{

			Latte la = new Latte(i); 
			Capp cf = new Capp(i);
			ExtraShot bl = new ExtraShot(i);
			SpiltCof sc = new SpiltCof(i);
			_Coffee.Add(cf);
			_Coffee.Add(la);
			_Coffee.Add(bl);
			_Coffee.Add(sc);
		}

		public int CoffeeCount
		{
			get
			{
				return _Coffee.Count;
			}
		}

		public void CheckTTL(int i)
		{
			foreach (Coffee cf in _Coffee)
			{
				if (cf.TTL > i)
					AddDest (cf);
			}
		}
	}
}


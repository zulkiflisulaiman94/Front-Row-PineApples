using System;
using SwinGameSDK;

namespace MyGame
{

	public abstract class Coffee
	{
		// FIELDS //
		private float _x;
		private float _y;
		private Bitmap _img; 
		private int _ttl;
		private int _value;


		public Coffee(int t, float pX, float pY, int v)
		{
			Random rnd = new Random();
			_ttl = t;
			_x = rnd.Next(690);
			_y = rnd.Next(50, 450);
		    _value = v;
		}


		// FIELDS //

		// PROPERTIES //
		public float posX
		{
			get { return _x; }
			set { _x = value; }
		}

		public float posY
		{
			get { return _y; }
			set { _y = value; }
		}

		public Bitmap cImg
		{
			get { return _img; }
			set { _img = value; }
		}

		public int TTL
		{
			get { return _ttl; }
			set { _ttl = value; }
		}
		public int Value
		{
			get { return _value; }
			set { _value = value; }
		}
		// PROPERTIES //

		public Coffee ()
		{
			_x = posX;
			_y = posY;
			_img = cImg;
		}			

		public abstract void Draw();

		public abstract bool IsAt(Point2D pt);

		//public int Return ();
		//{
		//
		//}
	}
}


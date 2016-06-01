using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGame
{
    public class ScoreControler
    {
        private int _score;
   

    public ScoreControler()
    {
        _score = 1;
    }

        public int FetchScore()
        {
            return _score;
        }

        public void add(int i)
        {
            _score = _score + i;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTest
{
    internal class PlayerBuilder : IPlayerBuilder
    {
        private Point mPos;
        private int mScore;
        private string mIcon;
        public IPlayerBuilder SetPos(Point point)
        {
            this.mPos = point;
            return this;
        }
        public IPlayerBuilder SetX(int x)
        {
            this.mPos.X = x;
            return this;
        }
        public IPlayerBuilder SetY(int y)
        {
            this.mPos.Y = y;
            return this;
        }
        public IPlayerBuilder SetScore(int score)
        {
            this.mScore = score;
            return this;
        }
        public IPlayerBuilder SetIcon(string icon)
        {
            mIcon = icon;
            return this;
        }
        public Player GetPlayer()
        {
            return new Player(mPos, mScore, mIcon);
        }
    }
}

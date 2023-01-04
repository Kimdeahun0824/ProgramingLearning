using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTest
{
    public class Item
    {
        private Point mPos;
        private int mScore;
        private string mIcon;
        public Item()
        {
            mPos = new Point();
            mScore = 0;
            mIcon = string.Empty;
        }
        public Item(Point Pos, int Score, string Icon)
        {
            mPos = Pos;
            mScore = Score;
            mIcon = Icon;
        }
        public void Update(object obj)
        {
            if ((Point)obj == mPos)
            {

            }
        }
        public Point Pos
        {
            get { return mPos; }
            set { mPos = value; }
        }
        public int Score
        {
            get { return mScore; }
            set { mScore = value; }
        }
        public string Icon
        {
            get { return mIcon; }
            set { mIcon = value; }
        }
    }
}

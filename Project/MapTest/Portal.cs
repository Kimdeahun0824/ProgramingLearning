using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTest
{
    public class Portal
    {
        private Point mPos;
        private Point mNextPos;
        private string mIcon;
        private int mNextIdx;
        public Portal()
        {
            mPos = new Point();
            mNextPos = new Point();
            mIcon = string.Empty;
            mNextIdx = 0;
        }
        public Portal(Point Pos, Point NextPos,  int NextIdx)
        {
            mPos = Pos;
            mNextPos = NextPos;
            mIcon = "＠";
            mNextIdx = NextIdx;
        }
        public Point Pos
        {
            get { return mPos; }
            set { mPos = value; }
        }
        public Point NextPos
        {
            get { return mNextPos; }
            set { mNextPos = value; }
        }
        public string Icon
        {
            get { return mIcon; }
            set { mIcon = value; }
        }
        public int NextIdx
        {
            get { return mNextIdx; }
            set { mNextIdx = value; }
        }
    }
}

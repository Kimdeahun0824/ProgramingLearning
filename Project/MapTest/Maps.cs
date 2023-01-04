using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTest
{
    public class Maps
    {
        private int mWidth;
        private int mHeight;
        private List<Item> mItems;
        private List<Portal> mPortals;
        public Maps()
        {
            mWidth = 0;
            mHeight = 0;
            mItems = new List<Item>();
            mPortals = new List<Portal>();
        }
        public Maps(int Width, int Height)
        {
            mWidth = Width;
            mHeight = Height;
            mItems= new List<Item>();
            mPortals = new List<Portal>();
        }
        public void PortalsCreate(Point Pos1, Point Pos2, int NextIdx)
        {
            Portal portal = new Portal(Pos1,Pos2,NextIdx);
            mPortals.Add(portal);
        }
        public int Width
        {
            get { return mWidth; }
            set { mWidth = value; }
        }
        public int Height
        {
            get { return mHeight; }
            set { mHeight = value; }
        }
        public List<Item> Items
        {
            get { return mItems; }
            set { mItems = value; }
        }
        public List<Portal> Portals
        {
            get { return mPortals; }
            set { mPortals = value; }
        }
    }
}

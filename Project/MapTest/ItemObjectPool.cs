using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MapTest
{
    public class ItemObjectPool
    {
        private Stack<Item> mItems;
        public ItemObjectPool()
        {
            mItems = new Stack<Item>();

            for (int i = 0; i < 100; i++)
            {
                mItems.Push(new Item(new System.Drawing.Point(-1, -1), 100, "★"));
            }
        }
        public Item ItemPop(int x, int y)
        {
            Item item = mItems.Pop();
            item.Pos = new Point(x, y);
            return item;
            //return ref mItems;
        }
        public void ItemPush(Item item)
        {
            item.Pos = new Point(-1, -1);
            mItems.Push(item);
            Console.WriteLine("Stack Size : {0}",mItems.Count);
        }
        public Stack<Item> Items
        {
            get { return mItems; }
            set { mItems = value; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeinAdventure
{
    internal class Item
    {
        private string ITEMNAME_;
        private string ITEMINFO_;
        private int FIGHTINGPOWER_;

        public Item(string itemName, string itemInfo, int fightingPower)
        {
            ITEMNAME_ = itemName;
            ITEMINFO_ = itemInfo;
            FIGHTINGPOWER_ = fightingPower;
        }

        public string getItemName_()
        {
            return ITEMNAME_;
        }
        public string getItemInfo()
        {
            return ITEMINFO_;
        }
        public int getFightingPower()
        {
            return FIGHTINGPOWER_;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeinAdventure
{
    internal class Item
    {
        private string mItemName;
        private string mItemInfo;
        private int mItemFightingPower;

        public Item(string ItemName, string ItemInfo, int ItemFightingPower)
        {
            this.mItemName = ItemName;
            this.mItemInfo = ItemInfo;
            this.mItemFightingPower = ItemFightingPower;
        }

        //#################################### Getter / Setter ####################################
        public string GetItemName()
        {
            return this.mItemName;
        }
        public string GetItemInfo()
        {
            return this.mItemInfo;
        }
        public int GetItemFightingPower()
        {
            return this.mItemFightingPower;
        }

        public void SetItemName(string ItemName)
        {
            this.mItemName = ItemName;
        }
        public void SetItemInfo(string ItemInfo)
        {
            this.mItemInfo = ItemInfo;
        }
        public void SetItemFightingPower(int ItemFightingPower)
        {
            this.mItemFightingPower = ItemFightingPower;
        }

        
    }
}

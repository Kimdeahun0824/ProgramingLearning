using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LifeinAdventure
{
    internal class Inventory
    {
        private List<Item> mItem = new List<Item>();

        public void ItemAdd(Item item)
        {
            this.mItem.Add(item);
        }

        public string GetItemName(int index)
        {
            return this.mItem[index].GetItemName();
        }
        public string GetItemInfo(int index)
        {
            return this.mItem[index].GetItemInfo();
        }
        public int GetItemFightingPower(int index)
        {
            return this.mItem[index].GetItemFightingPower();
        }
        
        public void SetItemName(int index, string itemName)
        {
            this.mItem[index].SetItemName(itemName);
        }
        public void SetItemInfo(int index, string itemInfo)
        {
            this.mItem[index].SetItemInfo(itemInfo);
        }
        public void SetItemFightingPower(int index, int fightingPower)
        {
            this.mItem[index].SetItemFightingPower(fightingPower);
        }
    }
}

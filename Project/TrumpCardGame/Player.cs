using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpCardGame
{
    internal class Player
    {
        private int mMoney;
        private Card mCard;

        public Player(int money)
        {
            mMoney = money;
        }

        public int Betting()
        {
            int userBettingMoney;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out userBettingMoney))
                {
                    if (mMoney < userBettingMoney)
                    {
                        Console.WriteLine("소지한 금액만큼만 배팅하실 수 있습니다. 호갱님");
                        continue;
                    }
                    else
                    {
                        mMoney -= userBettingMoney;
                        return userBettingMoney;
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        public int Money
        {
            get { return mMoney; }
            set { mMoney = value; }
        }

        public Card Card
        {
            get { return mCard; }
            set { mCard = value; }
        }
    }
}

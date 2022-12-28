using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsClass
{
    internal class RSPGame
    {
        public enum mEnumRSP
        {
            NONE, SCISSORS, ROCK, PAPER
        }
        private mEnumRSP[] mRSP;
        public RSPGame()
        {
            mRSP = new mEnumRSP[3];
            for (int i = 1; i < mRSP.Length; i++)
            {
                mRSP[i] = (mEnumRSP)i;
            }
            for (int i = 0; i < 100; i++)
            {
                mRSP = shuffle(mRSP);
            }
            Console.WriteLine("가위:1\n바위:2\n보:3");
        }


        public mEnumRSP[] GetRSP()
        {
            return mRSP;
        }

        public void UserSelect(int select)
        {
            if (mRSP[0] == (mEnumRSP)select)
            {
                Console.WriteLine("DRAW");
            }
            else if (mRSP[0] == mEnumRSP.PAPER)
            {
                if ((mEnumRSP)select == mEnumRSP.SCISSORS)
                {
                    Console.WriteLine("WIN");
                }
                else
                {
                    Console.WriteLine("LOSE");
                }
            }
            else if (mRSP[0] < (mEnumRSP)select)
            {
                Console.WriteLine("WIN");
            }
            else if (mRSP[0] > (mEnumRSP)select)
            {
                Console.WriteLine("LOSE");
            }


        }

        public mEnumRSP[] shuffle(mEnumRSP[] rsp)
        {
            Random random = new Random();
            int sourIdx = random.Next(mRSP.Length - 1);
            int destIdx = random.Next(mRSP.Length - 1);
            mEnumRSP temp = mRSP[sourIdx];
            mRSP[sourIdx] = mRSP[destIdx];
            mRSP[destIdx] = temp;
            return mRSP;
        }

    }


}

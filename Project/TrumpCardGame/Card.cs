using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpCardGame
{
    internal class Card
    {
        private string mName;
        private string mMark;
        private int mNumber;

        public Card()
        {
            mName = string.Empty;
            mMark = string.Empty;
            mNumber= 0;
        }
        public Card(string name, string mark, int number)
        {
            mName= name;
            mMark= mark;
            mNumber= number;
        }


        public int Number
        {
            get { return mNumber; }
            set { mNumber = value; }
        }

        public string Mark
        {
            get { return mMark; }
            set { mMark = value; }
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }






    }
}

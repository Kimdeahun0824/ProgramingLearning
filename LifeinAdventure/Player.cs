using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeinAdventure
{
    internal class Player
    {
        private int HP_;
        private int MP_;

        private int STRONG_;
        private int AGILITY_;
        private int INTELLIGENCE_;
        private int WISDOM_;
        private int CHARISMA_;
        private int HEALTH_;


        public Player(int Hp, int Mp, int Strong, int Agility, int Intelligence, int Wisdom, int Charisma, int Health)
        {
            HP_ = Hp;
            MP_ = Mp;
            STRONG_ = Strong;
            AGILITY_ = Agility;
            INTELLIGENCE_ = Intelligence;
            WISDOM_ = Wisdom;
            CHARISMA_ = Charisma;
            HEALTH_ = Health;
        }


        public void setHp(int HP)
        {
            HP_ = HP;
        }
        public void setMp(int MP)
        {
            MP_ = MP;
        }
        public void setStrong(int Strong)
        {
            STRONG_ = Strong;
        }
        public void setAgility(int Agility)
        {
            AGILITY_ = Agility;
        }
        public void setIntelligence(int Intelligence)
        {
            INTELLIGENCE_ = Intelligence;
        }
        public void setWisdom(int Wisdom)
        {
            WISDOM_ = Wisdom;
        }
        public void setCharisma(int Charisma)
        {
            CHARISMA_ = Charisma;
        }
        public void setHealth(int Health)
        {
            HEALTH_ = Health;
        }

        public int getHp()
        {
            return HP_;
        }
        public int getMp()
        {
            return MP_;
        }
        public int getStrong()
        {
            return STRONG_;
        }
        public int getAgility()
        {
            return AGILITY_;
        }
        public int getIntelligence()
        {
            return INTELLIGENCE_;
        }
        public int getWisdom()
        {
            return WISDOM_;
        }
        public int getCharisma()
        {
            return CHARISMA_;
        }
        public int getHealth()
        {
            return HEALTH_;
        }



    }
}

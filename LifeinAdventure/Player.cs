using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeinAdventure
{
    internal class Player
    {
        private int mHp;
        private int mMp;

        private int mStrong;
        private int mAgility;
        private int mIntelligence;
        private int mWisdom;
        private int mCharisma;
        private int mHealth;

        public Player(int Hp, int Mp, int Strong, int Agility, int Intelligence, int Wisdom, int Charisma, int Health)
        {
            mHp = Hp;
            mMp = Mp;
            mStrong = Strong;
            mAgility = Agility;
            mIntelligence = Intelligence;
            mWisdom = Wisdom;
            mCharisma = Charisma;
            mHealth = Health;
        }

        public int GetHp()
        {
            return mHp;
        }
        public int GetMp() { return mMp; }
        public int GetStrong() { return mStrong; }
        public int GetAgility() { return mAgility; }
        public int GetIntelligence() { return mIntelligence; }
        public int GetWisdom() { return mWisdom; }
        public int GetCharisma() { return mCharisma; }
        public int GetHealth() { return mHealth; }

        public void SetHp(int hp) { mHp = hp; }
        public void SetMp(int mp) { mMp = mp; }
        public void SetStrong(int strong) { mStrong = strong; }
        public void SetAgility(int agility) { mAgility = agility; }
        public void SetIntelligence(int intelligence) { mIntelligence = intelligence; }
        public void SetWisdom(int wisdom) { mWisdom = wisdom; }
        public void SetCharisma(int charisma) { mCharisma = charisma; }
        public void SetHealth(int health) { mHealth = health; }

        public void HpDamage(int damage)
        {
            mHp -= damage;
        }
        public void MpDamage(int damage)
        {
            mMp -= damage;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LifeinAdventure
{
    internal class MainScene
    {
        Player player;
        string playerInfo;
        public MainScene(Random rand)
        {
            player = new Player(rand.Next(3, 5), rand.Next(3, 5), rand.Next(7, 15), rand.Next(7, 15), rand.Next(7, 15), rand.Next(7, 15), rand.Next(7, 15), rand.Next(7, 15));
            playerInfo = $"체  력 : {player.getHp()}             힘 : {player.getStrong()} 민첩 : {player.getAgility()} 지능 : {player.getIntelligence()}\n" +
                         $"정신력 : {player.getMp()}       카리스마 : {player.getCharisma()} 건강 : {player.getHealth()} 지혜 : {player.getWisdom()}\n";
        }
        public MainScene()
        {

        }

        public string getPlayerInfo()
        {
            return playerInfo;
        }


    }
}

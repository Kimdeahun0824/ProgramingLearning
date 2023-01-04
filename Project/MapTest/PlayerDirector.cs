using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTest
{
    internal class PlayerDirector
    {
        private PlayerBuilder playerBuilder;
        public PlayerDirector(PlayerBuilder playerBuilder)
        {
            this.playerBuilder = playerBuilder;
        }
        public Player GetDefaultPlayer()
        {
            return playerBuilder.SetPos(new System.Drawing.Point(1, 1)).SetScore(0).SetIcon("◈").GetPlayer(); ;
        }
        public Player GetDefaultPlayerPos(Point pos)
        {
            return playerBuilder.SetPos(pos).SetScore(0).SetIcon("◈").GetPlayer(); ;
        }
    }
}

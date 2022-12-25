using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeinAdventure
{
    internal class MainScene
    {
        public MainScene(Random rand)
        {
            Player player = new Player(rand.Next(3,5), rand.Next(3,5), rand.Next(7,15), rand.Next(7, 15), rand.Next(7, 15), rand.Next(7, 15), rand.Next(7, 15), rand.Next(7, 15));
            Inventory inventory = new Inventory();
        }

    }
}

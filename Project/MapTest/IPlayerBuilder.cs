using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTest
{
    internal interface IPlayerBuilder
    {
        IPlayerBuilder SetPos(Point point);
        IPlayerBuilder SetX(int x);
        IPlayerBuilder SetY(int y);
        IPlayerBuilder SetScore(int score);
        IPlayerBuilder SetIcon(string icon);
        Player GetPlayer();
    }
}

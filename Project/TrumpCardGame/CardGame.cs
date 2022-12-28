using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpCardGame
{
    abstract class CardGame
    {
        protected abstract void CardSetup();
        protected abstract void CardShuffle();
        protected abstract Card CardDraw();
        protected abstract void CardGamePlay();
    }
}

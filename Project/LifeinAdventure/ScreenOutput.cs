using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeinAdventure
{
    internal class ScreenOutput
    {
        public void Screen(string text)
        {
            Console.Write(text);
        }

        public void ScreenClear()
        {
            Console.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeinAdventure
{
    internal class TitleScene
    {
        private string titleText;
        public TitleScene()
        {
            titleText = "============================\n" +
                    "**      모험가 이야기     **\n" +
                    "============================\n" +
                    "\n\n\n\n\n\n" +
                    "        Tap To Start        ";

        }

        public bool TapToStart()
        {

            if (Console.ReadLine() != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getTitleText()
        {
            return titleText;
        }

    }
}
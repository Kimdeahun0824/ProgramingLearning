using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeinAdventure
{
    internal class TitleScene
    {
        private string mTitle;
        public TitleScene() {
            mTitle = "===============================================\n" +
                                "**               모험가 이야기               **\n" +
                                "===============================================\n" +
                                "\n\n\n\n\n\n" +
                                "                 Tap To Start                 \n";
        }

        public string getTitle()
        {
            return mTitle;
        }
    }
}

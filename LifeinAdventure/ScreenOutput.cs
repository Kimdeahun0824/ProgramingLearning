using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeinAdventure
{
    internal class ScreenOutput
    {
        public ScreenOutput()
        {
        }

        public void screenOutPut(string outputText)
        {
            Console.WriteLine(outputText);
        }

        public void screenClear()
        {
            Console.Clear();
        }
    }
}

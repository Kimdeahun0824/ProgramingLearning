using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeinAdventure
{
    internal class userInput
    {
        ConsoleKeyInfo mInput;
        public ConsoleKey getInput()
        {
            mInput = Console.ReadKey(true);
            return mInput.Key;
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MapTest
{
    public class KeyManager
    {
        private static KeyManager mInstance = null;
        private static readonly object obj = new object();
        private ConsoleKeyInfo mConsoleKeyInfo;
        private KeyManager()
        {

        }
        public static KeyManager Instance
        {
            get
            {
                lock (obj)
                {
                    if(mInstance == null)
                    {
                        mInstance = new KeyManager();
                    }
                    return mInstance;
                }
            }
        }
        public ConsoleKey UserInput()
        {
            mConsoleKeyInfo = Console.ReadKey();
            return mConsoleKeyInfo.Key;
        }
    }
}

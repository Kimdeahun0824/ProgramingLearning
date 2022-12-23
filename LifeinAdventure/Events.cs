using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeinAdventure
{
    internal class Events
    {
        string[] EVENTLOGS_;
        string[] EVENTCHOICES_;
        int[] PROBABILITYOFSUCCESS_;
        int[] CHOICENUM_;

        public Events(string[] eventLogs, string[] eventChoices, int[] probabilityOfSuccess, int[] choiceNum)
        {
            EVENTLOGS_ = eventLogs;
            EVENTCHOICES_ = eventChoices;
            PROBABILITYOFSUCCESS_ = probabilityOfSuccess;
            CHOICENUM_ = choiceNum;
        }

        public bool eventChoice(Random rand, int ChoiceNum, int index)
        {
            
            return true;
        }

        private bool eventSuccess(Random rand, int index)
        {
            if (rand.Next(101) <= PROBABILITYOFSUCCESS_[index])
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public string eventLogsOutPut(int index)
        {
            return EVENTLOGS_[index];
        }
        public string eventChoiceOutPut(int index)
        {
            return EVENTCHOICES_[index];
        }
        public bool eventNextEvent(int index)
        {
            if (EVENTLOGS_.Length > index )
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public string[] getEventLogs_()
        {
            return EVENTLOGS_;
        }
        public string[] getChoiceLogs_()
        {
            return EVENTCHOICES_;
        }

    }
}

using System;
using System.Diagnostics.Tracing;

namespace LifeinAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Events[] events = new Events[5];
            ScreenOutput screen = new ScreenOutput();
            TitleScene titleScne = new TitleScene();
            MainScene mainScene = new MainScene(rand);


            screen.screenOutPut(titleScne.getTitleText());

            if (titleScne.TapToStart())
            {
                titleScne = null;
                screen.screenClear();
                screen.screenOutPut(mainScene.getPlayerInfo());
            }
            else
            {
                /* Do Nothing */
            }

            events = eventCreate();

            screen.screenOutPut(events[0].eventLogsOutPut(0));
            screen.screenOutPut(events[0].eventChoiceOutPut(0));
            
            if(Convert.ToInt32(Console.ReadLine())==1)
            {
                Console.Clear();
                screen.screenOutPut(mainScene.getPlayerInfo());
                Console.WriteLine();
                screen.screenOutPut(events[1].eventLogsOutPut(0));
                screen.screenOutPut(events[1].eventChoiceOutPut(0));
            }

            if (events[0].eventNextEvent(1))
            {
                screen.screenClear();
            }



        }
        static public Events[] eventCreate()
        {
            Events[] events = new Events[5];
            string[] event1Log = {"<위대한 모험가를 꿈꾸는>\n\n" +
                                "웅장한 나팔소리와 함께 한 사람이 단상으로 올라갔다.\n" +
                                "그 사람은 왕의 앞에 천천히 무릎을 꿇었다.\n" +
                                "\"자네의 모험을 온 국민이 기억할걸세. 모두 보아라! 이 자가 이 나라의 영웅이다!\n" +
                                "왕의 외침과 함께 관중들의 환호가 터져나왔다.\n" +
                                "당신은 그날부터, 아버지의 밭을 이어받는게 아니라, 명예로운 모험가가 되겠다는 꿈을 꾸었다. \n" +
                                "몇 녀의 세월이 흘렀지만 그 기억은 여전히 당신에게 남아, 모험을 떠나도록 만들었다.\n"};
            string[] event1Choice = { "1.모험을 계속한다" };
            int[] event1ChoiceNum = { 1 };
            int[] event1ChoiceProbability = { 100 };


            string[] event2Log = {"강을 따라 걷던 당신에게 한 남성이 헐레벌떡 달려왔다.\n"+
                                    "그는 거친 숨을 몰아쉬며 부탁할 것이 있다고 했다.\n\n"+
                                    "\"헉...헉...모험가님유... 제발 좀 도와주셔유...\"\n\n"+
                                    "그의 말에 따르면, 사하긴들이 나타나 그의 그물과 낚싯배를 부쉈고,\n"+
                                    "그는 겨우 그들에게서 도망쳤다고 했다. 그래서 그는 삶의 터전을 되찾을 수 있게 도와달라고 했다.\n",

                                    "당신은 그의 부탁을 들어주기로 했다. 그를 따라 해변의 허름한 집으로 향했다.\n"+
                                    "그곳에는 박살난 낚싯배와 그물만이 남아 있었다. 그는 주변을 둘러보며 말했다.\n",

                                    "\"보...보상이유? 돈이라면 조금 있...있슈\"+\n" +
                                    "그는 난색을 표하며 더듬더듬 말했다. 그리고는 주머니에서 골드 몇닢을 꺼내 당신에게 보여주었다.\n"+
                                    "그는 이것이 전부라고 말했다. 당신이 살짝 인상을 쓰자,\n"+
                                    "그는 당신에게 돈을 건내주고 의뢰를 완료하면 나중에 더 주겠노라 약속했다.",

                                    "당신은 그의 부탁을 들어자기로 했다.\n"+
                                    "그를따라 해변의 허름한 집으로 향했다. 그곳에는 박살난 낚싯배와 그물만이 남아 있었다.\n"+
                                    "그는 주변을 둘러보며 말했다.\n"+
                                    "\"아이고... 아무래도 늦었나봐유... 하지만 놈들이 필시 또 올거구만유.\n"+
                                    "미끼를 놓고 기다리는게 어때유?\""};



            string[] event2Choice = { "1.보상에 대해 말해보자", "2.그를 도와준다", "3.거절한다", "1.그를 도와준다" };
            int[] event2ChoiceProbability = { 50, 100, 100 };
            int[] event2ChoiceNum = { 3,1 };


            events[0] = new Events(event1Log, event1Choice, event1ChoiceProbability, event1ChoiceNum);
            events[1] = new Events(event2Log, event2Choice, event2ChoiceProbability, event2ChoiceNum);


            return events;

        }

        static public void itemCreate()
        {

        }
    }
}
using System;
using System.Diagnostics.Tracing;

namespace LifeinAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            ScreenOutput screen = new ScreenOutput();
            userInput userInput = new userInput();
            TitleScene titleScene= new TitleScene();
            screen.Screen(titleScene.getTitle());
            if(userInput.getInput() != ConsoleKey.Escape)
            {
                screen.ScreenClear();
            }
            else
            {
                screen.Screen("\n                 프로그램 종료                 \n");
            }

            MainScene mainScene = new MainScene(rand);
        }
    }
}
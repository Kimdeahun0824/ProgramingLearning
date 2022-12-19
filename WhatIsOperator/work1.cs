using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsOperator
{
    internal class work1
    {
        static void Main() 
        {

            //Lab 1 최대 한도의 사탕사기
            //현재 1000원이 있고 사탕의 가격이 300원 일 때 최대 살 수 있는 사탕의 개수와 나머지 돈은 얼마인지 출력하는 프로그램
            //      ex)
            //      현재 가지고 있는 돈 : 1000  (유저 인풋)
            //      캔디의 가격 : 300           (상수) 
            //      최대로 살 수 있는 캔디의 개수 = 3
            //      캔디 구입 후 남은 돈 = 100
            int money = 0;
            int candyPrice = 300;
            Console.Write("현재 가지고 있는 돈 : ");
            int.TryParse(Console.ReadLine(), out money);
            Console.Write("최대로 살 수 있는 캔디의 개수 = {0}개\n캔디 구입 후 남은 돈 = {1}\\\n", money / candyPrice, money % candyPrice);

            //Lab 2 화씨온도를 섭씨온도로 바꾸기
            //      우리나라는 섭씨온도를 사용하지만, 미국에서는 화씨 온도를 사용한다.
            //      화씨 온도를 섭씨 온도로 바꾸는 프로그램을 작성
            //      ex)
            //      화씨온도 60도는 섭씨온도 ??? 입니다.
            double fahrenheitTemperature = 0;
            double celsiusTemperature = 0;
            Console.Write("화씨 온도 : ");
            double.TryParse(Console.ReadLine(), out fahrenheitTemperature);
            celsiusTemperature = (fahrenheitTemperature - 32) * 5.0f / 9.0f;
            Console.Write("화씨 온도 {0}도는 섭씨온도 {1}도 입니다.\n", fahrenheitTemperature, celsiusTemperature);


            //Lab 3 주사위 게임
            //      2개의 주사위를 던져서 주사위의 합을 표시하는 프로그램을 작성, 주사위를 던지면 랜덤한 수가 나와야 한다.
            //      ex)
            //      첫 번째 주사위 : 
            //      두 번째 주사위 : 
            //      두 주사위의 합 :

            Random randNum = new Random();
            int dice1, dice2 = 0;
            dice1 = randNum.Next(5) + 1;
            dice2 = randNum.Next(5) + 1;
            Console.WriteLine("첫 번째 주사위 : {0}", dice1);
            Console.WriteLine("두 번째 주사위 : {0}", dice2);
            Console.WriteLine("두 주사위의 합 : {0}", dice1 + dice2);
        }
    }
}

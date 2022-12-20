using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 선택문인 Switch 문은 값에 따라 다양한 제어를 처리할 수 있다. 조건을 처리할 내용이 많은 경우 유용하다.
             * switch, case, default 키워드를 사용하여 조건을 처리한다.
             **/

            //Console.Write("정수 1, 2, 3 중에 하나를 입력하시오 : ");
            //int switchNumber = 0;
            //int.TryParse(Console.ReadLine(), out switchNumber);

            //switch (switchNumber)
            //{
            //    case 1:
            //        Console.WriteLine("1을(를) 입력했습니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("2을(를) 입력했습니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("3을(를) 입력했습니다.");
            //        break;
            //    default:
            //        Console.WriteLine("처리하지 않은 예외 입력입니다.");
            //        break;
            //}// switch()

            /**
             * 02.5 중간점검
             * 1. case 절에서 break 문을 생략하면 어떻게 되는가?
             * case 절에 break문이 빠지면 break문을 만날때까지 코드를 실행함
             **/

            //Console.WriteLine("가장 좋아하는 프로그래밍 언어는?");
            //Console.WriteLine("1. C\t");
            //Console.WriteLine("2. C++\t");
            //Console.WriteLine("3. C#\t");
            //Console.WriteLine("4. JAVA\t");

            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("C 선택");
            //        break;
            //    case 2:
            //        Console.WriteLine("C++ 선택");
            //        break;
            //    case 3:
            //        Console.WriteLine("C# 선택"); 
            //        break;
            //    case 4:
            //        Console.WriteLine("JAVA 선택");
            //        break;
            //    default:
            //        Console.WriteLine("예외");
            //        break;
            //}   //switch

            //Console.WriteLine("오늘의 날씨는 어떤가요? (맑음, 흐림, 비, 눈...)");
            //string weather = Console.ReadLine();

            //switch (weather)
            //{
            //    case "맑음":
            //        Console.WriteLine("오늘의 날씨는 맑군요.");
            //        break;
            //    case "흐림":
            //        Console.WriteLine("오늘의 날씨는 흐리군요.");
            //        break;
            //    case "비":
            //        Console.WriteLine("오늘의 날씨는 비가 오는군요.");
            //        break;
            //    case "눈":
            //        Console.WriteLine("오늘의 날씨는 눈이 오는군요.");
            //        break;
            //    default:
            //        Console.WriteLine("예외");
            //        break;
            //}   //switch


            /**
             * while문은 조건식이 참일 동안 문장을 반복 실행한다.
             */

            //while 문은 반복문인데 5번 실행할 예정
            //int loopCounter = 0;
            //while (loopCounter < 5)
            //{
            //    Console.WriteLine("loopCounter : {0}", loopCounter);
            //    loopCounter++;
            //}   //while

            ////10~1 카운트 후 발사 출력하는 프로그램 작성
            //loopCounter = 10;
            //while (loopCounter > 0)
            //{
            //    Console.WriteLine("{0}", loopCounter);
            //    loopCounter--;
            //}   //while
            //Console.WriteLine("발사");

            //예제 #1 - 구구단 출력하는 프로그램 작성. User Input 받아서 해당 단을 출력
            //int userGugudan = 0;
            //Console.Write("구구단 중에서 출력하고 싶은 단 입력 : ");
            //int.TryParse(Console.ReadLine(), out userGugudan);

            //const int GUGU_LOOP_COUNT = 9;
            //int guguLoopIdx = 1;

            //while(guguLoopIdx <= GUGU_LOOP_COUNT) 
            //{
            //    Console.WriteLine("{0}*{1}={2}",userGugudan, guguLoopIdx,userGugudan*guguLoopIdx);
            //    guguLoopIdx++;
            //}   //loop : 9번

            /**
             * while 연습
             **/

            /** 
             * 문제 1
             * 프로그램 사용자로부터 양의 정수를 하나 입력 받아서, 그 수만큼 "Hello World"를 출력하는 프로그램 작성
             *  ex)
             *      user input => 3
             *          out => "Hello World"
             *          out => "Hello World"
             *          out => "Hello World"
             */

            //int userInput = 0;
            //int loopCount = 0;
            //Console.Write("양의 정수 입력 : ");
            //int.TryParse(Console.ReadLine(), out userInput);
            //if (userInput > 0)
            //{
            //    while (loopCount < userInput)
            //    {
            //        Console.WriteLine("Hello World");
            //        loopCount++;
            //    }   //while
            //}   //if
            //else
            //{
            //    Console.WriteLine("잘못된 입력");
            //}   //else


            ///** 
            // * 문제 2
            // * 프로그램 사용자로부터 양의 정수를 하나 입력 받은 다음, 그 수만큼 3의 배수를 출력하는 프로그램 작성
            // * ex)
            // *      user input => 5
            // *          out => "3, 6, 9, 12, 15"
            // **/

            //userInput = 0;
            //loopCount = 0;
            //int threeMultiply = 3;

            //Console.Write("양의 정수 입력 : ");
            //int.TryParse(Console.ReadLine(), out userInput);
            //if (userInput > 0)
            //{
            //    while (loopCount < userInput)
            //    {
            //        threeMultiply *= loopCount + 1;
            //        Console.WriteLine("{0}", threeMultiply);
            //        threeMultiply = 3;
            //        loopCount++;
            //    }   //while
            //}   //if
            //else
            //{
            //    Console.WriteLine("잘못된 입력");
            //}   //else

            ///**
            // * 문제 3
            // * 프로그램 사용자로부터 계속해서 정수를 입력받아서, 그 값을 계속해서 더해 나간다.
            // * 이러한 작업은 프로그램 사용자가  0을 입력할 때까지 계속 되어야 하며 0이 입력되면 입력된 모든 정수의 합을 출력하고 프로그램 종료
            // * ex)
            // *      user input => 1
            // *      user input => 10
            // *      user input => 0
            // *      out => "모든 정수의 합은 : 11"
            // **/

            //userInput = 1;
            //loopCount = 0;
            //int sum = 0;
            //bool intergerCheck = false;
            //while (!userInput.Equals(0))
            //{
            //    Console.Write("정수 입력 : ");
            //    intergerCheck = int.TryParse(Console.ReadLine(), out userInput);
            //    if (intergerCheck)
            //    {
            //        sum += userInput;
            //    }   //if
            //    else
            //    {
            //        Console.WriteLine("잘못된 입력");
            //    }   //else

            //}   //while
            //if (intergerCheck)
            //{
            //    Console.WriteLine("모든 정수의 합은 : {0}", sum);
            //}   //if

            ///** 
            // * 문제 4
            // * 프로그램 사용자로부터 입력 받은 숫자에 해당하는 구구단을 출력하되, 역순으로 출력하는 프로그램 작성
            // * ex)
            // *      user input => 2
            // *      out => "18, 16, 14, 12, 10, 8, 6, 4, 2,"
            // **/

            //userInput = 0;
            //loopCount = 9;
            //Console.Write("정수 입력 : ");
            //intergerCheck = int.TryParse(Console.ReadLine(), out userInput);
            //if (intergerCheck)
            //{
            //    while (loopCount > 0)
            //    {
            //        Console.Write("{0}, ", userInput * loopCount);
            //        loopCount--;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("잘못된 입력");
            //}


            ///** 
            // * 문제 5
            // * 프로그램 사용자로부터 입력 받은 정수의 평균을 출력하는 프로그램을 작성하되, 다음 두 가지의 조건을 만족 할 것
            // * -먼저 몇 개의 정수를 입력할 것인지 프로그램 사용자에게 묻는다. 그리고 그 수의 수만큼 정수를 입력 받는다.
            // * -평균 값은 소수점 이하까지 계산해서 출력한다.
            // * ex)
            // *      user input => 3
            // *      user input => 10
            // *      user input => 10
            // *      user input => 10
            // *      out => "평균 값은 : 10.0"
            // **/

            //userInput = 0;
            //int userInputLoopCount = 0;
            //loopCount = 0;
            //sum = 0;
            //Console.Write("\n정수 입력 : ");
            //intergerCheck = int.TryParse(Console.ReadLine(), out userInputLoopCount);
            //if (intergerCheck)
            //{
            //    while (loopCount < userInputLoopCount)
            //    {
            //        Console.Write("정수 입력 : ");
            //        intergerCheck = int.TryParse(Console.ReadLine(), out userInput);
            //        if (intergerCheck)
            //        {
            //            sum += userInput;
            //            loopCount++;
            //        }
            //        else
            //        {
            //            Console.WriteLine("잘못된 입력");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("잘못된 입력");
            //}
            //double avr = (double)sum / (double)userInputLoopCount;
            //Console.WriteLine("평균 값은 : {0:.00}", avr);

            //const float FLOAT_VALUE = 0.1f;
            //int loopCount = 10;
            //float sumOfFloatValue = 0.0f;

            //while(loopCount>0)
            //{
            //    sumOfFloatValue += FLOAT_VALUE;
            //    loopCount--;
            //}   //while Loop : 10번 돈다
            //Console.WriteLine("무슨 값이 나오나 : {0}", sumOfFloatValue); //1.0000001 근사값

            /**
             * 두 실수를 입력받아서 값이 같은지 다른지 출력하는 프로그램 작성 Equlas 등 메서드 사용X)
             **/

            /**
             * 부동소수점 에러
             * 앱실론
             **/

            //float inputNum1 = 0.0f;
            //float inputNum2 = 0.0f;
            //float.TryParse(Console.ReadLine(), out inputNum1);
            //float.TryParse(Console.ReadLine(), out inputNum2);
            //bool check = false;
            //check = inputNum1 == inputNum2;
            //Console.WriteLine(check);

            /**
             * for문은 일정한 횟수만큼 반복할 때 유용하다.
             * 초기식을 실행한 후에 조건식이 참인동안, 문장을 반복한다. 한번 반복이 끝날때마다 증감식이 실행된다.
             **/

            //1~10 까지 정수의 합

            //int sumNumber = 0;
            //for(int index = 1; index <= 10; index++) 
            //{
            //    sumNumber += index;
            //}
            //Console.WriteLine($"1부터 10까지 정수의 합 : {sumNumber}");


            /**
             * 1~100 숫자 중에서 3의 배수를 제외한 수의 합 구하기
             **/
            //for (int index = 1; index <= 100; index++)
            //{
            //    if (index % 3 != 0)
            //    {
            //        sumNumber += index;
            //        Console.WriteLine(sumNumber);
            //    }
            //    else
            //    {
            //        /* Do Nothing */
            //    }
            //}   //loop : 100번 도는 루프


            /**
             * break 문
             * break 문은 반복 루프를 벗어나기 위해서 사용한다. break 문이 실행되면 반복 루프는 즉시 증단되고,
             * 반복 루프 다음에 있는 문장이 실행된다.
             * 
             * continue문
             * continue 문은 현재 수행하고 있는 반복 과정의 나머지를 건너띄고, 다음 반복 과정을 강제적으로 시작하게 만든다.
             * 반복 루프에서 continue문을 만나게 되면 문 다음에 있는 후속 코드들은 실행되지 않고 건너띄어진다.
             **/

            // 1~100 숫자 중에서 3의 배수를 제외하 수의 합 구하기
            //sumNumber = 0;
            //for (int index = 1; index <= 100; index++)
            //{
            //    if (index % 3 == 0) { continue; }
            //    else { sumNumber += index; }
            //}
            //Console.WriteLine(sumNumber);

            //sumNumber = 0;
            //for (int index = 1; index <= 100; index++)
            //{
            //    {
            //        if (index == 4)
            //        {
            //            break;
            //        }
            //        Console.WriteLine($"현재 인덱스 {index}");
            //    }
            //}


            /**
             * Lab 문제 1
             * 자음과 모음 개수 세기
             * 사용자로부터 영문자를 받아서 자음과 모음의 개수를 세는 프로그램을 작성
             * (대, 소문자 모두 카운트)
             * ex)
             *      a
             *      b
             *      c
             *      d
             *      e
             *      종료문자
             *      모음 : 2개
             *      자음 : 3개
             **/

            //string[] upperCase = { "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z", "A", "E", "I", "O", "U" };
            //string[] lowerCase = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z", "a", "e", "i", "o", "u" };

            //string userInput = "";
            //int index = 0;
            //string[] wordSave = { };
            //int consonantNum = 0;
            //int vowelNum = 0;

            //while (!userInput.Equals("0"))
            //{
            //    userInput = Console.ReadLine();
            //    for (; index < upperCase.Length; index++)
            //    {
            //        if (userInput.Equals(upperCase[index]) || userInput.Equals(lowerCase[index]))
            //        {
            //            if (index < 21)
            //            {
            //                consonantNum++;
            //            }
            //            else
            //            {
            //                vowelNum++;
            //            }
            //            index = 0;
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine($"입력한 자음 : {consonantNum} 개");
            //Console.WriteLine($"입력한 모음 : {vowelNum} 개");

            /**
             * Lab 문제 2
             * 숫자 맞추기 게임
             * 프로그램은 1~100사이의 정수를 저장하고 있고 사용자는 질문을 통해서 알아맞힌다.
             * 사용자가 답을 제시하면 Up Down을 알려준다.
             * 사용자가 알아맞힐 때까지 루프한다.
             **/

            //Random random = new Random();
            //int userInputNum = 0;
            //int computerNum = random.Next(1, 100);
            //bool oxCheck = false;
            //while (!oxCheck)
            //{
            //    int.TryParse(Console.ReadLine(), out userInputNum);
            //    if (computerNum < userInputNum)
            //    {
            //        Console.WriteLine("down");
            //    }
            //    else if (computerNum > userInputNum)
            //    {
            //        Console.WriteLine("up");
            //    }
            //    else if (computerNum.Equals(userInputNum))
            //    {
            //        Console.WriteLine("정답");
            //        break;
            //    }
            //}

            /**
             * Lab 문제 3
             * 프로그램을 수정하여 컴퓨터가 생성한 숫자를 사용자가 추측하는 대신에
             * 사용자가 결정한 번호를 컴퓨터가 추측하도록 수정한다.
             * 사용자는 컴퓨터가 추측한 숫자가 높거나 낮은지를 컴퓨터에 알려야 한다.
             * 컴퓨터가 맞힐때 까지 반복한다.
             **/

            //Random rand = new Random();
            //string userInput = null;
            //int userInputNum = 0;
            //int computerNum = 0;

            //int minNum = 0;
            //int maxNum = 2147483647;
            //int tempNum = 0;

            //bool oxCheck = false;

            //Console.Write("컴퓨터가 맞출 숫자를 입력 : ");
            //int.TryParse(Console.ReadLine(), out userInputNum);
            //computerNum = rand.Next();
            //Console.WriteLine($"컴퓨터가 입력한 숫자 {minNum} {maxNum}: {computerNum} / up / down / correct");
            //while (!oxCheck)
            //{
            //    userInput = Console.ReadLine();
            //    if (userInput.Equals("up"))
            //    {
            //        minNum = computerNum;
            //        computerNum = rand.Next(minNum, maxNum);
            //        Console.WriteLine($"컴퓨터가 입력한 숫자 {minNum} {maxNum}: {computerNum} / up / down / correct");
            //    }
            //    else if (userInput.Equals("down"))
            //    {
            //        maxNum = computerNum;
            //        computerNum = rand.Next(minNum, maxNum);
            //        Console.WriteLine($"컴퓨터가 입력한 숫자 {minNum} {maxNum}: {computerNum} / up / down / correct");
            //    }
            //    else if (userInput.Equals("correct"))
            //    {
            //        oxCheck = true;
            //        Console.WriteLine("종료");
            //        break;
            //    }
            //}


            /**
             * Lab 문제 4
             * 사용자가 결정한 값의 범위는 1~100 어떤 숫자를 생각하던 간에 7번 이하의 추측으로 컴퓨터가 맞출 수 있도록
             * 문제3 을 수정해라
             **/

            //Random rand = new Random();
            //string userInput = null;
            //int userInputNum = 0;
            //int computerNum = 0;

            //int minNum = 0;
            //int maxNum = 100;

            //bool oxCheck = false;

            //Console.Write("컴퓨터가 맞출 숫자를 입력 : ");
            //int.TryParse(Console.ReadLine(), out userInputNum);
            //computerNum = rand.Next(minNum, maxNum);
            ////Console.WriteLine($"컴퓨터가 입력한 숫자 {minNum} {maxNum}: {computerNum} / up / down / correct");
            //while (!oxCheck)
            //{
            //    //userInput = Console.ReadLine();
            //    //if (userInput.Equals("up"))
            //    //{
            //    //    minNum = computerNum;
            //    //    computerNum = (maxNum - minNum) / 2 + minNum; 
            //    //    Console.WriteLine($"컴퓨터가 입력한 숫자 {minNum} {maxNum}: {computerNum} / up / down / correct");
            //    //}
            //    //else if (userInput.Equals("down"))
            //    //{
            //    //    maxNum = computerNum;
            //    //    computerNum = (maxNum - minNum) / 2 + minNum;
            //    //    Console.WriteLine($"컴퓨터가 입력한 숫자 {minNum} {maxNum}: {computerNum} / up / down / correct");
            //    //}
            //    //else if (userInput.Equals("correct"))
            //    //{
            //    //    oxCheck = true;
            //    //    Console.WriteLine("종료");
            //    //    break;
            //    //}
            //    if (userInputNum > computerNum)
            //    {
            //        minNum = computerNum;
            //        computerNum = (maxNum - minNum) / 2 + minNum;
            //        Console.WriteLine($"컴퓨터가 입력한 숫자 {minNum} {maxNum}: {computerNum} /up/");
            //    }
            //    else if (userInputNum < computerNum)
            //    {
            //        maxNum = computerNum;
            //        computerNum = (maxNum - minNum) / 2 + minNum;
            //        Console.WriteLine($"컴퓨터가 입력한 숫자 {minNum} {maxNum}: {computerNum} /down/ ");
            //    }
            //    else if (userInputNum.Equals(computerNum))
            //    {
            //        //oxCheck = true;
            //        Console.WriteLine("종료");
            //        Console.Write("컴퓨터가 맞출 숫자를 입력 : ");
            //        int.TryParse(Console.ReadLine(), out userInputNum);
            //        minNum = 0;
            //        maxNum = 100;
            //        computerNum = rand.Next(minNum, maxNum);
            //    }
            //}

        }   //main()
    }
}
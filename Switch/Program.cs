using System;

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

            int userInput = 0;
            int loopCount = 0;
            Console.Write("양의 정수 입력 : ");
            int.TryParse(Console.ReadLine(), out userInput);
            if (userInput > 0)
            {
                while (loopCount < userInput)
                {
                    Console.WriteLine("Hello World");
                    loopCount++;
                }   //while
            }   //if
            else
            {
                Console.WriteLine("잘못된 입력");
            }   //else


            /** 
             * 문제 2
             * 프로그램 사용자로부터 양의 정수를 하나 입력 받은 다음, 그 수만큼 3의 배수를 출력하는 프로그램 작성
             * ex)
             *      user input => 5
             *          out => "3, 6, 9, 12, 15"
             **/

            userInput = 0;
            loopCount = 0;
            int threeMultiply = 3;

            Console.Write("양의 정수 입력 : ");
            int.TryParse(Console.ReadLine(), out userInput);
            if (userInput > 0)
            {
                while (loopCount < userInput)
                {
                    threeMultiply *= loopCount + 1;
                    Console.WriteLine("{0}", threeMultiply);
                    threeMultiply = 3;
                    loopCount++;
                }   //while
            }   //if
            else
            {
                Console.WriteLine("잘못된 입력");
            }   //else

            /**
             * 문제 3
             * 프로그램 사용자로부터 계속해서 정수를 입력받아서, 그 값을 계속해서 더해 나간다.
             * 이러한 작업은 프로그램 사용자가  0을 입력할 때까지 계속 되어야 하며 0이 입력되면 입력된 모든 정수의 합을 출력하고 프로그램 종료
             * ex)
             *      user input => 1
             *      user input => 10
             *      user input => 0
             *      out => "모든 정수의 합은 : 11"
             **/

            userInput = 1;
            loopCount = 0;
            int sum = 0;
            bool intergerCheck = false;
            while (!userInput.Equals(0))
            {
                Console.Write("정수 입력 : ");
                intergerCheck = int.TryParse(Console.ReadLine(), out userInput);
                if (intergerCheck)
                {
                    sum += userInput;
                }   //if
                else
                {
                    Console.WriteLine("잘못된 입력");
                }   //else

            }   //while
            if (intergerCheck)
            {
                Console.WriteLine("모든 정수의 합은 : {0}", sum);
            }   //if

            /** 
             * 문제 4
             * 프로그램 사용자로부터 입력 받은 숫자에 해당하는 구구단을 출력하되, 역순으로 출력하는 프로그램 작성
             * ex)
             *      user input => 2
             *      out => "18, 16, 14, 12, 10, 8, 6, 4, 2,"
             **/

            userInput = 0;
            loopCount = 9;
            Console.Write("정수 입력 : ");
            intergerCheck = int.TryParse(Console.ReadLine(), out userInput);
            if (intergerCheck)
            {
                while (loopCount > 0)
                {
                    Console.Write("{0}, ", userInput * loopCount);
                    loopCount--;
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력");
            }


            /** 
             * 문제 5
             * 프로그램 사용자로부터 입력 받은 정수의 평균을 출력하는 프로그램을 작성하되, 다음 두 가지의 조건을 만족 할 것
             * -먼저 몇 개의 정수를 입력할 것인지 프로그램 사용자에게 묻는다. 그리고 그 수의 수만큼 정수를 입력 받는다.
             * -평균 값은 소수점 이하까지 계산해서 출력한다.
             * ex)
             *      user input => 3
             *      user input => 10
             *      user input => 10
             *      user input => 10
             *      out => "평균 값은 : 10.0"
             **/

            userInput = 0;
            int userInputLoopCount = 0;
            loopCount = 0;
            sum = 0;
            Console.Write("\n정수 입력 : ");
            intergerCheck = int.TryParse(Console.ReadLine(), out userInputLoopCount);
            if (intergerCheck)
            {
                while (loopCount < userInputLoopCount)
                {
                    Console.Write("정수 입력 : ");
                    intergerCheck = int.TryParse(Console.ReadLine(), out userInput);
                    if (intergerCheck)
                    {
                        sum += userInput;
                        loopCount++;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력");
                    }
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력");
            }
            double avr = (double)sum / (double)userInputLoopCount;
            Console.WriteLine("평균 값은 : {0:.00}", avr);

        }   //main()
    }
}
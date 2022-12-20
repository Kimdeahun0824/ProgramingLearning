using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Class1
    {
        static void study1()
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
            int loopCounter = 0;
            while (loopCounter < 5)
            {
                Console.WriteLine("loopCounter : {0}", loopCounter);
                loopCounter++;
            }   //while

            //10~1 카운트 후 발사 출력하는 프로그램 작성
            loopCounter = 10;
            while (loopCounter > 0)
            {
                Console.WriteLine("{0}", loopCounter);
                loopCounter--;
            }   //while
            Console.WriteLine("발사");
        }
    }
}

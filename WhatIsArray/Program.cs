/* 2022-12-21 */

// System 이라는 어셈블리에서 이것 저것 여러 기능을 가져와사 사용할 거라는 뜻
using System;

//내 프로그램 이름, 
namespace WhatIsArray
{
    //네임스페이스는 필드, 메서드 또는 문과 같은 멤버를 직접 포함할 수 있음
    //Class C#에서는 모든 요소들이 클래스 안에 있어야 함
    internal class Program
    {
        // Main 메서드는 무조건 1개는 있어야 함. -> C# 콘솔을 사용할 때 (Unity는 없을 수 있음)
        static void Main(string[] args)
        {
            //프로그램은 여기서부터 읽기 시작함

            /**
             * if(조건문 A 검사)
             * {
             *      조건 A가 참(True)이면 이 대괄호 안 구문을 실행
             * }
             * else if(조건문 B 검사)
             * {
             *      조건  A가 거짓(False)이고 조건 B가 참(True)이면 이 대괄호 안 구문을 실행
             * }
             * else
             * {
             *      조건 A B가 거짓이면 이 대괄호 안 구문 실행
             * } 
             * 조건문이 마치면 이 라인부터 프로그램 시작
             **/

            //int sumOfNumber = 0;

            //for (int variable = 1; variable <= 100; variable++)
            //{
            //    bool isRealMultipleOfThree = (variable % 3 == 0);
            //    Console.WriteLine($"{variable} -> isRealMultipleOfThree : {isRealMultipleOfThree}");

            //    if (!isRealMultipleOfThree)
            //    {
            //        sumOfNumber += variable;
            //        Console.WriteLine(sumOfNumber);
            //    }
            //    else
            //    {
            //        /* Do Nothing */
            //    }
            //}


            //for (int index = 1; index <= 10; index++)
            //{
            //    for (int index2 = 1; index2 <= 10; index2++)
            //    {
            //        Console.Write("{0} ", "*");
            //    }   // loop : 이건 밖의 루프가 1번 도는 동안 10번을 도는 루프
            //    Console.WriteLine();
            //}   // loop : 이건 10번 도는 루프

            //int count = 0;
            //for (int index = 1; index <= 10; index++)
            //{
            //    for (int index2 = 1; index2 <= 10; index2++)
            //    {
            //        for (int index3 = 1; index3 <= 10; index3++)
            //        {
            //            count++;
            //            if (100 < count)
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                /* Do Nothing */
            //            }
            //            Console.Write("{0} ", "*");

            //            //여기서 10번마다 한 줄을 띄어 줄거임
            //            if(count%10 ==0)
            //            {
            //                Console.WriteLine();
            //            }   //if : 별을 10번 찍을 때마다 한 줄 띄어주는 중
            //            else
            //            {
            //                /* Do Nothing */
            //            }
            //        }   //loop : 1번 루프가 10번 도는 동안 2번 루프가 10번 돌고 그 동안 다시 10번 도는 루프
            //        //Console.WriteLine();
            //    }   // loop : 이건 밖의 루프가 1번 도는 동안 10번을 도는 루프
            //    //Console.WriteLine();
            //}   // loop : 이건 10번 도는 루프



            //string personalGander = "남자";
            //if (personalGander.Equals("남자"))
            //{
            //    Console.WriteLine(personalGander); 
            //}
            //else if (personalGander.Equals("여자")) 
            //{
            //    Console.WriteLine(personalGander);
            //}
            //else
            //{
            //    Console.WriteLine(personalGander);
            //}


            /**
             * 문제 1
             * 유저 입력 받아서 (1~20 줄 이내로 입력 받음). 유저 입력은 줄, 단의 개수임.
             * 등차 수열로 점점 한 단이 내려갈 때마다 별 1개씩 추가로 증가하는 프로그램 작성
             * ex)
             *      userInput -> 5
             *      ===============
             *      *
             *      **
             *      ***
             *      ****
             *      *****
             **/

            //int userInput = 0;
            //int.TryParse(Console.ReadLine(), out userInput);
            //for (int index = 0; index <= userInput; index++)
            //{
            //    for (int index2 = 0; index2 < index; index2++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            /**
             * 문제 2
             * 유저 입력 받아서 (1~20 줄 이내로 입력 받음). 유저 입력은 줄, 단의 개수임.
             * 등차 수열로 점점 한 단이 내려갈 때마다 별 1개씩 추가로 증가하는 프로그램 작성
             * ex)
             *      userInput -> 5
             *      ===============
             *         *
             *        ***
             *       *****
             *        ***
             *         *
             **/


            //userInput = 0;
            //bool evenNum = false;
            //int.TryParse(Console.ReadLine(), out userInput);
            //if (userInput % 2 == 0)
            //{
            //    evenNum = true;
            //}
            //else
            //{
            //    evenNum = false;
            //}

            //if (evenNum)
            //{
            //    for (int index = 0; index <= userInput / 2; index++)
            //    {
            //        for (int index2 = userInput / 2 - 1; index2 >= index; index2--)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int index3 = 0; index3 < index * 2 - 1; index3++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //    for (int index = 0; index < userInput / 2; index++)
            //    {
            //        for (int index2 = 0; index2 < index; index2++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int index3 = userInput - index - 1; index3 > index; index3--)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    for (int index = 0; index <= userInput / 2; index++)
            //    {
            //        for (int index2 = userInput / 2; index2 > index; index2--)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int index3 = 0; index3 <= index * 2; index3++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //    for (int index = 1; index < userInput / 2 + 1; index++)
            //    {
            //        for (int index2 = 0; index2 < index; index2++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int index3 = userInput - index; index3 > index; index3--)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //}


            /**
             * 숫자 야구 게임
             **/

            //Random rand = new Random();
            //int computerNum1, computerNum2, computerNum3;
            //int userInput = 0;
            //int userInputNum1, userInputNum2, userInputNum3;

            //int life = 9;
            //int strike = 0;
            //int ball = 0;

            //bool overlap = true;
            //bool correct = false;

            //computerNum1 = rand.Next(0, 9);
            //computerNum2 = rand.Next(0, 9);
            //computerNum3 = rand.Next(0, 9);

            ////난수 중복 처리 overlap bool값이 true면(숫자가 중복되면) 반복
            //while (overlap)
            //{
            //    //숫자가 중복되면 조건식 3개중 1나라도 만족하면 난수 재생성
            //    if (computerNum1.Equals(computerNum2) || computerNum1.Equals(computerNum3) || computerNum2.Equals(computerNum3))
            //    {
            //        computerNum1 = rand.Next(0, 9);
            //        computerNum2 = rand.Next(0, 9);
            //        computerNum3 = rand.Next(0, 9);
            //    }   //if
            //    else
            //    {
            //        overlap = false;
            //    }   //else
            //}   //while

            //while (!correct && life > 0)
            //{
            //    Console.Write($"정답 : {computerNum1}, {computerNum2}, {computerNum3}\n남은 생명{life}, 숫자를 입력 : ");
            //    int.TryParse(Console.ReadLine(), out userInput);
            //    userInputNum1 = userInput / 100;
            //    userInputNum2 = userInput / 10 % 10;
            //    userInputNum3 = userInput % 10;

            //    if (userInputNum1.Equals(userInputNum2) || userInputNum1.Equals(userInputNum3) || userInputNum2.Equals(userInputNum3))
            //    {
            //        Console.WriteLine("숫자 중복 다시 입력");
            //        continue;
            //    }
            //    if (userInputNum1.Equals(computerNum1))
            //    {
            //        strike++;
            //    }
            //    if (userInputNum2.Equals(computerNum2))
            //    {
            //        strike++;
            //    }
            //    if (userInputNum3.Equals(computerNum3))
            //    {
            //        strike++;
            //    }

            //    if (userInputNum1.Equals(computerNum2) || userInputNum1.Equals(computerNum3))
            //    {
            //        ball++;
            //    }
            //    if (userInputNum2.Equals(computerNum1) || userInputNum2.Equals(computerNum3))
            //    {
            //        ball++;
            //    }
            //    if (userInputNum3.Equals(computerNum1) || userInputNum3.Equals(computerNum2))
            //    {
            //        ball++;
            //    }

            //    if (strike == 3)
            //    {
            //        correct = true;
            //        Console.WriteLine("Home Run");
            //        break;
            //    }
            //    else if (strike == 0 && ball == 0)
            //    {
            //        Console.WriteLine("OUT");
            //        life--;
            //        strike = 0;
            //        ball = 0;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{strike}S, {ball}B");
            //        life--;
            //        strike = 0;
            //        ball = 0;
            //    }

            //}   //while

            /**
             * 컬렉션
             * 이름 하나로 데이터 여러 개를 담을 수 있는 자료 구조를 컬렉션(Colletcion) 또는
             * 컨테이너(Container) 라고 한다. C#에서 다루는 컬렉션은 배열(Array), 리스트(List),
             * 사전(Dictinary) 등이 있다.
             * 
             * 배열(Array) 은 같은 종류의 데이터들이 순차적으로 메모리에 저장되는 자료 구조이다. 각각의 데이터들은
             * 인덱스(번호)를 사용하여 독립적으로 접근된다. 배열을 사용하면 편리하게 데이터를 모아서 관리할 수 있다.
             * 
             * 배열의 특징들
             * 1. 배열 하나에는 데이터 형식 한 종류만 보관할 수 있다.
             * 2. 배열은 메모리의 연속된 미리 할당하고, 이를 대괄호 ([])와 0부터 시작하는 정수형 인덱스를
             *      사용하여 접근할 수 있다.
             * 3. 배열을 선얼할 때는 new 키워드로 배열을 생성한 후 사용할 수 있다.
             * 4. 배열에서 값 하나는 요소(Element) 또는 항목(Item)으로 표현한다.
             * 5. 필요한 데이터 개수를 정확히 정한다면 메모리를 적게 사용하여 프로그램 크기가 작아지고 성능이 향상된다.
             * 
             * 배열에는 세 가지 종류가 있다.
             * 1차원 배열 : 배열의 첨자를 하나만 사용하는 배열
             * 다차원 배열 : 첨자 2개 이상을 사용하는 배열 (2차원, 3차원, ... n차원 배열)
             * 가변(Jagged) 배열 : '배열의 배열' 이라고도 하며, 이름 하나로 다양한 차원의 배열을 표현할 때 사용한다.
             **/

            // 배열의 선언과 초기화
            //int[] numbers = new int[5] { 100, 200, 300, 400, 500 };

            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(number1);

            //for (int index = 0; index < numbers.Length; index++)
            //{
            //    Console.WriteLine(numbers[index]);
            //}

            //foreach (var element in numbers)
            //{
            //    Console.WriteLine(element);
            //}

            //프로그램은 여기서 끝난다.
        }
    }
}
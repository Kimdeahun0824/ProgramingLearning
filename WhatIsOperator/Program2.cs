using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsOperator
{
    internal class Program2
    {
        static void Main()
        {
            /**
             * 제어문 소개
             * 프로그램을 이루는 3가지의 중요한 제어 구조에는 순차 구조(순차문), 선택 구조(조건문), 반복 구조(반복문)이 있다.
             * 
             * 순차문
             * 프로그램은 기본적으로 Main()메서도 시작 지점부터 끝 지점까지 코드가 나열되면 순서대로 실행 후 종료한다.
             * 
             * 제어문
             * 프로그램 실행 순서를 제어하거나 프로그램 내용을 반복하는 작업 등을 처리할 때 사용하는 구문으로
             * 조건문과 반복문으로 구분한다.
             * 
             * 조건문(선택문)
             * 조건에 참 또는 거짓의 따라 서로 다른 명령문을 실행할 수 있는 구조이다.
             * 분기문 또는 비교판단문이라고 한다.
             * 
             * 반복문
             * 특정 명령문을 지정된 수만큼 반복해서 실행할 때나 조건식이 참일 동안 반복 시킬 때 사용한다.
             **/

            /**
             * if / else 문
             * 프로그램 흐름을 여러가지 갈래로 가지치기(Branching)할 수 있는데, 이때 if문을 사용한다.
             * if문은 조건을 비교해서 판단하는 구문으로 if, else if, else 3가지 키워드가 있다.
             **/

            //02.3 예제 #1
            //두개의 정수 중에서 더 큰 수를 찾는 프로그램

            //int numberX, numberY = 0;
            //Console.Write("X 값을 입력하시오 : ");
            //int.TryParse(Console.ReadLine(), out numberX);
            //Console.Write("Y 값을 입력하시오 : ");
            //int.TryParse(Console.ReadLine(), out numberY);

            //if (numberY < numberX)
            //{
            //    Console.WriteLine("X가 Y보다 큽니다.");
            //}
            //else
            //{
            //    Console.WriteLine("Y가 X보다 큽니다.");
            //}

            /**
             * 02.4 중간점검 1
             * 컵의 사이즈를 받아서 100ml 미만은 Small, 100ml 이상 200ml 미만은 Medium, 200ml 이상은 Large
             **/

            //int cupSize = 0;
            //Console.Write("컵의 사이즈 : ");
            //int.TryParse(Console.ReadLine(), out cupSize);
            //if (cupSize < 100 && cupSize > 0)
            //{
            //    Console.WriteLine("컵의 사이즈 : Small");
            //}
            //else if (cupSize >= 100 && cupSize < 200)
            //{
            //    Console.WriteLine("컵의 사이즈 : Medium");
            //}
            //else if (cupSize >= 200)
            //{
            //    Console.WriteLine("컵의 사이즈 : Large");
            //}
            //else
            //{
            //    Console.WriteLine("잘못된 값 입력");
            //}

            /**
             * Lab 1 비밀 코드 맞추기
             * Computer가 숨시고 있는 비밀 코드를 추측하는 게임을 작성
             * Rule : 비밀 코드는 A~Z사이의 문자
             * Computer는 사용자의 추측을 읽고서 앞에있는지 뒤에있는지 알려준다(Up & Down) 즉 사용자에게 힌트를 준다
             * ex)
             *      Computer의 비물 코드 : H(미리 초기화해서 변수에 가지고 있음)
             *      User 입력 : 비밀 코드를 맞춰보세요 : [입력] -> input C입력시
             *      out : C 뒤에 있음
             *      -프로그램이 종료됨-
             *      User 입력 : 비밀 코드를 맞춰보세요 : [입력] -> input H입력시
             *      정답입니다.
             **/

            int randNum = 0;
            string computerWord = null;
            string userInputWord = null;
            bool oxCheck = false;
            bool TFCheck = false;
            string[] word = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Random rand = new Random();
            randNum = rand.Next(word.Length);
            computerWord = word[randNum];
            int life = 5;

            int iterator = 0;
            while (!oxCheck)
            {
                //if(life <= 0 && !oxCheck)
                //{
                //    Console.WriteLine("라이프가 소진되었습니다");
                //    break;
                //}
                Console.Write("비밀 코드를 맞춰보세요 [입력] : ");
                userInputWord = Console.ReadLine();
                for (; iterator < word.Length; iterator++)
                {
                    if (userInputWord.Equals(computerWord))
                    {
                        oxCheck = true;
                        TFCheck = true;
                    }
                    else if (userInputWord.Equals(word[iterator]))
                    {
                        if (iterator <= randNum)
                        {
                            Console.WriteLine("뒤에 있음");
                            TFCheck = true;
                        }
                        else if (iterator >= randNum)
                        {
                            Console.WriteLine("앞에 있음");
                            TFCheck = true;
                        }
                        life--;
                    }
                }
                if (!TFCheck)
                {
                    Console.WriteLine("잘못된 입력");
                }
                else if (!oxCheck)
                {
                    //Console.WriteLine("Life가 {0} 남았습니다.", life);
                }
                iterator = 0;
                Console.WriteLine("정답은 : {0}", computerWord);
            }
            if (oxCheck)
            {
                Console.WriteLine("정답입니다.");
            }


            /**
             * Lab 2 세 개의 정수 중에서 큰 수 찾기
             * 사용자로부터 받은 3개의 정수 중에서 가장 큰 수를 찾는 프로그램 작성
             * ex)
             *      3개의 정수를 입력하시오 : 20 10 30 (Hard Ver) -> hint split 한줄로 입력받아서 쪼개면 됨
             *      ============================================
             *      1번 정수를 입력하시오 : 20
             *      2번 정수를 입력하시오 : 10
             *      3번 정수를 입력하시오 : 30   (Easy Ver)
             *      
             *      ============================================
             *      가장 큰 정수는 : 30  
             **/

            string[] strNum = null;
            int inputNum1, inputNum2, inputNum3;
            int minNum = 0, middleNum = 0, maxNum = 0;
            Console.Write("3개의 정수를 입력하시오 : ");
            strNum = Console.ReadLine().Split();
            int.TryParse(strNum[0], out inputNum1);
            int.TryParse(strNum[1], out inputNum2);
            int.TryParse(strNum[2], out inputNum3);

            //Console.Write("1번 정수를 입력하시오 : ");
            //int.TryParse(Console.ReadLine(), out inputNum1);
            //Console.Write("2번 정수를 입력하시오 : ");
            //int.TryParse(Console.ReadLine(), out inputNum2);
            //Console.Write("3번 정수를 입력하시오 : ");
            //int.TryParse(Console.ReadLine(), out inputNum3);

            if (inputNum1 < inputNum2)
            {
                if (inputNum1 < inputNum3)
                {
                    minNum = inputNum1;
                    if (inputNum2 < inputNum3)
                    {
                        middleNum = inputNum2;
                        maxNum = inputNum3;
                    }
                    else
                    {
                        middleNum = inputNum3;
                        maxNum = inputNum2;
                    }
                }
                else
                {
                    minNum = inputNum3;
                    middleNum = inputNum1;
                    maxNum = inputNum2;
                }
            }
            else
            {
                if (inputNum2 < inputNum3)
                {
                    minNum = inputNum2;
                    if (inputNum3 < inputNum1)
                    {
                        maxNum = inputNum1;
                        middleNum = inputNum3;
                    }
                    else
                    {
                        maxNum = inputNum3;
                        middleNum = inputNum1;
                    }
                }
                else
                {
                    minNum = inputNum3;
                    middleNum = inputNum2;
                    maxNum = inputNum1;
                }
            }
            Console.WriteLine("가장 큰 정수는 : {0}", maxNum);
            Console.WriteLine("중간 크기 정수는 : {0}", middleNum);
            Console.WriteLine("가장 작은 정수는 : {0}", minNum);

        }
    }
}

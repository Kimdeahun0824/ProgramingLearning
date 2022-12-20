using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Lab3
    {
        public Lab3()
        {
            /**
             * Lab 문제 3
             * 산수 문제 자동 출제
             * 산수 문제를 자동으로 출제하는 프로그램을 작성
             * 덧셈 문제들을 자동으로 생성해야 한다.
             * 피연산자는 0~99 사이의 숫자 난수 한 번이라도 맞으면 종료 틀리면 리트라이
             * 뺄셈, 곱셋, 나눗셈, 문제도 출제 -> 나눗셈 예외처리 (무한대 값 주의)
             **/

            //난수를 발생하기 위한 random 클래스 생성
            Random rand = new Random();
            //피연산자1, 피연산자2 의 값을 랜덤으로 받기 위해 해당 값을 저장할 변수 선언
            int randomNum1, randomNum2;
            //+,-,*,/ 식을 랜덤으로 만들기 위해 랜덤으로 받은 값을 식 선택에 사용할 변수 (switch문)
            int randOperator = 0;
            //유저의 입력을 저장받을 변수
            double userInputNum = 0.0f;
            //정답 체크용 Boolean 변수
            bool oxCheck = false;

            //난수 발생으로 식, 피연산자1, 피연산자2 의 값을 저장함
            randOperator = rand.Next(4);
            randomNum1 = rand.Next(99);
            randomNum2 = rand.Next(99);

            //난수 발생으로 저장받은 값으로 switch문을 통해서 식 선택
            switch (randOperator)
            {
                case 0:
                    Console.WriteLine($"{randomNum1} + {randomNum2} = ?");
                    break;
                case 1:
                    Console.WriteLine($"{randomNum1} - {randomNum2} = ?");
                    break;
                case 2:
                    Console.WriteLine($"{randomNum1} * {randomNum2} = ?");
                    break;
                case 3:
                    Console.WriteLine($"{randomNum1} / {randomNum2} = ?");
                    break;
            }   //switch

            //정답을 체크할 Boolean값이 false(오답이면) 반복
            while (!oxCheck)
            {
                //유저가 입력한 값을 Console.ReadLine()으로 받아와서 userInputNum의 저장
                double.TryParse(Console.ReadLine(), out userInputNum);

                //난수 발생으로 저장받은 값으로 switch문을 통해 식 선택
                switch (randOperator)
                {
                    //덧셈식
                    case 0:
                        //유저가 입력한 값이 식 결과와 같다면 정답
                        if (userInputNum.Equals(randomNum1 + randomNum2))
                        {
                            Console.WriteLine("정답");
                            //정답 체크용 oxCheck Boolean값을 true로 바꿈 -> 반복문 탈출
                            oxCheck = true;
                        }   //if
                        //유저가 입력한 값이 식 결과와 다르다면 오답
                        else
                        {
                            Console.WriteLine("오답 다시");
                            //정답 출력
                            Console.WriteLine(randomNum1 + randomNum2);
                        }   //else
                        break;
                    //뺄셈식
                    case 1:
                        //유저가 입력한 값이 식 결과와 같다면 정답
                        if (userInputNum.Equals(randomNum1 - randomNum2))
                        {
                            Console.WriteLine("정답");
                            //정답 체크용 oxCheck Boolean값을 true로 바꿈 -> 반복문 탈출
                            oxCheck = true;
                        }   //if
                        //유저가 입력한 값이 식 결과와 다르다면 오답
                        else
                        {
                            Console.WriteLine("오답 다시");
                            //정답 출력
                            Console.WriteLine(randomNum1 - randomNum2);
                        }   //else
                        break;
                    //곱셈식
                    case 2:
                        //유저가 입력한 값이 식 결과와 같다면 정답
                        if (userInputNum.Equals(randomNum1 * randomNum2))
                        {
                            Console.WriteLine("정답");
                            //정답 체크용 oxCheck Boolean값을 true로 바꿈 -> 반복문 탈출
                            oxCheck = true;
                        }   //if
                        //유저가 입력한 값이 식 결과와 다르다면 오답
                        else
                        {
                            Console.WriteLine("오답 다시");
                            //정답 출력
                            Console.WriteLine(randomNum1 * randomNum2);
                        }   //else
                        break;
                    //나눗셈 식
                    case 3:
                        //유저가 입력한 값이 식 결과와 같다면 정답
                        if (userInputNum.Equals(Math.Round((double)randomNum1 / randomNum2, 2)))
                        {
                            Console.WriteLine("정답");
                            //정답 체크용 oxCheck Boolean값을 true로 바꿈 -> 반복문 탈출
                            oxCheck = true;
                        }   //if
                        //유저가 입력한 값이 식 결과와 다르다면 오답
                        else
                        {
                            Console.WriteLine("오답 다시");
                            //Console.WriteLine()함수가 1보다 작은 숫자 출력 시 0. <- 이 출력되지 않는 문제로 인해 값이 1보다 작은 값 예외처리
                            if (Math.Round((double)randomNum1 / randomNum2, 2) < 1)
                            {
                                //정답 출력
                                Console.WriteLine("0{0:.00}", Math.Round((double)randomNum1 / randomNum2, 2));
                            }   //if
                            else
                            {
                                //정답 출력
                                Console.WriteLine("{0:.00}", Math.Round((double)randomNum1 / randomNum2, 2));
                            }   //else
                        }   //else
                        break;
                }   //switch
            }   //while
        }   //생성자
    }   //class
}

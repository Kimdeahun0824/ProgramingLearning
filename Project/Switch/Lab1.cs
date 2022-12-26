using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Lab1
    {
        public Lab1()
        {
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

            //영단어(대문자) string 배열
            string[] upperCase = { "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z", "A", "E", "I", "O", "U" };
            //영단어(소문자) string 배열
            string[] lowerCase = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z", "a", "e", "i", "o", "u" };

            //Console.ReadLine()을 통해 유저 입력을 받을 변수
            string userInput = "";
            //영단어 string 배열의 접글한 인덱스
            int index = 0;
            //자음 갯수를 저장할 int형 변수
            int consonantNum = 0;
            //모음 갯수를 저장할 int형 변수
            int vowelNum = 0;

            //Console.ReadLine()을 통해 받은 값이 0이 아니면 반복
            while (!userInput.Equals("0"))
            {
                //화면 출력
                Console.Write("영단어를 입력 (종료는 0입력) :");
                //Console.ReadLine()을 통해 유저 입력을 받아서 (int)userInput 의 저장
                userInput = Console.ReadLine();
                //반복문을 통해 영단어 string배열의 원소에 접근
                for (; index < upperCase.Length; index++)
                {
                    //유저가 입력한 값이 영단어 string배열에 있는지 확인 or문을 통해 대,소문자 구별없이 있으면 true반환
                    if (userInput.Equals(upperCase[index]) || userInput.Equals(lowerCase[index]))
                    {
                        //배열의 위치를 21번 이후부터는 모음만을 배치하여 유저가 입력한 값과 일치한 index가 21미만이면 자음 변수 값 증가
                        if (index < 21)
                        {
                            consonantNum++;
                        }   //if
                        //배열의 위치를 21번 이후부터는 모음만을 배치하여 유저가 입력한 값과 일치한 index가 21이상면 모음 변수 값 증가
                        else
                        {
                            vowelNum++;
                        }   //else
                        //값을 찾은 시점에서 string배열의 원소에 더 접근할 필요가 없기때문에 index값을 0으로 초기화 하고 반복문 탈출
                        index = 0;
                        break;
                    }   //if
                }   //for
            }   //while
            Console.WriteLine($"입력한 자음 : {consonantNum} 개");
            Console.WriteLine($"입력한 모음 : {vowelNum} 개");
        }   //생성자
    }   //class
}

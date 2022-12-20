using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Lab2
    {
        public Lab2()
        {
            /**
             * Lab 문제 2
             * 사용자가 결정한 값의 범위는 1~100 어떤 숫자를 생각하던 간에 7번 이하의 추측으로 컴퓨터가 맞출 수 있도록
             * 문제3 을 수정해라
             **/

            //난수를 발생하기 위한 random 클래스 생성
            Random rand = new Random();
            //Consol.ReadLine()을 통해 유저의 값을 받아와 저장할 변수
            int userInputNum = 0;
            //난수로 유저의 값을 맞출 변수
            int computerNum = 0;

            //난수 발생 시 최소 값
            int minNum = 0;
            //난수 발생 시 최대 값
            int maxNum = 100;

            //정답이 맞는지 체크할 Boolean값
            bool oxCheck = false;

            Console.Write("컴퓨터가 맞출 숫자를 입력 : ");
            //Console.ReadLine()를 통해 유저의 입력을 받아서 userInputNum변수에 int형으로 캐스팅하여 저장
            int.TryParse(Console.ReadLine(), out userInputNum);
            //난수발생 함수를 통해 최소, 최대값 사이의 난수를 생성하여 computerNum변수에 저장
            computerNum = rand.Next(minNum, maxNum);
            
            //정답을 체크할 Boolean값이 false(오답이면) 반복
            while (!oxCheck)
            {
                //유저가 입력한 숫자보다 computerNum의 저장된 숫자가 작다면
                if (userInputNum > computerNum)
                {
                    //최솟값의 현재 computerNum 값 저장
                    minNum = computerNum;
                    //최대값과 최소값 사이의 숫자중 중간에 위치한 숫자를 computerNum 변수에 저장
                    computerNum = (maxNum - minNum) / 2 + minNum;
                    Console.WriteLine($"컴퓨터가 입력한 숫자 : {computerNum} 현재 최소값({minNum}) 현재 최대값({maxNum}) /up/");
                }   //if
                //유저가 입력한 숫자보다 computerNum의 저장된 숫자가 크다면
                else if (userInputNum < computerNum)
                {
                    //최대값의 현재 computerNum 값 저장
                    maxNum = computerNum;
                    //최대값과 최소값 사이의 숫자중 중간에 위치한 숫자를 computerNum 변수에 저장
                    computerNum = (maxNum - minNum) / 2 + minNum;
                    Console.WriteLine($"컴퓨터가 입력한 숫자 : {computerNum} 현재 최소값({minNum}) 현재 최대값({maxNum}) /down/ ");
                }   //else if
                //유저가 입력한 숫자와 computerNum의 저장된 숫자가 같다면
                else if (userInputNum.Equals(computerNum))
                {
                    //정답 체크용 oxCheck Boolean값을 true로 바꿈 -> 반복문 탈출
                    oxCheck = true;
                    Console.WriteLine("종료");
                }   //else if
            }   //while
        }   //생성자
    }   //class
}

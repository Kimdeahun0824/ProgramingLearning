using System;
namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] starArray = new string[5, 5];

            // 별찍기 직각 삼각형 했었던거
            // 별을 초기화 하는 코드
            for (int y = 0; y < 5; y++)
            {
                for (int x = y; x < 5; x++)
                {
                    starArray[y, x] = "*";
                }
            }   // loop : 별을 배열에 초기화 하는 루프

            // 별을 출력하는 코드
            for (int y = 0; y < 5; y++)
            {
                for (int x = y; x < 5; x++)
                {
                    if (starArray[y, x].Equals("*"))
                    {
                        Console.Write($"{starArray[y, x]} ");
                    }
                }
                Console.WriteLine();
            }   // loop : 배열에 담긴 별을 출력하는 루프
        }
    }
}
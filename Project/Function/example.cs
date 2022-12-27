using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class example
    {
        /**
         * 화면에 "Hello"를 출력하는 SayHello() 함수를 작성
         *      - int 타입 매개변수 받아서 그 횟수만큼 "Hello"를 반복해서 출력
         * 3개의 정수 중에서 최대값을 찾는 함수 Maximum(x,y,z)를 정의할 것
         * 다른 두변이 주어 졌을 때 직각 삼각형의 빗변을 계산하는 함수 Hypot()를 정의할 것
         *      - 매개변수는 2개 타입은 double형 
         *      - 리턴 타입도 double형
         * 주어진 숫자가 소수인지 여부를 찾는 함수 Prime()을 작성,
         *      - 판별할 값의 범위는 2~100 사이의 값 중에서 소수는 모두 출력
         * 사용자가 입력하는 전화번호에서 소괄호를 삭제한 형태로 출력하는 프로그램을 작성(함수 사용)     
         *      - 전화번호를 입력받는다 -> 소괄호를 삭제한 형태로 출력한다
         *      - quit 입력하면 프로그램을 종료한다.
         *      - 프로그램 종료 전까지 전화번호를 입력 받는다.
         */
        static void Main(string[] args)
        {
            SayHello(3);
            Console.WriteLine(Maximum(1, 2, 3));
            Console.WriteLine(Hypot(5, 5));
            prime();
            string input = null;
            while (true)
            {
                input = CallNumber(Console.ReadLine());
                if (input.Equals("quit") || input.Equals("QUIT"))
                {
                    break;
                }
                Console.WriteLine(input);
                
            }
            flipString("Hello World!");
        }

        /**
         * 화면에 "Hello"를 출력하는 SayHello() 함수를 작성
         *      - int 타입 매개변수 받아서 그 횟수만큼 "Hello"를 반복해서 출력
         */

        static public void SayHello(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hello");
            }
        }

        /**
         * 3개의 정수 중에서 최대값을 찾는 함수 Maximum(x,y,z)를 정의할 것
         */

        static public int Maximum(int x, int y, int z)
        {
            if (y < x && z < x)
            {
                return x;
            }
            else if (x < y && z < y)
            {
                return y;
            }
            else if (x < z && y < z)
            {
                return z;
            }
            return 0;
        }

        /**
         * 다른 두변이 주어 졌을 때 직각 삼각형의 빗변을 계산하는 함수 Hypot()를 정의할 것
         *      - 매개변수는 2개 타입은 double형 
         *      - 리턴 타입도 double형
         */

        static public double Hypot(double x, double y)
        {
            double length = Math.Sqrt(x * x + y * y);
            return length;
        }

        /**
         * 주어진 숫자가 소수인지 여부를 찾는 함수 Prime()을 작성,
         *      - 판별할 값의 범위는 2~100 사이의 값 중에서 소수는 모두 출력
         */

        static public void prime()
        {
            List<int> list = new List<int>();
            for (int i = 2; i <= 100; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != 2 && list[i] % 2 == 0)
                {
                    list.Remove(list[i]);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != 3 && list[i] % 3 == 0)
                {
                    list.Remove(list[i]);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != 5 && list[i] % 5 == 0)
                {
                    list.Remove(list[i]);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != 7 && list[i] % 7 == 0)
                {
                    list.Remove(list[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"소수는 : {list.Count}개");
        }

        /**
         * 사용자가 입력하는 전화번호에서 소괄호를 삭제한 형태로 출력하는 프로그램을 작성(함수 사용)     
         *      - 전화번호를 입력받는다 -> 소괄호를 삭제한 형태로 출력한다
         *      - quit 입력하면 프로그램을 종료한다.
         *      - 프로그램 종료 전까지 전화번호를 입력 받는다.
         */

        static public string CallNumber(string number)
        {
            number = number.Replace("(", "");
            number = number.Replace(")", "");
            return number;
        }

        static public void flipString(string str)
        {
            char[] charArr = str.ToArray();
            Array.Reverse(charArr);
            string newStr = new string(charArr);

            Console.WriteLine(newStr);
        }
    }
}

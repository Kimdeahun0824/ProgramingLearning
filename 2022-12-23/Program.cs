namespace _2022_12_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 1. 사용자로부터 2개의 문자열을 읽어서 같은지 다른지 화면에 출력하는 프로그램 작성
             *      ex)
             *              첫 번째 문자열 : Hello
             *              두 번째 문자열 : World
             *              2개의 문자열은 다릅니다.
             *              -Equals 메서드를 사용하지 않을 것
             *              hint) Length 비교?
             */

            string[] userInput = new string[2];
            for (int index = 0; index < 2; index++)
            {
                userInput[index] = Console.ReadLine();
            }
            if (userInput[0] == userInput[1])
            {
                Console.WriteLine("2개의 문자열은 같음");
            }
            else
            {
                Console.WriteLine("2개의 문자열은 다름");
            }


            /**
             * 2. 5개의 음료(콜라, 물, 스프라이트, 주스, 커피)를 판매하는 자판기 머신을 구현해보기
             *      - 사용자가 1부터 5사이의 숫자를 입력함
             *      - 선택한 음료를 출력함
             *      - 1~5 이외의 숫자를 선택하면 오류 메시지 출력함
             *      ex) 
             *              콜라, 물, 스프라이트, 주스, 커피(1~5) 중에서 하나를 선택하세요.
             *              콜라를 선택하였습니다.
             *              - 프로그램 종료 -
             *              hint) switch문이나, if/else 문을 사용한다.
             */
            Console.WriteLine("콜라, 물, 스프라이트, 주스, 커피(1~5) 중에서 하나를 선택하세요.");
            int switchIdx = 0;
            bool numCheck = int.TryParse(Console.ReadLine(), out switchIdx);
            if (numCheck)
            {
                switch (switchIdx-1)
                {
                    case 0:
                        Console.WriteLine("콜라 선택");
                        break;
                    case 1:
                        Console.WriteLine("물 선택");
                        break;
                    case 2:
                        Console.WriteLine("스프라이트 선택");
                        break;
                    case 3:
                        Console.WriteLine("주스 선택");
                        break;
                    case 4:
                        Console.WriteLine("커피 선택");
                        break;
                    default:
                        Console.WriteLine("잘못된 선택");
                        break;

                }
            }
            else
            {
                Console.WriteLine("잘못된 선택");
            }
            


            /**
             * 3. 배열 days[] 를 아래와 같이 초기화 하고 배열 요소의 값을 다음과 같이 출력하는 프로그램 작성
             *      - 배열 days[] 는 -> 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
             *      ex)
             *              - 1월은 31일까지 입니다.
             *              - 2월은 29일까지 입니다.....
             *              hint) 배열의 초기화는 중괄호를 사용한다.
             */

            int[] days = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for(int index = 0; index < days.Length; index++)
            {
                Console.WriteLine($"{index+1}월은 {days[index]}까지 입니다.");
            }



        }
    }
}
using System;
using System.Diagnostics.Metrics;

namespace WhatIsOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Console.WriteLine("Hello, World!");

            ////string stringBinary = Convert.ToString(10, 2);

            ////Console.WriteLine(stringBinary);
            ////convert.toint32 10진수에서 2진수로 변환
            ////https://learn.microsoft.com/ko-kr/dotnet/api/system.convert.toint32?view=net-7.0
            ////int intBinary = Convert.ToInt32("0111", 2);
            ////Console.WriteLine(intBinary);
            ///*
            //연산자란(Operator) : 데이터로 연산 작업을 사용할 때 연산자를 사용함
            //연산자는 기능에 따라 대입, 산술, 관계, 증감, 조건, 비트 ,시프트 연산자 등으로 나누며
            //이용 형태에 따라 항 1개로 연산을 하는 단항(Unary)연산자와 항 2개로 연산을 하는 이항 연산자(Binary) 연산자
            //항3개로 연산을 하는 3항 연산자(Teranry) 연산자로 나눈다

            //단항 연산자(Unary)
            //단항 연산자는 연산자와 피연산자 하나로 식을 처리한다.
            //ex) [연산자] [피연산자]
            //+ 연산자 : 특정 정수형 변수 값을 그래도 출력한다.
            //- 연산자 : 특정 정수형 변수 값을 음수로 변경하여 출력한다. 
            //음수 값이 들어 있다면 양수로 변환해서 반환한다(return)

            //이항 연산자(Binary)
            //이항 연산자는 연산자와 피연산자 2개로 식을 처리한다.
            //ex) [피연산자1] [연산자] [피연산자2]

            //삼항 연산자
            //삼항 연산자는 식 1개의 항(Expression)과 그 결과에 따른 피연산자 각 1개씩 총 2개 항으로 식을 처리한다.
            //ex) (식) ? 피연산자1 : 피연산자2

            //식과 문
            //값 하나 또는 연산을 진행하는 구문의 계산식을 식(Expression) 또는 표현식이라고 한다. 표현식을 사용하여
            //명령 하나를 진행하는 구문을 문(statement) 또는 문장이라고 한다.
            //*/

            //// 단항 연산자
            ////const int PLUS_FIVE = +5;
            ////const int MINUS_FIVE = -5;

            //// 이항 연산자
            ////const int PLUS_TEN = 5 + 5;

            //// 삼항 연산자
            ////string compareTen = (PLUS_FIVE > 10) ? "{0}은(는) 10보다 크다" : "{0}은(는) 10 보다 크지 않다";
            ////Console.WriteLine(compareTen, PLUS_FIVE);

            //// 변환 연산자
            //// () 기호를 사용하여 특정 값을 원하는 데이터 형식으로 변환할 수 있다.
            ////const int PI_INT = (int)3.141592;
            ////const float PI_FLOAT = (float)3.141592;

            ////Console.WriteLine("PI_INT : {0} , PI_FLOAT : {1} ", PI_INT, PI_FLOAT);

            ///*
            // * 산술, 관계, 논리, 증감, 조건, 비트, 시프트 연산자
            // * 
            // * 산술 연산자
            // * 더하기(Add), 빼기(subtract), 곱하기(multiply), 나누기(Divide), 나머지(Remainder, Modules) 등
            // * 수학적 연산을 하는 데 사용한다. 보통 정수 형식과 실수 형식의 산술 연산에 사용한다.
            // * ex) +, -, *, /, %
            // * 
            // * 문자열 연결 연산자
            // * 산술 연산자 중 하나만 + 연산자는 피연산자의 데이터 타입에 따라 산술 연산 또는 문자열 연결 연산을 수행한다.
            // * 
            // * 연산자 오버로딩 기능으로 인해 C#에서는 가독성 등의 문제로 인해 연산자 오버로딩 기능을 잘 사용하지 않음
            // * 내부적으로 메서드로 연산을 처리함 ex) == 대신 .equls();
            // * + 연산자 : 두 항이 숫자일 때는 산술(+) 연산 가능, 문자열일 때는 문자열 연결 가능
            // */


            ////string addMessage = "string " + "plus " + "string";
            ////Console.WriteLine(addMessage);

            ///*
            // * 할당 연산자(Assigment Operator)는 변수에 데이터를 대입하는 데 사용한다. 할당 연산자를 대입 연산자 라고도 한다.
            // * C#에서 = 기호는 같다는 의미가 아니라 오른쪽에 있는 값 또는 식의 결과를 왼쪽 변수에 할당하라고 지시하는 것
            // * ex) =, +=, -=, *=, /=, %=
            // * 
            // * 증감 연산자(Increment / Decrement Opreator)
            // * 변수 값을 1증가시키거나 1 감소시키는 연산자이다. 증감 연산자가 변수 앞에 위치하느냐, 뒤에 위치하느냐 따라 연산 처리 우선순위가 결정된다.
            // * 
            // * ++(증가 연산자) : 변수 값에 1을 더한다.
            // * --(감소 연산자) : 변수 값에 1을 뺀다
            // * 
            // * 증감 연산자가 앞에 붙으면 전위 증감 연산자라고 하며, 변수 뒤에 붙으면 후위 증감 연산자라고 한다.
            // * 
            // * 전위(Prefix) 증감 연산자 : 정수형 변수 앞에 연산자가 위치하여 변수 값을 미리 증감한 후 나머지 연산을 수행한다.
            // * 
            // * 후위(Postfix) 증감 연산자 : 정수형 변수 뒤에 연산자가 위치하여 연산식(대입)을 먼저 실행한 후 나중에 변수 값을 증감 한다.
            // */

            ////int number = 0;
            ////C# 에서는 값 타입 참조 타입으로 나뉨
            ////값 타입으로 연산을 진행함 연산을 할 때 메모리에 공간을 만들고 그 공간에서 연산을 진행후 그 결과를 리턴함
            ////아래 식이 0이 나오는 이유는 number의 값이 우선 대입되고 증감 연산자가 후위 연산으로 연산이 메모리에서 소멸해서 값 대입이 안되기 때문
            ////연산자 우선 순위때문 number 값이(0이) 대입이 진행되고 후위 연산은 메모리에서 소멸
            ////number = number++;
            ////Console.WriteLine(number);

            ///*
            // * 관계형 연산자
            // * 관계형 연산자(Relatcional operator) 또는 비교 연산자(Compratcvie operator)는 두 항이 큰지, 작은지
            // * 또는 같은지 등을 비교하는데 사용한다. 관계형 연산자의 결과값은 
            // * 논리 테이터 형식인 참(TRUE) 또는 거짓(FALSE)으로 출력된다.
            // * 
            // * 논리 연산자
            // * 논리 연산자(Logical Operator)는 논리곱(AND), 논리합(OR), 논리부정(NOT)의 조건식에 대한 논리 연산을 수행한다.
            // * 연산의 결과값은 참 또는 거짓의 bool 형식으로 반환되어 boolean 연산자라고 한다.
            // * ex) &&, ||, !
            // * 
            // * 비트 연산자
            // * 비트 연산자(Bit Operator)는 정수형 데이터의 값을 이진수 비트 단위로 연산을 수행할 때 사용한다.
            // * ex) &, |, ^, ~
            // * 
            // * 시프트 연산자
            // * 시프트 연산자(Shift Operator)는 정수 데이터가 담겨 있는 메모리의 비트를 왼쪽 또는 오른쪽으로 지정한 비트만큼 이동시킨다.
            // * ex) <<, >>
            // * 
            // * 조건 연산자
            // * 조건 연산자(Conditional Operator)는 조건에 따라서 참일 때와 거짓일 때 결과를 다르게 반환하여
            // * (조건식) ? (식1 또는 값1) : (식2 또는 값2) 형태의 연산자 이다. if~else 문의 축약형 이기도 하다.
            // */

            ///*
            //bool isBigger = false;
            //isBigger = (5 == 10) || (5 < 10);
            //Console.WriteLine(isBigger);

            //isBigger = !isBigger;
            //Console.WriteLine(isBigger);

            //int bitNumber = 10;
            //int bitResult = 0;
            //bitResult = bitNumber << 1;
            //Console.WriteLine(bitResult);
            //*/

            ///*
            // * 나열(콤마) 연산자
            // * 콤마를 구분자로 하여 한 문장에 변수 여러개를 선언할 떄 사용한다.
            // */
            ////int intNumber1, intNumber2, intNumber3;

            ///*
            // * sizeof 연산자 
            // * sizeof 연산자는 단항 연산자로 데이터 형식 자체의 크기를 구하는데 사용한다.
            // * sizeof([데이터타입]) 형태로 사용하며, 운영 체제와 CPU 아키텍처의 종류에 따라 결과값이 다르게 나올 수 있다.
            // */

            ////Console.WriteLine("int의 메모리 크기는 : {0} 바이트입니다.", sizeof(int));

            ///*
            // * 연산자 우선순위
            // * 연산자 여러 개를 함께 사용할 때는 연산자 우선순위(Precedence)에 따라서 계산된다.
            // * 연산자 우선순위를 잘 모를 때는 일단 괄호 연산자부터 잘 사용하도록 연습하는게 좋다.
            // */


            ////사용자에게 주어, 동사, 목적어를 각각 물어보고 이것들을 합하여 (주어 + 동사 + 목적어) 형태로 출력하는 프로그램 작성


            ///*
            //string subject, verb, Object = null;
            //Console.Write("주어 : ");
            //subject = Console.ReadLine();
            //Console.Write("\n동사 : ");
            //verb = Console.ReadLine();
            //Console.Write("\n목적어 : ");
            //Object = Console.ReadLine();
            //Console.WriteLine("출력 : {0}\n", subject + " " + verb + " a " + Object);


            ////사용자의 나이를 물어보고 10년 후에 몇 살이 되는지를 출력하는 프로그램 작성

            //int age = 0;
            //string strInputAge = null;
            //Console.Write("나이 : ");
            //strInputAge = Console.ReadLine();
            //age = Convert.ToInt32(strInputAge);
            //Console.Write("10년 후에는 {0}살이 됩니다.\n", age + 10);


            ////직각 삼각형의 양변 길이(양 변은 빗변이 아님)를 읽어서 빗변의 길이를 계산하는 프로그램을 작성
            //int intNum1, intNum2, intNum3;
            //string strNum = null;
            //Console.Write("첫 번째 변 : ");
            //strNum = Console.ReadLine();
            //intNum1 = Convert.ToInt32(strNum);
            //Console.Write("두 번째 변 : ");
            //strNum = Console.ReadLine();
            //intNum2 = Convert.ToInt32(strNum);
            //Console.Write("빗변 길이 : {0}\n", Math.Sqrt(Math.Pow(intNum1, 2) + Math.Pow(intNum2, 2)));
            //*/

            //// { 상자의 길이(Length), 너비(width), 높이(height)를 입력하라는 메시지를 표시 상자의 부피와 표면적을 계산해서 출력하는 프로그램 작성 / dy.Kim / 2022.12.19
            //// 변수 선언부
            //int Length, Width, Height = 0;
            //Console.Write("길이 : ");
            //// 입력 및 형변환
            //int.TryParse(Console.ReadLine(), out Length);
            //Console.Write("너비 : ");
            //// 입력 및 형변환
            //int.TryParse(Console.ReadLine(), out Width);
            //Console.Write("높이 : ");
            //// 입력 및 형변환
            //int.TryParse(Console.ReadLine(), out Height);
            //// 결과 값
            //Console.Write("상자의 부피 : {0}\n", Length * Width * Height);
            //Console.Write("상자의 표면적 : {0}\n", Length * Width * 6);
            //// } 상자의 길이(Length), 너비(width), 높이(height)를 입력하라는 메시지를 표시 상자의 부피와 표면적을 계산해서 출력하는 프로그램 작성 / dy.Kim / 2022.12.19

            //// { 우리나라에서 많이 사용되는 면적의 단위인 평을 평방미터로 환산하는 프로그램 작성. 여기서 1평은 3.3058 m^2 // dy.Kim / 2022.12.19
            //// 변수 선언부
            //int squareMeter = 0;
            //Console.Write("평 : ");
            //// 입력 및 형변환
            //int.TryParse(Console.ReadLine(), out squareMeter);
            //// 결과 값
            //Console.Write("평방미터 : {0}m^2\n", squareMeter * 3.3058);
            //// } 우리나라에서 많이 사용되는 면적의 단위인 평을 평방미터로 환산하는 프로그램 작성. 여기서 1평은 3.3058 m^2 // dy.Kim / 2022.12.19

            //// { 시, 분, 초 로 표현된 시간을 초 단위의 시간으로 변화하는 프로그램 작성 / dy.Kim / 2022.12.19
            //// 변수 선언부
            //int time, minute, second;
            //Console.Write("시 : ");
            //// 입력 및 형변환
            //int.TryParse(Console.ReadLine(), out time);
            //Console.Write("분 : ");
            //// 입력 및 형변환
            //int.TryParse(Console.ReadLine(), out minute);
            //Console.Write("초 : ");
            //// 입력 및 형변환
            //int.TryParse(Console.ReadLine(), out second);
            //// 결과 값
            //Console.Write("전체 초 : {0}\n", time * 60 * 60 + minute * 60 + second);
            //// } 시, 분, 초 로 표현된 시간을 초 단위의 시간으로 변화하는 프로그램 작성 / dy.Kim / 2022.12.19


            //// { 퀴즈, 중간고사, 기말고사의 성적을 사용자로부터 입력받아서 성적 총합을 게산하는 프로그램 작성 / dy.Kim / 2022.12.19
            //// 변수 선언부
            //int quizScore1, quizScore2, quizScore3, midtermExamScore, finalExamScore;
            //Console.Write("퀴즈    #1    성적 : ");
            //// 입력 및 형변환
            //int.TryParse(Console.ReadLine(), out quizScore1);
            //Console.Write("퀴즈    #2    성적 : ");
            //// 입력 및 형변환
            //int.TryParse(Console.ReadLine(), out quizScore2);
            //Console.Write("퀴즈    #3    성적 : ");
            //// 입력 및 형변환
            //int.TryParse(Console.ReadLine(), out quizScore3);
            //Console.Write("중간고사      성적 : ");
            //// 입력 및 형변환
            //int.TryParse(Console.ReadLine(), out midtermExamScore);
            //Console.Write("기말고사      성적 : ");
            //// 입력 및 형변환
            //int.TryParse(Console.ReadLine(), out finalExamScore);
            //// 결과 값
            //Console.Write("==================\n성적 총합 : {0}\n==================", quizScore1 + quizScore2 + quizScore3 + midtermExamScore + finalExamScore);
            //// } 퀴즈, 중간고사, 기말고사의 성적을 사용자로부터 입력받아서 성적 총합을 게산하는 프로그램 작성 / dy.Kim / 2022.12.19

        }
    }
}
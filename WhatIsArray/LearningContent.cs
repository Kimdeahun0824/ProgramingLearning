/* 2022-12-21 ~ 2022-12-22 학습 내용*/

// System 이라는 어셈블리에서 이것 저것 여러 기능을 가져와사 사용할 거라는 뜻
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//내 프로그램 이름, 
namespace WhatIsArray
{
    //네임스페이스는 필드, 메서드 또는 문과 같은 멤버를 직접 포함할 수 있음
    //Class C#에서는 모든 요소들이 클래스 안에 있어야 함
    internal class LearningContent
    {
        // Main 메서드는 무조건 1개는 있어야 함. -> C# 콘솔을 사용할 때 (Unity는 없을 수 있음)
        public LearningContent()
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

            //int number1 = 1;
            //int number2 = 2;
            //int number3 = 3;
            //int number4 = 4;
            //int number5 = 5;
            //int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            //Console.WriteLine(number1);

            //for (int index = 0; index < numbers.Length; index++)
            //{
            //    Console.WriteLine(numbers[index]);
            //}

            //foreach (var element in numbers)
            //{
            //    Console.WriteLine(element);
            //}


            /* ######################################### 2022-12-22 ############################################### */

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

            //int number = 1_0821;
            //Console.WriteLine("64 Mod 연산 : {0}",number%64);

            /**
             * 다차원 배열
             * 2차원 배열, 3차원 배열 처럼 차원이 2개 이상인 배열을 다차원 배열이라고 한다.
             * C#에서 배열을 선언할 때는 콤말를 기준으로 차원을 구분한다.
             **/

            //int[] oneArray = new int[2] { 1, 2 };
            //int[,] twoArray = new int[3, 3];
            //int[,,] threeArray = new int[2, 2, 2]
            //{
            //    { { 1, 2 }, { 3, 4 } },
            //    { { 5, 6 }, { 7, 8 } }
            //};


            //// 3행 3열짜리 배열에서 행과 열이 같으면 1, 다르면 0을 출력

            //for (int y = 0; y <= twoArray.GetUpperBound(0); y++)
            //{
            //    for (int x = 0; x <= twoArray.GetUpperBound(1); x++)
            //    {
            //        if (x.Equals(y)) { twoArray[y, x] = 1; }
            //        else { twoArray[y, x] = 0; }
            //    }   //loop : 값을 대입하는 루프
            //}

            ///**
            // * Array.GetUpperBound(int dimension) 배열에서 지정된 차원의 마지막 요소의 인덱스를 가져옴
            // * return : 배열에 있는 지정된 차원의 마지막 요소의 인덱스, 지정된 차원이 비어있는 경우 -1
            // **/

            //for (int y = 0; y <= twoArray.GetUpperBound(0); y++)
            //{
            //    for (int x = 0; x <= twoArray.GetUpperBound(1); x++)
            //    {
            //        Console.Write(twoArray[y, x]);
            //    }   //loop : 값을 출력하는 루프
            //    Console.WriteLine();
            //}

            /**
             * 가변 배열
             * 차원이 2개 이상인 배열은 다차원 배열이고, 배열 길이가 가변 길이인 배열은 가변 배열이라고 한다.
             **/

            //int[][] zagArray = new int[2][];
            //zagArray[0] = new int[] { 1, 2 };
            //zagArray[1] = new int[] { 3, 4, 5 };

            //for(int y = 0; y <= 2; y++)
            //{
            //    for(int x=0; x < zagArray[y].Length; x++)
            //    {
            //        Console.Write("{0}", zagArray[y][x]);
            //    }
            //    Console.WriteLine();
            //}

            //int[] intArray;         // int 형 데이터 타입의 intArray 라는 배열을 선언
            //intArray = new int[3];  // int 형 데이터 타입의 변수를 3개 메모리에 할당

            //intArray[0] = 1;        // intArray 0번째 인덱스에 1이라는 정수값을 대입
            //intArray[1] = 2;        // intArray 1번째 인덱스에 2이라는 정수값을 대입
            //intArray[2] = 3;        // intArray 2번째 인덱스에 3이라는 정수값을 대입

            //// 배열 직접 출력해본다.
            //for (int index = 0; index < 3; index++)
            //{
            //    Console.WriteLine($"{index} 번째 인덱스의 값 -> {intArray[index]}");
            //}   // loop : 3번 도는 루프

            //Console.WriteLine();

            //// intArray 배열에서 int 형 데이터 타입의 값을 하니씩 뽑아서 index에 저장 할거임
            //foreach (var index in intArray)
            //{
            //    Console.WriteLine($"intArray 배열에서 뽑아온 값 -> {index}");
            //}   // loop : intArray 배열의 길이만큼 도는 루프

            //Console.WriteLine();

            //for (int index = 0; index < intArray.GetLength(0); index++)
            //{
            //    Console.WriteLine($"{index} 번째 인덱스의 값 -> {intArray[index]}");
            //}   // loop : intArray 배열의 길이만큼 도는 루프

            //Console.WriteLine();

            //for (int index = 0; index <= intArray.GetUpperBound(0); index++)
            //{
            //    Console.WriteLine($"{index} 번째 인덱스의 값 -> {intArray[index]}");
            //}   // loop : intArray 배열의 길이만큼 도는 루프

            //Console.WriteLine();


            /**##################################################################################################
             * 배열을 사용하여 국어 점수의 총점과 평균 구하기
             * 학생 3명의 점수를 저장하는 배열 선언해서, 각 학생별로 점수를 할당하고 (범위는 1~100 점)
             * 모든 점수의 총점과 평균을 구해서 출력하는 프로그램 
             *      - userInput 받아서 프로그램 작성 해볼 것.
             *      - userInput은 3회 (3명의 학생이니까)
             *      - 점수 범위 (범위는 1~100 점)
             *      - 이상한 입력 예외처리
             **/

            //int[] studentScore = new int[3];
            //int scoreSum = 0;

            //for (int index = 0; index < studentScore.Length; index++)
            //{
            //    Console.Write("점수 입력 : ");
            //    if (int.TryParse(Console.ReadLine(), out studentScore[index]) && studentScore[index] >= 0 && 100 >= studentScore[index])
            //    {
            //        scoreSum += studentScore[index];
            //    }
            //    else
            //    {
            //        Console.WriteLine("잘못된 입력");
            //        index--;
            //    }
            //}

            //Console.WriteLine($"총점 : {scoreSum}\n평균 : {(float)scoreSum / studentScore.Length}");

            /**
             * Lab 1. 배열에서 최대값 찾기
             * 크기가 100인 배여을 1부터 100 사이의 난수로 채우고 배열 요소 중에서 최대값을 찾아보자.
             **/

            Random rand = new Random();
            int[] intArray = new int[100];

            for (int index = 0; index < intArray.Length; index++)
            {
                intArray[index] = rand.Next(1, 100);
            }
            Array.Sort(intArray);
            foreach (int iiterator in intArray)
            {
                Console.WriteLine(iiterator);
            }
            Console.WriteLine();
            //Console.WriteLine(intArray[intArray.Length - 1]);


            /**
             * Lab 2. 사과를 제일 좋아하는 사람찾기
             * 사람들 5명(사람1, 사람2 ... 사람5)에게 아침에 먹는 사과 개수를 입력하도록 요청하는 프로그램 작성
             * 데이터 입력이 마무리 되면 누가 가장 많은 사과를 아침으로 먹었는지 출력 (기본형)
             *      - 이상한 입력 예외처리
             *      - 제일 적게 먹은 사람도 찾도록 수정 (변형 1)
             *      - 먹은 사과의 개수 순으로 정렬 알고리즘은 본인이 사용한 것으로 하되
             *      - 알고리즘을 잘 모르겠다면 버블 정렬을 도전 해볼것 (변형 2)
             *      - 알고리즘을 잘 알겠다면 Merge sort 도전 해볼 것 (hard)
             *      - 정렬 도전 시 유저 입력 X
             *      - 난수로 100~1000개 정도의 값 입력
             *      - 중복 제거
             *      - 시간초는 전혀 상관 없음
             *      - 본인 능력껏 기본형, 변형1, 변형2, hard 순서로 도전
             **/

            //int[] peoples = new int[5];
            //bool numberCheck = false;

            //for(int index = 0; index < peoples.Length; index++)
            //{
            //    numberCheck = int.TryParse(Console.ReadLine(), out peoples[index]);
            //    if(!numberCheck)
            //    {
            //        index--;
            //    }
            //}
            //Array.Sort(peoples);
            //foreach(int index in peoples)
            //{
            //    Console.WriteLine(index);
            //}

            //Random rand = new Random();
            int[] peoples = new int[100];
            for (int index = 0; index < peoples.Length; index++)
            {
                peoples[index] = rand.Next(1, 101);
                // 0이하의 값, 중복값 예외처리
                for (int index2 = 0; index2 < peoples.Length; index2++)
                {
                    if (index != index2)
                    {
                        if (peoples[index] == peoples[index2] || peoples[index] <= 0)
                        {
                            index--;
                        }
                    }
                }
            }
            for (int index = 0; index < peoples.Length; index++)
            {
                Console.Write("{0} ", peoples[index]);
                if (index % 10 == 0 && index != 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("==============================================");

            MergeSort(peoples, 0, peoples.Length - 1);
            for (int index = 0; index < peoples.Length; index++)
            {
                Console.Write("{0} ", peoples[index]);
                if (index % 10 == 0 && index != 0)
                {
                    Console.WriteLine();
                }
            }


            /**
             * 2022-12-22 과제
             * Lab 1,2 코딩 했던 내용 주석 달아서 해석해서 제출
             *      - 미완성인 경우 이해하고 있는 내용까지만이라도 적어서 제출할 것.
             *      - 어느 단계까지 도전을 했는지도 포함할 것.
             *      - 용량 등 필요없는 파일이 섞이지 않도록 주의할 것.
             **/


        }   //main

        /**
         * 합병 정렬(MergeSort) : 분할, 정복, 결합 단계로 이루어짐
         * 분할(Divide) : 입력 배열을 같은 크기의 2개 배열로 분할
         * 정복(Conquer) : 부분 배열을 정렬, 부분 배열의 크기가 충분히 작지 않으면 다시 분할
         * 결합(Conbine) : 정렬된 부분 배열을 하나의 배열에 합병
         **/

        //분할 / 정복 부분
        public static void MergeSort(int[] list, int left, int right)
        {
            int mid;
            if (left < right)
            {
                mid = (left + right) / 2;
                MergeSort(list, left, mid);
                MergeSort(list, mid + 1, right);
                Merge(list, left, mid, right);
            }
        }

        //결합 부분
        public static void Merge(int[] list, int leftIdx, int midIdx, int rightIdx)
        {
            int[] sorted = new int[1000];

            int index1 = leftIdx;
            int index2 = midIdx + 1;
            int index3 = leftIdx;
            int index4 = 0;

            while (index1 <= midIdx && index2 <= rightIdx)
            {
                if (list[index1] <= list[index2])
                {
                    sorted[index3] = list[index1];
                    index3++;
                    index1++;
                }
                else
                {
                    sorted[index3] = list[index2];
                    index3++;
                    index2++;
                }
            }

            if (index1 > midIdx)
            {
                for (index4 = index2; index4 <= rightIdx; index4++)
                {
                    sorted[index3] = list[index4];
                    index3++;
                }
            }
            else
            {
                for (index4 = index1; index4 <= midIdx; index4++)
                {
                    sorted[index3] = list[index4];
                    index3++;
                }
            }

            for (index4 = leftIdx; index4 <= rightIdx; index4++)
            {
                list[index4] = sorted[index4];
            }

        }
    }
}

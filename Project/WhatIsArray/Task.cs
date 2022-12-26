using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsArray
{
    internal class Task
    {
        /**
             * Lab 1. 배열에서 최대값 찾기
             * 크기가 100인 배여을 1부터 100 사이의 난수로 채우고 배열 요소 중에서 최대값을 찾아보자.
             **/

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

        Random rand;    // Random클래스 객체 rand 선언                                

        public Task()
        {
            rand = new Random();                                                                                        // Random클래스 rand객체 new 할당
            Lab1();                                                                                                     // Lab1 메소드 실행
            Lab2();                                                                                                     // Lab2 메소드 실행
        }

        /* Lab 1. 배열에서 최대값 찾기 */
        public void Lab1()
        {
            Console.WriteLine("===================Lab 1. 배열에서 최대값 찾기===================");
            int[] array = new int[100];                                                                                 //크기가 100인 배열 생성
            for (int index = 0; index < array.Length; index++)                                                          // array 배열의 크기만큼 반복을 실행
            {
                array[index] = rand.Next(1, 100);                                                                       // array 배열의 index번째에 1~100까지 난수 입력
                Console.WriteLine($"{index + 1}번째의 난수 : {array[index]} ");
            }

            MergeSort(array, 0, array.Length - 1);                                                                      // 병합정렬 알고리즘 함수 실행

            Console.WriteLine("==============================정렬==============================");
            for (int index = 0; index < array.Length; index++)                                                          // array 배열의 크기만큼 반복을 실행
            {
                Console.WriteLine($"{index + 1}번째의 난수 : {array[index]} ");
            }

            Console.WriteLine($"가장 큰 값 : {array[array.Length - 1]}");
            Console.WriteLine("==============================================================");

        }

        /* Lab 2. 사과를 제일 좋아하는 사람찾기 */
        public void Lab2()
        {
            Console.WriteLine("===================Lab 1. 사과를 제일 좋아하는 사람찾기===================");
            int[] array = new int[1000];                                                                                // 크기가 1000인 배열 생성

            for (int index1 = 0; index1 < array.Length; index1++)                                                       // array의 배열 크기만큼 반복을 실행
            {
                array[index1] = rand.Next(1, 10000);                                                                    // array배열의 index번째에 1~10000까지 난수 입력
                for (int index2 = 0; index2 < array.Length; index2++)                                                   // array의 배열 크기만큼 반복을 실행
                {
                    if (index1 != index2 && array[index1] == array[index2])                                             // index1과 index2가 같지 않고 array 안에 같은 값이 있으면 index-- 난수 재생성
                    {
                        index1--;
                    }
                }
            }

            for (int index = 0; index < array.Length; index++)                                                          // array의 배열 크기만큼 반복을 실행
            {
                Console.WriteLine($"{index + 1}번째 사람의 아침에 사과 먹은 개수 : {array[index]}");
            }

            MergeSort(array, 0, array.Length - 1);                                                                      // 병합정렬 알고리즘 함수 실행

            Console.WriteLine("==============================정렬==============================");

            for (int index = 0; index < array.Length; index++)                                                          // array의 배열 크기만큼 반복을 실행
            {
                Console.WriteLine($"{index + 1}번째 사람의 아침에 사과 먹은 개수 : {array[index]}");
            }

            Console.WriteLine($"사과를 제일 적게 먹은 사람 : {array[0]}개");
            Console.WriteLine($"사과를 제일 많이 먹은 사람 : {array[array.Length - 1]}개");
        }

        /**
         * 병합 정렬 알고리즘(MergeSort) - 정렬 알고리즘의 일종으로 O(NLogN)의 시간복잡도를 가진다.
         * - 분할 정복 전략의 하나로, 하나의 큰 문제를 두개의 작은 문제로 분할하여 해결한 다음, 결과를 모아서 문제를 완전히 해결하는 전략
         * - 하나의 배열을 두개의 균등한 배열로 분할하고 분할된 배열을 각각 정렬한 다음, 이를 다시 합하여 정렬을 완성하는 알고리즘
         * - 병합 정렬은 다음의 단계들로 이루어진다.
         *      - 분할(Divide) : 입력 배열을 같은 크기의 2개의 부분 배열로 분할한다.
         *      - 정복(Conquer) : 부분 배열을 정렬한다. 부분 배열의 크기가 충분히 작지 않으면 순환 호출을 이용하여 다시 분할 정복 밥법을 적용한다.
         *      - 결합(Combine) : 정렬된 부분 배열들을 하나의 배열에 합병한다.
         * - 병합 정렬에서 실제로 정렬이 이루어지는 시점은 2개의 리스트를 병합(Merge)하는 단계이다.
         **/

        /**
         * 매개변수 설명
         * - int[] list : 정렬을 시행할 배열
         * - leftIdx : 배열의 가장 왼쪽 Index
         * - rightIdx : 배열의 가장 오른쪽 Index
         **/
        public static void MergeSort(int[] list, int leftIdx, int rightIdx)                                             // 배열을 더 이상 쪼갤 수 없을때까지 분할한다. (재귀함수)
        {
            int midIdx;
            if (leftIdx < rightIdx)                                                                                     // 배열을 더 쪼갤 수 있는지 확인하는 조건문
            {
                midIdx = (leftIdx + rightIdx) / 2;                                                                      // 입력된 배열의 중간값을 계산하여 리스트를 균등 분할 - 분할(Divide) 
                MergeSort(list, leftIdx, midIdx);                                                                       // 찾은 중간값을 기준으로 앞쪽(왼쪽) 리스트 정렬 - 정복(Conquer)
                MergeSort(list, midIdx + 1, rightIdx);                                                                  // 찾은 중간값을 기준으로 뒷쪽(오른쪽) 리스트 정렬 - 정복(Conquer)
                Merge(list, leftIdx, midIdx, rightIdx);                                                                 // 정렬된 2개의 부분 배열을 합병하는 과정 - 결합(Combine) 
            }
        }

        /**
         * 매개변수 설명
         * - int[] list : 정렬을 시행할 배열
         * - leftIdx : 배열의 가장 왼쪽 Index
         * - midIdx : 배열의 중간 Index
         * - rightIdx : 배열의 가장 오른쪽 Index
         **/
        public static void Merge(int[] list, int leftIdx, int midIdx, int rightIdx)
        {
            int[] tempList = new int[list.Length];                                                                      // 입력받은 배열을 병합할  임시 배열 생성

            int repeatIdx;
            int repeatIdx1 = leftIdx;
            int repeatIdx2 = midIdx + 1;
            int repeatIdx3 = leftIdx;


            while (repeatIdx1 <= midIdx && repeatIdx2 <= rightIdx)                                                      // 분할 정렬된 List의 결합(Combine)
            {
                if (list[repeatIdx1] <= list[repeatIdx2])                                                               // repeatIdx2의 담긴 값이 repeatIdx1의 담긴 값보다 크다면
                {
                    tempList[repeatIdx3] = list[repeatIdx1];                                                            // repeatIdx3의 repeatIdx1의 담긴 값을 넣는다.
                    repeatIdx3++;
                    repeatIdx1++;
                }
                else
                {
                    tempList[repeatIdx3] = list[repeatIdx2];                                                            // repeatIdx3의 repeatIdx2의 담긴 값을 넣는다.
                    repeatIdx3++;
                    repeatIdx2++;
                }
            }


            if (midIdx < repeatIdx1)                                                                                    // 남아 있는 값들을 복사
            {
                for (repeatIdx = repeatIdx2; repeatIdx <= rightIdx; repeatIdx++)
                {
                    tempList[repeatIdx3] = list[repeatIdx];
                    repeatIdx3++;
                }
            }
            else
            {
                for (repeatIdx = repeatIdx1; repeatIdx <= midIdx; repeatIdx++)                                          // 남아 있는 값들을 복사
                {
                    tempList[repeatIdx3] = list[repeatIdx];
                    repeatIdx3++;
                }
            }

            for (repeatIdx = leftIdx; repeatIdx <= rightIdx; repeatIdx++)                                               // 배열 tempList(임시 배열)의 리스트를 배열 list로 재복사
            {
                list[repeatIdx] = tempList[repeatIdx];
            }
        }

    }

}
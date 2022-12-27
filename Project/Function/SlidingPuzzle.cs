using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class SlidingPuzzle
    {
        /**
         * 슬라이딩 퍼즐 성립 조건
         * 1. 타일이 N행 으로 펼쳐지는 대신 단일 행으로 되어있다 가정하면 a타일이 b타일 앞에 나타나지만
         * A>B가 나타나면 타일 쌍(a,b)이 inversion을 형성한다
         * ex) 2 1 3 6 5 4 7 8 X / 와 같이 정렬된 배열에서
         * 2가 1보다 앞에있고 크기 때문에 Inversion 개수가 1 추가된다
         * 6이 5,4보다 앞에있고 크기 때문에 Inversion 개수가 2 추가된다
         * 2. 타일의 너비가 홀수일때 Inversion 개수가 짝수면 퍼즐은 성립한다.
         * 3. 타일의 너비가 짝수일때 공백의 위치가 짝수열에 있고 Inversion이 홀수면 퍼즐은 성립한다.
         * 4. 타일의 너비가 짝수일때 공백의 위치가 홀수열에 있고 Inversion이 짝수면 퍼즐은 성립한다.
         * 이 외에 모든 퍼즐은 성립하지 않는다.
         */

        static Random mRand = new Random();                                                     // 난수를 생성할 Random 클래스
        static int[]? mPuzzleBoard;                                                             // 퍼즐의 값을 담을 배열
        static bool[]? mPuzzleClearBoard;                                                       // 퍼즐이 옳은 위치에 있나 판단을 위한 bool 배열
        const int mPuzzleSize = 3;                                                              // ==== 퍼즐의 너비 ==== > 9X9 츄라이 츄라이
        static int mPlayerPoint;                                                                // 퍼즐에서 빈공간에 좌표
        static int mInversion;                                                                  // 퍼즐이 성립하는지 확인하기 위한 변수
        static int mCount;                                                                      // 퍼즐을 움직인 횟수
        static int mGameClearCount;                                                             // 모든 퍼즐이 올바른 위치에 있는지 확인할 변수
        static bool mValidPuzzle;                                                               // 퍼즐에 성립 조건을 확인
        static bool mGameClear;                                                                 // 퍼즐에 클리어 확인
        static bool mGameExit;                                                                  // 퍼즐 종료 확인

        static ConsoleKeyInfo mUserInput;                                                       // 유저의 입력을 받기 위한 변수

        static void Main(string[] args)                                                         // Main()
        {
            Init();
        }   // Main()

        static public void Init()                                                               // 최초 실행 초기화 함수
        {
            mPlayerPoint = 0;                                                       // 변수 초기화
            mInversion = 0;                                                         //     "
            mCount = 0;                                                             //     "
            mGameClearCount = 0;                                                    //     "
            mValidPuzzle = false;                                                   //     "
            mGameClear = false;                                                     //     "

            mPuzzleBoard = new int[mPuzzleSize * mPuzzleSize];                      // 배열 생성
            mPuzzleClearBoard = new bool[mPuzzleSize * mPuzzleSize];                //     "

            for (int i = 0; i < mPuzzleBoard.Length; i++)
            {
                mPuzzleBoard[i] = i + 1;
                mPuzzleClearBoard[i] = false;
            }

            Shuffle();                                                              // Shuffle 함수 실행
            Update();                                                               // Update 함수 실행

            if (mGameClear)
            {
                Console.WriteLine("게임 클리어! (고생했다 나자신)");
            }
            else if (mGameExit)
            {
                Console.WriteLine("게임 종료! (고생했다 나자신)");
            }

        }   // Init()

        static public void Update()                                                             // 반복루프 함수
        {
            while (true)
            {
                Draw();                                                             // Draw() 함수 실행
                Move();                                                             // Move() 함수 실행
                GameClearCheck();                                                   // GameClearCheck() 함수 실행
                if (mGameClear || mGameExit)                                        // 게임 종료 조건
                {
                    break;
                }
            }
        }   // Update()

        static public void Shuffle()                                                            // 셔플 함수
        {
            while (!mValidPuzzle)                                                   // mValidPuzzle bool 값이 true가 나올때까지 도는 반복문
            {
                mValidPuzzle = false;
                for (int i = 0; i < mPuzzleBoard.Length; i++)
                {
                    int temp = mPuzzleBoard[i];                                     // 임시 변수를 생성해서 mPuzzleBoard배열의 i번째 값을 대입
                    int randNum = mRand.Next(0, mPuzzleBoard.Length);               // 난수 생성 ( 범위 0 ~ mPuzzleBoard크기만큼 )
                    mPuzzleBoard[i] = mPuzzleBoard[randNum];                        // mPuzzleBoard i번째 배열의 mPuzzleBoard 난수번째 배열 값 대입
                    mPuzzleBoard[randNum] = temp;                                   // mPuzzleBoard 난수번째 배열의 임시 저장한 값 대입
                }   // loop : mPuzzleBoard 배열 크기만큼 도는 루프
                for (int i = 0; i < mPuzzleBoard.Length; i++)                       // 퍼즐 성립조건 확인용 반복문
                {
                    for (int j = i; j < mPuzzleBoard.Length; j++)
                    {
                        if (mPuzzleBoard[i] > mPuzzleBoard[j])
                        {
                            mInversion++;
                        }
                    }
                }   // loop : mPuzzleBoard 배열 크기만큼 도는 루프
                if (mPuzzleSize % 2 == 0)            //   if : 퍼즐 사이즈가 짝수면
                {
                    for (int i = 0; i < mPuzzleBoard.Length; i++)
                    {
                        if (mPuzzleBoard[i].Equals(mPuzzleSize * mPuzzleSize))
                        {
                            //Console.WriteLine($"{i}");
                            //Console.WriteLine($"{i / mPuzzleSize + 1}");
                            if ((i / mPuzzleSize + 1) % 2 == 0 && mInversion % 2 != 0)      // if : 퍼즐 성립 조건 (상세 내용 최상단부 확인)
                            {
                                mValidPuzzle = true;
                                mPlayerPoint = i;                                           // 플레이어의 좌표를 지정
                                break;
                            }
                            else if ((i / mPuzzleSize + 1) % 2 != 0 && mInversion % 2 == 0) // if : 퍼즐 성립 조건 (상세 내용 최상단부 확인)
                            {
                                mValidPuzzle = true;
                                mPlayerPoint = i;                                           // 플레이어의 좌표를 지정
                                break;
                            }
                            else
                            {
                                mValidPuzzle = false;
                                break;
                            }
                        }
                    }   // loop : mPuzzleBoard의 크기만큼 도는 루프
                }
                else                                // else : 퍼즐 사이즈가 홀수면
                {
                    if (mInversion % 2 == 0)        // if : Inversion이 짝수면 셔플 중지
                    {
                        mValidPuzzle = true;
                        for (int i = 0; i < mPuzzleBoard.Length; i++)
                        {
                            if (mPuzzleBoard[i].Equals(mPuzzleSize * mPuzzleSize))
                            {
                                mPlayerPoint = i;
                            }
                        }
                        break;
                    }
                }
            }

        }   // Shuffle()

        static public void Draw()
        {
            Console.Clear();                                                        // 화면 초기화
            string gameBoard = "===============\n" +                                // 상단부 표시용 string값
                " 슬라이딩 퍼즐 \n" +
                "===============\n";
            Console.Write(gameBoard);                                               // 상단부 표시
            for (int i = 0; i < mPuzzleBoard.Length; i++)
            {
                if (i % mPuzzleSize == 0 && i != 0)
                {
                    Console.WriteLine();
                }
                if (i.Equals(mPlayerPoint))
                {
                    Console.Write($"X".PadLeft(4));
                }
                else if (mPuzzleClearBoard[i])
                {
                    Console.Write("■".PadLeft(4));
                }
                else
                {
                    Console.Write($"{mPuzzleBoard[i]}".PadLeft(4));
                }
            }
            Console.WriteLine();
            string gameInfo = "===============\n" +
                "시도 횟수 : " + mCount + "\n" +
                "===============\n";
            Console.WriteLine(gameInfo);
            //Console.WriteLine($"{mPuzzleBoard[mPlayerPoint]} : {temp}");
        }   // Draw()

        static public ConsoleKey GetInput()                                                     // 유저의 입력을 받는 함수
        {
            mUserInput = Console.ReadKey();
            return mUserInput.Key;
        }   //GetInput()

        static void Move()                                                                      // 유저의 입력을 받아서 입력 값에 따른 동작을 수행하는 함수
        {
            int temp = 0;
            switch (GetInput())
            {
                case ConsoleKey.W:
                    if (mPlayerPoint / mPuzzleSize == 0)                                        // 공백의 좌표가 최상단이면
                    {
                        break;                                                                  // switch문 탈출
                    }
                    temp = mPuzzleBoard[mPlayerPoint];                                          // 공백의 좌표의 값 임시 저장
                    mPuzzleBoard[mPlayerPoint] = mPuzzleBoard[mPlayerPoint - mPuzzleSize];      // 공백칸이 이동할 좌표의 값 저장
                    mPuzzleBoard[mPlayerPoint - mPuzzleSize] = temp;                            // 공백칸이 이동하고 난 뒤에 좌표의 임시 저장한 값 대입
                    mPlayerPoint -= mPuzzleSize;
                    mCount++;
                    break;
                case ConsoleKey.S:
                    if (mPlayerPoint / mPuzzleSize == mPuzzleBoard.Length / mPuzzleSize - 1)    // 공백의 좌표가 최하단이면
                    {
                        break;                                                                  // switch문 탈출
                    }
                    temp = mPuzzleBoard[mPlayerPoint];                                          // 공백의 좌표의 값 임시 저장
                    mPuzzleBoard[mPlayerPoint] = mPuzzleBoard[mPlayerPoint + mPuzzleSize];      // 공백칸이 이동할 좌표의 값 저장
                    mPuzzleBoard[mPlayerPoint + mPuzzleSize] = temp;                            // 공백칸이 이동하고 난 뒤에 좌표의 임시 저장한 값 대입
                    mPlayerPoint += mPuzzleSize;
                    mCount++;
                    break;
                case ConsoleKey.A:
                    if (mPlayerPoint % mPuzzleSize == 0)                                        // 공백의 좌표가 최좌측이면
                    {
                        break;                                                                  // switch문 탈출
                    }
                    temp = mPuzzleBoard[mPlayerPoint];                                          // 공백의 좌표의 값 임시 저장
                    mPuzzleBoard[mPlayerPoint] = mPuzzleBoard[mPlayerPoint - 1];                // 공백칸이 이동할 좌표의 값 저장
                    mPuzzleBoard[mPlayerPoint - 1] = temp;                                      // 공백칸이 이동하고 난 뒤에 좌표의 임시 저장한 값 대입
                    mPlayerPoint -= 1;
                    mCount++;
                    break;
                case ConsoleKey.D:
                    if (mPlayerPoint % mPuzzleSize == mPuzzleSize - 1)                          // 공백의 좌표가 최우측이면
                    {
                        break;                                                                  // switch문 탈출
                    }
                    temp = mPuzzleBoard[mPlayerPoint];                                          // 공백의 좌표의 값 임시 저장
                    mPuzzleBoard[mPlayerPoint] = mPuzzleBoard[mPlayerPoint + 1];                // 공백칸이 이동할 좌표의 값 저장
                    mPuzzleBoard[mPlayerPoint + 1] = temp;                                      // 공백칸이 이동하고 난 뒤에 좌표의 임시 저장한 값 대입
                    mPlayerPoint += 1;
                    mCount++;
                    break;
                case ConsoleKey.Escape:
                    mGameExit = true;
                    break;
                default:
                    break;
            }
        }   //Move()

        static void GameClearCheck()                                                            // 게임의 클리어 조건을 확인하는 함수
        {
            mGameClearCount = 0;                                                                // 변수 초기화    
            for (int i = 0; i < mPuzzleBoard.Length; i++)                                       
            {
                if (mPuzzleBoard[i].Equals(i + 1))                                              // mPuzzleBoard배열의 값이 올바른 위치에 있다면 ex) 0번째 칸의 1이 위치한다면
                {
                    mPuzzleClearBoard[i] = true;                                                // mPuzzleClearBoard[i] true
                }
                else
                {
                    mPuzzleClearBoard[i] = false;
                }

            }   // loop : mPuzzleBoard배열의 크기만큼 도는 루프
            for (int i = 0; i < mPuzzleClearBoard.Length; i++)
            {
                if (mPuzzleClearBoard[i])                                                       // mPuzzleClearBoard의 값이 true라면
                {
                    mGameClearCount++;                                                          // 카운트 ++
                }
            }   // loop : mPuzzleBoard배열의 크기만큼 도는 루프
            if (mGameClearCount.Equals(mPuzzleSize * mPuzzleSize))                              // 카운트값이 게임보드의 최대 칸수와 일치한다면
            {
                mGameClear = true;                                                              // mGameClear true => 게임 클리어 확인 bool변수
            }
        }   // GameClearCheck()
    }   // class SlidingPuzzle
}   // namespace Function

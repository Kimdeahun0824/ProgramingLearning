using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Task
    {
        /**
         * 5x5 보드 ( 사이즈 줘도 ok)
         * 빈 곳 중에 아무곳이나 사람( 이모티콘 또는 옷)을 초기화해서
         * w, a, s, d 입력 받아서 빈 곳을 자유롭게 이동하는 프로그램 작성.
         * - 조건 사람은 빈 곳을 다닐 수 있음
         */

        static int FIELDMAX_X = 10;
        static int FIELDMAX_Y = 10;
        static string[,] field = new string[FIELDMAX_X, FIELDMAX_Y];
        static int playerX = 3;
        static int playerY = 3;

        static ConsoleKey Input;
        static bool Escape = false;

        static void Main(string[] args)
        {
            fieldInit();
            while (!Escape)
            {
                fieldDraw();
                move();
                Console.Clear();
            }

        }

        static ConsoleKey getInput()
        {
            ConsoleKeyInfo Input;
            Input = Console.ReadKey(true);
            return Input.Key;
        }
        static void fieldInit()
        {

            for (int y = 0; y < FIELDMAX_Y; y++)
            {
                for (int x = 0; x < FIELDMAX_X; x++)
                {
                    if (y.Equals(0) || y.Equals(FIELDMAX_Y - 1) || x.Equals(0) || x.Equals(FIELDMAX_X - 1))
                    {
                        field[y, x] = "■";
                    }
                    else
                    {
                        field[y, x] = ". ";
                    }
                }
            }
        }
        static void fieldDraw()
        {
            for (int y = 0; y < FIELDMAX_Y; y++)
            {
                for (int x = 0; x < FIELDMAX_X; x++)
                {
                    if (playerX.Equals(x) && playerY.Equals(y))
                    {
                        Console.Write("♥");
                    }
                    else
                    {
                        Console.Write($"{field[y, x]}");
                    }

                }
                Console.WriteLine();
            }
        }
        static void move()
        {
            Input = getInput();
            switch (Input)
            {
                case ConsoleKey.W:
                    if (playerY < 2)
                    {
                        break;
                    }
                    else
                    {
                        playerY--;
                    }
                    break;
                case ConsoleKey.S:
                    if (FIELDMAX_Y - 2 <= playerY)
                    {
                        break;
                    }
                    else
                    {
                        playerY++;
                    }
                    break;
                case ConsoleKey.A:
                    if (playerX < 2)
                    {
                        break;
                    }
                    else
                    {
                        playerX--;
                    }
                    break;
                case ConsoleKey.D:
                    if (FIELDMAX_X - 2 <= playerX)
                    {
                        break;
                    }
                    else
                    {
                        playerX++;
                    }
                    break;
                case ConsoleKey.Escape:
                    Escape = true;
                    break;
                default:
                    break;

            }
        }
    }
}

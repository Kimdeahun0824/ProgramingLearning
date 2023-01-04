using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MapTest
{
    public class Player                                     // 플레이어 클래스
    {
        KeyManager keyManager = KeyManager.Instance;        // 키보드 입력을 받기 위한 매니저 클래스 Singleton
        private Point mPos;                                 // 플레이어의 좌표
        private int mScore;                                 // 플레이어의 점수
        private string mIcon;                               // 플레이어가 화면에 표시될 아이콘
        private bool mIs_Up_Move_Possibility;               // 위로 이동이 가능한지 체크하기 위한 Boolean값
        private bool mIs_Down_Move_Possibility;             // 아래로 이동이 가능한지 체크하기 위한 Boolean값
        private bool mIs_Left_Move_Possibility;             // 왼쪽으로 이동이 가능한지 체크하기 위한 Boolean값
        private bool mIs_Right_Move_Possibility;            // 오른쪽으로 이동이 가능한지 체크하기 위한 Boolean값
        private bool mIs_Press_Escape;                      // ESC를 눌렀는지 확인하기 위한 Boolean값

        public Player()                                     // Player클래스 생성자 매개변수가 안 들어올땐 모든 값을 기본 값으로 바꿔줌
        {
            mPos = new Point();
            mScore = 0;
            mIcon = string.Empty;
            mIs_Up_Move_Possibility = true;
            mIs_Down_Move_Possibility = true;
            mIs_Left_Move_Possibility = true;
            mIs_Right_Move_Possibility = true;
            mIs_Press_Escape = false;
        }       // Constuctor Player()                            
        public Player(Point Pos, int Score, string Icon)    // Player클래스 생성자 매개변수로 좌표, 점수, 아이콘을 받아와서 저장
        {
            mPos = Pos;
            mScore = Score;
            mIcon = Icon;
            mIs_Up_Move_Possibility = true;
            mIs_Down_Move_Possibility = true;
            mIs_Left_Move_Possibility = true;
            mIs_Right_Move_Possibility = true;
            mIs_Press_Escape = false;
        }       // Consturctor Player(Point Pos, int Score, string Icon)
        public void Move()                                  // Player의 이동을 구현한 함수 KeyManager 클래스에서 키보드 입력을 받아옴
        {
            switch (keyManager.UserInput())                 // 유저 입력에 따라 Switch문을 통하고 유저의 좌표를 변경시킴 / Boolean값을 통해 이동 불가능한 경우에는 이동하지 않음
            {
                case ConsoleKey.UpArrow:
                    if (Is_Up_Move_Possibility)
                    {
                        mPos.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Is_Down_Move_Possibility)
                    {
                        mPos.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (Is_Left_Move_Possibility)
                    {
                        mPos.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (Is_Right_Move_Possibility)
                    {
                        mPos.X += 1;
                    }
                    break;
                case ConsoleKey.W:
                    if (Is_Up_Move_Possibility)
                    {
                        mPos.Y -= 1;
                    }
                    break;
                case ConsoleKey.S:
                    if (Is_Down_Move_Possibility)
                    {
                        mPos.Y += 1;
                    }
                    break;
                case ConsoleKey.A:
                    if (Is_Left_Move_Possibility)
                    {
                        mPos.X -= 1;
                    }
                    break;
                case ConsoleKey.D:
                    if (Is_Right_Move_Possibility)
                    {
                        mPos.X += 1;
                    }
                    break;
                case ConsoleKey.Spacebar:
                    break;
                case ConsoleKey.Escape:
                    mIs_Press_Escape = true;
                    break;
                default:
                    break;
            }       // switch (keyManager.UserInput())
        }       // Move()
        public void AddScore(int score)                     // Player의 점수를 매개변수 값만큼 더해주는 함수
        {
            mScore += score;        
        }       // AddScore(int score)
        public Point Pos                                    // Player mPos Property
        {
            get { return mPos; }
            set { mPos = value; }
        }       // Point Pos Getter Setter                             
        public int Pos_X                                    // Player mPos.X Property
        {
            get { return mPos.X; }
            set { mPos.X = value; }

        }       // int Pos_X Getter Setter
        public int Pos_Y                                    // Player mPos.Y Property
        {
            get { return mPos.Y; }
            set { mPos.Y = value; }

        }       // int Pos_Y Getter Setter
        public int Score                                    // Player mScore Property
        {
            get { return mScore; }
            set { mScore = value; }
        }       // int Score Getter Setter
        public string Icon                                  // Player mIcon Property
        {
            get { return mIcon; }
            set { mIcon = value; }
        }       // string Icon Getter Setter
        public bool Is_Up_Move_Possibility                  // Player mIs_Up_Move_Possibility Property
        {
            get { return mIs_Up_Move_Possibility; }
            set { mIs_Up_Move_Possibility = value; }
        }       // bool Is_Up_Move_Possibility Getter Setter
        public bool Is_Down_Move_Possibility                // Player mIs_Down_Move_Possibility Property
        {
            get { return mIs_Down_Move_Possibility; }
            set { mIs_Down_Move_Possibility = value; }
        }       // bool Is_Down_Move_Possibility Getter Setter
        public bool Is_Left_Move_Possibility                // Player mIs_Left_Move_Possibility Property
        {
            get { return mIs_Left_Move_Possibility; }
            set { mIs_Left_Move_Possibility = value; }
        }       // bool Is_Left_Move_Possibility Getter Setter
        public bool Is_Right_Move_Possibility               // Player mIs_Right_Move_Possibility Property
        {
            get { return mIs_Right_Move_Possibility; }
            set { mIs_Right_Move_Possibility = value; }
        }       // bool Is_Right_Move_Possibility Getter Setter
        public bool Is_Press_Escape                         // Player mIs_Press_Escape Property
        {
            get { return mIs_Press_Escape; }
            set { mIs_Press_Escape = value; }
        }       // bool Is_Press_Escape Getter Setter

    }
}

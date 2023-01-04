using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTest
{
    internal class Game
    {
        ItemObjectPool itemOjbectPool;                                  // Item ObjectPool
        private PlayerDirector playerDirector;                          // Player Builder
        private Player player;                                          // Player Instance
        private List<Maps> maps;                                        // 맵들을 담을 List
        private int currentMapIdx;                                      // 현재 위치한 맵의 Index

        public Game()                                                   // 생성자
        {
            Init();                                                     // Initializing Method
            Update();                                                   // Update Method
        }       // Constructor Game() End
        public void Init()                                              // Initializing Method
        {
            itemOjbectPool = new ItemObjectPool();                      // Item ObjectPool Instance 생성
            maps = new List<Maps>();                                    // maps List Instance 생성
            for (int i = 0; i < 4; i++)                                 // 맵 Instance 생성하여 List에 Add
            {
                maps.Add(new Maps(13, 17));
            }   // loop : N만큼 돎
            currentMapIdx = 0;                                          // 최초 시작 맵의 Index : 0
            playerDirector = new PlayerDirector(new PlayerBuilder());   // PlayerDirector Class Instance 생성
            player = playerDirector.GetDefaultPlayerPos
                (new System.Drawing.Point(maps[currentMapIdx].Width / 2
                , maps[currentMapIdx].Height / 2));                     // 맵의 가운데로 Player의 생성
            ItemCreate(5);                                              // ItemObjectPool 에서 매개변수 값만큼 Item을 Pop해오고 랜덤한 좌표로 이동시킴
            PortalCreate();                                             // 맵간 이동을 구현하기 위한 Portal 정해진 정수 값을 할당해서 위치를 고정시킴
        }       // Init() Method End
        public void Update()                                            // Update Method
        {
            while (true)                                                // loop : 무한반복 루프
            {
                Console.Clear();
                Draw();                                                 // 화면을 출력해줄 Draw Method
                player.Move();                                          // Player의 이동 함수를 여기서 호출함
                Collision();                                            // Player의 각종 충돌을 구현한 Method
                if (player.Is_Press_Escape)                             // Player가 Escape를 누를 시 루프 탈출
                {
                    break;
                }       // if End
            }       // While(loop) End
        }       // Update() Method End
        public void Collision()                                         // Player와 각종 객체의 충돌을 구현한 Collision Method
        {
            ItemCollision();                                            // Item과의 충돌을 구현한 Method
            PortalCollision();                                          // Portal과의 충돌을 구현한 Method
            WallCollsion();                                             // 벽과의 충돌을 구현한 Method
        }       // Collision() Method End
        public void ItemCollision()                                     // Item과의 충돌을 구현한 Method
        {
            for (int i = 0; i < maps[currentMapIdx].Items.Count; i++)   // loop : 현재 위치한 맵의 Item 갯수만큼 반복
            {
                if (maps[currentMapIdx].Items[i].Pos == player.Pos)     // if : Item의 좌표와 Player의 좌표가 동일하다면
                {
                    player.AddScore(maps[currentMapIdx].Items[i].Score);    // Player의 점수를 Item의 점수만큼 더해줌
                    itemOjbectPool.ItemPush(maps[currentMapIdx].Items[i]);  // Item을 ObjectPool에 Push함
                }       // if : End
            }       // loop : End
        }       // ItemCollision() Method End
        public void PortalCollision()                                   // Portla과의 충돌을 구현한 Method
        {
            for (int i = 0; i < maps[currentMapIdx].Portals.Count; i++) // loop : 현재 맵의 Portal의 갯수만큼 반복
            {
                if (maps[currentMapIdx].Portals[i].Pos == player.Pos)   // if : Portal의 좌표와 플레이어의 좌표가 동일하다면
                {
                    for (int j = 0; j < maps[currentMapIdx].Items.Count; j++)   // loop : 현재 맵의 Item의 갯수만큼 반복
                    {
                        itemOjbectPool.ItemPush(maps[currentMapIdx].Items[j]);  // ItemObjectPool의 Item Push
                    }
                    player.Pos = maps[currentMapIdx].Portals[i].NextPos;        // Player의 좌표를 Portal의 저장된 좌표로 변경
                    currentMapIdx = maps[currentMapIdx].Portals[i].NextIdx;     // 현재 맵의 Index를 Portal의 저장된 Index로 변경
                    ItemCreate(5);                                              // 새로 Item을 N만큼 Pop
                    break;
                }       // if End
            }
        }       // PortalCollision() Method End
        public void WallCollsion()
        {
            if (player.Pos.X <= 1)
            {
                player.Is_Left_Move_Possibility = false;
            }
            else
            {
                player.Is_Left_Move_Possibility = true;
            }
            if (player.Pos.Y <= 1)
            {
                player.Is_Up_Move_Possibility = false;
            }
            else
            {
                player.Is_Up_Move_Possibility = true;
            }
            if (player.Pos.X >= maps[currentMapIdx].Width - 2)
            {
                player.Is_Right_Move_Possibility = false;
            }
            else
            {
                player.Is_Right_Move_Possibility = true;
            }
            if (player.Pos.Y >= maps[currentMapIdx].Height - 2)
            {
                player.Is_Down_Move_Possibility = false;
            }
            else
            {
                player.Is_Down_Move_Possibility = true;
            }
        }
        public void Draw()
        {
            MapDraw();
            UIDraw();
        }
        public void MapDraw()
        {
            for (int y = 0; y < maps[currentMapIdx].Height; y++)
            {
                for (int x = 0; x < maps[currentMapIdx].Width; x++)
                {
                    if (x == player.Pos_X && y == player.Pos_Y)
                    {
                        Console.Write(player.Icon);
                        continue;
                    }
                    Pair<bool, int> mapDrawCheck = MapItemDraw(x, y);
                    if (mapDrawCheck.LeftValue)
                    {
                        Console.Write(maps[currentMapIdx].Items[mapDrawCheck.RightValue].Icon);
                        continue;
                    }
                    mapDrawCheck = MapPortalDraw(x, y);
                    if (mapDrawCheck.LeftValue)
                    {
                        Console.Write(maps[currentMapIdx].Portals[mapDrawCheck.RightValue].Icon);
                        continue;
                    }
                    if (x == 0 || y == 0 || x == maps[currentMapIdx].Width - 1 || y == maps[currentMapIdx].Height - 1)
                    {
                        Console.Write("■");
                        continue;
                    }
                    else
                    {
                        Console.Write("□");
                    }
                }
                Console.WriteLine();
            }
        }
        public void UIDraw()
        {
            Console.WriteLine("플레이어가 현재 있는 방 : {0}번째 방", currentMapIdx + 1);
            Console.WriteLine("플레이어의 점        수 : {0}", player.Score);
            Console.WriteLine("플레이어 좌표 : {0}", player.Pos);
        }
        public Pair<bool, int> MapItemDraw(int x, int y)
        {
            Pair<bool, int> result = new Pair<bool, int>();
            for (int i = 0; i < maps[currentMapIdx].Items.Count; i++)
            {
                if (x.Equals(maps[currentMapIdx].Items[i].Pos.X) && y.Equals(maps[currentMapIdx].Items[i].Pos.Y))
                {
                    result.LeftValue = true;
                    result.RightValue = i;
                    return result;
                }
            }
            result.LeftValue = false;
            return result;
        }
        public Pair<bool, int> MapPortalDraw(int x, int y)
        {
            Pair<bool, int> result = new Pair<bool, int>();
            for (int i = 0; i < maps[currentMapIdx].Portals.Count; i++)
            {
                if (x.Equals(maps[currentMapIdx].Portals[i].Pos.X) && y.Equals(maps[currentMapIdx].Portals[i].Pos.Y))
                {
                    result.LeftValue = true;
                    result.RightValue = i;
                    return result;
                }
            }
            result.LeftValue = false;
            return result;
        }
        public void ItemCreate(int num)
        {
            Random random = new Random();
            List<int> overlapX = new List<int>();
            List<int> overlapY = new List<int>();

            for (int i = 0; i < num; i++)
            {
                bool overlap = false;
                int randX = random.Next(1, maps[currentMapIdx].Width - 2);
                int randY = random.Next(1, maps[currentMapIdx].Height - 2);
                if (randX == 1 || randY == 1)
                {
                    i--;
                    continue;
                }
                for (int j = 0; j < overlapX.Count; j++)
                {
                    if (overlapX[j] == randX)
                    {
                        i--;
                        overlap = true;
                        break;
                    }
                }
                if (overlap)
                {
                    continue;
                }
                for (int j = 0; j < overlapY.Count; j++)
                {
                    if (overlapY[j] == randY)
                    {
                        i--;
                        overlap = true;
                        break;
                    }
                }
                if (overlap)
                {
                    continue;
                }
                else
                {
                    maps[currentMapIdx].Items.Add(itemOjbectPool.ItemPop(randX, randY));
                    overlapX.Add(randX);
                    overlapY.Add(randY);
                }
            }


            //Console.WriteLine(maps[currentMapIdx].Items[0].Icon);
        }
        public void PortalCreate()
        {
            maps[0].PortalsCreate
                (new Point(maps[0].Width / 2, 1)
                , new Point(maps[1].Width / 2, maps[1].Height - 3)
                , 1);

            maps[0].PortalsCreate
                (new Point(maps[0].Width - 2, maps[0].Height / 2)
                , new Point(2, maps[3].Height / 2)
                , 3);


            maps[1].PortalsCreate
                (new Point(maps[1].Width / 2, maps[1].Height - 2)
                , new Point(maps[0].Width / 2, 2)
                , 0);

            maps[1].PortalsCreate
                (new Point(maps[1].Width - 2, maps[1].Height / 2)
                , new Point(2, maps[2].Height / 2)
                , 2);


            maps[2].PortalsCreate
                (new Point(1, maps[2].Height / 2)
                , new Point(maps[1].Width - 3, maps[1].Height / 2)
                , 1);

            maps[2].PortalsCreate
                (new Point(maps[2].Width / 2, maps[2].Height - 2)
                , new Point(maps[3].Width / 2, 2)
                , 3);


            maps[3].PortalsCreate
                (new Point(maps[3].Width / 2, 1)
                , new Point(maps[2].Width / 2, maps[2].Height - 3)
                , 2);

            maps[3].PortalsCreate
                (new Point(1, maps[3].Height / 2)
                , new Point(maps[0].Width - 3, maps[0].Height / 2)
                , 0);
        }
    }
}

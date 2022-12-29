using System.Text;

namespace ValueTypeAndReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item sword1 = new Item("녹슨 검", 1, 0);
            Item sword2 = new Item("철 검", 3, 0);
            Item shield1 = new Item("녹슨 방패", 0, 1);
            Item shield2 = new Item("철 방패", 0, 3);
            Item AddItem = new Item();
            Player player = new Player("플레이어", 50, 5, 0, 0);
            player.AddItem(sword2);
            Random random = new Random();
            switch (random.Next(4))
            {
                case 0:
                    AddItem = sword1;
                    break;
                case 1:
                    AddItem = sword2;
                    break;
                case 2:
                    AddItem = shield1;
                    break;
                case 3:
                    AddItem = shield2;
                    break;
                default:
                    break;
            }
            Slime slime = new Slime("슬라임", 10, 2, 0, 0, 0, AddItem);
            Goblin goblin = new Goblin("고블린", 15, 3, 2, 0, 0, AddItem);
            Orc orc = new Orc("오크", 20, 4, 4, 0, 0, AddItem);

            int userInput = 0;
            while (true)
            {
                if (player.DIE)
                {
                    break;
                }
                Console.WriteLine($"공격할 몬스터를 선택\n{slime.Name} : 1\n{goblin.Name} : 2\n{orc.Name} : 3");
                int.TryParse(Console.ReadLine(), out userInput);
                switch (userInput)
                {
                    case 1:
                        player.Attack(slime);
                        slime.attack(player);
                        break;
                    case 2:
                        player.Attack(goblin);
                        goblin.attack(player);
                        break;
                    case 3:
                        player.Attack(orc);
                        orc.attack(player);
                        break;
                    default:
                        break;
                }
                switch (random.Next(4))
                {
                    case 0:
                        AddItem = sword1;
                        break;
                    case 1:
                        AddItem = sword2;
                        break;
                    case 2:
                        AddItem = shield1;
                        break;
                    case 3:
                        AddItem = shield2;
                        break;
                    default:
                        break;
                }
                if (slime.DIE)
                {
                    slime = null;
                    slime = new Slime("슬라임", 10, 2, 0, 0, 0, AddItem); 
                }
                if (goblin.DIE)
                {
                    goblin = null;
                    goblin = new Goblin("고블린", 15, 3, 2, 0, 0, AddItem);
                }
                if (orc.DIE)
                {
                    orc = null;
                    orc = new Orc("오크", 20, 4, 4, 0, 0, AddItem);
                }
            }

        }
    }
}
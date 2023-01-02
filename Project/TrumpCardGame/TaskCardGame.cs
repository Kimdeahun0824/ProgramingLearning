using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpCardGame
{
    //internal class TaskCardGame : CardGame
    //{
    //    /**
    //     * 과제 - 카드 뽑기 게임을 작성해서 제출
    //     *      - 컴퓨터가 2장을 뽑아서 보여줌
    //     *      - 플레이어가 배팅을 함. (패스 가능)
    //     *      - 플레이어가 뽑은 카드가 컴퓨터가 뽑은 2장의 카드 사이에 있는 카드라면 플레이어가 2배 벌어감.
    //     *      - 플레이어가 뽑은 카드가 컴퓨터가 뽑은 2장의 카드 사이에 없다면 플레이어는 배팅금액을 잃음.
    //     *      - 플레이어는 10,000 포인트 들고 게임을 시작함
    //     *      - 카드의 대, 소 비교는 오직 숫자로만.
    //     *      - 게임 종료는 100,000 포인트를 벌거나, 모두 잃을 때
    //     */

    //    Deck mDeck;
    //    Player player;
    //    Dealer dealer;
    //    bool gameEnd;

    //    public TaskCardGame()
    //    {
    //        Init();
    //        Update();
    //    }

    //    private void Init()
    //    {
    //        mDeck = new Deck();
    //        mDeck.CardSetup();
    //        mDeck.CardShuffle();
    //        player = new Player(10000);
    //        dealer = new Dealer();
    //        gameEnd = false;

    //        //foreach (var card in cards)
    //        //{
    //        //    Console.WriteLine($"{card.Name} / {card.Mark} / {card.Number} ");
    //        //}
    //    }

    //    private void Update()
    //    {
    //        while (!gameEnd)
    //        {
    //            CardGamePlay();
    //        }
    //    }

    //    protected override Card CardDraw()
    //    {
    //        try
    //        {
    //            Card card = mDeck.cards[0];
    //            mDeck.cards.Remove(mDeck.cards[0]);
    //            return card;
    //        }
    //        catch (Exception)
    //        {

    //            throw;
    //        }

    //    }

    //    protected override void CardGamePlay()
    //    {
    //        try
    //        {
    //            mDeck.CardSetup();
    //            mDeck.CardShuffle();
    //            if(dealer.Cards != null)
    //            {
    //                dealer.Cards.Clear();
    //            }
    //            dealer.CardDraw(CardDraw());
    //            dealer.CardDraw(CardDraw());
    //            string GameBoard = "     ===========================\n" +
    //                "      Welcome to Kyungil Casino\n" +
    //                "     ===========================";
    //            Console.WriteLine(GameBoard);
    //            string dealerCards = "  ==========            ==========\n";

    //            if (dealer.Cards[0].Name == "10" && dealer.Cards[1].Name == "10")
    //            {
    //                dealerCards += " |" + dealer.Cards[0].Mark + dealer.Cards[0].Name + "      |          |" + dealer.Cards[1].Mark + dealer.Cards[1].Name + "      |\n";
    //            }
    //            else if (dealer.Cards[0].Name == "10" && dealer.Cards[1].Name != "10")
    //            {
    //                dealerCards += " |" + dealer.Cards[0].Mark + dealer.Cards[0].Name + "      |          |" + dealer.Cards[1].Mark + dealer.Cards[1].Name + "       |\n";
    //            }
    //            else if (dealer.Cards[0].Name != "10" && dealer.Cards[1].Name == "10")
    //            {
    //                dealerCards += " |" + dealer.Cards[0].Mark + dealer.Cards[0].Name + "       |          |" + dealer.Cards[1].Mark + dealer.Cards[1].Name + "      |\n";
    //            }
    //            else
    //            {
    //                dealerCards += " |" + dealer.Cards[0].Mark + dealer.Cards[0].Name + "       |          |" + dealer.Cards[1].Mark + dealer.Cards[1].Name + "       |\n";
    //            }
    //            dealerCards +=
    //                " |          |          |          |\n" +
    //                " |          |          |          |\n" +
    //                " |          |          |          |\n" +
    //                " |          |          |          |\n" +
    //                " |          |          |          |\n" +
    //                " |          |          |          |\n";
    //            if (dealer.Cards[0].Name == "10" && dealer.Cards[1].Name == "10")
    //            {
    //                dealerCards += " |      " + dealer.Cards[0].Name + dealer.Cards[0].Mark + "|          |      " + dealer.Cards[1].Name + dealer.Cards[1].Mark + "|\n";
    //            }
    //            else if (dealer.Cards[0].Name == "10" && dealer.Cards[1].Name != "10")
    //            {
    //                dealerCards += " |      " + dealer.Cards[0].Name + dealer.Cards[0].Mark + "|          |       " + dealer.Cards[1].Name + dealer.Cards[1].Mark + "|\n";
    //            }
    //            else if (dealer.Cards[0].Name != "10" && dealer.Cards[1].Name == "10")
    //            {
    //                dealerCards += " |       " + dealer.Cards[0].Name + dealer.Cards[0].Mark + "|          |      " + dealer.Cards[1].Name + dealer.Cards[1].Mark + "|\n";
    //            }
    //            else
    //            {
    //                dealerCards += " |       " + dealer.Cards[0].Name + dealer.Cards[0].Mark + "|          |       " + dealer.Cards[1].Name + dealer.Cards[1].Mark + "|\n";
    //            }
    //            dealerCards += "  ==========            ==========";

    //            Console.WriteLine(dealerCards);

    //            Console.WriteLine($"현재 보유 잔고 : {player.Money}");

    //            Console.Write("베팅 금액을 입력 : ");

    //            int bettingMoney = player.Betting();

    //            player.Card = CardDraw();

    //            Console.WriteLine("###########당신이 뽑은 카드###########");

    //            string playerCard = "             ==========\n";
    //            if (player.Card.Name == "10")
    //            {
    //                playerCard += "            |" + player.Card.Mark + player.Card.Name + "      |\n";
    //            }
    //            else
    //            {
    //                playerCard += "            |" + player.Card.Mark + player.Card.Name + "       |\n";
    //            }
    //            playerCard +=
    //                "            |          |\n" +
    //                "            |          |\n" +
    //                "            |          |\n" +
    //                "            |          |\n" +
    //                "            |          |\n";
    //            if (player.Card.Name == "10")
    //            {
    //                playerCard += "            |      " + player.Card.Name + player.Card.Mark + "|\n";
    //            }
    //            else
    //            {
    //                playerCard += "            |       " + player.Card.Name + player.Card.Mark + "|\n";
    //            }
    //            playerCard += "             ==========";
    //            Console.WriteLine(playerCard);

    //            if (dealer.Cards[0].Number < dealer.Cards[1].Number)
    //            {
    //                if (dealer.Cards[0].Number < player.Card.Number && player.Card.Number < dealer.Cards[1].Number)
    //                {
    //                    Console.WriteLine("당신의 승리");
    //                    player.AddMoney(bettingMoney * 2);
    //                }
    //                else
    //                {
    //                    Console.WriteLine("당신의 패배");
    //                }
    //            }
    //            else if (dealer.Cards[1].Number <= dealer.Cards[0].Number)
    //            {
    //                if (dealer.Cards[1].Number < player.Card.Number && player.Card.Number < dealer.Cards[0].Number)
    //                {
    //                    Console.WriteLine("당신의 승리");
    //                    player.AddMoney(bettingMoney * 2);
    //                }
    //                else
    //                {
    //                    Console.WriteLine("당신의 패배");
    //                }
    //            }

    //            Console.WriteLine("Press To Enter");
    //            ConsoleKeyInfo PressToEnter = Console.ReadKey();
    //            switch (PressToEnter.Key)
    //            {
    //                case ConsoleKey.Enter:
    //                    break;
    //                default:
    //                    break;
    //            }
    //            Console.Clear();

    //            if (100000 < player.Money)
    //            {
    //                gameEnd = true;
    //                Console.WriteLine("목표금액 달성 게임 종료");
    //            }
    //            else if (player.Money < 1)
    //            {
    //                gameEnd = true;
    //                Console.WriteLine("파산 게임 종료");
    //            }

    //        }
    //        catch (Exception)
    //        {

    //            throw;
    //        }

    //    }
    //}
}

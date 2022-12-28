using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpCardGame
{
    internal class TaskCardGame : CardGame
    {
        /**
         * 과제 - 카드 뽑기 게임을 작성해서 제출
         *      - 컴퓨터가 2장을 뽑아서 보여줌
         *      - 플레이어가 배팅을 함. (패스 가능)
         *      - 플레이어가 뽑은 카드가 컴퓨터가 뽑은 2장의 카드 사이에 있는 카드라면 플레이어가 2배 벌어감.
         *      - 플레이어가 뽑은 카드가 컴퓨터가 뽑은 2장의 카드 사이에 없다면 플레이어는 배팅금액을 잃음.
         *      - 플레이어는 10,000 포인트 들고 게임을 시작함
         *      - 카드의 대, 소 비교는 오직 숫자로만.
         *      - 게임 종료는 100,000 포인트를 벌거나, 모두 잃을 때
         */

        List<Card> cards;
        Player player;
        Dealer dealer;

        public TaskCardGame()
        {
            Init();
            Update();
        }

        private void Init()
        {
            CardSetup();
            CardShuffle();
            player = new Player(10000);
            dealer = new Dealer();


            //foreach (var card in cards)
            //{
            //    Console.WriteLine($"{card.Name} / {card.Mark} / {card.Number} ");
            //}
        }

        private void Update()
        {
            CardGamePlay();
            //while (true)
            //{

            //}
        }

        protected override void CardSetup()
        {
            try
            {
                cards = new List<Card>();
                string[] Marks = new string[4] { "♣", "◆", "♥", "♠" };

                for (int i = 1; i <= 52; i++)
                {
                    Card card = new Card();
                    switch (i % 13)
                    {
                        case 0:
                            card.Name = "K";
                            card.Number = 13;
                            break;
                        case 1:
                            card.Name = "A";
                            card.Number = 1;
                            break;
                        case 11:
                            card.Name = "J";
                            card.Number = 11;
                            break;
                        case 12:
                            card.Name = "Q";
                            card.Number = 12;
                            break;
                        default:
                            card.Name = Convert.ToString(i % 13);
                            card.Number = i % 13;
                            break;
                    }
                    card.Mark = Marks[(i - 1) / 13];
                    cards.Add(card);
                }
                //foreach (var card in cards)
                //{
                //    Console.WriteLine($"{card.Name} / {card.Mark} / {card.Number} ");
                //}
            }
            catch (Exception)
            {

                throw;
            }


        }

        protected override void CardShuffle()
        {
            try
            {
                Random random = new Random();
                for (int i = 0; i < 100; i++)
                {
                    int sourIdx = random.Next(0, 52);
                    int destIdx = random.Next(0, 52);
                    Card temp = cards[sourIdx];
                    cards[sourIdx] = cards[destIdx];
                    cards[destIdx] = temp;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected override Card CardDraw()
        {
            try
            {
                Card card = cards[0];
                cards.Remove(cards[0]);
                return card;
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected override void CardGamePlay()
        {
            try
            {
                dealer.CardDraw(CardDraw());
                dealer.CardDraw(CardDraw());
                string GameBoard = "     ===========================\n" +
                    "      Welcome to Kyungil Casino\n" +
                    "     ===========================";
                Console.WriteLine(GameBoard);
                string dealerCards = "  ==========            ==========\n";

                if (dealer.Cards[0].Name == "10" && dealer.Cards[1].Name == "10")
                {
                    dealerCards += " |" + dealer.Cards[0].Mark + dealer.Cards[0].Name + "      |          |" + dealer.Cards[1].Mark + dealer.Cards[1].Name + "      |\n";
                }
                else if (dealer.Cards[0].Name == "10" && dealer.Cards[1].Name != "10")
                {
                    dealerCards += " |" + dealer.Cards[0].Mark + dealer.Cards[0].Name + "      |          |" + dealer.Cards[1].Mark + dealer.Cards[1].Name + "       |\n";
                }
                else if (dealer.Cards[0].Name != "10" && dealer.Cards[1].Name == "10")
                {
                    dealerCards += " |" + dealer.Cards[0].Mark + dealer.Cards[0].Name + "       |          |" + dealer.Cards[1].Mark + dealer.Cards[1].Name + "      |\n";
                }
                else
                {
                    dealerCards += " |" + dealer.Cards[0].Mark + dealer.Cards[0].Name + "       |          |" + dealer.Cards[1].Mark + dealer.Cards[1].Name + "       |\n";
                }
                dealerCards +=
                    " |          |          |          |\n" +
                    " |          |          |          |\n" +
                    " |          |          |          |\n" +
                    " |          |          |          |\n" +
                    " |          |          |          |\n" +
                    " |          |          |          |\n";
                if (dealer.Cards[0].Name == "10" && dealer.Cards[1].Name == "10")
                {
                    dealerCards += " |      " + dealer.Cards[0].Name + dealer.Cards[0].Mark + "|          |      " + dealer.Cards[1].Name + dealer.Cards[1].Mark + "|\n";
                }
                else if (dealer.Cards[0].Name == "10" && dealer.Cards[1].Name != "10")
                {
                    dealerCards += " |      " + dealer.Cards[0].Name + dealer.Cards[0].Mark + "|          |       " + dealer.Cards[1].Name + dealer.Cards[1].Mark + "|\n";
                }
                else if (dealer.Cards[0].Name != "10" && dealer.Cards[1].Name == "10")
                {
                    dealerCards += " |       " + dealer.Cards[0].Name + dealer.Cards[0].Mark + "|          |      " + dealer.Cards[1].Name + dealer.Cards[1].Mark + "|\n";
                }
                else
                {
                    dealerCards += " |       " + dealer.Cards[0].Name + dealer.Cards[0].Mark + "|          |       " + dealer.Cards[1].Name + dealer.Cards[1].Mark + "|\n";
                }
                dealerCards += "  ==========            ==========";

                Console.WriteLine(dealerCards);
                Console.Write("베팅 금액을 입력 : ");
                player.Betting();
                player.Card = CardDraw();
                Console.WriteLine("###########당신이 뽑은 카드###########");
                string playerCard = "             ==========\n";
                if (player.Card.Name == "10")
                {
                    playerCard += "            |" + player.Card.Mark + player.Card.Name + "      |\n";
                }
                else
                {
                    playerCard += "            |" + player.Card.Mark + player.Card.Name + "       |\n";
                }
                playerCard +=
                    "            |          |\n" +
                    "            |          |\n" +
                    "            |          |\n" +
                    "            |          |\n" +
                    "            |          |\n";
                if (player.Card.Name == "10")
                {
                    playerCard += "            |      " + player.Card.Name + player.Card.Mark + "|\n";
                }
                else
                {
                    playerCard += "            |       " + player.Card.Name + player.Card.Mark + "|\n";
                }
                playerCard += "             ==========";
                Console.WriteLine(playerCard);

                ////dealer.Cards.Sort();
                //if (dealer.Cards[0].Number < dealer.Cards[1].Number)
                //{

                //}
                //else
                //{

                //}
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

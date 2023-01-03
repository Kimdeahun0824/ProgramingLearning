using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TrumpCardGame
{
    internal class PokerCardGame : CardGame
    {
        /**
         * - 컴퓨터가 5장의 카드를 뽑는다. (플레이어가 볼 수 있음)
         * - 플레이어도 5장의 카드를 뽑는다.
         * - 플레이어는 베팅을 한다. (0 ~ 알아서)
         * - 컴퓨터는 2장의 카드를 추가로 받는다. -> 총 7장의 카드 보유
         * - 플레이어는 2장의 카드를 교체할 수 있따.(카드 1장 교체 가능한 횟수가 최대 2회)
         * - 모든 액션이 끝난 후에는 결과를 체크한다.
         * - 플레이어가 이기면 2배로 받고
         * - 플레이어가 지면 베팅금액을 잃는다.
         * - 100,000 포인트 이상을 얻거나, 0포인트 이하가 되면 게임 종료
         * - 시작 포인트는 10,000 포인트
         * - 탑, 원페어, 투페어, 트리플, 포카드, 플러쉬, 스트레이트
         *      - 마운틴, 백스트레이트, 풀하우스, 스티플, 로티플은 HARD모드
         */
        public enum PokerHandRangkings
        {
            TOP, OWN_PAIR, TWO_PAIR, TRIPLE, STRAIGHT, BACK_STRAIGHT, MOUNTAIN, FLUSH, FULL_HOUSE, FOUR_CARD, STRAIGHT_FLUSH, BACK_STRAIGHT_FLUSH, ROYAL_STARIGHT_FLUSH
        }
        Deck mDeck;
        Player mPlayer;
        PokerHandRangkings mPlayerHandRankings;
        PokerHandRangkings mPDealerHandRankings;
        Dealer mDealer;
        bool gameEnd;

        public PokerCardGame()
        {
            Init();
            Update();
        }

        public void Init()
        {
            mDeck = new Deck();
            mPlayer = new Player(10000);
            mDealer = new Dealer();
            gameEnd = false;
        }

        public void Update()
        {
            //while (true)
            //{
            //    //CardGamePlay();

            //}
            CardGamePlay();


        }

        protected override Card CardDraw()
        {
            Card drawCard = mDeck.cards[0];
            mDeck.cards.Remove(drawCard);
            return drawCard;
        }

        protected override void CardGamePlay()
        {
            string GameBoard = "     ===========================\n" +
                    "      Welcome to Kyungil Casino\n" +
                    "     ===========================";
            Console.WriteLine(GameBoard);

            mDealer.AddCard(CardDraw());
            mDealer.AddCard(CardDraw());
            mDealer.AddCard(CardDraw());
            mDealer.AddCard(CardDraw());
            mDealer.AddCard(CardDraw());

            Card card1 = new Card("A", "♥", 1, 2);
            Card card2 = new Card("10", "♠", 10, 3);
            Card card3 = new Card("J", "♣", 11, 0);
            Card card4 = new Card("Q", "◆", 12, 1);
            Card card5 = new Card("K", "♠", 13, 3);
            Card card6 = new Card("7", "◆", 7, 1);
            Card card7 = new Card("7", "♠", 7, 3);
            //mPlayer.AddCard(CardDraw());
            //mPlayer.AddCard(CardDraw());
            //mPlayer.AddCard(CardDraw());
            //mPlayer.AddCard(CardDraw());
            //mPlayer.AddCard(CardDraw());
            //mPlayer.AddCard(CardDraw());
            //mPlayer.AddCard(CardDraw());
            mPlayer.AddCard(card1);
            mPlayer.AddCard(card2);
            mPlayer.AddCard(card3);
            mPlayer.AddCard(card4);
            mPlayer.AddCard(card5);
            mPlayer.AddCard(card6);
            mPlayer.AddCard(card7);
            List<Card> SortedList = mPlayer.Cards.OrderBy(x => x.Number).ToList();
            //DeckCheck(SortedList).ToString();
            Pair<PokerHandRangkings, List<Card>> test = new Pair<PokerHandRangkings, List<Card>>();
            test = DeckCheck(SortedList);
            Console.WriteLine(test.LeftValue);
            foreach (var i in test.RightValue)
            {
                Console.WriteLine("{0} / {1} / {2} / {3}", i.Name, i.Number, i.Mark, i.MarkNum);
            }
        }

        public void BoardScreen()
        {

        }

        public Pair<PokerHandRangkings, List<Card>> DeckCheck(List<Card> cards)
        {
            Pair<PokerHandRangkings, List<Card>> result = new Pair<PokerHandRangkings, List<Card>>();

            List<Card> resultCards = new List<Card>();

            //bool Is_Own_Pair = false;
            //bool Is_Two_Pair = false;
            bool Is_Triple = false;
            //bool Is_Straight = false;
            //bool Is_Back_Straight = false;
            //bool Is_Mountain = false;
            //bool Is_Flush = false;
            bool Is_Full_House = false;
            bool Is_Four_Card = false;
            //bool Is_Straight_Flush = false;
            //bool Is_Back_Straight_Flush = false;
            //bool Is_Royal_Straight_Flush = false;

            // 숫자별 파악   
            Dictionary<int, List<Card>> numbersDictionary = new Dictionary<int, List<Card>>();

            for (int i = 0; i < 13; i++)
            {
                numbersDictionary[i] = new List<Card>();
            }
            for (int i = 0; i < cards.Count; i++)
            {
                numbersDictionary[cards[i].Number - 1].Add(cards[i]);
                Console.WriteLine("테스트");
            }

            int pair = 0;
            // 풀하우스, 포카드 체크
            for (int i = 0; i < numbersDictionary.Count; i++)
            {
                Console.WriteLine($"테스트 : {numbersDictionary[i].Count}");
                if (3 < numbersDictionary[i].Count)
                {
                    Is_Four_Card = true;
                }
                else if (2 < numbersDictionary[i].Count)
                {
                    Is_Triple = true;
                }
                else if (1 < numbersDictionary[i].Count)
                {
                    pair++;
                }
            }

            if (1 <= pair && Is_Triple)
            {
                Is_Full_House = true;
            }
            Console.WriteLine("풀하우스 / 트리플 / 포카드 체크 : {0} / {1} / {2}", Is_Full_House, Is_Triple, Is_Four_Card);



            Dictionary<string, List<Card>> marksDictionary = new Dictionary<string, List<Card>>();
            marksDictionary.Add("♣", new List<Card>());
            marksDictionary.Add("♥", new List<Card>());
            marksDictionary.Add("◆", new List<Card>());
            marksDictionary.Add("♠", new List<Card>());

            string[] marks = { "♣", "♥", "◆", "♠" };
            int StraightCnt = 0;
            // 마크별 카드 저장
            for (int i = 0; i < cards.Count; i++)
            {
                marksDictionary[cards[i].Mark].Add(cards[i]);
            }

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"{marks[i]}는 {marksDictionary[marks[i]].Count}개 있음");
                // 플러시 체크
                if (5 <= marksDictionary[marks[i]].Count)
                {
                    //로티플 체크
                    for (int j = 0; j < marksDictionary[marks[i]].Count; j++)
                    {
                        if (marksDictionary[marks[i]][j].Number == 1 ||
                            marksDictionary[marks[i]][j].Number == 10 ||
                            marksDictionary[marks[i]][j].Number == 11 ||
                            marksDictionary[marks[i]][j].Number == 12 ||
                            marksDictionary[marks[i]][j].Number == 13)
                        {
                            resultCards.Add(marksDictionary[marks[i]][j]);
                            StraightCnt++;
                        }
                    }   // loop : 로티플 체크
                    if (5 <= StraightCnt)
                    {
                        result.RightValue = resultCards;
                        result.LeftValue = PokerHandRangkings.ROYAL_STARIGHT_FLUSH;
                        return result;
                    }
                    else
                    {
                        StraightCnt = 0;
                        resultCards.Clear();
                    }

                    // 백티플 체크
                    for (int j = 0; j < marksDictionary[marks[i]].Count; j++)
                    {
                        if (marksDictionary[marks[i]][j].Number == 1 ||
                            marksDictionary[marks[i]][j].Number == 2 ||
                            marksDictionary[marks[i]][j].Number == 3 ||
                            marksDictionary[marks[i]][j].Number == 4 ||
                            marksDictionary[marks[i]][j].Number == 5)
                        {
                            resultCards.Add(marksDictionary[marks[i]][j]);
                            StraightCnt++;
                        }
                    }   // loop : 백티플 체크
                    if (5 <= StraightCnt)
                    {
                        result.RightValue = resultCards;
                        result.LeftValue = PokerHandRangkings.BACK_STRAIGHT_FLUSH;
                        return result;
                    }
                    else
                    {
                        StraightCnt = 0;
                        resultCards.Clear();
                    }
                    // 스트레이트 체크
                    for (int j = 0; j < marksDictionary[marks[i]].Count; j++)
                    {
                        for (int k = j; k < marksDictionary[marks[i]].Count; k++)
                        {
                            if (k == j) continue;
                            if (marksDictionary[marks[i]][j].Number + 1 == marksDictionary[marks[i]][k].Number)
                            {
                                StraightCnt++;
                                resultCards.Add(marksDictionary[marks[i]][j]);
                                break;
                                //continue;
                            }
                            else
                            {
                                StraightCnt = 0;
                                resultCards.Clear();
                                break;
                            }
                        }
                    }
                    if (4 == StraightCnt)
                    {
                        resultCards.Add(marksDictionary[marks[i]][marksDictionary[marks[i]].Count - 1]);
                        result.RightValue = resultCards;
                        result.LeftValue = PokerHandRangkings.STRAIGHT_FLUSH;
                        return result;
                    }
                    // 스티플 큰수부터 대입
                    else if (4 < StraightCnt)
                    {
                        int minCnt = StraightCnt - 4;
                        Console.WriteLine("테스트 5 minCnt : {0} / {1}", minCnt, marksDictionary[marks[i]].Count - 1);
                        resultCards.Clear();
                        for (int j = minCnt; j < marksDictionary[marks[i]].Count; j++)
                        {
                            resultCards.Add(marksDictionary[marks[i]][j]);
                        }
                        result.RightValue = resultCards;
                        result.LeftValue = PokerHandRangkings.STRAIGHT_FLUSH;
                        return result;
                    }
                    else
                    {
                        StraightCnt = 0;
                        resultCards.Clear();
                    }

                    // 위에 조건식에서 return되지 않으면 + 족보가 풀하우스, 포카드가 아니면
                    if (Is_Full_House || Is_Four_Card)
                    {
                        /* Do Nothing */
                    }
                    else
                    {
                        if (5 < marksDictionary[marks[i]].Count)
                        {
                            int minCnt = marksDictionary[marks[i]].Count - 5;
                            for (int j = minCnt; j < marksDictionary[marks[i]].Count; j++)
                            {
                                resultCards.Add(marksDictionary[marks[i]][j]);
                            }
                        }
                        else
                        {
                            for (int j = 0; j < marksDictionary[marks[i]].Count; j++)
                            {
                                resultCards.Add(marksDictionary[marks[i]][j]);
                            }
                        }

                        result.RightValue = resultCards;
                        result.LeftValue = PokerHandRangkings.FLUSH;
                        return result;
                    }
                }
            }       // 플러시 체크

            StraightCnt = 0;
            resultCards.Clear();

            // 포카드 체크
            for (int i = numbersDictionary.Count - 1; 0 < i; i--)
            {
                if (Is_Four_Card)
                {
                    // 포카드 체크
                    if (3 < numbersDictionary[i].Count)
                    {
                        for (int j = 0; j < numbersDictionary[i].Count; j++)
                        {
                            resultCards.Add(numbersDictionary[i][j]);
                        }
                        result.LeftValue = PokerHandRangkings.FOUR_CARD;
                        result.RightValue = resultCards;
                        return result;
                    }
                }
            }
            resultCards.Clear();

            // 풀 하우스 체크             문제 : 트리플과 투페어가 나오면 투 페어중 높은 값을 대입해 줘야함
            if (Is_Full_House)
            {
                for (int i = 0; i < numbersDictionary.Count; i++)
                {
                    if (2 < numbersDictionary[i].Count)
                    {
                        for (int j = 0; j < numbersDictionary[i].Count; j++)
                        {
                            resultCards.Add(numbersDictionary[i][j]);
                        }
                    }
                }
                for (int i = numbersDictionary.Count - 1; 0 < i; i--)
                {
                    if (2 == numbersDictionary[i].Count)
                    {
                        for (int j = 0; j < numbersDictionary[i].Count; j++)
                        {
                            resultCards.Add(numbersDictionary[i][j]);
                        }
                        if (resultCards.Count == 5)
                        {
                            result.LeftValue = PokerHandRangkings.FULL_HOUSE;
                            result.RightValue = resultCards;
                            return result;
                        }
                    }
                }
            }
            resultCards.Clear();

            for (int i = 0; i < numbersDictionary.Count; i++)
            {
                Console.WriteLine("##테스트 : {0}", numbersDictionary[i].Count);
                for (int j = 0; j < numbersDictionary[i].Count; j++)
                {
                    Console.WriteLine("##테스트####### : {0}", numbersDictionary[i][j].Number);
                }
            }

            // 마운틴, 백스트레이트, 스트레이트 체크
            





            return result;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
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

            Card card1 = new Card("A", "♠", 1);
            Card card2 = new Card("K", "♠", 13);
            Card card3 = new Card("Q", "♠", 12);
            Card card4 = new Card("J", "◆", 11);
            Card card5 = new Card("10", "♠", 10);
            Card card6 = new Card("6", "♣", 6);
            Card card7 = new Card("5", "♠", 5);
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
            Console.WriteLine(DeckCheck(SortedList));

        }

        public void BoardScreen()
        {

        }

        public PokerHandRangkings DeckCheck(List<Card> cards)
        {
            bool Is_Own_Pair = false;
            bool Is_Two_Pair = false;
            bool Is_Triple = false;
            bool Is_Four_Card = false;
            bool Is_Straight = false;
            bool Is_Back_Straight = false;
            bool Is_Mountain = false;
            bool Is_Flush = false;
            bool Is_FullHouse = false;

            int clover = 0;
            int heart = 0;
            int diamond = 0;
            int spade = 0;

            int[] array = new int[13];
            for (int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine("{0} / {1} / {2}", cards[i].Name, cards[i].Mark, cards[i].Number);
                array[cards[i].Number - 1]++;
                if (cards[i].Mark == "♣")
                {
                    clover++;
                }
                else if (cards[i].Mark == "♥")
                {
                    heart++;
                }
                else if (cards[i].Mark == "◆")
                {
                    diamond++;
                }
                else if (cards[i].Mark == "♠")
                {
                    spade++;
                }
            }

            Is_Own_Pair = Own_Pair_Check(array);
            Is_Two_Pair = Two_Pair_Check(array);
            Is_Triple = Triple_Check(array);
            Is_FullHouse = FullHouse_Check(array);
            Is_Four_Card = Four_Card_Check(array);
            Is_Straight = Straight_Check(array);
            Is_Back_Straight = Back_Straight_Check(array);
            Is_Mountain = Mountain_Check(array);
            Is_Flush = Flush_Check(clover, heart, diamond, spade);

            if (Is_Mountain && Is_Flush)
            {
                return PokerHandRangkings.ROYAL_STARIGHT_FLUSH;
            }
            if (Is_Back_Straight && Is_Flush)
            {
                return PokerHandRangkings.BACK_STRAIGHT_FLUSH;
            }
            if (Is_Straight && Is_Flush)
            {
                return PokerHandRangkings.STRAIGHT_FLUSH;
            }
            if (Is_Four_Card)
            {
                return PokerHandRangkings.FOUR_CARD;
            }
            if (Is_FullHouse)
            {
                return PokerHandRangkings.FULL_HOUSE;
            }
            if (Is_Flush)
            {
                return PokerHandRangkings.FLUSH;
            }
            if (Is_Mountain)
            {
                return PokerHandRangkings.MOUNTAIN;
            }
            if (Is_Back_Straight)
            {
                return PokerHandRangkings.BACK_STRAIGHT;
            }
            if (Is_Straight)
            {
                return PokerHandRangkings.STRAIGHT;
            }
            if (Is_Triple)
            {
                return PokerHandRangkings.TRIPLE;
            }
            if (Is_Two_Pair)
            {
                return PokerHandRangkings.TWO_PAIR;
            }
            if (Is_Own_Pair)
            {
                return PokerHandRangkings.OWN_PAIR;
            }

            return PokerHandRangkings.TOP;
        }

        public bool Own_Pair_Check(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (1 < array[i])
                {
                    return true;
                }
            }
            return false;
        }
        public bool Two_Pair_Check(int[] array)
        {
            int pair = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (1 < array[i])
                {
                    pair++;
                }
            }

            if (1 < pair)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Triple_Check(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (2 < array[i])
                {
                    return true;
                }
            }
            return false;
        }
        public bool FullHouse_Check(int[] array)
        {
            int pair = 0;
            bool Triple = false;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("트리플 체크 : {0}", array[i]);
                if (2 < array[i])
                {
                    Triple = true;
                }
                if (1 < array[i])
                {
                    pair++;
                }
            }
            if (1 < pair && Triple)
            {
                return true;
            }
            return false;
        }
        public bool Four_Card_Check(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (3 < array[i])
                {
                    return true;
                }
            }
            return false;
        }
        public bool Flush_Check(int clover, int heart, int diamond, int spade)
        {
            if (5 <= clover || 5 <= heart || 5 <= diamond || 5 <= spade)
            {
                return true;
            }
            return false;
        }
        public bool Straight_Check(int[] array)
        {
            for (int i = 0; i < array.Length - 5; i++)
            {
                int temp = 0;
                if (array[i] == 0) continue;
                for (int j = i; j < i + 5; j++)
                {
                    if (!(0 < array[j]))
                    {
                        break;
                    }
                    temp++;
                    if (temp == 5)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool Back_Straight_Check(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < 5; i++)
            {
                if (!(0 < array[i]))
                {
                    break;
                }
                temp++;
                if (temp == 5)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Mountain_Check(int[] array)
        {
            if (0 < array[0] && 0 < array[12] && 0 < array[11] && 0 < array[10] && 0 < array[9])
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsClass
{
    internal class TrumpCard
    {
        

        private int[] trumpCardSet;
        private string[] trumpCardMark;
        public TrumpCard()
        {
            SetUpTrumpCards();
            Shuffle();
            //PrintCardSet();
            RollCard();
        }

        private void PrintCardSet()
        {
            foreach (var iterator in trumpCardSet)
            {
                Console.WriteLine(iterator.ToString());
            }
        }       // PrintCardSet

        private void SetUpTrumpCards()
        {
            trumpCardSet = new int[52];
            for (int i = 0; i < trumpCardSet.Length; i++)
            {
                trumpCardSet[i] = i + 1;
            }       // loop : 카드의 숫자를 셋업하는 루프

            // 트럼프 카드의 마크를 셋업
            trumpCardMark = new string[4] { "♣", "◆", "♥", "♠" };

        }       // SetUpTrumpCards

        //! 한장의 카드를 뽑아서 보여주는 함수
        public void RollCard()
        {
            int card = trumpCardSet[0];
            string cardMark = trumpCardMark[(card - 1) / 13];
            string cardNum = Convert.ToString(card % 13);
            switch (cardNum)
            {
                case "1":
                    cardNum = "A";
                    break;
                case "11":
                    cardNum = "J";
                    break;
                case "12":
                    cardNum = "Q";
                    break;
                case "0":
                    cardNum = "K";
                    break;
                default:
                    break;
            }
            Console.WriteLine($"드로우! : {cardNum}{cardMark}{card}");
            Console.WriteLine(" -----");
            Console.WriteLine($"|{cardMark}{cardNum}  |");
            Console.WriteLine("|     |");
            Console.WriteLine($"|  {cardNum}{cardMark}|");
            Console.WriteLine(" -----");
        }       // RollCard()

        //! 카드를 섞는 함수
        private void Shuffle()
        {
            Shuffle(200);
        }
        //! 카드를 섞는 함수
        private void Shuffle(int loopMax)
        {
            Random random = new Random();
            for (int i = 0; i < loopMax; i++)
            {
                int sourIdx = random.Next(0, trumpCardSet.Length);
                int destIdx = random.Next(0, trumpCardSet.Length);
                int temp = trumpCardSet[sourIdx];
                trumpCardSet[sourIdx] = trumpCardSet[destIdx];
                trumpCardSet[destIdx] = temp;
            }
        }       // Shuffle(int loopMax)
    }
}

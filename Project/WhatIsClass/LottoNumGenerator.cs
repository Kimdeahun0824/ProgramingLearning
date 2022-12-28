using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsClass
{
    /**
     * 클래스를 사용해서 로또번호 생성기를 작성할 것
     *      - 1 ~ 45 사이의 랜덤한 숫자 (중복 X)
     *      - 6개의 랜덤한 숫자 + 보너스 번호 1 을 뽑아서 출력할 것.
     */

    internal class LottoNumGenerator
    {
        private int[] mLottoNumbers;
        public LottoNumGenerator()
        {
            Random random = new Random();
            mLottoNumbers = new int[45];
            for (int i = 0; i < mLottoNumbers.Length; i++)
            {
                mLottoNumbers[i] = i + 1;
            }
            foreach (var item in mLottoNumbers)
            {
                mLottoNumbers = shuffleOnce(mLottoNumbers);
            }
            for (int i = 0; i < mLottoNumbers.Length; i++)
            {
                //Console.WriteLine(mLottoNumbers[i]);
            }
        }



        public int[] GetLottoNum()
        {
            return mLottoNumbers;
        }

        //! 배열을 1번 섞는 함수
        private int[] shuffleOnce(int[] lottoNumbers)
        {
            Random random = new Random();
            int sourIndex = random.Next(0, lottoNumbers.Length);
            int destIndex = random.Next(0, lottoNumbers.Length);
            int tempVariable = lottoNumbers[sourIndex];
            lottoNumbers[sourIndex] = lottoNumbers[destIndex];
            lottoNumbers[destIndex] = tempVariable;
            return lottoNumbers;
        }   // shuffleOnce
    }
}

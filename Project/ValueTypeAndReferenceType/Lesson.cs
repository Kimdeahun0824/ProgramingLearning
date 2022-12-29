using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeAndReferenceType
{
    internal class Lesson
    {
        /**
             * 값 형식과 참조 형식
             * 클래스나 구조체 같은 데이터 형식을 말할 때 값 형식(value Type)과 참조 형식(Reference type)으로
             * 구분 짓기도 한다.
             * 
             * 값 형식
             * 개체에 값 자체를 담고 있는 구조이다. 지금까지 다룬 int, double 등은 내부적으로 구조체로 된
             * 전형적인 값 형식의 데이터 구조이다.
             * 
             * 참조 형식
             * 개체가 값을 담고 있는 또 다른 개체를 포인터로 바라보는 구조이다. 여러 값이 동일한 개체를
             * 가리킬 수 있다.
             */
        public void ValueTypeAndReffernceType()
        {
            int number = 10;
            Console.WriteLine(number);
        }

        /**
         * 박싱 언박싱
         * 프로그래밍을 하다 보면 데이터의 형식 변환이 필요하다. 이러한 변환 과정에서 값 형식의 데이터를
         * 참조 형식의 데이터로 변경하는 것을 박싱(Boxing)이라고 한다. 반대로 참조 형식의 데이터를
         * 값 형식의 데이터로 변경하는 것을 언박싱(Unboxing)이라고 한다.
         * 
         * 박싱
         * 박싱이란 말 그대로 박스에 포장을 하는 것이다. C#에서 박싱은 값 형식의 데이터를 차조 형식의
         * 데이터로 변환하는 작업을 의미한다. 예를 들어 다음 코드처럼 정수 형식의 데이터를 오브젝트 형식의
         * 데이터에 담는 형태를 박싱이라고 한다.
         * 
         * 좀 더 어렵게 말하면 스택 메모리 영역에 저장된 값 형식의 데이터를 힙 메모리 영역에 저장하는
         * 단계를 거치기 때문에 시간과 공간이 소비되는 비용이 발생한다.
         */

        public void boxing()
        {
            int number = 1234;
            object objectValue = number;

            Console.WriteLine(objectValue);
        }
        
        

        /** 
         * 언박싱
         * 다음 코드는 object 변수에 저장된 1234를 실제 정수 형식의 데이터로 변환하는 모습을 보여 준다
         * 참조 형식의 데이터를 값 형식의 데이터로 변환하는 과정이 포장을 푸는 것과 비슷해 보여서 언박싱
         * 이라고 한다. 언박싱을 캐스트(Cast) 또는 캐스팅(Casting)으로 표현한다. 
         * 
         * object 형 변수에 들어 있는 데이터 중에서 숫자 형식의 데이터는 바로 iut 형 변수에 대입할 수 없다.
         * object 형 변수 값을 int형 변수의 대입하려면 형식 변환을 해야 한다. 형식 변환은
         * 캐스팅이나 Convert 클래스 같은 변환 API를 사용하면 된다. 즉, (int) 또는 Convert.ToInt32()
         * 같은 형식 변환 관련 기능을 명시적으로 지정해 주어야 한다.
         * 
         */

        public void unboxing()
        {
            object objectValue;
            char charValue = 'a';
            int intValue = 97;
            char charValue2;

            objectValue = charValue;
            charValue2 = (char)objectValue;
            Console.WriteLine($"{charValue2}");


        }
    }
}

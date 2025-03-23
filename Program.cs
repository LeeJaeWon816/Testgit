using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace C_STUDY20250222
{
    internal class Program
    {
        // C#에서 제공하는 참조 타입들을 살펴본다
        // 1. 배열
        // 배열이란?
        // 배열은 같은 타입의 여러 데이터들을 순서대로 저장하기 위한 데이터 구조입니다.
        // 2. List
        // List는 가변 계열로 일반적으로 크기가 고정되어 있는 배열과 달리 동적으로 바꿀 수 있는 배열

        //         일반 배열 vs 가변 배열
        // 크기    고정            변함

        // List 사용법
        // List<데이터 타입> 변수 이름 = new List<데이터 타입>();
        // 3. Dictionary
        // Dictionary : 키와 값을 쌍으로 데이터를 관리합니다.
        // List나 배열은 1가지 타입으로만 데이터를 저장하고 관리할 수 있었다면
        // Dictionary는 Key, Value 이렇게 2가지 데이터를 둘 다 저장하고 관리한다.
        // {
        //         // Key      Value
        //         {{"노원1"}},  {1} },
        //         {{"노원2"}},  {2} }
        // }
        // 키는 Dictionary 내에서 고유한 값을 가져야 한다. => 중복 안됨
        // 동적으로 크기를 조절할 수 있습니다.
        static void Main(string[] args)
        {
            // 문자열 데이터 타입 키와 문자열 데이터 타입 값을 가지는 Dictionary 타입
            // Dictionary<string, int> capitals
            Dictionary<string,string> capitals = new Dictionary<string,string>();
            // Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();

            // 데이터 추가
            // Dictionary는 값만 추가? X Key만 추가? X , 키와 값을 모두 동시에 추가해줘야 한다.
            capitals.Add("South Korea", "Seoul");
            capitals.Add("United states", "Washington D.C.");
            capitals.Add("United Kingdom", "London");

            // 키를 통한 값 접근
            Console.WriteLine(capitals["South Korea"]);

            // 키 존재 여부를 확인
            if (capitals.ContainsValue("North Korea"))
            {
                Console.WriteLine($"North Koread에 해당하는 값은 {capitals["North Korea"]}입니다.");
            }
            else
            {
                Console.WriteLine("North Korea에 해당하는 값은 없습니다.");
            }
            // 값 존재 여부도 확인 가능 : capitals.ContainsValue를 통해서 값이 있는지 확인 가능합니다.
            if (capitals.ContainsValue("Seoul"))
            {
                Console.WriteLine($"Seoul에 해당하는 값이 있습니다.");
            }
            else
            {
                Console.WriteLine("Seoul에 해당하는 값이 없습니다.");
            }

            capitals.Remove("South Korea");
            // foreach : 컬렉션(List, Dictionary 등등) 또는 배열의 모든 요소를 순회한다.
            // foreach(변수 in 컬렉션(List, Dictionary 등등) 혹은 배열)
            // {
            //       //변수에 대한 처리
            // }

            int[] intarr = { 1, 2, 3, 4, 5, 6 };
            foreach (int v in intarr)
            {
                Console.WriteLine($"inrarr에 있는 요소입니다. {v}");
                //foreach문 내에서는 배열의 요소를 직접 수정할 수 없다.
                // v = 2 * v;
            }
            // Dictionary 요소를 순회하는 foreach문 사용법
            foreach (KeyValuePair<string,string> entry in capitals)
            {
                Console.WriteLine($"capitals Dictionary에는 {entry.Key} 와 {entry.Value}을 가지고 있습니다.");
            }

            // 모든 Key, Value 값을 삭제한다.
            capitals.Clear();
        }
    }
}

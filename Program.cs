using System;
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
        static void Main(string[] args)
        {
            // 
            List<int> ints = new List<int>();

            // List 데이터를 추가
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);

            // List의 길이 => Count 키워드로 가져온다.
            for (int i = 0; i < ints.Count; i++)
            {
                // List도 배열과 같이 인덱스로 접근할 수 있다.
                Console.WriteLine(ints[i]);
            }

            // list를 일반 배열로 변환시킬 수 있습니다.
            int[] intArr = ints.ToArray();

            Console.WriteLine();

            // List의 특정요소를 제거
            ints.Remove(2);
            ints.Remove(3);

            for(int i = 0;i < ints.Count; i++)
            {
                Console.WriteLine(ints[i]);
            }


            // List 특정 요소를 포함하고 있는지를 확인
            Console.WriteLine($"2가 포함되어 있는지 {ints.Contains(2)}");
            Console.WriteLine($"1이 포함되어 있는지 {ints.Contains(1)}");


            // 리스트 정렬
            ints.Add(500);
            ints.Add(34);
            ints.Add(45);
            ints.Add(80);
            // 리스트의 모든 요소를 Sort()를 통해서 정렬을 할 수 있다.

            Console.WriteLine($"리스트 정렬 전");
            for (int i = 0; 1 < ints.Count; i++)
            {
                Console.WriteLine(ints[i]);
            }
            ints.Sort();
        }
    }
}

namespace C_STUDY20250222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 다중 반복문
            // 반복문 안에 반복문을 또 넣을 걸
            // for(int i = 0; i < 5; i++)
            // {
            //     i 변수를 선언한 for문에서 반복적으로 실행할 코드
            //     아래의 반복문도 i 변수를 선언한 for문에 맞춰서 반복적으로 실행된다.
            //     for(int j = 0; j < 5; j++)
            //        {
            //            j변수를 선언한 for문에서 반복적으로 실행할 코드
            //        }
            // }

            // 이 for문은 i 변수에 대한 조건을 처리하기 때문에 5번 실행된다.
            /*for (int i = 0; i < 5; i++)
            {
                // 5번 반복할 코드들이 들어 있다.
                Console.WriteLine($"i : {i}");
                // 이 for문은 j 변수에 대한 조건을 처리하기 때문에 5번 실행된다.
                for(int j = 0; j < 5; j++)
                {
                   Console.WriteLine($"i = {i} , j : {j}");
                }
            }
            */
            
            // * 찍는 문제
            // 문제 1 = 왼쪽 정렬된 직각 삼각형
            // 출력 예시
            // *
            // **
            // ***
            // ****
            // *****
            /*
            for (int i = 0; i < 1; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0;i < 5; i++)
            {
                // 각 줄에서 출력해야 할 별의 갯수에 따라서
                // 별을 출력해주면 된다.
                // j < i + 1
                for (int j = 0; j < i + 1; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 5;j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            // 문제 2 = 오른쪽 정렬된 직각 삼각형
            // 출력 예시
            //     *
            //    **
            //   ***
            //  ****
            // *****
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j > i; j--) 
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i + 1; k++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            // 문제 2-1 오른쪽 역정렬된 직각 삼각형
            for (int i = 0;i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 5; k > i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            // 문제 3 = 피라미드 (중앙 정렬)
            // 출력 예시
            //    *
            //   ***
            //  *****
            // *******
            int num = 1;
            for (int i = 0;i < 5; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < num; k++)
                {
                    Console.Write("*");
                }
                num = num + 2;
                Console.WriteLine();
            }
            */
            // 문제 4 = 다이아몬드
            int num1 = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < num1; k++)
                {
                    Console.Write("*");
                }
                num1 = num1 + 2;
                Console.WriteLine();
            }
            int num2 = 7;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = num2; k > 0; k--)
                {
                    Console.Write("*");
                }
                num2 = num2 - 2;
                Console.WriteLine();
            }
        }
    }
}

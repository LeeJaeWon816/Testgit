namespace C_STUDY20250222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 놀이동산 입장권
            // 사용자로부터 나이, 군인 할인, 연간 회원 여부를 입력받아서 입장 요금을 계산합니다.

            // 무료입장 조건
            // 1. 나이가 3세 이하
            // 2. 나이가 65세 이상
            // 3. 연간 회원

            // 할인 적용
            // 1. 군인일 경우 => 30% 할인

            // 일반 요금
            // 성인(19~64세) : 10000원
            // 청소년(13~18세) : 8000원
            // 어린이(4~12세) : 5000원

            // 출력 예시
            // 나이를 입력하세요. : 20
            // 군인인가요? (네/아니오) : 네
            // 연간 회원 인가요? (네/아니오) : 아니오
            // 무료 입장 입니다.

            Console.Write("나이를 입력해주세요 : ");
            string ageInput = Console.ReadLine();
            Console.Write("연간 회원 인가요? (네/아니오) : ");
            string yuser = Console.ReadLine();
            int age = int.Parse(ageInput);
            if (age >= 4 && age <= 12)
            {
                Console.WriteLine("어린이");
            }
            else if (age >= 13 && age <= 18)
            {
                Console.WriteLine("청소년");
            }
            else if (age >= 19 && age <= 64)
            {
                Console.WriteLine("성인");
            }
            else
            {
                Console.WriteLine("무료입장 입니다.");
            }

            Console.Write("군인인가요? (네/아니오) : ");
            string soldier = Console.ReadLine();
            age = int.Parse(ageInput);
            if (soldier == "네")
            {
                age = ;
            }
        }
    }
}

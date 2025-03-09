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

            int adult = 10000; // 어른 요금
            int youth = 8000; // 청소년 요금
            int child = 5000; // 어린이 요금

            Console.Write("나이를 입력해주세요 : ");
            string ageInput = Console.ReadLine();
            // int.Parse로 입력받은 나이 문자열을 숫자(정수) 데이터로 변환한다.]
            int age = int.Parse(ageInput);
            Console.Write("연간 회원 인가요? (네/아니오) : ");
            string packageinput = Console.ReadLine();
            Console.Write("군인인가요? (네/아니오) : ");
            string soldierinput = Console.ReadLine();

            int pay = 0;
            // 무료입장 조건
            // 3세 이하 또는 65세 이상
            if (age >= 65 || age <= 3)
            {
                pay = 0;
            }
            // 성인 요금은 나이가 19세 이상 64세 이하일때 적용
            else if (age >= 19 && age <= 64)
            {
                pay = adult;
            }
            // 청소년 요금은 13세 이상 18세 이하일때 적용
            else if (age >= 13 && age <= 18)
            {
                pay = youth;
            }
            // 이 위에 있는 if문에서 무료 입장 조건, 성인 입장 조건, 청소년 입장 조건을 다 처리해서
            // 남은건 어린이 요금밖에 없기에 else문으로 해도 상관없다.
            else
            {
                pay = child;
            }
            if (soldierinput == "네")
            {
                // 소수점 단위로 계산을 할 경우
                // 정수형 데이터를 소수점 계산을 아예 못하기에 float로 데이터 타입으로 변환된다.
                //           비용 = 70% 할인된 가격
                pay = (int)(pay * 0.7f); 
                // 6999.121234
                // float temp = (pay * 0.7f);
                // pay = (int)temp;
            }
            if (packageinput == "네")
            {
                pay = 0;
            }

            if (pay == 0)
            {
                Console.WriteLine("무료입장입니다.");
            }
            else
            {
                Console.WriteLine($"입장료는 {pay}원 입니다.");
            }
        }
    }
}

namespace C_STUDY20250222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parse
            // 문자열 데이터를 int, double 과 같은 다른 데이터 타입으로 변환시키는 기능
            Console.Write("숫자를 입력해주세요 : ");
            string input = Console.ReadLine();
            // input에 들어온 값을 숫자로 변환하고 싶다.
            int value = int.Parse(input);
            Console.WriteLine(value);
        }
    }
}

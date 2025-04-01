namespace TEXT_RPG
{
    // 1. 상황 설명
    // 2. 선택지 제시
    // 3. 선택지 입력 대기
    // 4. 선택한 선택지에 따라 결과 출력
    // 5. 다음으로 넘어가기 대기
    // 6. 다음상황으로 전환
    internal class Program
    {
        // Git 연동
        // 간이기획과 구조설계
        static void Main(string[] args)
        {
            // TEXT_RPG 실습
            Game.Start(); // 시작시 필요한 작업
            Game.Run(); //  게임 돌아가는동안 계속 작업
            Game.End(); // 종료시 필요한 작업
        }
    }
}

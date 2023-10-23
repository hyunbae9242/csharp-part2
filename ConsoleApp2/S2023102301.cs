namespace ConsoleApp2;

public class S2023102301 {
    public static void Run()
    {
        // BIG-O 표기법
        // 두 알고리즘 A 와 B 를 비교하려면?
        // 1. 조금, 많이 빨리요 -> 애매모호
        // 2. 프로그램으로 실행속도 비교 -> 환경에 의존적
        // 3. 입력이 적은 구간과 많은 구간에서 성능이 확연하게 차이가 날 경우는?
        // 대안으로 big-O 표기법을 사용.
        
        // 수행되는 연산의 개수를 '대략적으로' 판단.
        // 영향력이 가장 큰 대표 항목만 남기고 삭제
        // 상수 무시! (ex. 2N => N)
        // O(1 + N + (4*N*N) + 1)
        // = O(4*N*N)
        // = O(N*N)
        Console.SetCursorPosition(0,0);
        Console.WriteLine("안녕하세요!");
        Console.SetCursorPosition(0,0);
        Console.WriteLine("dydyd");
    }
}
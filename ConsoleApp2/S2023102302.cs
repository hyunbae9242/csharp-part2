namespace ConsoleApp2;

public class S2023102302 {
    public static void Run()
    {
        Board board = new Board();
        Player player = new Player();
        board.Initialize(55, player);
        player.Initialize(1,1, board);
        
        Console.CursorVisible = false;

        const int WAIT_TICK = 1000 / 30;

        int lastTick = 0;
        
        while (true)
        {
            #region 프레임관리
            int currentTick = System.Environment.TickCount;
            if(currentTick - lastTick < WAIT_TICK)
                continue;
            int deltaTick = currentTick - lastTick;
            lastTick = currentTick;
            #endregion
            
            // 입력
            
            // 로직
            player.Update(deltaTick);
            // 렌더링
            Console.SetCursorPosition(0,0);
            board.Render();

            
        }
    }
}
namespace ConsoleApp4;

class Graph
{
    int[,] adj = new int[6, 6]
    {
        {0,1,0,1,0,0},
        {1,0,1,1,0,0},
        {0,1,0,0,0,0},
        {1,1,0,0,0,0},
        {0,0,0,0,0,1},
        {0,0,0,0,1,0}
    };

    private List<int>[] adj2 = new List<int>[]
    {
        new List<int>() { 1, 3 },
        new List<int>() { 0, 2, 3 },
        new List<int>() { 1 },
        new List<int>() { 0, 1 },
        new List<int>() { 5 },
        new List<int>() { 4 }
    };

    private bool[] visited = new bool[6];

    public void ClearVisited()
    {
        visited = new bool[6];
    }
    // 1. now 부터 방문
    // 2. now 와 연결된 정점들을 하나씩 확인해서 아직 미방문 상태라면 방문한다.
    public void DFS(int now)
    {
        Console.WriteLine(now);
        visited[now] = true; // 1. now 부터 방문

        for (int next = 0; next < 6; next++)
        {
            if (adj[now, next] == 0) // 연결되어 있지 않으면 스킵
                continue;
            if(visited[next]) // 이미 방문했으면 스킵
                continue;
            DFS(next);
        }
    }

    public void DFS2(int now)
    {
        Console.WriteLine(now);
        visited[now] = true; // 1. now 부터 방문
        
        foreach (var next in adj2[now])
        {
            if(visited[next]) // 이미 방문했으면 스킵
                continue;
            DFS2(next);
        }
    }

    public void SearchAll()
    {
        for (int now = 0; now < 6; now++)
        {
            Console.WriteLine($"now : {now}");
            if(visited[now] == false)
                DFS(now);
        }
    }
}



class Program
{
    
    static void Main(string[] args)
    {
        // DFS (Depth First Search) 깊이 우선 탐색
        Graph graph = new Graph();
        Console.WriteLine("DFS start");
        graph.DFS(3);
        Console.WriteLine("DFS2 start");
        graph.ClearVisited();
        graph.DFS2(3);
        Console.WriteLine("SearchAll start");
        graph.ClearVisited();
        graph.SearchAll();
        // BFS (Breadth first Search) 너비 우선 탐색
    }
}
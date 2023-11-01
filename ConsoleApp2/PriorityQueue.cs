namespace ConsoleApp2;

public class PriorityQueue<T> where T : IComparable<T>
{
    private List<T> _heap = new List<T>();
    
    public void Push(T data)
    {
        // 힙의 맨 끝에 새로운 데이터 삽입
        _heap.Add(data);

        int now = _heap.Count - 1;
        while (now > 0)
        {
            int next = (now - 1) / 2;
            if (_heap[now].CompareTo(_heap[next]) < 0)
                break;

            T temp = _heap[now];
            _heap[now] = _heap[next];
            _heap[next] = temp;

            now = next;
        }
    }
    
    public T Pop()
    {
        // 반환데이터 
        T ret = _heap[0];
        
        //마지막 데이터 -> root로 이동
        int lastIndex = _heap.Count - 1;
        _heap[0] = _heap[lastIndex];
        _heap.RemoveAt(lastIndex);
        lastIndex--;
        
        // 역으로 내려간다
        int now = 0;
        while (true)
        {
            int left = 2 * now + 1;
            int right = 2 * now + 2;

            int next = now;
            // 왼쪽값이 현재값보다 크면 , 왼쪽으로 이동
            if (left <= lastIndex && _heap[next].CompareTo(_heap[left]) < 0)
                next = left;
            // 오른쪽값이 현재값(왼쪽 이동 포함) 보다 크면, 오른쪽으로 이동
            if (right <= lastIndex && _heap[next].CompareTo(_heap[right]) < 0)
                next = right;
            
            // 왼쪽 오른쪽 모두 현재값보다 작으면 종료
            if (next == now)
                break;
            
            T temp = _heap[now];
            _heap[now] = _heap[next];
            _heap[next] = temp;
            // 검사위치 이동
            now = next;
        }
        
        return ret;
    }

    public int Count
    {
        get { return _heap.Count; }
    }
}
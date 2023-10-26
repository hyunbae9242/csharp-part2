namespace ConsoleApp2;

// public class MyList<T>
// {
//     private const int DEFAULT_SIZE = 1;
//     private T[] _data = new T[DEFAULT_SIZE];
//     public int Count = 0; // 실제 사용중인 데이터 개수
//     public int Capacity  // 예약된 데이터 개수
//     {
//         get { return _data.Length; }
//     }
//
//     public void Add(T item)
//     {
//         // 1. 공간이 충분히 남아있는지 확인
//         if (Count >= Capacity)
//         {
//             // 공간 확보
//             T[] newArray = new T[Count * 2];
//             for (int i = 0; i < Count; i++)
//                 newArray[i] = _data[i];
//             _data = newArray;
//         }
//         // 2. 공간에다가 데이터를 넣어준다.
//         _data[Count] = item;
//         Count++;
//     }
//
//     public T this[int index]
//     {
//         get { return _data[index]; }
//         set { _data[index] = value; }
//     }
//
//     public void RemoveAt(int index)
//     {
//         for (int i = index; i < Count - 1; i++)
//             _data[i] = _data[i + 1];
//         _data[Count - 1] = default(T);
//         Count--;
//     }
//     
// }

public class MyLinkedListNode<T>
{
    public T Data;
    public MyLinkedListNode<T> Next;
    public MyLinkedListNode<T> Prev;
}

public class MyLinkedList<T>
{
    public MyLinkedListNode<T> Head = null; // 첫번째
    public MyLinkedListNode<T> Tail = null; // 마지막
    public int Count = 0;

    public MyLinkedListNode<T> AddLast(T data)
    {
        MyLinkedListNode<T> newRoom = new MyLinkedListNode<T>();
        newRoom.Data = data;
        if (Head == null)
            Head = newRoom;

        if (Tail != null)
        {
            Tail.Next = newRoom;
            newRoom.Prev = Tail;
        }

        Tail = newRoom;
        Count++;
        return newRoom;
    }

    public void Remove(MyLinkedListNode<T> room)
    {
        if (Head == room)
            Head = Head.Next;

        if (Tail == room)
            Tail = Tail.Prev;

        if (room.Prev != null)
            room.Prev.Next = room.Next;

        if (room.Next != null)
            room.Next.Prev = room.Prev;

        Count--;
    }
    
}
public class S2023102601
{
    public int[] _data = new int[25]; // ㅂㅐ열
    // public List<int> _data2 = new List<int>(); // 동적 배열
    public MyLinkedList<int> _data3 = new MyLinkedList<int>(); // 연결 리스트
    
    public void Initialize()
    {
        _data3.AddLast(101);
        _data3.AddLast(102);
        MyLinkedListNode<int> node = _data3.AddLast(103);
        _data3.AddLast(104);
        _data3.AddLast(105);

        _data3.Remove(node);

    }
}
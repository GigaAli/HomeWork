#region EX1
/*
int a = 10;
int b = 20;

Swap(a, b);

Console.WriteLine("a = {0}", a);
Console.WriteLine("b = {0}", b); 


static void Swap<T>(T a, T b)
{
    T temp = a;
    a = b;
    b = temp;
}
*/
#endregion

#region EX2
/*
var queue = new PriorityQueue<int>();

queue.Enqueue(10);
queue.Enqueue(5);
queue.Enqueue(15);

while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue()); // 5, 10, 15
}
public class PriorityQueue<T> where T : IComparable<T>
{

    private List<T> elements = new List<T>();
    private IComparer<T> comparer;

    public PriorityQueue()
    {
        comparer = Comparer<T>.Default;
    }

    public PriorityQueue(IComparer<T> comparer)
    {
        this.comparer = comparer;
    }

    public void Enqueue(T element)
    {
        elements.Add(element);
        InsertIntoOrder(elements.Count - 1);
    }

    public T Dequeue()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Очередь пуста");
        }

        T element = elements[0];
        elements.RemoveAt(0);
        return element;
    }

    public bool Contains(T element)
    {
        return elements.Contains(element);
    }

    public int Count
    {
        get
        {
            return elements.Count;
        }
    }

    private void InsertIntoOrder(int index)
    {
        while (index > 0 && comparer.Compare(elements[index], elements[(index - 1) / 2]) < 0)
        {
            Swap(index, (index - 1) / 2);
            index = (index - 1) / 2;
        }
    }

    private void Swap(int index1, int index2)
    {
        T temp = elements[index1];
        elements[index1] = elements[index2];
        elements[index2] = temp;
    }
}
*/
#endregion

#region EX3



using System.Text;

var list = new LinkedList<int>();

list.AddFirst(1);
list.AddLast(2);
list.AddLast(3);

Console.WriteLine(list); // 1 -> 2 -> 3

list.RemoveFirst();

Console.WriteLine(list); // 2 -> 3

list.Clear();

Console.WriteLine(list); // []

public class LinkedList<T>
{
    private Node<T> _head;
    private int _count;

    public LinkedList()
    {
        _head = null;
        _count = 0;
    }

    public void AddFirst(int item)
    {
        var node = new Node<T>(item, _head);
        _head = node;
        _count++;
    }

    public void AddLast(int item)
    {
        if (_head == null)
        {
            AddFirst(item);
            return;
        }

        var node = new Node<T>(item);
        var current = _head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = node;
        _count++;
    }

    public int RemoveFirst()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("Список пуст");
        }

        int item = _head.Value;
        _head = _head.Next;
        _count--;
        return item;
    }

    public int RemoveLast()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("Список пуст");
        }

        var current = _head;
        while (current.Next.Next != null)
        {
            current = current.Next;
        }

        var item = current.Next.Value;
        current.Next = null;
        _count--;
        return item;
    }

    public bool Contains(int item)
    {
        var current = _head;
        while (current != null)
        {
            bool v = current.Value == item;
            if (v)
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public int Count
    {
        get { return _count; }
    }

    public bool IsEmpty
    {
        get { return _count == 0; }
    }

    public void Clear()
    {
        _head = null;
        _count = 0;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        var current = _head;
        while (current != null)
        {
            builder.Append(current.Value);
            if (current.Next != null)
            {
                builder.Append(" -> ");
            }
            current = current.Next;
        }
        return builder.ToString();
    }

    private class Node<T>
    {
        public int Value;
        public Node<T> Next;
        private T? item;
        private int item1;

        public Node(T? item)
        {
            this.item = item;
        }

        public Node(int item1)
        {
            this.item1 = item1;
        }

        public Node(int value, Node<T> next)
        {
            Value = value;
            Next = next;
        }
    }
}


#endregion

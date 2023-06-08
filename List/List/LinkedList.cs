public class LinkedList<T>
{
    private Node<T> head;
    private Node<T> tail;

    public LinkedList()
    {
        head = null;
        tail = null;
    }

    public void AddFirst(T item)
    {
        Node<T> newNode = new Node<T>(item);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head = newNode;
        }
    }

    public void AddLast(T item)
    {
        Node<T> newNode = new Node<T>(item);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
    }

    public bool Remove(T item)
    {
        if (head == null)
        {
            return false;
        }

        if (head.Data.Equals(item))
        {
            head = head.Next;

            if (head == null)
            {
                tail = null;
            }

            return true;
        }

        Node<T> current = head;

        while (current.Next != null)
        {
            if (current.Next.Data.Equals(item))
            {
                current.Next = current.Next.Next;

                if (current.Next == null)
                {
                    tail = current;
                }

                return true;
            }

            current = current.Next;
        }

        return false;
    }

    public bool Contains(T item)
    {
        Node<T> current = head;

        while (current != null)
        {
            if (current.Data.Equals(item))
            {
                return true;
            }

            current = current.Next;
        }

        return false;
    }

    public void Clear()
    {
        head = null;
        tail = null;
    }

    public void Print()
    {
        Node<T> current = head;

        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }

        Console.WriteLine();
    }
}
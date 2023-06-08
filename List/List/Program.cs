LinkedList<int> list = new LinkedList<int>();
list.AddLast(1);
list.AddLast(2);
list.AddFirst(0);

list.Print();

list.Remove(1);
list.Print();

bool contains = list.Contains(2);
Console.WriteLine(contains);

list.Clear();
list.Print();
using System;
using System.Collections;

// ДЗ 3 *****************************************************************
class Program
{
     public class Node<T>
    {   
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    public class LinkedList<T> // односвязный список
    {
        Node<T> head; // первый элемент
        Node<T> tail; // последний элемент
        int count;  // количество элементов в списке
 
        // создание списка
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
        
            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;
        
            count++;
        }
        // удаление элемента
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null; //предыдущий эллемент
 
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
 
                previous = current;
                current = current.Next;
            }
            return false;
        }
 
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        // очистка списка
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        // содержит ли список элемент
        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    Console.WriteLine("Эллемент присутствует в списке");
                    return true;
                }
                current = current.Next;
            }
            Console.WriteLine("Эллемент отсутствует в списке");
            return false;
        }
        // добвление в начало
        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }
        //Добавление в середину ------- ДОДЕЛАТЬ
        /*public bool AddToList(int _Count, T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> current = head;
            Node<T> previous = null; //предыдущий эллемент
 
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count++;
                    return true;
                }
 
                previous = current;
                current = current.Next;
            }
            return false;

        }*/
        // вывод эллементов
        public void Show()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.WriteLine($"a[{current.Data}]");
                current = current.Next;
            }
        }
    }

	static void Main()
	{
        Console.Clear();
        LinkedList<int> linkedList = new LinkedList<int>();
        // добавление элементов в список
        linkedList.Add(1);
        linkedList.Add(2);
        linkedList.Add(3);
        linkedList.Add(4);
        // выводим элементы
        linkedList.Show();
        // удаляем элемент
        Console.WriteLine("Удаление обьекта");
        linkedList.Remove(3);
        linkedList.Show();
            //Console.WriteLine("Добавление обьекта в середину");
            //linkedList.AddToList(4,5);
            //linkedList.Show();
        // проверяем наличие элемента
        bool isPresent = linkedList.Contains(5);
        // добавляем элемент в начало            
        linkedList.AppendFirst(6);
        linkedList.Show();
	}
}

// ДЗ 2 *****************************************************************
/*class Program
{
	static void Main()
	{
		int[] array = new int[] { -3, 0, 2, 4, 9 };
		int k = 6;
		First_array(array, k);
		Second_array(array, k);
		Thiree_array(array, k);
	}

	static void First_array(int[] array, int k)
	{
		Console.Write("Первый метод: \n");

		for (int i = 0; i < array.Length; i++)
		{
			for (int j = i + 1; j < array.Length; j++)
			{
				if (array[i] + array[j] == k)
				{
					Console.WriteLine($"[{array[i]}, {array[j]}]");
				}
			}
		}
		Console.WriteLine("\n");
	}

	static void Second_array(int[] array, int k)
	{
        Console.Write("Второй метод: \n");
        
		Array.Sort(array);
		int first = 0;
		int last = array.Length - 1;
		while (first < last)
		{
			if (array[first] + array[last] == k)
			{
				Console.WriteLine($"[{array[first]}, {array[last]}]");
			}
			if (array[first] + array[last] < k)
			{
				first++;
			}
			else
			{
				last--;
			}
		}
		Console.Write("\n");
	}

	static void Thiree_array(int[] array, int k)
	{
		Console.Write("Третий метод: \n");

		Hashtable hash = new Hashtable();
		for (int i = 0; i < array.Length; i++)
		{
			if (hash.ContainsKey(k - array[i]))
			{
				Console.WriteLine($"[{k - array[i]}, {array[i]}]");
			}
			hash.Add(array[i], i);
		}
	}
	}*/
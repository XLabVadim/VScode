using System;
using System.Collections;

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
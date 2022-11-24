using System;
using System.Collections;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        // ДЗ 5 *******************************************************
		// Сорировка пузырьком
		Stopwatch stopwatch = new Stopwatch(); // замер времени выполнения
		stopwatch.Start(); // старт замера
		Bubble bubble = new Bubble();
        Console.WriteLine("Домашнее задание №5");
        int[] someArray = new int[] { 1, 2, 4, 3, 8, 5, 7, 6, 9, 0 };
        bubble.Bubble_Sort(someArray);
		stopwatch.Stop(); // остановка замера
		Console.Write("Время выполнения программы пузырька = ");
		Console.WriteLine(stopwatch.ElapsedMilliseconds); // вывод замера
		Console.WriteLine("\n");

		// Пирамидальная сортировка
		stopwatch.Start(); // старт замера
		Piramid piramid = new Piramid();
		int[] arr = {12, 11, 13, 5, 6, 7};
		Console.Write("Массив до сортировки пирамидой = ");
		piramid.printArray(arr);
        int n = arr.Length;
        piramid.sort(arr);
		Console.WriteLine("\n");
        Console.Write("Массив сортировка пирамидой = ");
        piramid.printArray(arr);
		stopwatch.Stop(); // остановка замера
		Console.WriteLine("\n");
		Console.Write("Время выполнения программы пирамиды = ");
		Console.WriteLine(stopwatch.ElapsedMilliseconds); // вывод замера
		Console.WriteLine("\n");

        // ДЗ 3 *******************************************************
        Console.WriteLine("Домашнее задание №3");
        _List<int> list = new _List<int>();
        for (int i = 0; i < 10; i++)
            list.Add(i);
        foreach (int r in list)
        {
            Console.WriteLine(r);
        }
        Console.Write("\n");

        // дз 4 *******************************************************
        Console.WriteLine("Домашнее задание №4");
        LinkedList<int> linkedList = new LinkedList<int>();
        // добавление элементов в список
        linkedList.Add(3);
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
        Console.Write("\n");
        //Bublesort
        //linkedList.BubbleSort();
        //linkedList.Show();

        // ДЗ 2 ********************************************************
        Console.WriteLine("Домашнее задание №2");
        int[] array = new int[] { -3, 0, 2, 4, 9 };
        int k = 6;
        First_array(array, k);
        Second_array(array, k);
        Thiree_array(array, k);

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
            Console.Write("\n");
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
    }
}


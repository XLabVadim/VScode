using System;
using System.Collections;

class Program
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
	}
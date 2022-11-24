using System;
using System.Collections;

public class Bubble
{
    public void Bubble_Sort(int[] anArray)
    {
		Console.Write("*Пузырёк* Исходный массив = ");
		PrintArray(anArray);
        for (int i = 0; i < anArray.Length; i++)
        {
            for (int j = 0; j < anArray.Length - 1 - i; j++)
            {
                if (anArray[j] > anArray[j + 1])
                {
                    Swap(ref anArray[j], ref anArray[j + 1]);
                }
            }
        }
		Console.Write("*Пузырёк* Отсортированный массив = ");
        PrintArray(anArray);
    }
    public void Swap(ref int aFirstArg, ref int aSecondArg)
    {
        int tmpParam = aFirstArg;
        aFirstArg = aSecondArg;
        aSecondArg = tmpParam;
    }
    public void PrintArray(int[] anArray)
    {
        for (int i = 0; i < anArray.Length; i++)
        {
            Console.Write(anArray[i] + " ");
        }
        Console.WriteLine("\n");
    }
}
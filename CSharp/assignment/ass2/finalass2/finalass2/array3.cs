using System;

class array3
{
    static void Main(string[] args)
    {
        int[] sourceArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] targetArray = new int[sourceArray.Length];

        CopyArrayElements(sourceArray, targetArray);

        Console.WriteLine("Source Array: ");
        PrintArray(sourceArray);
        Console.WriteLine("Target Array: ");
        PrintArray(targetArray);
    }

    static void CopyArrayElements(int[] source, int[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
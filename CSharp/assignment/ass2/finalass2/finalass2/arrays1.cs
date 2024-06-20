using System;

class arrays1
{
    static void Main(string[] args)
    {
        int[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        double average = CalculateAverage(array);
        int min = FindMin(array);
        int max = FindMax(array);

        Console.WriteLine("Array elements: ");
        PrintArray(array);

        Console.WriteLine("Average value of Array elements: " + average);
        Console.WriteLine("Minimum value in an array: " + min);
        Console.WriteLine("Maximum value in an array: " + max);
    }

    static double CalculateAverage(int[] array)
    {
        int sum = 0;
        foreach (int element in array)
        {
            sum += element;
        }
        return (double)sum / array.Length;
    }

    static int FindMin(int[] array)
    {
        int min = array[0];
        foreach (int element in array)
        {
            if (element < min)
            {
                min = element;
            }
        }
        return min;
    }

    static int FindMax(int[] array)
    {
        int max = array[0];
        foreach (int element in array)
        {
            if (element > max)
            {
                max = element;
            }
        }
        return max;
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
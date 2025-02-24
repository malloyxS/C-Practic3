using System;

class Program
{
    static void Main()
    {
        int[] array = {-2, 3, 5, -1, 0, 7, -4, 8};
        int positiveCount = 0;

        foreach (int number in array)
        {
            if (number > 0)
            {
                positiveCount++;
            }
        }

        Console.WriteLine($"Количество положительных чисел в массиве: {positiveCount}");
    }
}

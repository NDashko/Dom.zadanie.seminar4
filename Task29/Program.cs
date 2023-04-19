
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);

    }
    return array;
}

void PrintArray (int [] array)
{   
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
    // for (int i = 0; i < array.Length; i++)
    // {
    //     Console.Write(array[i] + " ");
    // }
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRandomArray(size, minValue, maxValue);
PrintArray(arr);

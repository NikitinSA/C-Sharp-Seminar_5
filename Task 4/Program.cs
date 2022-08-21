/*Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

Console.Clear();

int[] array = new int[123];

void PrintRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 999);
        Console.Write($"{array[i]} ");
    }
}

int SearchForTwoDigitNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        {
            count++;
        }
    }
    return count;
}

PrintRandomArray(array);
Console.WriteLine();
int result = SearchForTwoDigitNumbers(array);
Console.Write($"Количество элементов массива, значения которых лежат в отрезке от 10 до 99 = {result}");
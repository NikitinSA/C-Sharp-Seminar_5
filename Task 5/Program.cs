/*Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.Clear();

int[] array = new int[5];

void PrintRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} ");
    }
}

int TheMultiplicationOfPairsOfNumbers(int[] array)
{
    int count = 1;
    Console.Write("Произведение первого и последнего элемента массива = ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == array[^count])
        {
            Console.Write($"{array[i]}");
            break;
        }
        else
        {
            int Mult = array[i] * array[^count];
            Console.Write($"{Mult} ");
            count++;
        }
    }
    return count;
}

PrintRandomArray(array);
Console.WriteLine();
TheMultiplicationOfPairsOfNumbers(array);
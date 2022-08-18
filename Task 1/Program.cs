/*Задать массив из 12 эллементов, заполненный случайными числами из промежутка [-9, 9].
Найти сумма положительных и отрицательных элементов массива.*/

int[] Get_array(int size, int min_Vale, int max_value)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min_Vale, max_value + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int[] array = Get_array (12, -9, 9); //задаем значения в функцию
Console.WriteLine();
int positive_sum = 0;
int negative_sum = 0;
foreach(int i in array)
{
    if (i > 0)
    {
        positive_sum += i;
    }
    else
    {
        negative_sum += i;
    }
}

Console.WriteLine($"Сумма положительных эллементов массива = {positive_sum}");
Console.WriteLine($"Сумма отрицательных эллементов массива = {negative_sum}");
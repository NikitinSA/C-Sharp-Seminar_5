/*Напишите программу замены эллементов массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

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

int[] array = Get_array(12, -9, 9); //задаем значения в функцию
Console.WriteLine();
int positive = 0;
int negative = 0;
foreach (int i in array)
{
    if (i > 0)
    {
        positive = i * -1;
        Console.Write($"{positive} ");
    }
    else
    {
        negative = i * -1;
        Console.Write($"{negative} ");
    }
}

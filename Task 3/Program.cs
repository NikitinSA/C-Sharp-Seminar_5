/*Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

Console.Write("Введите число 1 до 10: ");
int find = Convert.ToInt32(Console.ReadLine());

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

void Is_sum_in_array(int[] array, int find)
{
    int numExist = 0;
    for (int i = 0; i < array.Length; i++) // пока i меньше количества элементов в массиве
    {
        if (array[i] == find) // если элемент массива равен введенному числу
        {
            numExist++; //плюсуем в счетчик
        }
    }
    if (numExist > 0) //если в счетчике больше 0, то выводим результат.
    {
        if (numExist == 2 || numExist == 3 || numExist == 4)
        {
            Console.WriteLine($"Число есть! Ваше число повторяется {numExist} раза.");
        }
        else
        {
            Console.WriteLine($"Число есть! Ваше число повторяется {numExist} раз.");
        }
    }
    else
    {
        Console.WriteLine("Числа нет!");
    }
}


int[] array = Get_array(20, 1, 10); //задаем значения в функцию
Console.WriteLine();
Is_sum_in_array(array, find); //ищем введенное число в массиве
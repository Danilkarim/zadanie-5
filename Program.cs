// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int size = ReadInt("Введите размерность массива: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}
if (result % 10 == 1)
{
    Console.WriteLine($"В массиве {result} четное число");
}
if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
    Console.WriteLine($"В массиве {result} четных числа");
}
else

    Console.WriteLine($"В массиве {result} четных чисел");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = randomArray(4);
{
    Console.WriteLine($"[{string.Join(",", array)}] -> {sumOfOdd(array)}");
}
int[] randomArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 100);
    }
    return array;
}

int sumOfOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



{

    {
        Random rnd = new Random();
        int[] d = new int[30];
        int max = 0, min = 100;
        for (int i = 0; i < d.Length; i++) d[i] = rnd.Next(100);
        for (int i = 0; i < d.Length; i++)
        {
            if (d[i] > max) max = d[i];
            if (d[i] < min) min = d[i];
        }

        for (int i = 0; i < d.Length; i++) Console.Write(" " + d[i]);
        Console.WriteLine();
        Console.WriteLine("max:  " + max);
        Console.WriteLine("min  " + min);
        Console.WriteLine("Разница максимального и минимального:  " + (max - min));
        Console.ReadKey();
    }
}
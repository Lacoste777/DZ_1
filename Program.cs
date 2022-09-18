//--------------------------------------------ДЗ к семинару №4--------------------------------------------------------------------------------------------
//Задача №1.Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateArray(int sz)
{
    int[] arr = new int[sz];
    for(int i = 0; i < sz; i++)
        arr[i] = new Random().Next(100, 1000);
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine("\b\b]");
}

int NumEvenElements(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
        if(arr[i] % 2 == 0)
            count ++;
    return count;
}

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] Array = CreateArray(size);
PrintArray(Array);
Console.WriteLine($"в данном массиве {NumEvenElements(Array)} четных элемента(ов)");
*/
// Задача №2. Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateArray(int n, int min, int max)
{
    int [] arr = new int[n];
    for(int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(min, max + 1);
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("\b\b]");
    Console.WriteLine();
}

int Sumevenelements(int[] arr)
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i += 2)
        sum += arr[i];
    return sum;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива min = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива max = ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] Array = CreateArray(size, min, max);
PrintArray(Array);
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях равна {Sumevenelements(Array)} ");
*/
//Задача №3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateArray(int sz, int min, int max)
{
    double[] arr = new double[sz];
    for(int i = 0; i < sz; i++)
    {
        double Int = new Random().Next(min, max + 1);
        double Fract = new Random().NextDouble();
        arr[i] = Int + Fract;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine("\b\b]");
}

double Difference(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
    }
    double diff = max - min;
    return diff;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] Array = CreateArray(size, min, max);
PrintArray(Array);
double difference = Difference(Array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {difference}");
*/























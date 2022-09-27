//--------------------------------------------ДЗ к семинару №7--------------------------------------------------------------------------------------------
//Задача №1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    double[,] newArray = new double[rows, cols];

    for(int i = 0; i< rows; i++)
    {
    
        for(int j = 0; j < cols; j++)
        {
            newArray[i,j] = new Random().Next(minValue,maxValue) + new Random().NextDouble();
        }   
    }
    return newArray;
}   
void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        {
            for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]:f2}  ");
        }
        Console.WriteLine();
    }
}
double [,] Array = CreateRandom2dArray();
PrintArray(Array);
*/
//Задача №2.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, cols];

    for(int i = 0; i< rows; i++)
        for(int j = 0; j < cols; j++)
            newArray[i,j] = new Random().Next(min, max+1);
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "  ");
        Console.WriteLine();

    }
    Console.WriteLine();
}
void ShowArrayElement(int[,] arr)
{
    Console.Write("Enter the item line number: ");
    int i = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the column number of the element: ");
    int j = Convert.ToInt32(Console.ReadLine());

    if(i > arr.GetLength(0) || j > arr.GetLength(1))
    {
        Console.WriteLine("There is no such element in the array!");
    } 
    else
     Console.WriteLine($"At this position there is an element: {arr[i-1, j-1]}");
    Console.WriteLine();

}
int [,] Array = CreateRandom2dArray();
Show2dArray(Array);
ShowArrayElement(Array);
*/
//Задача №3.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, cols];

    for(int i = 0; i< rows; i++)
        for(int j = 0; j < cols; j++)
            newArray[i,j] = new Random().Next(min, max+1);
    return newArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "  ");
        Console.WriteLine();

    }
    Console.WriteLine();
}
void ArithmeticMean(int[,] arr)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        double sumStlb = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            sumStlb = (sumStlb + arr[i, j]);
        }       
        double average = sumStlb / arr.GetLength(0);
        Console.Write ($"{average:f2}  ");
    }
}
int [,] Array = CreateRandom2dArray();
Show2dArray(Array);
ArithmeticMean(Array);
*/
















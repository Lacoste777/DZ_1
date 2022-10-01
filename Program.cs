//----------------------------------------- ДЗ к семинару №8----------------------------------------------------------------------------
//Задача №1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ChangeArray(int[,] array)
{
    for(int k = 0; k < array.GetLength(0); k++)
    {
        for(int i = 0; i < array.GetLength(1) - 1; i++)
        {
            for(int j = i + 1; j < array.GetLength(1); j++)
            {
                if(array[k, j] > array[k, i])
                {
                    int count = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = count;
                }
            }
        }
    }
    return array;
}
int[,] array = CreateRandom2dArray();
Print2DArray(array);
int[,] newArray = ChangeArray(array);
Print2DArray(newArray);
*/
//Задача №2.Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[] FindSumRow(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];
    int min = sumRows[0];
    
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                sumRows[i] += array[i, j];
            }
        }
    return sumRows;
}
int FindMin(int[] array)
{
    int count = 0;
    int min = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            count = i;
            min = array[i];
        }
    }
    return count;

}
Console.Clear();
int[,] array = CreateRandom2dArray();
Print2DArray(array);
int[] sumRows = FindSumRow(array);
Console.WriteLine($"The line number with the minimum sum of elements - {FindMin(sumRows) + 1} ");
*/
//Задача №3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Print2DArray(int[,] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < 10) Console.Write($"0{array[i, j]} ");
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MatrixArray(int[,] arrA, int[,] arrB)
{
    int[,] arrC = new int[arrA.GetLength(0), arrB.GetLongLength(1)];
    for(int i = 0; i < arrA.GetLength(0); i++)
    {
        for(int j = 0; j < arrB.GetLength(1); j++)
        {
            int sum = 0;
            for(int k = 0; k < arrB.GetLength(0); k++)
            {
                sum += arrA[i, k] * arrB[k, j];
            }
            arrC[i, j] = sum;
        }
    }
    return arrC;
}
Console.WriteLine("Matrix A");
int[,] arrayA = CreateRandom2dArray();
Console.WriteLine("Matrix В");
int[,] arrayB = CreateRandom2dArray();
Print2DArray(arrayA);
Print2DArray(arrayB);
int[,] arrayC = MatrixArray(arrayA, arrayB);
Print2DArray(arrayC);
*/
//Задача №4.формируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. 
/*

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for(int i = 10; i < size + 10; i++)
    {
        arr[i-10] = i;
    }
    //PrintArray(arr);
    return arr;
}

int[,,] Create3DArray()
{
    Console.Write("Enter the number of rows by coordinate х = ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number of rows by coordinate у = ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number of rows by coordinate z = ");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int sizeArray = x * y * z;
    int[] array = CreateArray(sizeArray);
    int[,,] arr = new int[x, y, z];
    int n = 0;

    for(int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            for(int k = 0; k < z; k++)
            {
                arr[i, j, k] = array[n];
                n++;
            }
        }
    }
    return arr;
}

void Print3DArray(int[,,] array)
{
    for(int k = 0; k < array.GetLength(2); k++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}
int[,,] Array3D = Create3DArray();
Print3DArray(Array3D);
*/

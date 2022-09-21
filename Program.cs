//--------------------------------------------ДЗ к семинару №6--------------------------------------------------------------------------------------------
//Задача №1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] Numbers(int num)
{
    int[] arr = new int[num];
    
    for(int i = 0; i < num; i++)
    {
        Console.Write("Введите число :");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    return arr;
}
void PrintArr(int[] arr)
{

    Console.Write("[");
    for(int i=0; i<arr.Length;i++)
        if(i==arr.Length-1)
            Console.Write($"{arr[i]} ]");
        else
            Console.Write($"{arr[i]}, ");
}

int CountPositive(int[] arr)
{
    int zeroplus = 0;
    foreach(int x in arr)
        if(x >= 0) zeroplus++;
    
    return zeroplus;
}
Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = Numbers(n);
PrintArr(arr);
Console.WriteLine($"Количество чисел больше 0 : {CountPositive(arr)}");
*/
// Задача №2. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.Write("введите b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());
if(b1 == b2 && k1 == k2)
{
    Console.WriteLine("Заданные прямые совпадают");
}
if(k1 == k2)
{
    Console.WriteLine("Заданные прямые не имеют точки пересечения");
}
else
{
    double Xresult = (b2 - b1) / (k1 - k2);
    double Yresult = k1 * Xresult + b1;
    Console.WriteLine($"Координаты точки пересечения ({Xresult}; {Yresult})");
}
*/




















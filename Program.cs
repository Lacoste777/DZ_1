// -------------------------------- ДЗ к семинару №4 ---------------------------------------------------------------------------------

// Задача №1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Resultat(int a, int b)
{
    int result = 1;
    for ( int i = 1; i <= b; i++)
    result *= a;
    return result;
}
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"{a} в степени {b} равняется {Resultat(a,b)} ");
*/
// Задача №2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumDigits(int num)
{
int result = 0;
int ost = 0;
    while(num > 0)
    {
       
        ost = num%10;
        num /= 10;
        result += ost;
    }
  return result;  
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine($"Сумма всех цифр в данном числе равна {SumDigits(a)} ");
*/
//Задача №3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] InputArray(int num)
{
    int[] arr = new int[num];
    for(int i = 0; i <num; i++)
    {
        Console.Write($"Введите {i} элемент: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i]}, ");
    Console.WriteLine("\b\b]");
    Console.WriteLine();
    
}
Console.Write("Укажите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int[] array = InputArray(n);
PrintArray(array);
*/















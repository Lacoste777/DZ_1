
// Задача №1. Напишите программу,которая на вход принимает два числа и выдает,какое число большее,а какое меньшее.
/*
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"{num1} большее число,а {num2} меньшее число");
}
else
{
    Console.WriteLine($"{num2} большее число,а {num1} меньшее число");
}
*/
// Задача №2. Напишите программу,которая принимает на вход три числа и выдает максимальное из этих чисел.
/*
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if(num1 < num2)
{
    max = num2;
}
if(max < num3)
{
    max = num3;
}
 Console.WriteLine($"{max} большее число из трех введенных чисел");
*/

// Задача №3. Напишите программу,которая на вход принимает число и выдает, является ли число чётным.
/*
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int ost = num % 2;
if(ost == 0)
{
    Console.WriteLine($"{num} чётное число");
}
else
{
    Console.WriteLine($"{num} нечётное число");
}
*/
// Задача №4. Напишите программу,которая на вход принимает число (N),а на выходе показывает все четные числа от 1 до N.
/*
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 2;
 
while(current <= num)
{
    Console.Write(current + " ");
    current = current + 2;
}
*/
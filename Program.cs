
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
// ---------------------ДЗ к семинару№2----------------------------------------------------------------------------------------------------------
// Задача №1. Напишите программу,которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNum(int num)
{
    int a = num/10;
    int res = a%10;
    return res;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра данного числа: {SecondNum(num)} ");
*/

// Задача №2. Напишите программу,которая выводит третьтю цифру заданного числа или сообщает, что третьей цифры нет.
/*
int Kolvo( int count)
{
    int a = 1;
    while(count / 10 != 0)
    { 
        count = count / 10;
        a++;
    }
return a;
}

int Dec(int num)
{
    int dec = 10;
    while(num != 1)
    {
        dec = dec * 10;
        num = num - 1;
    }
return dec;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(Kolvo(num) <= 2)
{
  Console.WriteLine($"В числе {num} нет третьей цифры"); 
}
else
{
    int exp = Kolvo(num) - 2;
    int znam = Dec(exp);
    int ThirdNumber = (num % znam)/ (znam / 10);
    Console.WriteLine($"В числе {num} третья цифра {ThirdNumber}"); 
}
*/
// Задача №3. Напишите программу,которая на принимает на вход цифру,обозначающую день недели,и проверяет,является ли этот день выходным.
/*
void Proverka(int a)
{
    if(a <= 5) Console.WriteLine("Работаем");
       
    else Console.WriteLine("Выходной");
         
}
Console.Write("Введите число от 1 до 7: ");
int а = Convert.ToInt32(Console.ReadLine());

Proverka(а);
*/

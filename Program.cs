//----------------------------------- ДЗ к семинару №3 ------------------------------------------------------------------------------------------------------


//Задача №1.Напишите программу,которая принимает на вход пятизначное число и проверяет,является ли палиндромом.
/*
void Palindrom(int x)
{
    int x1 = x/10000;
    
     int x5 = x%10;
   
    int sr2 = x/1000;
    
    int x2 = sr2%10;
    
    int sr4 = x%100;
    
    int x4 = sr4/10;
    
     if(x1 == x5 && x2 == x4)
     {
        Console.WriteLine("Данное число является палиндромом");
     }
     else 
     {
        Console.WriteLine("Данное число не является палиндромом");
     }
}
Console.Write("Введите любое пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
Palindrom(x);
*/
//Задача №2. Напишите программу,которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance( double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = Math.Pow(x2-x1,2);
    double y = Math.Pow(y2-y1,2);
    double z = Math.Pow(z2-z1,2);
    double dis = Math.Sqrt(x+y+z);
    return dis;
}
Console.Write("Введите x координату 1 точки : ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y координату 1 точки : ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z координату 1 точки : ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x координату 2 точки : ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y координату 2 точки : ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z координату 2 точки : ");
double z2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Расстояние между данными точками {Distance(x1,y1,z1,x2,y2,z2)}");
*/

// Задача №3. Напишите программу, которая принимает на вход число(N) и выдает таблицу кубов чисел от 1 до N.
/*
void Cube(int n)
{
    int i = 1;
    while(i <= n)
    {
        Console.WriteLine($"Куб числа {i} = {i*i*i}");
        i++;
    }
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);
*/





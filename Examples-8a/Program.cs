/*Задача 8. Найти максимальное значение 
из 8 введённычх чисел(С ПОМОЩЬЮ ФУНКЦИИ)*/

//int Max - функция 

/*int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; 
}
*/


Console.Clear();
Console.Write("Введите a1= ");
int a1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите b1= "); 
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c1= ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите a2= ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2= ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c2= ");
int c2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите a3= ");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b3= ");
int b3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c3= ");
int c3 = Convert.ToInt32(Console.ReadLine());


int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; 
}
//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);
int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine($"максимальлное число из введённых= {max}");



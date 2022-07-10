/*Задача 8. Найти максимальное значение 
из 8 введённычх чисел*/

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

int max = a1;

if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine($"максимальлное число из введённых= {max}");


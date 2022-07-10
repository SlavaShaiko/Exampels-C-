/*Задача 8. Найти максимальное значение 
из 9 введённычх чисел(С ПОМОЩЬЮ Массива)*/


Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; 
}//             0  1  2  3  4  5  6  7  8 индекс массива
int[] array = { 0, 2, 78, 4, 5, 6, 14, 8, 9};
//array[0] = 12; -заменить значение 1 на 12
 Console.Write("{  ");
Console.Write(array[0]); // вывести в консоль текущее значение индекса
 Console.Write("  ");
Console.Write(array[1]);
 Console.Write("  ");
Console.Write(array[2]);
 Console.Write("  ");
Console.Write(array[3]);
 Console.Write("  ");
Console.Write(array[4]);
 Console.Write("  ");
Console.Write(array[5]);
Console.Write("  ");
Console.Write(array[6]);
 Console.Write("  ");
Console.Write(array[7]);
 Console.Write("  ");
Console.Write(array[8]);
 Console.Write("  }  ");
 
int max = Max(
    Max(array[0], array[1], array[2]),
     Max(array[3], array[4], array[5]),
      Max(array[6], array[7], array[8]));
Console.WriteLine($"Максимальное значение массива=  {max}");



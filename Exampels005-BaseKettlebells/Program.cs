double a = new Random().Next(1,10);
Console.Write(a);
Console.Write('-');
double b = new Random().Next(1,10);
Console.Write(b);
Console.Write('-');
double c = new Random().Next(1,10);
Console.Write(c);
Console.Write('-');
double d = new Random().Next(1,10);
Console.Write(d);
Console.Write('-');
double e = new Random().Next(1,10);
Console.Write(e);

double max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("  max =  "); 
Console.WriteLine(max);

    
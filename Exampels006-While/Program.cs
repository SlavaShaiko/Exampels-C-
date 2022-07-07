Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("@");

int xa = 1, ya = 1,
    xb = 1,  yb = 30,
    xc = 70, yc = 30,
    xd = 70, yd = 1;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("A");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("A");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("A");

Console.SetCursorPosition(xd, yd);
Console.WriteLine("A");

int x = xa, y = xb, z = xd;

int count = 0;

while(count < 500)
{
    int what = new Random().Next(0, 3); // 0 1 2 3
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
        z = (z + xa) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
        z = (z + xb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
        z = (z + xc) / 2;
    }
 
    
    Console.SetCursorPosition(x, y, z);
    Console.WriteLine(".");
    count ++;
}
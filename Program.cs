Console.WriteLine("Task 17");
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X!=0 и Y!=0 и выдает номер четверти плоскости, в которой 
// находится эта точка.

Console.WriteLine("Type X value: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type Y value: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0) Console.WriteLine("The point is at the quater I");
else if (x<0 && y>0) Console.WriteLine("The point is at the quater II");
else if (x<0 && y<0) Console.WriteLine("The point is at the quater III");
else if (x>0 && y<0) Console.WriteLine("The point is at the quater IV");
else Console.WriteLine("X or Y equals 0");


Console.WriteLine("\nTask 18");
// Напишите программу, которая по заданному номеру четверти показывает
// диапазон возможных координат точек в этой четверти (x и y).

// 1st Option
Console.WriteLine("Type a quater where the point is located: ");
int q = Convert.ToInt32(Console.ReadLine());

int X = 0;
int Y = 0;

Random random = new Random();

if(q==1)
{
    X = random.Next(1,1001);
    Y = random.Next(1,1001);
    Console.WriteLine($"Possible coordinates of the point are ({X}, {Y}).");
}
else if(q==2)
{
    X = random.Next(-1000,0);
    Y = random.Next(1,1001);
    Console.WriteLine($"Possible coordinates of the point are ({X}, {Y}).");
}
else if(q==3)
{
    X = random.Next(-1000,0);
    Y = random.Next(-1000,0);
    Console.WriteLine($"Possible coordinates of the point are ({X}, {Y}).");
}
else if(q==4)
{
    X = random.Next(1,1001);
    Y = random.Next(-1000,0);
    Console.WriteLine($"Possible coordinates of the point are ({X}, {Y}).");
}
else
{
    Console.WriteLine("Choose a quater between 1-4");
}


// 2nd Option
Console.WriteLine("\nTask 18. Option 2");

Console.WriteLine("Type a quater: ");
int num = Convert.ToInt32(Console.ReadLine());

switch(num)
{
    case 1:     // if num == 1
    {
        Console.Write("X>0 Y>0");
        break;      // break is necessary
    }
    case 2:     // if num == 2
    {
        Console.Write("X<0 Y>0");
        break;
    }
        case 3:     // if num == 3
    {
        Console.Write("X<0 Y<0");
        break;
    }
    case 4:     // if num == 4
    {
        Console.Write("X>0 Y<0");
        break;
    }
    default:    // else
    {
        Console.Write("Invalid quater");
        break;
    }
}


Console.WriteLine("\nTask 21");
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// Formula: s = root(square(x2-x1)+square(y2-y1))

Console.WriteLine("Type X for point A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type Y for point A: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type X for point B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type Y for point B: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double s = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));  // We can't use int here, because the result might be with decimals.

Console.WriteLine($"The distance between point A and point B equals {s}");


Console.WriteLine("\nTask 22");
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Enter a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<=n; i++)
{
    Console.WriteLine(Math.Pow(i, 2));  // Sine we are not assining square(Pow) to a variable here and only
}                                       // writing the result, we can use int.
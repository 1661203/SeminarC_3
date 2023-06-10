/*Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void Koords (int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine ("This point on 1st quater");
    else if (x < 0 && y > 0)
        Console.WriteLine ("This point on 2st quater");
    else if (x < 0 && y < 0)
        Console.WriteLine ("This point on 3st quater");
    else if (x > 0 && y < 0)
        Console.WriteLine ("This point on 4st quater");
}

Console.WriteLine ("Enter your x coordinate: ");
int x_Coord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter your y coordinate: ");
int y_Coord = Convert.ToInt32(Console.ReadLine());

if (x_Coord == 0 || y_Coord == 0)
    Console.WriteLine ("Its impossible value for this task! ");
else
    Koords(x_Coord, y_Coord);
    */


/*Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).

void PossibleValue (int num)
{
    if (num==1)
    Console.WriteLine ("1st quater x > 0, y > 0");
    else if (num==2)
    Console.WriteLine ("2st quater x < 0, y > 0");
    else if (num==3)
    Console.WriteLine ("3st quater x < 0, y < 0");
    else 
    Console.WriteLine ("4st quater x > 0, y < 0");
}

Console.WriteLine ("Input number of quater: ");
int numQuater = Convert.ToInt32 (Console.ReadLine());

if (numQuater >=1 && numQuater <=4)
    PossibleValue (numQuater);
else
Console.WriteLine ("Its not number of quater! ");
*/

/*Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 2D пространстве

double LongLine (int x1, int x2, int y1, int y2)
{
    double lenghtAB = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    //double lengthAB1 = Math.Round(lengthAB, 2);                       //округление десятичной доли
    return lenghtAB;
}
Console.WriteLine ("Input X coordinat of A: ");
int xCoordsA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Y coordinat of A: ");
int yCoordsA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input X coordinat of B: ");
int xCoordsB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Y coordinat of B: ");
int yCoordsB = Convert.ToInt32 (Console.ReadLine());

double dist = LongLine(xCoordsA, xCoordsB, yCoordsA, yCoordsB);
Console.WriteLine ($"Distance AB is {dist:f2}");
*/

/*Напишите программу, которая принимает на вход число (N) ивыдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4

void SquareFinder()
{
    Console.WriteLine ("Input number: ");
    int numberN = Convert.ToInt32 (Console.ReadLine());

    if (numberN > 0)
    {
        int current_i = 1;
        while (current_i <= numberN)
        {
            int res = current_i*current_i;
            Console.Write($"{res}, ");
            current_i++;
        }
        Console.WriteLine ("\b\b.");
    }
    else
    {
        int current_i = 1;
        while (current_i >= numberN)
        {
            Console.Write(current_i*current_i + ", ");
            current_i--;
        }
        Console.WriteLine("\b\b.");
    }
}
SquareFinder();*/



// Домашнее задание.

/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

Console.WriteLine ("Input your 5-digit number: ");
int number = Convert.ToInt32 (Console.ReadLine ());

void Palindrom ()
{
    
    
    if (number<100000 && number>9999)
    {
        int n1=number / 10000;
        int n2=number / 1000 % 10;
        int n3=number / 10 % 10;
        int n4=number % 10;
        
        if (n1==n4 && n2==n3)
        {
            Console.WriteLine(" Yes! Its a palindrom! ");
        }
        else
        {
            Console.WriteLine(" No! Its a not palindrom! ");
        }
    }
    else
    {
        Console.WriteLine ("Your number is not 5-digit! ");
    }
}   
Palindrom();*/

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


double LongLine (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lenghtAB = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    return lenghtAB;
}
Console.WriteLine ("Input X coordinat of A: ");
int xCoordsA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Y coordinat of A: ");
int yCoordsA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Z coordinat of A: ");
int zCoordsA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input X coordinat of B: ");
int xCoordsB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Y coordinat of B: ");
int yCoordsB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Z coordinat of B: ");
int zCoordsB = Convert.ToInt32 (Console.ReadLine());

double dist = LongLine(xCoordsA, xCoordsB, yCoordsA, yCoordsB, zCoordsA, zCoordsB);
Console.WriteLine ($"Distance AB is {dist:f2}");*/


/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

void cube()
{
    Console.WriteLine ("Input your number: ");
    int numberN = Convert.ToInt32 (Console.ReadLine());

    if (numberN > 0)
    {
        int current_i = 1;
        while (current_i <= numberN)
        {
            int res = current_i*current_i*current_i;
            Console.Write($"{res}, ");
            current_i++;
        }
        Console.WriteLine ("\b\b.");
    }
    else
    {
        int current_i = 1;
        while (current_i >= numberN)
        {
            Console.Write(current_i*current_i*current_i + ", ");
            current_i--;
        }
        Console.WriteLine("\b\b.");
    }
}
cube();
*/




int x = 12;
int y;

// операнд - над чим виконується операція
// оператор - дія, яку виконує програма

// унарний оператор
// -,+,++,--,~

int a = 12;
int b = -a;
int c = -b;

int d = +c;

Console.WriteLine(d); // 12

int e = d + 1;

//d = d + 1;

int f = d++; // постфіксний інкремент оператор f=12, d=13
int g = ++d; // префіксний інкремент оператор g=14, d=14

int h = d--; // постфіксний декремент оператор h=14, d=13
int i = --d; // префіксний декремент оператор i=12, d=12

int j = ~d;

Console.WriteLine($"f={f}, g={g}, d={d}");
Console.WriteLine($"h={h}, i={i}");


// бінарний оператори
// +,-,*,/,%

int k = 12 + 5 + 10;
int l = 10 + (g - 5);
int m = 55 * a;
int n = 100 / 3;

int o = 100 % 3; // остача від ділення

// оператори порівняння
// ==,!=,>,<,>=,<=

bool isEqual = (10 == 10);
bool isNotEqual = (10 != 10);
bool isNotEquesl2 = (10 != 11);
bool isGreater = (10 > 5);
bool isLess = (10 < 5);
bool isGreaterOrEqual = (10 >= 10);
bool isLessOrEqual = (12 <= 10);

// логічні оператори
// &&,||,!,^

bool p = (10 == 10) && (10 > 5); // логічне І
bool q = (10 == 10) || (10 < 5) || (3 == 5); // логічне АБО

bool r = !p; // логічне НЕ

bool s = (10 == 10) ^ (10 > 5); // логічне виключне АБО

// побітові оператори
// |, &, <<, >>

int v = 5 | 3; // 101 | 011 = 111 // 7 // побітове АБО
int w = 5 & 3; // 101 & 011 = 001 // 1 // побітове І

int x1 = 5 << 1; // 101 << 1 = 1010 // 10 // зсув вліво
int y1 = 5 >> 1; // 101 >> 1 = 10 // 2 // зсув вправо

double v1 = 10.0 / 3;

{
    Console.WriteLine($"f={f}, g={g}, d={d}");
    {
        Console.WriteLine($"f={f}, g={g}, d={d}");
    }
}

if (r != true)
{
    Console.WriteLine("Hello");
}

if ((10 == 10) || (10 < 5) || (3 == 5)) // якщо істина
{
    Console.WriteLine("Is true");
}
else // якщо хибно
{
    Console.WriteLine("Is false");
}

if (5 < 2)
{
    Console.WriteLine("5 < 2");
}
else if (10 < 8)
{ 
    Console.WriteLine("10 < 8");
}
else
{
    Console.WriteLine("Else");
}

int age = 18;

if (age < 18)
{
    Console.WriteLine("You are under 20");
    Console.WriteLine("You are under 18");
}
else if (age >= 18 && age < 21)
{
    Console.WriteLine("You are older than 18");
}
else if (age >= 21 && age < 30)
{
    Console.WriteLine("You are older than 18");
}
else
{
    Console.WriteLine("You are older than 18");
}

// switch case
if (age == 18)
{
    Console.WriteLine("You are 18");
}
else if (age == 19)
{
    Console.WriteLine("You are 19");
}
else if (age == 20)
{
    Console.WriteLine("You are 20");
}
else
{
    Console.WriteLine("You are older than 20");
}

switch (age)
{
    case 18:
        Console.WriteLine("You are 18");
        break;
    case 19:
        Console.WriteLine("You are 19");
        break;
    case 20:
        Console.WriteLine("You are 20");
        break;
    //case >20:
    //    Console.WriteLine("You are older than 20");
    //    break;
    case 24:
    case 25:
    case 26:
        Console.WriteLine("You are 24, 25 or 26");
        break;
    default:
        Console.WriteLine("You are older than 20");
        break;
}

// тернарний оператор
int p1;

if (age == 18)
{
    p1 = 18;
}
else
{
    p1 = 20;
}

p1 = (age == 18) ? 18 : 20;

int tt = 5;

int x2 = 10 + ++tt >> 3;
Console.WriteLine(x2);
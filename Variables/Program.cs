// <тип змінної> <ім'я змінної>;
int myVariable;
char myChar;


// цілі числа
// byte, sbyte, short, ushort, int, uint, long, ulong

// byte - 8 біт, від 0 до 255
// sbyte - 8 біт, від -128 до 127
byte myByte = 45;
// byte myByte2 = 555555; // помилка - вихід за діапазон

// short - 16 біт, від -32768 до 32767
// ushort - 16 біт, від 0 до 65535
short myShort = 32767;

// int - 32 біт, від -2147483648 до 2147483647
// uint - 32 біт, від 0 до 4294967295
int myInt = 2147483647;
uint myUInt = 4294967295;

// long - 64 біт, від -9223372036854775808 до 9223372036854775807
// ulong - 64 біт, від 0 до 18446744073709551615
long myLong = 9223372036854775807;
ulong myULong = 18446744073709551615;


// дійсні числа
// float, double, decimal

// double - 64 біт, від ±5.0 x 10^-324 до ±1.7 x 10^308
double myDouble = 3.2013;

// float - 32 біт, від ±1.5 x 10^-45 до ±3.4 x 10^38
float myFloat = 3.2014f;

// decimal - 128 біт, від ±1.0 x 10^-28 до ±7.9 x 10^28
decimal myDecimal = 3.2015m;

//Console.WriteLine(43.65 + 61.11);
//Console.WriteLine(43.65m + 61.11m);


// логічний тип
// bool
bool myBool = true; // true або false


// символьний тип
// char
char myChar2 = 'm';
char myChar3 = '3';

// рядковий тип
// string
string myString = "Hello, World!";
string myString2 = "3";
string myString3 = "";

// dynamic
// dynamic myDynamic = 'd';

Console.WriteLine(myString);
Console.WriteLine(3.2m);
Console.WriteLine('y');

Console.WriteLine();

Console.Write(myString);
Console.Write(3.2m);
Console.Write('y');

Console.WriteLine();

string input = Console.ReadLine();
//Console.WriteLine(input);

Console.WriteLine("Ваш введений текст: " + input);

// форматиований вивід
Console.WriteLine($"Ваш введений текст: {input}");
Console.WriteLine("Ваш введений текст: {0} {1}", input, myString);

Convert.ToInt64(input);

int parsedInput = Convert.ToInt32(input);
double parsedDouble = Convert.ToDouble(input);

Console.Write($"First row \nSecond row");
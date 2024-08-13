int x = 0;
string template = "Pair number: ";

int max = 10; //int.Parse(Console.ReadLine());

// while
while (x < max - 1)
{
    Console.WriteLine($"{template} {x += 2}");
}

// do-while
do
{
    Console.WriteLine($"First count");
} 
while (x < max - 1);


while (x != 5)
{
    x = new Random().Next(0, 6);
}

// for
for (int i = 1; i <= max; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{template} {i}");
    }
}

Console.WriteLine();
for (int i = 2; i <= max; i += 2)
{
    Console.WriteLine($"{template} {i}");
}

// break - припинення циклу
while (true)
{
    x = new Random().Next(0, 6);

    if (x == 5)
    {
        break;
    }

    Console.WriteLine(x);
}

// continue - перехід на наступну ітерацію
for (int i = 1; i <= max; i++)
{
    if (i % 2 == 1)
    {
        continue;
    }

    Console.WriteLine($"{template} {i}");
}

bool isBreak = false;

// goto - перехід на мітку
for (int i = 0; i < 10; i++)
{ 
    for (int j = 0; j < 10; j++)
    {
        for (int k = 0; k < 10; k++)
        {
            if (i == 2 && j == 4 && k == 5)
            {
                goto end;
            }
        }
    }
}

end:
Console.WriteLine("End of the program.");

// return - вихід з програми (тимчасово!)
return;


// input: 4
// output:
// *
// **
// ***
// ****

// input: 3
// output:
// 3 * 1 = 3
// 3 * 2 = 6
// 3 * 3 = 9
using Methods;
using System;


internal class Program
{
    static void Main(string[] args)
    {
        string user1Greeting = "Hello user 2!";

        int user1Num = 1;
        int user2Num = 2;

        PrintUserPhrase(ref user1Num, user1Greeting);
        PrintUserPhrase(ref user2Num, "Hello user 1");

        PrintUserPhrase(ref user1Num, "How are you?");

        PrintUserPhrase("I'm fine");

        try
        { 
            ConcatStrings("Hello", "World");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        string result = ConcatStrings("Exception", " deny");
        Console.WriteLine(result);

        SumAll(1, 3, 2, 4, 87, 12, 6, 7);

        Console.WriteLine(Multiple(10, 3));

        // виклик статичного методу з класу SimpleClass
        SimpleClass.Multiple(10, 3);

        Func<int, int, int> multiple = SimpleClass.Multiple;

        multiple += multiple;

        return;
    }

    // <модифікатор доступу> <що повертає> <ім'я методу>(<тип> <ім'я>, <тип> <ім'я>)
    static void PrintUserPhrase(ref int user1Num, string text)
    {
        user1Num++;
        Console.WriteLine($"User {user1Num} sad: {text}");
    }

    static void PrintUserPhrase(string text)
    { 
        Console.WriteLine($"Undefined user sad: {text}");
    }

    static string ConcatStrings(string first, string second)
    {
        string user1Greeting = "Hello user 2!";

        if (first.Length > second.Length)
        {
            return first + second;
        }

        throw new Exception("First string is shorter than second");

        //return second + first;
    }

    static int SumAll(params int[] nums)
    {
        return nums.Sum();
    }

    static int Multiple(int num1, int num2)
    {
        if (num2 == 1)
        { 
            return num1;
        }
        return num1 + Multiple(num1, num2 - 1);
    }

    // 5 * 3 = 5 + (5 * 2) = 5 + (5 + (5 * 1)) = 5 + (5 + 5) = 5 + 10 = 15
}
using System;
using System.Linq;

namespace Linq
{
    delegate void Print();
    delegate void PrintValue(string val);

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            // пошук числа - цикл
            for (int i = 0; i < nums.Length; i++)
            { 
                if (nums[i] == 5)
                {
                    //Console.WriteLine("Found 5!");
                    break;
                }
            }

            // модифікація масиву - цикл
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= 10;
            }

            // перетворення масиву - цикл
            List<int> numsMoreThan20 = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 20)
                {
                    numsMoreThan20.Add(nums[i] + 15);
                }
            }

            // перший елемент
            int f = nums.First();
            int f1 = nums.FirstOrDefault();

            // останній елемент
            nums.Last();
            nums.LastOrDefault();

            // пропустити перші 2 елементи
            int[] ints = nums.Skip(2).ToArray();

            foreach (int item in ints)
            {
                //Console.WriteLine(item);
            }

            // взяти перші 5 елементів
            nums.Take(5).ToList();

            // середнє значення
            nums.Average();

            // сума всіх елментів масиву
            nums.Sum();

            // унікальні елементи
            nums.Distinct().ToArray();

            Print printDelegate = PrintHello;

            printDelegate += PrintBye;
            printDelegate += PrintHello;

            printDelegate += printDelegate + PrintBye;            

            printDelegate();

            PrintValue printValueDelegate = PrintString;

            printValueDelegate("smth");

            // Action - делегат, який не повертає значення
            Action<string> action = PrintString;

            Action action1 = PrintHello;
            action1 += PrintBye;

            // Func - делегат, який повертає значення
            Func<int, int> func = Plus10;

            // Predicate - делегат, який повертає bool
            Predicate<int> predicate = IsEven;

            // LINQ
            int[] linqNums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // пошук числа - LINQ
            if (linqNums.Where(IsFive).Any())
            {
                Console.WriteLine("Found 5!");
            }

            // модифікація масиву - LINQ
            Func<int, int> multiple = Multiple10;

            int[] linqNumsX10 = linqNums.Select(multiple).ToArray();

            // перетворення масиву - LINQ
            // 1. Where - фільтрація
            // 2. Select - проекція

            Func<int, bool> moreThan20 = (int x) => { return x > 20; };
            Func<int, int> plus15 = (int x) => { return x + 15; };

            int[] ints1 = linqNums
                .Select(plus15)
                .Where(moreThan20)
                .Where(IsEven)
                .ToArray();

            foreach (int item in ints1)
            {
                Console.Write($"{item} ");
            }

            linqNums.Any(x => x > 5 && x < 7);

            string[] names = { "Tom", "Alice", "Bob", "Sam" };

            names.Any(x => x == "Sam");

            Console.WriteLine();

            int[] ints2 = linqNums.OrderBy(x => -x).ToArray();

            foreach (int item in ints2)
            {
                Console.Write($"{item} ");
            }
        }

        static void PrintHello()
        { 
            Console.WriteLine("Hello");
        }

        static void PrintBye()
        {
            Console.WriteLine("Bye");
        }

        static void PrintString(string val)
        {
            Console.WriteLine(val);
        }

        static int Plus10(int num)
        {
            return num + 10;
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        static bool IsFive(int num)
        {
            return num == 5;
        }

        static int Multiple10(int num)
        {
            return num * 10;
        }
    }
}

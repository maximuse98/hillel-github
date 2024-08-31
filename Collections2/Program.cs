List<string> listOfStrings = new List<string>();

listOfStrings.Add("First string");
listOfStrings.Add("Second string");

//Console.WriteLine(listOfStrings[1]);

string[] strings = { "Third string", "Fourth string" };

listOfStrings.AddRange(strings);

foreach (string str in listOfStrings)
{
    Console.WriteLine(str);
}

List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6 };
List<int> ints2 = new List<int>(ints);

ints.Add(7);
ints.Remove(2);

bool is50Removed = ints.Remove(50);
ints.RemoveAt(2);

int sizeOfList = ints.Count();

int[] ints1 = ints.ToArray();

List<int> list = ints1.ToList();

// Task 1
string input = "It`s Friday, dudes! 33";
//string input = "Lorem 1 ipsum dolor sit amet, consectetur 8 adipiscing elit 9, sed 3 do eiusmod@ tempor incididunt 5 ut labore** et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
string[] words = input.Split(' ');

Console.WriteLine(words.Length);

// linq
// int count = input.Where(c => c == ' ').Count();
// input.Count(x => x == ' ');

// Task 2
int start = 2;
int lengthOfSubstring = 5;

for (int i = start; i < start + lengthOfSubstring; i++)
{
    Console.Write(input[i]);
}
Console.WriteLine();

// Task 3
char[] spec = { '!', '@', '*', '.', ',', ' ', '`'};
int numberOfLetters = 0;
int numberOfSpec = 0;
int numberOfDigits = 0;

//foreach (char c in input)
//{
//    // check for digits
//    try
//    {
//        Convert.ToInt32(c.ToString());
//        numberOfDigits++;

//        continue;
//    }
//    catch { }

//    // check for special characters
//    if (spec.Contains(c))
//    {
//        numberOfSpec++;

//        continue;
//    }

//    // check for letters
//    numberOfLetters++;
//}

Console.WriteLine($"Input: {input}");
Console.WriteLine($"Letters count: {numberOfLetters}");
Console.WriteLine($"Special characters count: {numberOfSpec}");
Console.WriteLine($"Digits count: {numberOfDigits}");

Console.WriteLine();

// Task 4
bool[] mask = new bool[input.Length];
int maxCount = 0;
char resultChar = '^';

for (int i = 0; i < input.Length; i++)
{
    if (mask[i] || input[i] == ' ')
    {
        continue;
    }

    char currentChar = input[i];
    int currentCharCount = 1;

    for (int j = i + 1; j < input.Length; j++)
    {
        if (input[j] == currentChar)
        {
            currentCharCount++;
            mask[j] = true;
        }
    }

    if (currentCharCount > maxCount)
    {
        maxCount = currentCharCount;
        resultChar = currentChar;
    }
}

Console.WriteLine($"Most common character: {resultChar}");
Console.WriteLine($"Count: {maxCount}");
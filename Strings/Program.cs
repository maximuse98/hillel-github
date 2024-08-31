//string str = "Hello, World!";

//str[1] = 'a';

using System.Text;

int a;
bool b;
string str = string.Empty; //= "";

char[] ch = { 'H', 'e', 'l', 'l', 'o' };
string str2 = new string(ch);

Console.WriteLine(str);

str = "welcome";
Console.WriteLine(str);

str = string.Empty;

string formattedString = $"Value: {str}";
formattedString = string.Format("Value 1: {0}, Value 2: {1}, Value 3: {2}", str, "he-he", "ha-ha");

Console.WriteLine(formattedString);

Console.WriteLine("Value 1: " + str + ", Value 2: " + "he-he" + ", Value 3: " + "ha-ha");
formattedString += "!";

string name = "Maxim";
string surname = "Kabakov";

string result = "Welcome, " + name + " " + surname + "!";

// "0123456789"

string result2 = string.Empty;
for (int i = 0; i < 10; i++)
{
    result2 += i.ToString();
}
Console.WriteLine(result2);

StringBuilder stringBuilder = new StringBuilder();
for (int i=0; i< 10; i++)
{
    stringBuilder.Append(i);
}
Console.WriteLine(stringBuilder.ToString());

Console.WriteLine(stringBuilder[2]);
//Console.WriteLine(stringBuilder[15]);

string s1 = "Hello";
string s2 = "Hello";
string s3 = str;

// s2 == s1; //true
// s3 == str; //true

s2 = "World";

// s2 != s1; //true

// конкатенація
string.Concat(s1, s2, s1, s1, s1,s1,s1,s1,s1,s1,s1,s1,s1);
// підстрока
//s1[..1]; // s1[..1]
string s4 = s1.Substring(1, 3); // s1[1..4]

// розділення
Console.WriteLine("Split:");
string[] formattedValuesArray = formattedString.Split(',', 4, StringSplitOptions.None);
foreach (var item in formattedValuesArray)
{
    Console.WriteLine(item);
}

// конвертація
int number = 123;
string numberStr = number.ToString();

int res = int.Parse(numberStr);

string str4 = "C:\\Users\\maxim.kabakov\\Videos\\Captures\n\n\tEnd";
Console.WriteLine(str4);

string unicode = "\ud83d\udc02";

Console.WriteLine(unicode);

string str5 = @"C:\Users\maxim.kabakov\Videos\Captures\n\n\tEnd";

// linq
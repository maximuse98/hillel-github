using Classes;
using System.Diagnostics;
using System.Xml.Linq;

Person person = new Person("John", "M");
person.Speak();

//person.name = "John";

Person person1 = new Person("Jane", "F");
//person1.name = "Jane";

//Console.WriteLine(person.name + " " + person1.name);

//Person.Speak(); -  not allowed

string[] names = new string[10];
string[] grades = new string[10];
int[][] marks = new int[10][];

Person[] people = { person, person1, new Person("Peter", "M"), new Person("Lisa", "M", "5-A") };

foreach (Person p in people)
{
    p.Speak();
}

people[0].SetName("Mark");
Console.WriteLine(people[0].GetName());

people[0].Age = 14;
int firstAge = people[0].Age;

List<string> strings = new List<string>();

strings.Add("John");
strings.Add("Jane");
strings.Add("Peter");
using Classes;
using Classes.Animal;
using Classes.Inheritence;
using Classes.User;
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

StaticClass.Introduce();
string name = StaticClass.name;





User user = new User("hillel_user@gmail.com", "user_test");
//Console.WriteLine(user.Email);
//user.CheckHomework(); // Error
//Console.WriteLine(user.password);

Teacher teacher = new Teacher();
//Console.WriteLine(teacher.Email);
teacher.CheckHomework();
teacher.ToString();

object obj = new object();
obj.ToString();

Dog dog = new Dog();
dog.Sound(); // Bark
dog.Nickname = "Rex";

Cat cat = new Cat();
cat.Sound(); // Meow
cat.Nickname = "Barsik";

// upcasting
Animal dogAnimal = dog;
Animal catAnimal = cat;
//dogAnimal.Nickname

// downcasting
Dog dog1 = (Dog)dogAnimal;
Cat cat1 = (Cat)catAnimal;

Dog dog2 = (Dog)catAnimal; // Error

object obj1 = name;


// Inheritence
BaseClass _base = new BaseClass();
DerivedClass derived = new DerivedClass(_base);

derived.BaseMethod();
derived.DerivedMethod();
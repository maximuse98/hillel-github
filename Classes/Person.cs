using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        // поля
        private string name;
        private string grade;
        private int[] marks;
        private string gender;
        private int age;

        // властивості
        public int Age 
        {   
            get { return age; } 
            set 
            {
                if (value > 5)
                {
                    age = value;
                }
            } 
        }

        // конструктор
        public Person(string name, string gender)
        { 
            this.name = name;
            this.gender = gender;
        }

        public Person(string name, string gender, string grade) : this(name, gender)
        { 
            this.grade = grade;
        }

        // методи
        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {name}");
        }

        public void Speak()
        {
            Introduce();

            if ( grade != null)
            {
                Console.WriteLine($"I study at {grade}");
            }
        }

        public void SetName(string name)
        {
            if (name != null)
            { 
                this.name = name;
            }
        }

        public string GetName()
        {
            string prefix;
            if (gender == "M")
            { 
                prefix = "Mr. ";
            }
            else
            {
                prefix = "Ms. ";
            }
            return prefix + name;
        }

        public void SetGrade(string grade)
        {
            this.grade = grade;
        }

        public string GetGrade()
        {
            return grade;
        }
    }
}

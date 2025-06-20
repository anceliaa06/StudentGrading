using System;

namespace ConstructorOverloading
{
    class Student
    {
        public string Name;
        public int Marks;
        public char Grade;

        // constructor with only name
        public Student(string name)
        {
            this.Name = name;
            this.Marks = 0;
            this.Grade = '-';
        }

        // constructor with name and marks
        public Student(string name, int marks)
        {
            this.Name = name;
            this.Marks = marks;
            this.Grade = '-';
        }

        // constructor with name, marks and grade
        public Student(string name, int marks, char grade)
        {
            this.Name = name;
            this.Marks = marks;
            this.Grade = grade;
        }

        // method to assign grade based on marks
        public void AssignGrade()
        {
            if (Marks >= 90)
                Grade = 'A';
            else if (Marks >= 80)
                Grade = 'B';
            else if (Marks >= 70)
                Grade = 'C';
            else
                Grade = 'D';
        }

        // method to display student details
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Marks: {Marks}, Grade: {Grade}");
        }
    }

    class Program
    {
        static void Main()
        {
            Student student1 = new Student("pam");
            student1.Marks = 76;

            Student student2 = new Student("sam", 85);
            Student student3 = new Student("ram", 92, ' '); 

            student1.AssignGrade();
            student2.AssignGrade();
            student3.AssignGrade();

            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();
        }
    }
}

namespace Delegates;

public class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
    public int Age { get; set; }

    public Student(string name, int marks, int age)
    {
        Name = name;
        Marks = marks;
        Age = age;
    }
}

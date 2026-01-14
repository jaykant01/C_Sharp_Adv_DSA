using System.Collections.Generic;
namespace Delegates;

public class StudentSorter
{
    // Delegate for comparison
    public delegate int StudentCompare(Student s1, Student s2);

    // Generic sort method using delegate
    public static void SortStudents(List<Student> students, StudentCompare compare)
    {
        students.Sort((s1, s2) => compare(s1, s2));
    }

    // Sorting by Name
    public static int SortByName(Student s1, Student s2)
    {
        return s1.Name.CompareTo(s2.Name);
    }

    // Sorting by Marks
    public static int SortByMarks(Student s1, Student s2)
    {
        return s1.Marks.CompareTo(s2.Marks);
    }

    // Sorting by Age
    public static int SortByAge(Student s1, Student s2)
    {
        return s1.Age.CompareTo(s2.Age);
    }
}

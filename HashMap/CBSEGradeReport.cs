using System;
using System.Collections.Generic;
namespace HashMap;

public interface IGradeReport
{
    string GetGrade(int marks);
}


public class CBSEGradeReport : IGradeReport
{
    public string GetGrade(int marks)
    {
        if (marks >= 91) return "A1";
        if (marks >= 81) return "A2";
        if (marks >= 71) return "B1";
        if (marks >= 61) return "B2";
        if (marks >= 51) return "C1";
        return "C2";
    }
}

public class GPAGradeReport : IGradeReport
{
    public string GetGrade(int marks)
    {
        if (marks >= 90) return "4.0";
        if (marks >= 80) return "3.7";
        if (marks >= 70) return "3.3";
        if (marks >= 60) return "3.0";
        if (marks >= 50) return "2.7";
        return "0.0";
    }
}


public class GradeService
{
    private Dictionary<int, IGradeReport> studentGrades = new Dictionary<int, IGradeReport>();

    public void AddGrade(int rollNumber, IGradeReport gradeReport)
    {
        studentGrades[rollNumber] = gradeReport;
        Console.WriteLine($"Grade report added for Roll No: {rollNumber}");
    }

    public void DisplayGrade(int rollNumber, int marks)
    {
        if (studentGrades.TryGetValue(rollNumber, out IGradeReport gradeReport))
        {
            string grade = gradeReport.GetGrade(marks);
            Console.WriteLine($"Roll No: {rollNumber}, Marks: {marks}, Grade: {grade}");
        }
        else
        {
            Console.WriteLine($"No grade report found for Roll No: {rollNumber}");
        }
    }
}

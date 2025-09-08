using System;
public class StudentGroup
{
    private string groupName;
    private string[] studentNames;
    private int numberOfStudents;

    public StudentGroup(string nameOfGroup, int fixedNumberOfStudents)
    {
        groupName = nameOfGroup;
        studentNames = new string[fixedNumberOfStudents];
        numberOfStudents = 0;
    }

    public string getStudent(int studentIndex)
    {
        return (studentIndex >= 0 && studentIndex < studentNames.Length && !string.IsNullOrEmpty(studentNames[studentIndex]))
                ? studentNames[studentIndex]
                : "no student here";
    }
    public void addStudent(string nameOfStu, int studentIndex)
    {
        if (studentIndex >= 0 && studentIndex < studentNames.Length)
        {
            if (string.IsNullOrEmpty(studentNames[studentIndex]))
            {
                numberOfStudents++;
            }
            studentNames[studentIndex] = nameOfStu;
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }

    public void displayGroup()
    {
        Console.WriteLine($"Group: {groupName}");
        for (int i = 0; i < studentNames.Length; i++)
        {
            if (!string.IsNullOrEmpty(studentNames[i]))
            {
                Console.WriteLine($"{studentNames[i]}");
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        StudentGroup ss1 = new StudentGroup("the people", 3);

        /*ss1.addStudent("d1", 0);*/
        ss1.addStudent("d2", 1);
        ss1.addStudent("d3", 2);

        ss1.displayGroup();

    }
} 
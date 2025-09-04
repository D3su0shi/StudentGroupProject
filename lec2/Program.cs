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
    { return studentNames[studentIndex]; }
    public void addStudent(string nameOfStu, int studentIndex)
    {
        studentNames.Inser(studentIndex, nameOfStu);
    }
    public void displayGroup()
    { }


 }
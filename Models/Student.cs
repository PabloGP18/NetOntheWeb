namespace NetOntheWeb.Models;

public class Student
{
    private int id;
    private string name;
    private int classId;


    public Student(int id, string name, int classId)
    {
        this.id = id;
        this.name = name;
        this.classId = classId;
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int ClassId
    {
        get => classId;
        set => classId = value;
    }
}
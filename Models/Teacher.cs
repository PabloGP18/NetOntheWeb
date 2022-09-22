namespace NetOntheWeb.Models;

public class Teacher
{
    private int _id;
    private string _name;
    private int _classId;

    public Teacher(int id, string name, int classId)
    {
        _id = id;
        _name = name;
        _classId = classId;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int ClassId
    {
        get => _classId;
        set => _classId = value;
    }
}
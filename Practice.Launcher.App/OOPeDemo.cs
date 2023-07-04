namespace Practice.Launcher.App;

public class OOPeDemo
{

    private int _myField;

    public OOPeDemo(
        int myField)
    {
        _myField = myField;
    }

    public void Foo()
    {
        Console.WriteLine("лабы тут");
    }

    public int MyField1
    {
        get;
        set;
    }
    
    public int MyField
    {
        get
        {
            return _myField;
        }

        set
        {
            _myField = value;
        }
    }
}
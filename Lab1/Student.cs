namespace Lab1;

public class Student : 
    IEquatable<Student>
{
    private readonly string _surname;
    private readonly string _name;
    private readonly string _patronymic;
    private readonly string _group;
    private readonly string _practiceCourse;

    public Student(
        string surname,
        string name,
        string patronymic,
        string group,
        string practiceCourse)
    {
        SurnameValue = surname ?? throw new ArgumentNullException(nameof(surname));
        NameValue = name ?? throw new ArgumentNullException(nameof(name));
        PatronymicValue = patronymic ?? throw new ArgumentNullException(nameof(patronymic));
        GroupValue = group ?? throw new ArgumentNullException(nameof(group));
        PracticeCourseValue = practiceCourse ?? throw new ArgumentNullException(nameof(practiceCourse));
    }
    public string SurnameValue
    {
        // get;
        // init;
        
        get => _surname;
        init => _surname = value;
    }
    public string NameValue
    {
        get => _name;
        init => _name = value;
    }
    public string PatronymicValue
    {
        get => _patronymic;
        init => _patronymic = value;
    }
    public string GroupValue
    {
        get => _group;
        init => _group = value;
    }
    public string PracticeCourseValue
    {
        get => _practiceCourse;
        init => _practiceCourse = value;
    }

    public string CourseNumberValue
    {
        get
        {
            if (DateTime.Now.Month > 8)
                return (DateTime.Now.Year - (2000 + 10 * (GroupValue[9] - '0') + GroupValue[10] - '0') + 1).ToString();
            else
                return (DateTime.Now.Year - (2000 + 10 * (GroupValue[9] - '0') + GroupValue[10] - '0')).ToString();
        }
    }

    public override string ToString()
    {
        Console.WriteLine("-> object.ToString called");
        return string.Format("Surname: {0};{1}Name: {2};{1}Patronymic: {3};{1}Group: {4};{1}Practice course: {5}.",
            SurnameValue, Environment.NewLine, NameValue, PatronymicValue, GroupValue, PracticeCourseValue);
        // return $"Surname: {SurnameValue};{Environment.NewLine}Name: {NameValue};\nPatronymic: {PatronymicValue};\nGroup: {GroupValue};\nPractice course: {PracticeCourseValue}.";
        // \n == Environment.NewLine лучше
    }

    public override bool Equals(
        object? obj)
    {
        Console.WriteLine("-> object.Equals called");
        if (obj is null)
        {
            return false;
        }

        if (obj is Student student)
        {
            return Equals(student);
        }
        
        if (obj is string @string)
        {
            return Equals(@string);
        }

        return false;
    }

    public bool Equals(
        string? @string)
    {
        Console.WriteLine("-> Student.Equals called");
        if (@string is null)
        {
            return false;
        }
        bool flag = false;
        if (SurnameValue.Equals(@string))
        {
            Console.WriteLine($"The {_surname} {_name} {_patronymic} student's surname is the same.");
            flag = true;
        }
        if (NameValue.Equals(@string))
        {
            Console.WriteLine($"The {_surname} {_name} {_patronymic} student's name is the same.");
            flag = true;
        }
        if (PatronymicValue.Equals(@string))
        {
            Console.WriteLine($"The {_surname} {_name} {_patronymic} student's patronymic is the same.");
            flag = true;
        }
        if (GroupValue.Equals(@string))
        {
            Console.WriteLine($"The {_surname} {_name} {_patronymic} student's group is the same.");
            flag = true;
        }
        if (PracticeCourseValue.Equals(@string))
        {
            Console.WriteLine($"The {_surname} {_name} {_patronymic} student's practice course is the same.");
            flag = true;
        }

        return flag;
    }

    public bool Equals(
        Student? student)
    {
        Console.WriteLine("-> Student.Equals called");
        if (student is null)
        {
            return false;
        }

        return SurnameValue.Equals(student.SurnameValue) &&
               NameValue.Equals(student.NameValue) &&
               PatronymicValue.Equals(student.PatronymicValue) &&
               GroupValue.Equals(student.GroupValue) &&
               PracticeCourseValue.Equals(student.PracticeCourseValue);
    }

    public override int GetHashCode()
    {
        return 37 * ((((SurnameValue.GetHashCode() * 101 + NameValue.GetHashCode()) * 499 +
                       PatronymicValue.GetHashCode())) * 701 + GroupValue.GetHashCode()) * 997 + PracticeCourseValue.GetHashCode();
    }
}
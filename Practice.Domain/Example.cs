namespace Practice.Domain;

public class Example:
    IEquatable<string>,
    IEquatable<int>,
    IEquatable<Example>
{
    public int IntValue
    {
        get;

        // init;
    }

    public string StringValue
    {
        get;
    }

    public Example(
        int @int = 0,
        string @string = "")
    {
        IntValue = @int;
        StringValue = @string ?? throw new 
            ArgumentNullException(nameof(@string));
    }
    
    public void Foo()
    {
        
    }

    public override bool Equals(
        object? obj)
    {
        if (obj == null)
        {
            return false;
        }

        if (obj is Example example)
        {
            return IntValue == example.IntValue
                   && StringValue.Equals(example.StringValue);
        }
        
        return false;
    }
    
    public bool Equals(
        string @string)
    {
        return StringValue.Equals(@string);
    }
    
    public bool Equals(
        int @int)
    {
        return IntValue.Equals((@int));
    }
    
    public bool Equals(
        Example example)
    {
        if (example == null)
        {
            return false;
        }

        
        
        return false;
    }
}

public class ExampleChild:
    Example
{
    
}
namespace ValueTypeVersusReferenceType;

public class PersonClass
{
    private string _name;

    public PersonClass()
    {
        
    }

    public string getName()
    {
        return name;
    }

    public string name
    {
        get { return _name; }
        set { _name = value; }
    }
}
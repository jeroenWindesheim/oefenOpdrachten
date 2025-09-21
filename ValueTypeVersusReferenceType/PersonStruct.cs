namespace ValueTypeVersusReferenceType;

public struct PersonStruct
{
    private string _name;

    public PersonStruct()
    {
        
    }

    public string name
    {
        get { return _name; }
        set { _name = value; }
    }
}
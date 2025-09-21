namespace EenvoudigQuizspelOpdracht;

public class User
{
    private string _FirstName;

    public string FirstName
    {
        get { return _FirstName; }
        set { _FirstName = value; }
    }

    private string _LastName;

    public string LastName
    {
        get { return _LastName; }
        set { _LastName = value; }
    }

    public void AddName(string firstname, string lastname)
    {
        FirstName = firstname;
        LastName = lastname;
    }

    public string getName()
    {
        string fullName = FirstName + " " + LastName;
        return fullName;
    }
}
namespace InheritanceGebouw;

public class Gebouw
{
    private int _kamers;
    private string _adres;

    public Gebouw(int kamers, string adres)
    {
        Kamers = kamers;
        Adres = adres;
    }
    
    public int Kamers
    {
        get { return _kamers; }
        set { _kamers = value; }
    }

    public string Adres
    {
        get { return _adres; }
        set { _adres = value; }
    }
}
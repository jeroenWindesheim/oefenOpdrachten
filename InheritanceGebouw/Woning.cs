namespace InheritanceGebouw;

public class Woning : Gebouw
{
    private int _inwoners;
    private decimal _WOZ;
    
    public Woning(int kamers, string adres, int inwoners, decimal woz): base(kamers, adres)
    {
        Inwoners = inwoners;
        WOZ = woz;
    }

    public string getInfo()
    {
        string info = $"Kamers: {Kamers}, Adres: {Adres}, Inwoners: {Inwoners}, Woz: {WOZ}";

        return info;
    }

    public int Inwoners
    {
        get { return _inwoners; }
        set { _inwoners = value; }
    }

    public decimal WOZ
    {
        get { return _WOZ; }
        set { _WOZ = value; }
    }
}
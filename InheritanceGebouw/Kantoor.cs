namespace InheritanceGebouw;

public class Kantoor : Gebouw
{
    private int _parkeerPlaatsen;
    private int _verdiepingen;
    
    public Kantoor(int kamers, string adres, int parkeerPlaatsen, int verdiepingen) : base(kamers, adres)
    {
        ParkeerPlaatsen = parkeerPlaatsen;
        Verdiepingen = verdiepingen;
    }

    public string getInfo()
    {
        string info = $"Kamers: {Kamers}, Adres: {Adres}, ParkeerPlaatsen: {ParkeerPlaatsen}, Verdiepingen: {Verdiepingen}";
        
        return info;
    }

    public int ParkeerPlaatsen
    {
        get { return _parkeerPlaatsen; }
        set { _parkeerPlaatsen = value; }
    }

    public int Verdiepingen
    {
        get { return _verdiepingen; }
        set { _verdiepingen = value; }
    }
}
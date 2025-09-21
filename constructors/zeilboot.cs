namespace constructors;

public class Zeilboot
{
    private string _naam;
    private int _lengte;
    private int _zeiloppervlak;
    
    public Zeilboot(string naam, int lengte, int zeiloppervlak)
    {
        Naam = naam;
        Lengte = lengte;
        Zeiloppervlak = zeiloppervlak;
    }

    public string getAll()
    {
        return ($"Naam: {Naam}, Lengte: {Lengte}, Zeiloppervlak: {Zeiloppervlak}");
    }
    
    
    public string Naam
    {
        get { return _naam; }
        set { _naam = value; }
    }

    public int Lengte
    {
        get { return _lengte; }
        set { _lengte = value; }
    }

    public int Zeiloppervlak
    {
        get { return _zeiloppervlak; }
        set { _zeiloppervlak = value; }
    }
}
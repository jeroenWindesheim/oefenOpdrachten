namespace VolledigeNaam.Classes;

public class Person
{
    private string _voornaam;
    private string _tussenvoegsels;
    private string _achternaam;

    public Person(string voornaam, string tussenvoegsels, string achternaam)
    {
        Voornaam = voornaam;
        Tussenvoegsels = tussenvoegsels;
        Achternaam = achternaam;
    }

    public virtual string VolledigeNaam()
    {
        return $"{Voornaam}, { Achternaam } { Tussenvoegsels }";
    }
    
    public string Voornaam { get; set; }
    public string Tussenvoegsels { get; set; }
    public string Achternaam { get; set; }
}
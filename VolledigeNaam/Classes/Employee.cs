namespace VolledigeNaam.Classes;

public class Employee : Person
{
    public Employee(string voornaam, string tussenvoegsels, string achternaam) : base(voornaam, tussenvoegsels,
        achternaam)
    {
        
    }

    public override string VolledigeNaam()
    {
        return $"{this.Voornaam} { this.Tussenvoegsels } { this.Achternaam }";
    }
}
namespace VolledigeNaam.Classes;

public class Customer : Person
{
    public Customer(string voornaam, string tussenvoegsels, string achternaam) : base(voornaam, tussenvoegsels,
        achternaam)
    {
        
    }

    public override string VolledigeNaam()
    {
        return $"{ this.Achternaam }, { this.Voornaam } { this.Tussenvoegsels }";
    }
}
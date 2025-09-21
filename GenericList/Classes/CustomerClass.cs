namespace GenericList.Classes;

public class CustomerClass : PersonClass
{
    public CustomerClass(string voornaam, string tussenvoegsel, string achternaam) : base(voornaam, tussenvoegsel,
        achternaam)
    {
        
    }
    
    public override string VolledigeNaam()
    {
        return $"{ this.Achternaam }, { this.Voornaam } { this.Tussenvoegsels }";
    }
}
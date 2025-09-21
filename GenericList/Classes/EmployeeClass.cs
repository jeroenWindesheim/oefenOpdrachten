namespace GenericList.Classes;

public class EmployeeClass : PersonClass
{
    public EmployeeClass(string voornaam, string tussenvoegsel, string achternaam) : base(voornaam, tussenvoegsel,
        achternaam)
    {
        
    }
    
    public override string VolledigeNaam()
    {
        return $"{this.Voornaam} { this.Tussenvoegsels } { this.Achternaam }";
    }
}
// See https://aka.ms/new-console-template for more information

using VolledigeNaam.Classes;

Console.WriteLine("Volledige Naam");

Person Jeroen = new Person("Jeroen", "Tussen", "Maassen van den Brink");
Employee e1 = new Employee("Jeroen", "Tussen", "Maassen van den Brink");
Customer c1 = new Customer("Jeroen", "Tussen", "Maassen van den Brink");

Console.WriteLine(Jeroen.VolledigeNaam());
Console.WriteLine(e1.VolledigeNaam());
Console.WriteLine(c1.VolledigeNaam());


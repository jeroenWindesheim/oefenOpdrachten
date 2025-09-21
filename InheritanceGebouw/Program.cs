// See https://aka.ms/new-console-template for more information
using InheritanceGebouw;

Console.WriteLine("Inheritence Gebouw");

// Maak een kantoor pand en geef de informatie terug
Woning huis = new Woning(4, "7741 SG", 4, 300000.75m);
string huistInformatie = huis.getInfo();

Kantoor kantoor = new Kantoor(20, "7556 AX", 100, 4);
string kantoorInformatie = kantoor.getInfo();


Console.WriteLine(huistInformatie);
Console.WriteLine(kantoorInformatie);
// See https://aka.ms/new-console-template for more information

using CallByValueCallByReference;

Console.WriteLine("Call by value, Call by reference");

// Make Printer
Printer printer = new Printer();


// Make a Paper
Paper papier = new Paper();

// Print papier 3 times
printer.Print(papier);
printer.Print(papier);
printer.Print(papier);


// Make a book
Book boek1 = new Book();

// Print boek 3 times
printer.Print(boek1);
printer.Print(boek1);
printer.Print(boek1);

Console.WriteLine($"Hoe vaak is papier geprint: {papier.TimesPrinted}");
Console.WriteLine($"Hoe vaak is boek geprint: {boek1.TimesPrinted}");
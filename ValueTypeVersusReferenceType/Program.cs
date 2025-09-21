// See https://aka.ms/new-console-template for more information

using ValueTypeVersusReferenceType;

Console.WriteLine("Hello, World!");

PersonClass jan = new PersonClass();
jan.name = "Jan";
PersonClass jantje = jan;
jantje.name = "Jantje";

PersonStruct jannie = new PersonStruct();
jannie.name = "Jannie";
PersonStruct jannietje = jannie;
jannietje.name = "Jannietje";

Console.WriteLine($"(CLASS) jan: {jan.name}, jantje: {jantje.name}");
Console.WriteLine($"(STRUCT) jannie: {jannie.name}, jannietje: {jannietje.name}");
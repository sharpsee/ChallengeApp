// See https://aka.ms/new-console-template for more information
var name = "Ewa";
var sex = 'M';
var age = 15;

Console.WriteLine("===== wersja 1 =====");

if (sex == 'K' && age < 30)
    Console.WriteLine("Kobieta poniżej 30 lat");
if (name == "Ewa" && age == 30)
    Console.WriteLine("Ewa, lat 30");
if (sex == 'M' && age < 18)
    Console.WriteLine("Niepełnoletni mężczyzna");

Console.WriteLine("===== wersja 2 =====");

if (age == 30) {
    if (name == "Ewa")
        Console.WriteLine("Ewa, lat 30");
} else if (age < 30) {
    if (sex == 'K')
        Console.WriteLine("Kobieta poniżej 30 lat");
    if (sex == 'M' && age < 18)
        Console.WriteLine("Niepełnoletni mężczyzna");
}

Console.WriteLine("===== wersja 3 =====");

if (age == 30 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 30");
}
else if (age < 30 && sex == 'K')
{
    Console.WriteLine("Kobieta poniżej 30 lat");
} 
else if (sex == 'M' && age < 18)
{ 
    Console.WriteLine("Niepełnoletni mężczyzna");
}

var name = "Lukasz";
char plec = 'M';
var wiek = 17;
if (plec == 'K')
{
    if (wiek < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (name == "Ewa" && wiek == 33)
    {
        Console.WriteLine("Ewa lat 33");
    }
}
else if (wiek < 18)
{
    Console.WriteLine("Mężczyzna niepełnoletni");
}
else
{
    Console.WriteLine("Mężczyzna lat " + wiek);
}

Console.WriteLine("Podaj liczbe ocen: ");
int liczba_ocen = Convert.ToInt32(Console.ReadLine());
double suma_ocen = 0;

for (int i = 0; i < liczba_ocen; i++)
{
    double ocena;
    while (true)
    {
        Console.Write($"Podaj ocene {i + 1} (1-6)");
        ocena = Convert.ToDouble(Console.ReadLine());
        if (ocena >= 1 && ocena <= 6)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ocena musi byc w zakresie od 1 do 6");
        }
    }
    suma_ocen += ocena;
}

double srednia = suma_ocen / liczba_ocen;
Console.WriteLine($"srednia: {srednia:F2}");

if (srednia >= 3.0)
{
    Console.WriteLine("uczen zdal");
}
else
{
    Console.WriteLine("czuen nie zdal");
}
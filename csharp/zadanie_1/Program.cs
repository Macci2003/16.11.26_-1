Console.Write("Podaj pierwsza liczbe: ");
double liczba_1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj druga liczbe: ");
double liczba_2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Wybierz operacje [+, -, *, /]: ");
string operacja = Console.ReadLine();

if (operacja == "+")
{
    Console.WriteLine($"Wynik: {liczba_1 + liczba_2}");
}
else if (operacja == "-")
{
    Console.WriteLine($"Wynik: {liczba_1 - liczba_2}");
}
else if (operacja == "*")
{
    Console.WriteLine($"Wynik: {liczba_1 * liczba_2}");
}
else if (operacja == "/")
{
    if (liczba_2 != 0)
    {
        Console.WriteLine($"Wynik: {liczba_1 / liczba_2}");
    }
    else
    {
        Console.WriteLine("Nie mozna dzielic przez 0");
    }
}
else
{
    Console.WriteLine("niepoprawna operacja");
}

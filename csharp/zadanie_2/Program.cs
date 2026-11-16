Console.Write("Podaj jednostke do konwersji [c - celcjusz; f - fahrenheit]:" );
string jednostka = Console.ReadLine();

if (jednostka == "c")
{
    Console.Write("Podaj stopnie celcjusza do przeliczenia na fahrenheity: ");
    double temperatura_c = Convert.ToDouble(Console.ReadLine());
    double konwersja = temperatura_c * 1.8 + 32;
    Console.Write($"{konwersja} fahrenheitow");
}
else if (jednostka == "f")
{
    Console.Write("Podaj temperature w fahrenheitach do przeliczenia na stopnie celcjusza: ");
    double temperatura_f = Convert.ToDouble(Console.ReadLine());
    double konwersja = (temperatura_f - 32) / 1.8;
    Console.WriteLine($"{konwersja} stopni celcjusza");
}

else
{
    Console.WriteLine("Niepoprawna jednostka");
}
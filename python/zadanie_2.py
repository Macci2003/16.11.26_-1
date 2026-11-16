jednostka = input("jednostka bazowa [c - celcjusz; f - farenheit]: ")

if jednostka == "c":
    temperatura_c = float(input("Podaj stopnie Celcjusza do przeliczenia na Fahrenheity: "))
    konwersja = temperatura_c*1.8+32
    print(konwersja, "Fahrenheitow")

elif jednostka == "f":
    temperatura_f = float(input("Podaj temperature w Fahrenheitach do przeliczenia na stopnie Celcjusza: "))
    konwersja = (temperatura_f-32)/1.8
    print(konwersja, "stopni Celcjusza")
else:
    print("niepoprawna jednostka")
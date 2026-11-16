liczba_1=int(input("Podaj pierwszą liczbe: "))
liczba_2=int(input("Podaj druga liczbe: "))
operacja=input("Wybierz operacje (+, -, *, /)")

if operacja == "+":
  wynik = liczba_1 + liczba_2
  print ("Wynik: ", wynik)
elif operacja == "-":
  wynik = liczba_1 - liczba_2
  print ("Wynik: ", wynik)
elif operacja == "*":
  wynik = liczba_1 * liczba_2
  print ("Wynik: ", wynik)
elif operacja == "/":
  if liczba_2 != 0:
    wynik = liczba_1 / liczba_2
    print ("Wynik: ", wynik)
  else:
    print("Nie mozna dzielic przez 0")
else:
  print("niepoprawna operacja")

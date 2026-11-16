liczba_ocen = int(input("Podaj liczbe ocen: "))
suma_ocen = 0

for i in range(liczba_ocen):
    while True:
        ocena = float(input(f"Podaj ocene {i+1}: "))
        if 1 <= ocena <= 6:
            break
        else:
            print("podaj ocene w zakresie od 1 do 6")    
    suma_ocen += ocena

srednia = suma_ocen/liczba_ocen
print(f"Średnia: {srednia: .2f}")

if srednia >= 3.0:
    print("uczen zdal")
else:
    print("uczen nie zdal")
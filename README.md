APBD s28797



Mój prosty projekt, jak odpalić:

1. wejść do folderu APBD2
2. wpisac w konsoli dotnet run





Decyzje proj:



podzieliłem go na:

Modele - dane o sprzęcie i ludziach, zastosowałem dziedziczenia dla łatwego rozróżnienia poszczególnych 'rodzai' ludzi nadając im specyficzne limitacje

Serwisy - mozg apki, tutaj zachodzą wszystkie sprawdzenia i naliczam kary

Kohezja i Coupling - z takim podzialem kazda klasa robi swoja rzecz, dlatego tez zmiany miejscowe nie popsują reszty kodu



zrobiłem:

klasy dla sprzętu: laptop, projektor, aparat i osoby wyporzyuczajace

blokadę limitow w systemie wypozyczeniowym

wymyślanie kar i nakładanie ich, pienieznych oczywiście

końcowy raport na konsoli


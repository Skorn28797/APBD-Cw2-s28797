using APBD2.Modele;
using APBD2.Serwisy;

var serwisowalnia = new WypozyczalniaSerwisowa();

var lapek1 = new Laptop("Asus bleh", 32, "i5");
var projek1 = new Projektor("Susa 30X", 1500, "HD");
var apaparat1 = new Aparat("Srony Jung4", 20, "Full");

serwisowalnia.DodajSprzet(lapek1);
serwisowalnia.DodajSprzet(projek1);
serwisowalnia.DodajSprzet(apaparat1);

var stustudent1 = new Student("Stas", "Stasiewski");
var pracocownik1 = new Pracownik("Adam", "Blazej");

serwisowalnia.DodajUzytkownika(stustudent1);
serwisowalnia.DodajUzytkownika(pracocownik1);

//poprawne wypozyczenie
Console.WriteLine(serwisowalnia.Wypozycz(stustudent1, lapek1, 7));

//zle, sprezet zajety
Console.WriteLine(serwisowalnia.Wypozycz(pracocownik1, lapek1, 2));

//zle, za duzo na raz wykraczajac studentowy limit
serwisowalnia.Wypozycz(stustudent1, projek1, 5);
Console.WriteLine(serwisowalnia.Wypozycz(stustudent1, apaparat1, 1));


//dobrze, zwrot na czas
Console.WriteLine(serwisowalnia.Zwrot(lapek1));

//zle, zwrot nie na czas i danie kary
Console.WriteLine("raporty testowanie");
serwisowalnia.ShowDostepne();
serwisowalnia.ZdajRaport();
    


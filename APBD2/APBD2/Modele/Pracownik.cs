using APBD2.Apstrakcje;

namespace APBD2.Modele;

public class Pracownik : Uzytkownik
{
    public override int MaxLiczWypozyczen => 5;

    public Pracownik(string imie, string nazwisko) : base(imie, nazwisko)
    {
        
    }
}
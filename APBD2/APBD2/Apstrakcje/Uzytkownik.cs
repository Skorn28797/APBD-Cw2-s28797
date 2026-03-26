namespace APBD2.Apstrakcje;

public abstract class Uzytkownik
{
    public Guid Id { get; } =  Guid.NewGuid();
    
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    
    
    
    public abstract int MaxLiczWypozyczen { get; }
    
    

    protected Uzytkownik(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
    }
    
}
using APBD2.Apstrakcje;

namespace APBD2.Modele;

public class Wypozyczenie
{
    public Guid Id { get; } = Guid.NewGuid();
    public Uzytkownik Wypozyczator { get; set; }
    public Sprzet PodmiotWypozyczenia { get; set; }
    
    
    public DateTime DataWypozyczenie { get; set; }
    public DateTime DataZwrotu { get; set; }
    
    public DateTime? FDZ { get; set; }


    public Wypozyczenie(Uzytkownik uzytkownik, Sprzet sprzet, int dniWypozyczenia)
    {
        Wypozyczator = uzytkownik;
        PodmiotWypozyczenia = sprzet;
        DataWypozyczenie = DateTime.Now;
        DataZwrotu = DataWypozyczenie.AddDays(dniWypozyczenia);
        FDZ = null;
    }

    public bool CzyZwrotNaCzas()
    {
        if (!FDZ.HasValue) return true;
        return FDZ.Value <= DataZwrotu;
    }
    
    
}
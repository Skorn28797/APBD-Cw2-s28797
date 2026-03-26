using APBD2.Apstrakcje;
using APBD2.Modele;

namespace APBD2.Serwisy;

public class WypozyczalniaSerwisowa
{

    private const decimal CenaKaryZaDzien = 10.0m;
    
    
    private readonly List<Uzytkownik> _uzytkownicy = new();
    private readonly List<Sprzet> _sprzety = new();
    private readonly List<Wypozyczenie> _wypozyczenia = new();
    
    
    public void DodajUzytkownika(Uzytkownik uzytkownik) => _uzytkownicy.Add(uzytkownik);
    public void DodajSprzet(Sprzet sprzet) => _sprzety.Add(sprzet);

    public string Wypozycz(Uzytkownik uzytkownik, Sprzet sprzet, int dniWypozyczenia)
    {
        if (!sprzet.CzyDostep) return "error, sprzet niedostepny";

        int iloscWypozyczonych = _wypozyczenia.Count(x => x.Wypozyczator.Id == uzytkownik.Id && x.FDZ == null);

        if (iloscWypozyczonych >= uzytkownik.MaxLiczWypozyczen)
            return "error, user " + uzytkownik.Nazwisko + " za duzo wypozyczyl, limit: " + uzytkownik.MaxLiczWypozyczen;


        var freshWypozyczenie = new Wypozyczenie(uzytkownik, sprzet, dniWypozyczenia);
        _wypozyczenia.Add(freshWypozyczenie);
        sprzet.CzyDostep = false; //jest zajety

        return "wszystko dobrze, status: Wypozyczono " + sprzet.Nazwa + " uzytkownik " + uzytkownik.Nazwisko;

    }

    public void ShowAllSprzety()
    {
        foreach (var s in _sprzety)
            Console.WriteLine(s.Id + " " + s.Nazwa + " Dostep: " + s.CzyDostep);
    }


    public string Zwrot(Sprzet sprzet)
    {
        var w = _wypozyczenia.FirstOrDefault(x => x.PodmiotWypozyczenia.Id == sprzet.Id && x.FDZ == null);

        if (w == null) return "error, nie ma aktywnego wypozyczenia dla tej rzeczy";

        w.FDZ = DateTime.Now;
        sprzet.CzyDostep = true;

        decimal kara = 0;

        if (w.FDZ > w.DataZwrotu)
        {
            int dniOpoznienie = (w.FDZ.Value - w.DataZwrotu).Days;
            kara = dniOpoznienie * CenaKaryZaDzien;
        }

        return "wszystko dobrze, zwrot przyjety, wymiar kary w PLN: " + kara;
    }
    
    //Raporty

    public void ShowDostepne()
    {
        Console.WriteLine("to jest dostepne");
        foreach (var s in _sprzety.Where(x => x.CzyDostep))
            Console.WriteLine(s.ZdobadzOpis());
    }


    public void ShowPoTerminie()
    {
        Console.WriteLine("te sa po terminie");
        var poTerminie = _wypozyczenia.Where(w => w.FDZ == null && DateTime.Now > w.DataZwrotu);
        
        foreach (var w in poTerminie)
            Console.WriteLine("User: " + w.Wypozyczator.Nazwisko + " Sprzet: " + w.PodmiotWypozyczenia.Nazwa + " mija termin: " + w.DataZwrotu);
    }


    public void ZdajRaport()
    {
        Console.WriteLine("finisher raport");
        Console.WriteLine("ilosc sprzetu: " + _sprzety.Count);
        Console.WriteLine("aktualne wypozyczenia: " + _wypozyczenia.Count(w => w.FDZ == null));
        Console.WriteLine("Ciagle dostepne: " + _sprzety.Count(s => s.CzyDostep));
        Console.WriteLine("enddddddddddddddddddddddddddddddd");
    }




}
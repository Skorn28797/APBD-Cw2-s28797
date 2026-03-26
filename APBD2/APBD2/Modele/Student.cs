using APBD2.Apstrakcje;

namespace APBD2.Modele;

public class Student : Uzytkownik
{
    public override int MaxLiczWypozyczen => 2;

    public Student(string imie, string nazwisko) : base(imie, nazwisko)
    {
        
    }
    
    
}
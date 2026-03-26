using APBD2.Apstrakcje;

namespace APBD2.Modele;

public class Projektor : Sprzet
{
    public int Brightness { get; set; }
    public string Rezolucja { get; set; }
    
    public Projektor (string namae, int brightness, string rezolucja) : base(namae)
    {
        Brightness = brightness;
        Rezolucja = rezolucja;
    }

    public override string ZdobadzOpis()
    {
        return "Projektor: " + Nazwa + ", Brightness: " + Brightness + ", Rezolucja: " + Rezolucja;
    }
}
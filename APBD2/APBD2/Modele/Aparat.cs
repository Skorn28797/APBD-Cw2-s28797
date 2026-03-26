using APBD2.Apstrakcje;

namespace APBD2.Modele;

public class Aparat : Sprzet
{
    public double Matryca { get; set; }
    public string TypMatrycy { get; set; }
    
    public Aparat (string namae, double matryca, string typmatrycy) : base(namae)
        {
        Matryca = matryca;
        TypMatrycy = typmatrycy;
        }

    public override string ZdobadzOpis()
    {
        return "Aparat: " + Nazwa + ", Matryca: " + Matryca +  ", TypMatrycy: " + TypMatrycy;
    }
}
using APBD2.Apstrakcje;

namespace APBD2.Modele;

public class Laptop : Sprzet
{
    public int Ram { get; set; }
    public string Procek { get; set; }

    public Laptop(string namae, int ram, string procek) : base(namae)
    {
        Ram = ram;
        Procek = procek;
    }


    public override string ZdobadzOpis()
    {
        //throw new NotImplementedException();
        return "Laptop: " + Nazwa + ", RAM: " + Ram + "gb, Procesor: " + Procek;
    }
}
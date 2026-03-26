namespace APBD2.Apstrakcje;

//shared part dla kazdego typa urzadzenia
public abstract class Sprzet //abstract zapobiega utworzeniu pustego sprzetu
{

    public Guid Id { get; } =  Guid.NewGuid(); //uniq id od systemu

    //dane wspolen
    public string Nazwa { get; set; }
    public bool CzyDostep { get; set; } = true;


    protected Sprzet(string nazwa)
    {
        Nazwa = nazwa;
    }
    
    //todo podtyp wymuszenie cech specyficznych
    public abstract string ZdobadzOpis();
}
abstract class Appareil{
    private string marque { get; set; }
    private string modele { get; set; }
    private DateTime dateFabrication { get; set; }

    //les methodes

    public void Allumer(){
        Console.WriteLine("L'appareil s'allume.");
    }

    public virtual void  AfficherType()
    {
        Console.WriteLine("Je suis un appareil.");
    }

    public virtual void AfficherGarantie()
    {
        Console.WriteLine("Garantie standard de l'appareil.");
    }

    //methode abstraite
    public abstract void AfficherInfos();
    public abstract void CalculerAnciennete();
}
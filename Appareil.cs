abstract class Appareil{
    private protected string marque { get; set; }
    private protected string modele { get; set; }
    private protected DateTime dateFabrication { get; set; }

    public Appareil(string marque, string modele, DateTime dateFabrication)
    {
        this.marque = marque;
        this.modele = modele;
        this.dateFabrication = dateFabrication;
    }

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
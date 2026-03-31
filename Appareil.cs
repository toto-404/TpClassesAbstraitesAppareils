public abstract class Appareil
{
    protected string marque;// attribut protégé pour être accessible dans les classes dérivées
    public string Marque { get; set; } // propriété publique pour accéder à la marque equuivalent à un getter/setter
    protected string modele;
    public string Modele { get; set; }
    protected DateTime dateFabrication { get; set; }
    public DateTime DateFabrication { get; set; }


    public Appareil(string marque, string modele, DateTime dateFabrication)
    {
        Marque = marque;
        Modele = modele;
        DateFabrication = dateFabrication;
    }

    //les methodes

    public void Allumer()
    {
        Console.WriteLine("L'appareil s'allume.");
    }

    public virtual void AfficherType()
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
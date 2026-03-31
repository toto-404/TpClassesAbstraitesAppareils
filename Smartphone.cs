class Smartphone : Appareil
{
    private int nbCapteursPhoto { get; set; }

    public Smartphone(string marque, string modele, DateTime dateFabrication, int nbCapteursPhoto) : base(marque, modele, dateFabrication)
    {
        this.nbCapteursPhoto = nbCapteursPhoto;
    }

    public override void AfficherInfos()
    {
        Console.WriteLine($"Marque: {marque}, Modèle: {modele}, Date de fabrication: {dateFabrication}, Nombre de capteurs photo: {nbCapteursPhoto}.");
    }

    public override void CalculerAnciennete()
    {
        int anciennete = DateTime.Now.Year - dateFabrication.Year;
        Console.WriteLine($"L'ancienneté du smartphone est de {anciennete} ans.");
    }
}
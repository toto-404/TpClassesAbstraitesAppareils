class Ordinateur : Appareil
{
    private double tailleEcran { get; set; }

    public Ordinateur(string marque, string modele, DateTime dateFabrication, double tailleEcran) : base(marque, modele, dateFabrication)
    {
        this.tailleEcran = tailleEcran;
    }
    public override void AfficherType()
    {
        Console.WriteLine("Je suis un ordinateur.");
    }

    public override void AfficherInfos()
    {
        Console.WriteLine($"Marque: {marque}, Modèle: {modele}, Date de fabrication: {dateFabrication}, Taille de l'écran: {tailleEcran} pouces.");
    }

    public override void CalculerAnciennete()
    {
        int anciennete = DateTime.Now.Year - dateFabrication.Year;
        Console.WriteLine($"L'ancienneté de l'ordinateur est de {anciennete} ans.");
    }

    public override string ToString()
    {
        return $"Ordinateur - Marque: {marque}, Modèle: {modele}, Taille de l'écran: {tailleEcran} pouces.";
    }
}
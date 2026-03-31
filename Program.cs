namespace TpClassesAbstraitesAppareils;

class Program
{
    static void Main(string[] args)
    {
        Ordinateur ordi1 = new Ordinateur("Lenovo", "Thinkpad", new DateTime(2020, 5, 15), 15.6);
        // ordi1.Allumer();
        // ordi1.AfficherType();
        // ordi1.AfficherGarantie();
        // ordi1.AfficherInfos();
        // Console.WriteLine(ordi1.ToString());

        // Console.WriteLine("---");

        Smartphone phone1 = new Smartphone("Apple", "iPhone 12", new DateTime(2021, 10, 23), 3);
        // phone1.Allumer();
        // phone1.AfficherType();
        // phone1.AfficherGarantie();
        // phone1.AfficherInfos();

        List <Appareil> appareils = new List<Appareil>();
        appareils.Add(ordi1);
        appareils.Add(phone1);

        foreach (Appareil appareil in appareils)
        {
            Console.WriteLine("---");
            appareil.Allumer();
            appareil.AfficherType();
            appareil.AfficherGarantie();
            appareil.AfficherInfos();
        }

        //utilise modele comme clé pour le dictionnaire
        Dictionary<string, Appareil> dictAppareils = new Dictionary<string, Appareil>();
        dictAppareils.Add(ordi1.Modele, ordi1);
    }
}

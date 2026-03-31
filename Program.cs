namespace TpClassesAbstraitesAppareils;

class Program
{
    static void Main(string[] args)
    {
        Ordinateur ordi1 = new Ordinateur("Lenovo", "Thinkpad", new DateTime(2020, 5, 15), 15.6);
        ordi1.Allumer();
        ordi1.AfficherType();
        ordi1.AfficherGarantie();
        ordi1.AfficherInfos();
        Console.WriteLine(ordi1.ToString());
    }
}

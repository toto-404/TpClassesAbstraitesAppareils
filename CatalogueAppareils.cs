using System;
using System.Collections.Generic;

public class CatalogueAppareils
{
    private Dictionary<string, Appareil> appareils;

    public CatalogueAppareils()
    {
        appareils = new Dictionary<string, Appareil>();
    }

    public void AjouterAppareil(Appareil appareil)
    {
        if (appareil == null) return;
        string modele = appareil.Modele; // propriété publique attendue dans Appareil
        if (!appareils.ContainsKey(modele))
        {
            appareils.Add(modele, appareil);
        }
        else
        {
            // Optionnel : mettre à jour ou ignorer
            appareils[modele] = appareil;
        }
    }

    public void RechercherAppareil(string modele)
    {
        try
        {
            Appareil a = appareils[modele]; // peut lancer KeyNotFoundException
            a.AfficherInfos();
        }
        catch (Exception)
        {
            Console.WriteLine("Aucun appareil trouvé pour cette clé.");
        }
    }
}

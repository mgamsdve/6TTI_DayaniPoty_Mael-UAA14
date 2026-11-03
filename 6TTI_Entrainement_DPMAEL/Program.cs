namespace _6TTI_Entrainement_DPMAEL;

class Program
{
    static void Main(string[] args)
    {
        Entrainement[] entrainements = new Entrainement[3];
        entrainements[0] = new Entrainement("Mael Dayani Poty", 5, new TimeSpan(0, 25, 0));
        entrainements[1] = new Entrainement("Lucas Martin", 5, new TimeSpan(0, 30, 0));
        entrainements[2] = new Entrainement("Emma Laurent", 5, new TimeSpan(0, 22, 30));

        Console.WriteLine("Vitesses moyennes des participants :");
        foreach (Entrainement entrainement in entrainements)
        {
            Console.WriteLine("Nom : " + entrainement.Nom);
            Console.WriteLine("Distance : " + entrainement.LongueurParcours + " km");
            Console.WriteLine("Temps : " + entrainement.Temps);
            Console.WriteLine("Vitesse moyenne : " + Math.Round(entrainement.VitesseMoyenne(), 2) + " km/h");
            Console.WriteLine();
        }

        int meilleurTemps = 1200;
        Console.WriteLine("Meilleur temps sur les 5 km : " + meilleurTemps + " secondes (20 minutes)");
        foreach (Entrainement entrainement in entrainements)
        {
            TimeSpan ecart = entrainement.EcartParRapportAuMeilleur(meilleurTemps);
            Console.WriteLine(entrainement.Nom + " : " + ecart.TotalSeconds + " secondes de retard");
        }
    }
}

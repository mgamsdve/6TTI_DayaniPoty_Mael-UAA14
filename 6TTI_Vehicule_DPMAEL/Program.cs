namespace _6TTI_Vehicule_DPMAEL;

class Program
{
    static void Main(string[] args)
    {
        Vehicule[] garage = new Vehicule[2];
        garage[0] = new Vehicule("ABC123", "Toyota", "Corolla", 50, 10);
        garage[1] = new Vehicule("XYZ789", "Honda", "Civic", 45, 5);

        foreach (Vehicule vehicule in garage)
        {
            Console.WriteLine(vehicule.TypeVehicule());
            Console.WriteLine("Plaque : " + vehicule.Plaque);
            Console.WriteLine("Marque : " + vehicule.Marque);
            Console.WriteLine("Modèle : " + vehicule.Modele);
            Console.WriteLine("Capacité du réservoir : " + vehicule.CapaciteMaximumReservoir + " litres");
            Console.WriteLine("Carburant au départ : " + vehicule.NiveauJaugeCarburant + " litres");

            vehicule.AjouterCarburant(10);
            Console.WriteLine("Après l'ajout de 10 litres : " + vehicule.NiveauJaugeCarburant + " litres");

            vehicule.NiveauJaugeCarburant = vehicule.NiveauJaugeCarburant - 5;
            Console.WriteLine("Après avoir consommé 5 litres : " + vehicule.NiveauJaugeCarburant + " litres");

            vehicule.FaireLePlein();
            Console.WriteLine("Après le plein : " + vehicule.NiveauJaugeCarburant + " litres");
            Console.WriteLine();
        }

        Console.WriteLine("Tests des valeurs incorrectes sur le premier véhicule :");
        garage[0].AjouterCarburant(1);
        garage[0].AjouterCarburant(-5);
        garage[0].NiveauJaugeCarburant = -1;
        garage[0].NiveauJaugeCarburant = 100;
        Console.WriteLine("Le niveau reste à " + garage[0].NiveauJaugeCarburant + " litres.");
    }
}

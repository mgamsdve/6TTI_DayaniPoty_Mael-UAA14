using System.Text.RegularExpressions;

namespace _6TTI_DPMAEL_POO;

class Program
{
    static void Main(string[] args)
    {
        int nombreChiens;
        string nom;
        int age;
        string race;
        string couleur;
        int poids;
        
        Console.WriteLine("Bonjour, bienvenue dans le programme de gestion des chiens !");
        nombreChiens = LireEntier("Entrez le nombre de chiens que vous souhaitez créer :");
        GroupeChien groupe = new GroupeChien(nombreChiens);

        for (int iChien = 0; iChien < nombreChiens; iChien++)
        {
            Console.WriteLine($"Entrez le nom du chien {iChien + 1} :");
            nom = Console.ReadLine();
            
            age = LireEntier($"Entrez l'âge du chien {iChien + 1} :");
            
            Console.WriteLine($"Entrez la race du chien {iChien + 1} :");
            race = Console.ReadLine();

            Console.WriteLine($"Entrez la couleur du chien {iChien + 1} :");
            couleur = Console.ReadLine();

            poids = LireEntier($"Entrez le poids du chien {iChien + 1} :");
            
            Chien chien = new Chien(nom, age, race, couleur, poids);
            chien.AfficheCaracteristiques();
            groupe.AjouterChien(chien, iChien);
        }
    }
    
    static int LireEntier(string message)
    {
        int entier;
        do
        {
            Console.WriteLine(message);
        } while (!int.TryParse(Console.ReadLine(), out entier ));

        return entier;
    }
}

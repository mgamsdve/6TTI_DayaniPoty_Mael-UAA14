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
            
            Chien chien = new Chien(nom, age, race);
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
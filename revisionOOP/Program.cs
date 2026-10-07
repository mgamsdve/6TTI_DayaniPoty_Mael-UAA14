namespace revisionOOP;

class Program
{
    static void Main(string[] args)
    {
        Auteur auteur1 = new Auteur("Hugo", "Victor", new DateTime(1802, 2, 26));
        Livre livre1 = new Livre("Les Misérables", auteur1, 1232, false);
        Console.WriteLine(livre1.AfficheInfos());
        
        Livre livre2 = new Livre("Les Misérables 2", auteur1, 1232, false);
        Console.WriteLine(livre2.AfficheInfos());
        
        Auteur auteur2 = new Auteur("Maxime", "Baladi", new DateTime(1802, 2, 26));
        Livre livre3 = new Livre("Les Misérables 3", auteur2, 1232, false);
        Console.WriteLine(livre3.AfficheInfos());
    }
}
namespace _6TTI_DPMAEL_POO;

public class Chien
{
    private string _nom;
    private int _age;
    private string _race;
    private string _couleur;
    private int _poids;

    public Chien(string nom, int age, string race, string couleur, int poids)
    {
        _nom = nom;
        _age = age;
        _race = race;
        _couleur = couleur;
        _poids = poids;
    }
    
    public void AfficheCaracteristiques()
    {
        Console.WriteLine("Nom : " + _nom + " - Age : " + _age + " - Race : " + _race + " - Couleur : " + _couleur + " - Poids : " + _poids + " kg");
    }

    public void Aboyer()
    {
        Console.WriteLine(_nom + " aboie : Wouf wouf !");
    }

    public void Manger()
    {
        Console.WriteLine(_nom + " mange.");
    }

    public void Dormir()
    {
        Console.WriteLine(_nom + " dort.");
    }

    public void Vieillir()
    {
        _age = _age + 1;
    }
}

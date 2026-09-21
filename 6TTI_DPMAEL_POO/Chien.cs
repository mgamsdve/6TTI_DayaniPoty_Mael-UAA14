namespace _6TTI_DPMAEL_POO;

public class Chien
{
    private string _nom;
    private int _age;
    private string _race;

    public Chien(string nom, int age, string race)
    {
        _nom = nom;
        _age = age;
        _race = race;
    }
    
    public void AfficheCaracteristiques()
    {
        Console.WriteLine("Nom : " + _nom + " - Age : " + _age + " - Race : " + _race);
    }
}
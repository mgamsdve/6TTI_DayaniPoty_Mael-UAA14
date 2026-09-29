namespace _6TTI_DPMAEL_POO;

public class Chien
{
    private string _nom;
    private int _age;
    private string _race;
    private string _couleur;
    private int _poids;

    public string Nom
    {
        get
        {
            return _nom;
        }
    }

    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value >= 0)
            {
                _age = value;
            }
        }
    }

    public string Race
    {
        get
        {
            return _race;
        }
    }

    public string Couleur
    {
        get
        {
            return _couleur;
        }
    }

    public int Poids
    {
        get
        {
            return _poids;
        }
        set
        {
            if (value > 0)
            {
                _poids = value;
            }
        }
    }

    public Chien(string nom, int age, string race, string couleur, int poids)
    {
        _nom = nom;
        _age = age;
        _race = race;
        _couleur = couleur;
        _poids = poids;
    }

    public string AfficheCaracteristiques()
    {
        return "Nom : " + _nom + " - Age : " + _age + " - Race : " + _race + " - Couleur : " + _couleur + " - Poids : " + _poids + " kg";
    }

    public string Aboyer()
    {
        return _nom + " aboie : Wouf wouf !";
    }

    public string Manger()
    {
        return _nom + " mange.";
    }

    public string Dormir()
    {
        return _nom + " dort.";
    }

    public string Mourir()
    {
        return _nom + " est mort.";
    }
}

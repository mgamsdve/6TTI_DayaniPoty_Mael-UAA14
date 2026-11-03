namespace _6TTI_Entrainement_DPMAEL;

public class Entrainement
{
    private string _nom;
    private double _longueurParcours;
    private TimeSpan _temps;

    public string Nom
    {
        get
        {
            return _nom;
        }
    }

    public double LongueurParcours
    {
        get
        {
            return _longueurParcours;
        }
    }

    public TimeSpan Temps
    {
        get
        {
            return _temps;
        }
    }

    public Entrainement(string nom, double longueurParcours, TimeSpan temps)
    {
        _nom = nom;
        _longueurParcours = longueurParcours;
        _temps = temps;
    }

    public double VitesseMoyenne()
    {
        return _longueurParcours / _temps.TotalHours;
    }

    public TimeSpan EcartParRapportAuMeilleur(int meilleurTemps)
    {
        return _temps - TimeSpan.FromSeconds(meilleurTemps);
    }
}

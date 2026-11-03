namespace _6TTI_Vehicule_DPMAEL;

public class Vehicule
{
    private string _plaque;
    private string _marque;
    private string _modele;
    private int _capaciteMaximumReservoir;
    private double _niveauJaugeCarburant;

    public Vehicule(string plaque, string marque, string modele, int capaciteMaximumReservoir, double niveauJaugeCarburant)
    {
        _plaque = plaque;
        _marque = marque;
        _modele = modele;
        _capaciteMaximumReservoir = capaciteMaximumReservoir;
        _niveauJaugeCarburant = niveauJaugeCarburant;
    }

    public string Plaque
    {
        get { return _plaque; }
    }
    public string Marque
    {
        get { return _marque; }
    }

    public string Modele
    {
        get { return _modele; }
    }
    public int CapaciteMaximumReservoir
    {
        get { return _capaciteMaximumReservoir; }
    }
    public double NiveauJaugeCarburant
    {
        get { return _niveauJaugeCarburant; }
        set
        {
            if (value >= 0 && value <= _capaciteMaximumReservoir)
            {
                _niveauJaugeCarburant = value;
            }
        }
    }

    public string TypeVehicule()
    {
        return _marque + " " + _modele;
    }

    public void AjouterCarburant(double nombreLitre)
    {
        if (nombreLitre <= 0)
        {
            Console.WriteLine("La quantité de carburant doit être positive.");
        }
        else if (_niveauJaugeCarburant + nombreLitre > _capaciteMaximumReservoir)
        {
            Console.WriteLine("Impossible d'ajouter cette quantité : la capacité du réservoir serait dépassée.");
        }
        else
        {
            _niveauJaugeCarburant = _niveauJaugeCarburant + nombreLitre;
        }
    }

    public void FaireLePlein()
    {
        _niveauJaugeCarburant = _capaciteMaximumReservoir;
    }
}

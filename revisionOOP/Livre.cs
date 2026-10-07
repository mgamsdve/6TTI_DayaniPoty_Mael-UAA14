namespace revisionOOP;

public class Livre
{
    private string _titre;
    private Auteur _auteur;
    private int _nombrePages;
    private bool _estEmprunte;

    public Livre(string titre, Auteur auteur, int nombrePages, bool estEmprunte)
    {
        _titre = titre;
        _auteur = auteur;
        _nombrePages = nombrePages;
        _estEmprunte = estEmprunte;
    }

    public string Titre
    {
        get { return _titre; }
    }

    public Auteur Auteur
    {
        get {return _auteur; }
    }
    
    public int NombrePages
    {
        get { return _nombrePages; }
    }

    public bool EstEmprunte
    {
        get { return _estEmprunte; }
        set { _estEmprunte = value; }
    }

    public string AfficheInfos()
    {
        return $"Titre: {_titre} - Auteur: {_auteur.Nom} {_auteur.Prenom} - Pages: {_nombrePages} - Emprunté : {_estEmprunte}";
    }
}
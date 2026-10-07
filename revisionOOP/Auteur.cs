namespace revisionOOP;

public class Auteur
{
    private string _nom;
    private string _prenom;
    private DateTime _dateNaissance;

    public Auteur(string nom, string prenom, DateTime dateNaissance)
    {
        _nom = nom;
        _prenom = prenom;
        _dateNaissance = dateNaissance;
    }
    
    public string Nom
    {
        get { return _nom; }
    }
    public string Prenom
    {
        get { return _prenom; }
    }
}
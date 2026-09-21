namespace _6TTI_DPMAEL_POO;

public class GroupeChien
{
    private Chien[] _chiens;
    
    public GroupeChien(int nombreChiens)
    {
        _chiens = new Chien[nombreChiens];
    }
    
    public void AjouterChien(Chien chien, int iChien)
    {
        if (iChien >= 0 && iChien < _chiens.Length)
        {
            _chiens[iChien] = chien;
        }
        else
        {
            Console.WriteLine("Index hors limites.");
        }
    }
}
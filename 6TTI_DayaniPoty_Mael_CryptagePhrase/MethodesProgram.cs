namespace _6TTI_DayaniPoty_Mael_CryptagePhrase;

public static class MethodesProgram
{
    public static int LireEntier(string question)
    {
        int resultat;
        do
        {
            Console.WriteLine(question);
        }
        while (!int.TryParse(Console.ReadLine(), out resultat));

        return resultat;   
    }
    
    public static void preparerPhrase(ref string phrase)
    {
        phrase = phrase.ToUpper();
        phrase = phrase.Replace(" ", "");
    }

    public static bool PhraseValide(string phrase)
    {
        if (phrase.Length == 0)
        {
            return false;
        }

        for (int iLettre = 0; iLettre < phrase.Length; iLettre++)
        {
            if (phrase[iLettre] < 'A' || phrase[iLettre] > 'Z')
            {
                return false;
            }
        }

        return true;
    }


    public static void CryptVigenere(string phClaire, string phClef, out string[,] MatVigenere)
    {
        int codeAscii;
        int jLettreClef = 0;
        
        MatVigenere = new string[4, phClaire.Length];

        for (int iLettreClaire = 0; iLettreClaire <= phClaire.Length - 1; iLettreClaire++)
        {
            MatVigenere[0, iLettreClaire] = phClaire[iLettreClaire].ToString();
            MatVigenere[1, iLettreClaire] = phClef[jLettreClef].ToString();
            MatVigenere[2, iLettreClaire] = (((int)phClef[jLettreClef]) - 65).ToString();
            if ((int)phClaire[iLettreClaire] + int.Parse(MatVigenere[2, iLettreClaire]) <= 90)
            {
                codeAscii = (int)char.Parse(MatVigenere[0, iLettreClaire]) + int.Parse(MatVigenere[2, iLettreClaire]);
            }
            else
            {
                codeAscii = (int)char.Parse(MatVigenere[0, iLettreClaire]) + int.Parse(MatVigenere[2, iLettreClaire]) - 26;
            }
            MatVigenere[3, iLettreClaire] = Convert.ToChar(codeAscii).ToString();
            // La clé se répète lorsqu'elle est plus courte que la phrase.
            jLettreClef = (jLettreClef + 1) % phClef.Length;
        }
    }
    
    public static void CryptAffine(string phClaire, int a, int b, out string[,] MatAffine)
    {
        int x;
        int y;
        MatAffine = new string[4, phClaire.Length];

        for (int iLettreClaire = 0; iLettreClaire <= phClaire.Length - 1; iLettreClaire++)
        {
            MatAffine[0, iLettreClaire] = phClaire[iLettreClaire].ToString();
            x = (((int)phClaire[iLettreClaire]) - 65);
            MatAffine[1, iLettreClaire] = x.ToString();
            y = (a * x + b) % 26;
            MatAffine[2, iLettreClaire] = y.ToString();
            MatAffine[3, iLettreClaire] = Convert.ToChar(y + 65).ToString();
        }
    }
    
    public static string LireMatrice(string[,] matrice, int numLigne)
    {
        string contenu = "";

        if (numLigne != 0 && numLigne <= matrice.GetLength(0))
        {
            for (int iColonne = 0; iColonne < matrice.GetLength(1); iColonne++)
            {
                contenu += matrice[numLigne, iColonne];
            }

            contenu += "\n";
            
        }else{
            for (int iLigne = 0; iLigne < matrice.GetLength(0); iLigne++)
            {
                for (int iColonne = 0; iColonne < matrice.GetLength(1); iColonne++)
                {
                    contenu += matrice[iLigne, iColonne] + " ";
                }

                contenu += "\n";
            }
        }

        
        return contenu;
    }
    
    
    
}

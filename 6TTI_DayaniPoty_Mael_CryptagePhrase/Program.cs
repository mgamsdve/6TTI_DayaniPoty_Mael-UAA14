namespace _6TTI_DayaniPoty_Mael_CryptagePhrase;

class Program
{
    static void Main(string[] args)
    {
        string recommencer;
        int option;
        string phClaire;
        string phClef;
        string[,] MatCryptage;
        int a;
        int b;
        

        do
        {
            Console.WriteLine("CRYPTAGE");
            Console.WriteLine("========");
            
            do
            {
                option = MethodesProgram.LireEntier("Choisissez parmi les options suivantes\n" +
                                           "1 - Cryptage de Vigenère\n" +
                                           "2 - Cryptage avec la méthode affine");
            } while (option != 1 && option != 2);

            do
            {
                Console.WriteLine("Encodez la phrase à chypter !");
                phClaire = Console.ReadLine();
                MethodesProgram.preparerPhrase(ref phClaire);
            } while (!MethodesProgram.PhraseValide(phClaire) || (option == 1 && phClaire.Length < 3));

            if (option == 1)
            {
                do
                {
                    Console.WriteLine("Vous avez choisi la méthode de Vigenère !\n" +
                                      "=--\n" +
                                      "Encodez la clé à utiliser dans la méthode de Vigenère !");
                    phClef = Console.ReadLine();
                    MethodesProgram.preparerPhrase(ref phClef);
                    
                } while (!MethodesProgram.PhraseValide(phClef) || phClef.Length <= 1 || phClef.Length >= phClaire.Length);
                
                MethodesProgram.CryptVigenere(phClaire, phClef, out MatCryptage);
                Console.WriteLine("Voici la matrice de cryptage :\n");
                Console.WriteLine(MethodesProgram.LireMatrice(MatCryptage, 0));
                Console.WriteLine("Résultat du cryptage par la méthode de Vigenère\n");
                Console.WriteLine(MethodesProgram.LireMatrice(MatCryptage, 3));
                
            }
            else
            {
                Console.WriteLine("Vous avez choisi la méthode de cryptage affine !\n");

                do
                {
                    
                    a = MethodesProgram.LireEntier("Donnez la valeur du coefficient a (impair entre 1 et 25 sauf 13) :");
                    
                } while (a < 1 || a > 25 || a % 2 == 0 || a == 13);

                do
                {
                    b = MethodesProgram.LireEntier("Donnez la valeur du coefficient b (entre 0 et 25) :");
                } while (b < 0 || b > 25);

                MethodesProgram.CryptAffine(phClaire, a, b, out MatCryptage);
                Console.WriteLine("Voici la matrice de cryptage :\n");
                Console.WriteLine(MethodesProgram.LireMatrice(MatCryptage, 0));
                Console.WriteLine("Résultat du cryptage par la méthode affine\n");
                Console.WriteLine(MethodesProgram.LireMatrice(MatCryptage, 3));
            }
            
            
            Console.WriteLine("Un autre cryptage ? o = oui / autre = non");
            recommencer = Console.ReadLine();
        } while (recommencer == "o");
    }
}

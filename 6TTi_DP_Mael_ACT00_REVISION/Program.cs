
namespace _6TTi_DP_Mael_ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep;
            string infos;
            
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                //lecture des 3 côtés => A FAIRE
                c1 = MethodesSuppupp.LireDouble("Tapez la valeur du côté 1 : ");
                c2 = MethodesSuppupp.LireDouble("Tapez la valeur du côté 2 : "); 
                c3 = MethodesSuppupp.LireDouble("Tapez la valeur du côté 3 : ");
                
                // ordonner les côtés => APPEL ORDONNECOTES
                MethodesDuProjet.OrdonneCotes(ref c1, ref c2, ref c3);
                // série de test (voir consignes)
                if (MethodesDuProjet.Triangle(c1, c2, c3)) // si on a un triangle...
                {
                    // préparation et affichage du résultat du test 'triangle' avec la procédure 'Affiche'
                    MethodesDuProjet.PrepareAffichage(true, "triangle", out infos);
                    Console.WriteLine(infos);

                    // vérification équilatéral
                    if (MethodesDuProjet.Equi(c1, c2, c3))// si on a un triangle équilatéral...
                    {
                        // préparation et affichage du résultat du test 'equilateral' avec la procédure 'Affiche'
                        MethodesDuProjet.PrepareAffichage(true, "equilateral", out infos);
                        Console.WriteLine(infos);
                    }
                    else
                    {
                        // vérification triangle rectangle
                        if (MethodesDuProjet.TriangleRectangle(c1, c2, c3))// si on a un triangle rectangle...
                        {
                            // préparation et affichage du résultat positif du test 'rectangle' avec la procédure 'Affiche'
                            MethodesDuProjet.PrepareAffichage(true, "rectangle", out infos);
                            Console.WriteLine(infos);
                        }
                        else
                        {
                            // préparation et affichage du résultat négatif du test 'rectangle' avec la procédure 'Affiche'
                            MethodesDuProjet.PrepareAffichage(false, "rectangle", out infos);
                            Console.WriteLine(infos);
                        }
                        // vérification du cas isocèle et affichage dans le cas positif
                        MethodesDuProjet.Isocele(c1, c2, c3, out ok);
                        if (ok)
                        {
                            MethodesDuProjet.PrepareAffichage(true, "isocele", out infos);
                            Console.WriteLine(infos);
                        }
                        else
                        {
                            MethodesDuProjet.PrepareAffichage(false, "isocele", out infos);
                            Console.WriteLine(infos);

                        }
                    }
                }
                else // si ce n'est pas un triangle
                {
                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    MethodesDuProjet.PrepareAffichage(false, "triangle", out infos);
                    Console.WriteLine(infos);
                }
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
    }
}

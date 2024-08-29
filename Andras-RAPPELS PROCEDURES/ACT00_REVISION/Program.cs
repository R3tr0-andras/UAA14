using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciation de la structure
            MethodesDuProjet uwu = new MethodesDuProjet();

            // déclaration des variables
            string rep;

            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;
            string infos;
            string methode = "";

            Console.WriteLine("Testez les polygones !");

            //On recommence tant que désiré
            do
            {
                //lecture des 3 côtés
                c1 = lireDouble(1);
                c2 = lireDouble(2);
                c3 = lireDouble(3);

                // ordonner les côtés => APPEL ORDONNECOTES
                uwu.OrdonneCotes(ref c1, ref c2, ref c3);

                // série de test (voir consignes)
                if (uwu.Triangle(c1, c2, c3))
                {
                    // préparation et affichage du résultat du test 'triangle' avec la procédure 'Affiche'
                    uwu.Affiche(true, "triangle", out infos);
                    Console.WriteLine(infos);

                    // vérification équilatéral
                    if (uwu.Equi(c1, c2, c3))
                    {
                        // préparation et affichage du résultat du test 'equilateral' avec la procédure 'Affiche'
                        uwu.Affiche(true, "equilateral", out infos);
                        Console.WriteLine(infos);
                    }
                    else
                    {
                        // vérification triangle rectangle
                        if (uwu.TriangleRectangle(c1, c2, c3))
                        {
                            // préparation et affichage du résultat positif du test 'rectangle' avec la procédure 'Affiche'
                            uwu.Affiche(true, "rectangle", out infos);
                            Console.WriteLine(infos);
                        }
                        else
                        {
                            // vérification du cas isocèle et affichage dans le cas positif
                            if (uwu.Isocele(c1, c2, c3))
                            {
                                // préparation et affichage du résultat positif du test 'isocele' avec la procédure 'Affiche'
                                uwu.Affiche(true, "isocele", out infos);
                                Console.WriteLine(infos);
                            }

                        }
                    }
                }
                else // si ce n'est pas un triangle
                {
                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    uwu.Affiche(false , "triangle", out infos);
                    Console.WriteLine(infos);
                }

                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}

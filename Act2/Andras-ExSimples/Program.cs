using Andras_Ex1_Le_cercle;
using Andras_Ex2_nombreComplexe;
using Andras_Ex3_SandwishAleatoires;
using Andras_Ex4_Personne;

namespace Andras_ExSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = true;
            bool end2 = true;
            bool end3 = true;
            bool end4 = true;
            bool end5 = true;

            while (end5)
            {
                Console.Clear();

                Console.WriteLine("Sélectionnez un programme à exécuter :");
                Console.WriteLine("1 - Programme du Cercle");
                Console.WriteLine("2 - Programme d'affichage de nombre complexe");
                Console.WriteLine("3 - Programme de créations de sandwish");
                Console.WriteLine("4 - Programme de gestions financière");
                Console.WriteLine("5 - Arret du programme");
                Console.WriteLine("Entrez votre choix (1, 2, 3, 4, 5) :");

                string? choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        Console.Clear();

                        Console.WriteLine("Bienvenue dans notre gestionnaire de cercle !");
                        Console.WriteLine("---------------------------------------------");

                        while (end)
                        {
                            Console.WriteLine("Veillez entrer le rayon du cercle afin de calculer.");
                            float rayon = float.Parse(Console.ReadLine());

                            Circle cercle = new Circle(rayon);
                            Console.Write(cercle.InfoCercle());
                            cercle = null;

                            Console.Write("Voulez-vous recommencer ? (o/n) : ");
                            string reponse = Console.ReadLine().ToLower();

                            if (reponse != "o")
                            {
                                end = false;
                            }
                        }

                        break;

                    case "2":
                        Console.Clear();

                        Console.WriteLine("Bienvenue dans notre gestionnaire de nombres complexes !");
                        Console.WriteLine("------------------------------------------------------");

                        List<Bidulechouette> bidulechouettes = new List<Bidulechouette>(); 
                        
                        while (end2)
                        {

                            Console.WriteLine("\nQue souhaitez-vous faire ?");
                            Console.WriteLine("1. Ajouter un nouveau nombre complexe");
                            Console.WriteLine("2. Fusionner (merge) deux nombres complexes déjà enregistrés");
                            Console.WriteLine("3. Quitter");

                            string choixInitial = Console.ReadLine();

                            if (choixInitial == "1")
                            {
                                Console.WriteLine("Que vaut la partie réelle du complexe ?");
                                int r1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Que vaut la partie imaginaire du complexe ?");
                                int i1 = int.Parse(Console.ReadLine());

                                Bidulechouette nouveauComplexe = new Bidulechouette(r1, i1);
                                bidulechouettes.Add(nouveauComplexe);

                                Console.Clear();
                                Console.WriteLine($"Le nouveau complexe créé : ({r1}, {i1})");
                                Console.WriteLine("\nVoici le module du complexe après calcul :");
                                Console.WriteLine(nouveauComplexe.AfficherModule());
                            }
                            else if (choixInitial == "2")
                            {
                                if (bidulechouettes.Count < 2)
                                {
                                    Console.WriteLine("Il n'y a pas assez de nombres complexes pour les fusionner.");
                                    continue;
                                }

                                Console.WriteLine("Voici la liste des complexes déjà enregistrés :");
                                for (int i = 0; i < bidulechouettes.Count; i++)
                                {
                                    Console.WriteLine($"[{i}] Complexe : {bidulechouettes[i].AfficherComplexe()}, Module : {bidulechouettes[i].AfficherModule()}");
                                }

                                Console.WriteLine("Entrez l'indice du premier complexe à fusionner :");
                                int index1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Entrez l'indice du second complexe à fusionner :");
                                int index2 = int.Parse(Console.ReadLine());

                                if (index1 >= 0 && index1 < bidulechouettes.Count && index2 >= 0 && index2 < bidulechouettes.Count && index1 != index2)
                                {
                                    Bidulechouette somme = new Bidulechouette(0, 0);
                                    somme.Ajoute(bidulechouettes[index1]);
                                    somme.Ajoute(bidulechouettes[index2]);

                                    Console.WriteLine($"La somme des complexes est : {somme.AfficherComplexe()}");

                                    Console.WriteLine("Voulez-vous remplacer l'un des complexes par cette somme ? (oui/non)");
                                    string remplacer = Console.ReadLine();
                                    if (remplacer.ToLower() == "oui")
                                    {
                                        Console.WriteLine($"Remplacer lequel ? (0 pour {index1}, 1 pour {index2})");
                                        int choixRemplacement = int.Parse(Console.ReadLine());

                                        if (choixRemplacement == 0)
                                        {
                                            bidulechouettes[index1] = somme;
                                        }
                                        else if (choixRemplacement == 1)
                                        {
                                            bidulechouettes[index2] = somme;
                                        }

                                        Console.WriteLine("Le complexe a été remplacé.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Indices invalides ou identiques.");
                                }
                            }
                            else if (choixInitial == "3")
                            {
                                end2 = false;
                                Console.WriteLine("Au revoir !");
                            }
                            else
                            {
                                Console.WriteLine("Choix non reconnu, veuillez réessayer.");
                            }
                        }

                        break;


                    case "3":
                        Console.Clear();

                        Console.WriteLine("Bienvenue dans notre gestionnaire de sandwish !");
                        Console.WriteLine("-----------------------------------------------");

                        while (end3)
                        {
                            Console.Write("Combien de sandwiches voulez-vous créer ? ");
                            int nombreDeSandwiches;

                            while (!int.TryParse(Console.ReadLine(), out nombreDeSandwiches) || nombreDeSandwiches <= 0)
                            {
                                Console.WriteLine("Veuillez entrer un nombre valide supérieur à 0.");
                                Console.Write("Combien de sandwiches voulez-vous créer ? ");
                            }

                            SandwishMaker sandwishMaker = new SandwishMaker();

                            for (int i = 0; i < nombreDeSandwiches; i++)
                            {
                                string sandwishAleatoire = sandwishMaker.ComposerSandwish();
                                Console.WriteLine($"Sandwich {i + 1}: {sandwishAleatoire}");
                            }

                            Console.Write("Voulez-vous recommencer ? (o/n) : ");
                            string reponse = Console.ReadLine().ToLower();

                            if (reponse != "o")
                            {
                                end3 = false;
                            }
                        }

                        break;

                    case "4":
                        Console.Clear();

                        Console.WriteLine("Bienvenue dans notre gestionnaire de porte monnaie !");
                        Console.WriteLine("----------------------------------------------------");

                        while (end4)
                        {
                            Personne benoit = new Personne("Benoît", 100);
                            Personne beatrice = new Personne("Béatrice", 100);
                            bool block = true;
                            decimal montant;

                            while (block)
                            {
                                Console.WriteLine("Quel personne voulez vous controller ?");
                                Console.WriteLine($"1 - {benoit.Nom}");
                                Console.WriteLine($"2 - {beatrice.Nom}");
                                Console.WriteLine("3 - Quitter le programme");
                                Console.WriteLine("Entrez votre choix (1, 2, 3) :");

                                string? choix2 = Console.ReadLine();
                                Console.Clear();

                                if (choix2 != null && choix2 == "1")
                                {
                                    choix2 = null;
                                    Console.WriteLine($"{benoit.Nom} possède {benoit.Montant:C}");
                                    Console.WriteLine("Que voulez vous faire ?");
                                    Console.WriteLine($"1 - Ajouter");
                                    Console.WriteLine($"2 - Retirer");
                                    Console.WriteLine("3 - Transférer");
                                    Console.WriteLine("4 - Quitter");
                                    Console.WriteLine("Entrez votre choix (1, 2, 3) :");
                                    choix2 = Console.ReadLine();

                                    if (choix2 == "1")
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{benoit.Nom} possède {benoit.Montant:C}");
                                        Console.WriteLine($"{benoit.Nom} ajoute combien à son compte ?");
                                        montant = decimal.Parse(Console.ReadLine());
                                        if (montant <= 0)
                                        {
                                            Console.WriteLine($"{benoit.Nom} possède {benoit.Montant:C}");
                                            Console.WriteLine("Le montant à ajouter doit être positif.");
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            benoit.AjouterArgent(montant);
                                            Console.WriteLine($"{benoit.Nom} a ajouté {montant:C} dans son porte-monnaie.");
                                            Console.WriteLine($"{benoit.Nom} possède {benoit.Montant:C}");
                                        }

                                    }
                                    else if (choix2 == "2")
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{benoit.Nom} possède {benoit.Montant:C}");
                                        Console.WriteLine($"{benoit.Nom} retire combien de son compte ?");
                                        montant = decimal.Parse(Console.ReadLine());
                                        if (montant <= 0)
                                        {
                                            Console.WriteLine("Le montant à retirer doit être positif.");
                                        }
                                        if (benoit.Montant >= montant)
                                        {
                                            Console.Clear();
                                            benoit.Montant -= montant;
                                            Console.WriteLine($"{benoit.Nom} a retiré {montant:C} de son porte-monnaie.");
                                            Console.WriteLine($"{benoit.Nom} possède {benoit.Montant:C}");
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"{benoit.Nom} possède {benoit.Montant:C}");
                                            Console.WriteLine($"{benoit.Nom} n'a pas assez d'argent pour retirer {montant:C}.");
                                        }
                                    }
                                    else if (choix2 == "3")
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{benoit.Nom} possède {benoit.Montant:C}");
                                        Console.WriteLine($"{benoit.Nom} envoie combien à {beatrice.Nom} ?");

                                        if (decimal.TryParse(Console.ReadLine(), out montant))
                                        {
                                            Console.Clear();
                                            benoit.TransfererArgent(beatrice, montant);
                                            Console.WriteLine($"{benoit.Nom} a transféré {montant:C} à {beatrice.Nom}.");
                                        }
                                    }
                                    else if (choix2 == "4")
                                    {
                                        Console.WriteLine("Vous retournez en arrière !");
                                    }
                                }
                                else if (choix2 != null && choix2 == "2")
                                {
                                    choix2 = null;
                                    Console.WriteLine($"{beatrice.Nom} possède {beatrice.Montant:C}");
                                    Console.WriteLine("Que voulez vous faire ?");
                                    Console.WriteLine($"1 - Ajouter");
                                    Console.WriteLine($"2 - Retirer");
                                    Console.WriteLine("3 - Transférer");
                                    Console.WriteLine("4 - Quitter");
                                    Console.WriteLine("Entrez votre choix (1, 2, 3) :");
                                    choix2 = Console.ReadLine();


                                    if (choix2 == "1")
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{beatrice.Nom} possède {beatrice.Montant:C}");
                                        Console.WriteLine($"{beatrice.Nom} ajoute combien à son compte ?");
                                        montant = decimal.Parse(Console.ReadLine());
                                        if (montant <= 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Le montant à ajouter doit être positif.");
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            beatrice.AjouterArgent(montant);
                                            Console.WriteLine($"{beatrice.Nom} a ajouté {montant:C} dans son porte-monnaie.");
                                            Console.WriteLine($"{beatrice.Nom} possède {beatrice.Montant:C}");
                                        }

                                    }
                                    else if (choix2 == "2")
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"{beatrice.Nom} possède {beatrice.Montant:C}");
                                        Console.WriteLine($"{beatrice.Nom} retire combien de son compte ?");
                                        montant = decimal.Parse(Console.ReadLine());
                                        if (montant <= 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"{beatrice.Nom} possède {beatrice.Montant:C}");
                                            Console.WriteLine("Le montant à retirer doit être positif.");
                                        }
                                        if (beatrice.Montant >= montant)
                                        {
                                            Console.Clear();
                                            beatrice.Montant -= montant;
                                            Console.WriteLine($"{beatrice.Nom} a retiré {montant:C} de son porte-monnaie.");
                                            Console.WriteLine($"{beatrice.Nom} possède {beatrice.Montant:C}");
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"{beatrice.Nom} n'a pas assez d'argent pour retirer {montant:C}.");
                                        }
                                    }
                                    else if (choix2 == "3")
                                    {

                                        Console.WriteLine($"{beatrice.Nom} possède {beatrice.Montant:C}");
                                        Console.WriteLine($"{beatrice.Nom} envoie combien à {benoit.Nom} ?");

                                        if (decimal.TryParse(Console.ReadLine(), out montant))
                                        {
                                            Console.Clear();
                                            beatrice.TransfererArgent(benoit, montant);
                                            Console.WriteLine($"{beatrice.Nom} a transféré {montant:C} à {benoit.Nom}.");
                                            Console.WriteLine($"{beatrice.Nom} possède {beatrice.Montant:C}");
                                        }
                                    }
                                    else if (choix2 == "4")
                                    {
                                        Console.WriteLine("Vous retournez en arrière !");
                                    }

                                }
                                else if (choix2 != null && choix2 == "3")
                                {
                                    block = false;
                                }
                                else
                                {
                                    Console.WriteLine("Choix invalide recommencez \n");
                                }
                            }

                            Console.WriteLine("\n1 - Voulez-vous revenir aux choix des programmes ?");
                            Console.WriteLine("2 - Ou voulez-vous continuer ?");
                            Console.WriteLine("Entrez votre choix(1, 2) :");
                            string? reponse = Console.ReadLine();
                            if (reponse != "1")
                            {
                                end4 = false;
                            }

                            benoit = null;
                            beatrice = null;
                        }

                        break;

                    case "5":
                        Console.Clear();
                        end5 = false;
                        Console.WriteLine("Bye Bye Bye");


                        break;
                    default:
                        Console.WriteLine("Choix non valide. \n");

                        break;
                }
            }
        }
    }
}
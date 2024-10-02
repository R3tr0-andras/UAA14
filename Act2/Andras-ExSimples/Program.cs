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
                Console.WriteLine("Entrez votre choix (1, 2, 3, 4) :");

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

                        Console.WriteLine("Bienvenue dans notre gestionnaire de nombre complexe !");
                        Console.WriteLine("------------------------------------------------------");

                        List<Bidulechouette> bidulechouettes = new List<Bidulechouette>();

                        while (end2)
                        {
                            if (bidulechouettes.Count != 0)
                            {
                                Console.WriteLine("Voici la liste des complexes déjà enregistré");
                                foreach (Bidulechouette element in bidulechouettes)
                                {
                                    Console.WriteLine($"C : {element.AfficherComplexe()}, M : {element.AfficherModule()}");
                                }
                            } else
                            {
                                Console.WriteLine("Bienvenue dans ce programme sur les complexes !");
                            }

                            Console.WriteLine("Que vaut la partie réelle du complexe de départ ?");
                            int r1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Que vaut la partie imaginaire du complexe de départ ?");
                            int i1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Que vaut la partie réelle du second complexe ?");

                            Console.Clear();
                            Console.WriteLine($"Le premier complexe : ({r1}, {i1})");

                            Console.WriteLine("\n" + "Voici le module 1 après calcul");
                            Bidulechouette bidule = new Bidulechouette(r1, i1);
                            bidulechouettes.Add(bidule);
                            Console.WriteLine(bidule.AfficherModule());

                            Console.WriteLine("\n" + "Voulez vous utiliser un autre complex ?");
                            string? choixContinuerInput = Console.ReadLine();

                            if (choixContinuerInput != null)
                            {
                                choixContinuerInput = choixContinuerInput.ToLower();
                                if (choixContinuerInput == "non")
                                {
                                    end2 = false;
                                }
                                else if (choixContinuerInput == "oui")
                                {
                                    Console.Clear();
                                    bidule = null;
                                }
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

                            Console.WriteLine("\nInitialisation des porte-monnaie:");
                            Console.WriteLine($"{benoit.Nom} a {benoit.Montant:C}.");
                            Console.WriteLine($"{beatrice.Nom} a {beatrice.Montant:C}.");

                            benoit.TransfererArgent(beatrice, 30);
                            Console.WriteLine($"{benoit.Nom} a maintenant {benoit.Montant:C}.");
                            Console.WriteLine($"{beatrice.Nom} a maintenant {beatrice.Montant:C}.");

                            beatrice.TransfererArgent(benoit, 100);
                            Console.WriteLine($"{beatrice.Nom} a maintenant {beatrice.Montant:C}.");
                            Console.WriteLine($"{benoit.Nom} a maintenant {benoit.Montant:C}.");

                            Console.WriteLine("\nVoulez-vous recommencer ? (o/n)");
                            string? reponse = Console.ReadLine();
                            if (reponse.ToLower() != "o")
                            {
                                end4 = false;
                            }

                            benoit = null;
                            beatrice = null;
                        }

                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Bye Bye Bye");

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Choix non valide. \n");

                        break;
                }
            }
        }
    }
}
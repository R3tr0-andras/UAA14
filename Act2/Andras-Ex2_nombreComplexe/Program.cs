namespace Andras_Ex2_nombreComplexe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bidulechouette> bidulechouettes = new List<Bidulechouette>();
            bool end = true;

            while (end)
            {
                if (bidulechouettes.Count != 0)
                {
                    Console.WriteLine("Voici la liste des complexes déjà enregistré");
                    foreach(Bidulechouette element in bidulechouettes)
                    {
                        Console.WriteLine($"C : {element.AfficherComplexe()}, M : {element.AfficherModule()}");
                    }
                }

                Console.WriteLine("Bienvenue dans ce programme sur les complexes !");

                Console.WriteLine("Que vaut la partie réelle du complexe de départ ?");
                int r1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Que vaut la partie imaginaire du complexe de départ ?");
                int i1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Que vaut la partie réelle du second complexe ?");

                Console.Clear();
                Console.WriteLine($"Le premier complexe : ({r1}, {i1})");

                Console.WriteLine("\n" + "Voici le module 1 après calcul");
                Bidulechouette bidule = new Bidulechouette(r1,i1);
                bidulechouettes.Add(bidule);
                Console.WriteLine(bidule.AfficherModule());

                Console.WriteLine("\n" + "Voulez vous utiliser un autre complex ?");
                string? choixContinuerInput = Console.ReadLine();

                if (choixContinuerInput != null)
                {
                    choixContinuerInput = choixContinuerInput.ToLower();
                    if (choixContinuerInput == "non")
                    {
                        end = false;
                    }
                    else if (choixContinuerInput == "oui")
                    {
                        Console.Clear();
                        bidule = null;
                    }
                }
            }
        }
    }
}
namespace I5_6TTIUAA14_Andras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Welcome to the armory");

            Fusil[] armurerie = new Fusil[20];
            for (int i = 0; i < armurerie.Length; i++)
            {
                armurerie[i] = new Fusil();
            }
            Joueur Moi = new Joueur("Andras", armurerie[alea()]);
            


            while (true)
            {
                Console.WriteLine("Vous avez une arme, que voulez vous faire ?");
                Console.WriteLine("1. Tirer");
                Console.WriteLine("2. Recharger");
                Console.WriteLine("3. Vérifier vos poches");
                Console.WriteLine("4. Reprendre des balles");
                Console.WriteLine("");

                int choix = int.Parse(Console.ReadLine());

                if (choix == 1)
                {
                    Console.WriteLine(Moi.Tirer());
                    
                } else if (choix == 2)
                {
                    Console.WriteLine(Moi.Recharger());
                    
                } else if (choix == 3)
                {
                    Console.WriteLine(Moi.VerifierPoches());
                    
                } else if (choix == 4)
                {
                    Console.WriteLine(Moi.Reprendre());
                    
                }
            }

        }
        static int alea()
        {
            Random alea = new Random();
            return alea.Next(1, 20);
        }
    }
}
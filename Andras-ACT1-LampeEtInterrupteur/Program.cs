namespace Andras_ACT1_LampeEtInterrupteur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = true;
            List<Lampe> lampes = new List<Lampe>();
            List<Interrupteur> interrupteurs = new List<Interrupteur>();
            int temp = 0;
            string input = "";

            while (end)
            {
                Console.WriteLine("Ajouter une Lampe\n");
                Console.WriteLine("Quel couleur ?");
                string couleur = Console.ReadLine();
                Console.WriteLine("La lampe possède une ampoule ?");
                Console.WriteLine("Veuillez entrer 'true' ou 'false' :");
                input = Console.ReadLine();
                bool aUneAmpoule;
                bool.TryParse(input, out aUneAmpoule);
                Console.WriteLine("La lampe possède une ampoule ?");
                Console.WriteLine("Veuillez entrer 'true' ou 'false' :");
                input = Console.ReadLine();
                bool aUneAmpoule;
                bool.TryParse(input, out aUneAmpoule);

                Console.WriteLine("Voulez-vous continuer ? (Oui/Non)");
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
                    }
                }
            }
        }
    }
}
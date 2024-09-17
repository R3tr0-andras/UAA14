using System.Diagnostics;

namespace Andras_ACT1_LampeEtInterrupteur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = true;
            List<Lampe> luminaires = new List<Lampe>();
            List<Interrupteur> buttons = new List<Interrupteur>();
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


                Random res = new Random();
                String str = "abcdefghijklmnopqrstuvwxyz";
                int size = 10;
                String ran = "";

                for (int i = 0; i < size; i++)
                {
                    int x = res.Next(26);
                    ran = ran + str[x];
                }

                string idalea = "L" + ran;

                Lampe lampe = new Lampe(couleur, aUneAmpoule, true, false, idalea);
                luminaires.Add(lampe);

                Interrupteur interrupteur = new Interrupteur(false, idalea);
                buttons.Add(interrupteur);

                lampe = null;
                interrupteur = null;

                Console.WriteLine("\nListe des chiens enregistrés :");
                foreach (Lampe luminaire in luminaires)
                {
                    Console.WriteLine($"- {luminaire.IdLampe}, " +
                    $" couleur : {luminaire.CouleurHexa}, " +
                    $" ampoule : {luminaire.AUneAmpoule}, " +
                    $" allumée : {luminaire.EstAllume}, " +
                    $" chargée : {luminaire.ADuCourrant}");
                }

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
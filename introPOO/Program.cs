namespace introPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = true;
            //pour cree plusieurs chien
            List<Chien> chiens = new List<Chien>();

            while (end)
            {
                bool puce;
                Console.WriteLine("Quel age à le chien ?");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Quel taille à le chien ?");
                double taille = double.Parse(Console.ReadLine());

                Console.WriteLine("Quel poid à le chien ?");
                double poid = double.Parse(Console.ReadLine());

                Console.WriteLine("Quel race à le chien ?");
                string race = Console.ReadLine();

                Console.WriteLine("Quel etat à le chien ?");
                string etat = Console.ReadLine();

                Console.WriteLine("Est-il pucee ? (y/n)");

                string pucee = Console.ReadLine();
                if (pucee == "y")
                {
                    puce = true;
                }
                else
                {
                    puce = false;
                }

                Chien dog = new Chien(age, race, taille, poid, etat, puce);
                chiens.Add(dog);
                dog = null;

                Console.WriteLine("\nListe des chiens enregistrés :");
                foreach (Chien chien in chiens)
                {
                    Console.WriteLine($"- {chien.Age} ans, {chien.Race}, {chien.Taille} cm, {chien.Poids} kg, état: {chien.Etat}, pucé: {(chien.Puce ? "Oui" : "Non")}");
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
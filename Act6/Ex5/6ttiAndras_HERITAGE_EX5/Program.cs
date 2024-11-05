namespace _6ttiAndras_HERITAGE_EX5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Vehicule> vehicules = new List<Vehicule>();

            while (true)
            {
                Console.Write("Voulez-vous créer un nouveau véhicule ? (o/n) : ");
                if (Console.ReadLine().ToLower() != "o")
                    break;

                Vehicule vehicule = CreerVehicule();
                if (vehicule != null)
                    vehicules.Add(vehicule);
            }

            Console.WriteLine("\nInformations sur les véhicules :");
            foreach (var vehicule in vehicules)
            {
                Console.WriteLine(vehicule.AfficherInfo());
            }
        }
        static Vehicule CreerVehicule()
        {
            Console.Write("Entrez le type de véhicule (Voiture/Camion/Bateau/Avion) : ");
            string typeVehicule = Console.ReadLine().ToLower();

            Console.Write("Entrez la marque : ");
            string marque = Console.ReadLine();

            Console.Write("Entrez le niveau de carburant : ");
            double carburant = double.Parse(Console.ReadLine());

            switch (typeVehicule)
            {
                case "voiture":
                    Console.Write("Entrez le kilométrage : ");
                    double km = double.Parse(Console.ReadLine());
                    return new Voiture(marque, carburant, km);

                case "camion":
                    Console.Write("Entrez le kilométrage : ");
                    km = double.Parse(Console.ReadLine());
                    Console.Write("Entrez le poids maximum : ");
                    double poids = double.Parse(Console.ReadLine());
                    return new Camion(marque, carburant, km, poids);

                case "bateau":
                    Console.Write("Entrez le tonnage : ");
                    double tonnage = double.Parse(Console.ReadLine());
                    return new Bateau(marque, carburant, tonnage);

                case "avion":
                    Console.Write("Entrez la portée maximale : ");
                    double portee = double.Parse(Console.ReadLine());
                    return new Avion(marque, carburant, portee);

                default:
                    Console.WriteLine("Type de véhicule invalide");
                    return null;
            }
        }

    }
}

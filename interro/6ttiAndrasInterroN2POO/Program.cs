namespace _6ttiAndrasInterroN2POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Set up
            TraficLight one = new TraficLight("007", false, '0');
            TraficLight two = new TraficLight("1001", false, '0');
            TraficLight[] traficLights = new TraficLight[2];
            traficLights[0] = one;
            traficLights[1] = two;
            

            //Porgramme principale
            Console.WriteLine("Etat et couleurs des feux : ");
            Console.WriteLine("---------------------------------");
            for (int i = 0;i < 2; i++) // fait passer du rouge au vert
            {
                traficLights[0].ChangeColor();
                traficLights[1].ChangeColor();
            }
            Console.WriteLine($"Le feu de signalisation 1001 est vert et éteint");
            Console.WriteLine($"Le feu de signalisation 007 est vert et éteint");
            Console.WriteLine("\n");
            Console.WriteLine("Faire passer le 007 à l'orange :");
            Console.WriteLine("---------------------------------");
            traficLights[0].ChangeColor(); // passe du rouge au oarange
            traficLights[0].TurnOnOrOff(); // Allume le feu
            Console.WriteLine("Le feu de signalisation 007 est Orange et allumé");
            Console.WriteLine("\n");
            Console.WriteLine("Feu clignotant");
            Console.WriteLine("---------------------------------");
            int nbAlternance = 6 ; // on le fait clignoter 6fois dans l'énoncé
            for (int i = 0; i < nbAlternance; i++)
            {
                traficLights[0].WinkLight();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Changement d'état : ");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < 5; i++)
            {
                traficLights[1].ChangeColor();
            }
            Console.WriteLine("Le feu de signalisation 1001 est rouge");
            Console.WriteLine("Le feu de signalisation 1001 est orange");
            Console.WriteLine("Le feu de signalisation 1001 est vert");
            Console.WriteLine("Le feu de signalisation 1001 est rouge");
            Console.WriteLine("Le feu de signalisation 1001 est orange");
        }
    }
}
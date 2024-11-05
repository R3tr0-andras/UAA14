namespace _6ttiAndras_HERITAGE_EX4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directeur.ChiffreAffaires = 1000000;

            List<Employe> employes = new List<Employe>
        {
            new Ouvrier("O1", "Dupont", "Jean", new DateTime(1980, 5, 15), new DateTime(2010, 1, 1)),
            new Ouvrier("O2", "Martin", "Sophie", new DateTime(1985, 8, 22), new DateTime(2015, 3, 1)),
            new Ouvrier("O3", "Lefevre", "Pierre", new DateTime(1975, 11, 30), new DateTime(2005, 6, 1)),
            new Ouvrier("O4", "Dubois", "Marie", new DateTime(1990, 2, 10), new DateTime(2018, 9, 1)),
            new Ouvrier("O5", "Moreau", "Luc", new DateTime(1982, 7, 5), new DateTime(2012, 4, 1)),
            new Cadre("C1", "Rousseau", "Claire", new DateTime(1978, 9, 18), 2),
            new Cadre("C2", "Girard", "Thomas", new DateTime(1983, 4, 25), 3),
            new Cadre("C3", "Roux", "Emilie", new DateTime(1976, 12, 8), 4),
            new Directeur("D1", "Lambert", "Philippe", new DateTime(1970, 3, 12), 5),
            new Directeur("D2", "Bernard", "Nathalie", new DateTime(1972, 6, 20), 6)
        };

            foreach (var employe in employes)
            {
                employe.AfficherCaracteristiques();
                Console.WriteLine();
            }
        }
    }
}
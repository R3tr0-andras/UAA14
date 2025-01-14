namespace _6tti_andras_reflectionClasseLiees_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Biblio
            Bibliotheque bibliotheque = new Bibliotheque();

            // Livres
            Livre a = new Livre("a", "a", 5);
            Console.WriteLine(a.description());
            Livre b = new Livre("b", "b", 4);
            Console.WriteLine(b.description());
            Livre c = new Livre("c", "c", 3);
            Console.WriteLine(c.description());
            Livre d = new Livre("d", "d", 2);
            Console.WriteLine(d.description());
            Livre e = new Livre("e", "e", 1);
            Console.WriteLine(e.description());
            Livre f = new Livre("f", "f", 0);
            Console.WriteLine(f.description());

            //degarde
            a.degrade(4);
            Console.WriteLine(a.description());

            // Ajout
            bibliotheque.ajoute(a);
            bibliotheque.ajoute(b);
            bibliotheque.ajoute(c);
            bibliotheque.ajoute(d);
            bibliotheque.ajoute(e);
            bibliotheque.ajoute(f);

            // inventaire
            Console.WriteLine(bibliotheque.inventaire());

            // Supprime
            bibliotheque.supprime();
            Console.WriteLine(bibliotheque.inventaire());
        }
    }
}
namespace Andras_Ex2_nombreComplexe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dnas ce programme sur les complexes !");
            Console.WriteLine("Que vaut la partie réelle du complexe de départ ?");
            int r1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Que vaut la partie imaginaire du complexe de départ ?");
            int i1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Que vaut la partie réelle du second complexe ?");


            Console.Clear();
            Console.WriteLine($"Le premier complexe : ({r1}, {i1})");

            int r2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Que vaut la partie imaginaire du second complexe ?");
            int i2 = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Le premier complexe : ({r2}, {r2})");

        }
    }
}
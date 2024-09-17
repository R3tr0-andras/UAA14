namespace Andras_Ex1_Le_cercle
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Veillez entrer le rayon du cercle afin de calculer.");
            float rayon = float.Parse(Console.ReadLine());

            Circle cercle = new Circle(rayon);
            Console.Write(cercle.InfoCercle());
            cercle = null;
        }
    }
}
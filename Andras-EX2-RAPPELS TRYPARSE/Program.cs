namespace tryparseRAPPELS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Space Name = new Space();
            bool end = true;
            byte choix = 0;
            bool t = false;
            while (end)
            {
                Console.WriteLine("Veuillez choisir ce que vous souhaitez faire :");
                Console.WriteLine("1 : utiliser le tryParse");
                Console.WriteLine("2 : personnaliser l'écran");
                

                choix = byte.Parse(Console.ReadLine());

                if (choix == 1) 
                {
                    Console.WriteLine("Merci de mettre un nombre divisible par 2");
                    double value = Name.First();
                } 
                else if (choix == 2) 
                { 
                    Name.Second();
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
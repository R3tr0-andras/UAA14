using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andras_ACT1_LampeEtInterrupteur
{
    public struct Structure
    {
        public void AjouterLampe(List<Lampe> luminaires, List<Interrupteur> buttons)
        {
            Console.WriteLine("Ajouter une Lampe\n");
            Console.WriteLine("Quelle couleur ?");
            string couleur = Console.ReadLine();
            Console.WriteLine("La lampe possède une ampoule ?");
            Console.WriteLine("Veuillez entrer 'true' ou 'false' :");
            string input = Console.ReadLine();
            bool aUneAmpoule;
            bool.TryParse(input, out aUneAmpoule);

            string idalea = "L" + Aleatoire();

            Lampe lampe = new Lampe(idalea, aUneAmpoule, true, false, couleur);
            luminaires.Add(lampe);

            Interrupteur interrupteur = new Interrupteur(false, idalea, lampe);
            buttons.Add(interrupteur);
        }
        public void AfficherLampes(List<Lampe> luminaires)
        {
            Console.WriteLine("\nListe des lampes enregistrées :");
            foreach (Lampe luminaire in luminaires)
            {
                Console.WriteLine(luminaire.InfoLampe());
            }
        }
        public void AfficherInterrupteurs(List<Interrupteur> buttons)
        {
            Console.WriteLine("\nListe des interrupteurs :");
            foreach (Interrupteur bouton in buttons)
            {
                Console.WriteLine($"Interrupteur pour lampe ID : {bouton.IdLampe}, État : {(bouton.EstEnclenche ? "Enclenché" : "Éteint")}");
            }
        }
        public void UtiliserInterrupteur(List<Interrupteur> buttons)
        {
            Console.WriteLine("Entrez l'ID de la lampe pour laquelle vous souhaitez basculer l'interrupteur :");
            string idLampe = Console.ReadLine();

            Interrupteur interrupteur = buttons.FirstOrDefault(b => b.IdLampe == idLampe);
            if (interrupteur != null)
            {
                bool nouvelEtat = interrupteur.Basculer();
                Console.WriteLine($"Interrupteur pour lampe ID : {idLampe} est maintenant {(nouvelEtat ? "Enclenché" : "Éteint")}");
                Console.WriteLine($"État de la lampe après basculement : {interrupteur.Lampe.InfoLampe()}");
            }
            else
            {
                Console.WriteLine("ID de lampe invalide.");
            }
        }
        public string Aleatoire()
        {
            Random res = new Random();
            String str = "abcdefghijklmnopqrstuvwxyz";
            int size = 10;
            String ran = "";
            for (int i = 0; i < size; i++)
            {
                int x = res.Next(26);
                ran = ran + str[x];
            }
            return ran;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE_POO_JUIN25_Andras6tti.Humanity;

namespace CE_POO_JUIN25_Andras6tti
{
    internal class Pool
    {
        private int _id;
        private List<Tireur> _tireurs;
        private List<Arbitre> _arbitres;
        private List<Match> _matchs;

        public int Id { get { return _id; } }
        public List<Tireur> Tireurs { get { return _tireurs; } }
        public List<Arbitre> Arbitres { get { return _arbitres; } }
        public List<Match> Matchs { get { return _matchs; } }

        public Pool(int id, List<Tireur> tireurs, List<Arbitre> arbitres, List<Match> matchs)
        {
            _id = id;
            _tireurs = tireurs ?? new List<Tireur>();
            _arbitres = arbitres ?? new List<Arbitre>();
            _matchs = matchs ?? new List<Match>();
        }

        public int CherchePlaceDansList(int id)
        {
            for (int i = 0; i < _tireurs.Count; i++)
            {
                if (_tireurs[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Terminee()
        {
            foreach (Match match in _matchs)
            {
                if (match.Status != "END")
                {
                    return false;
                }
            }
            return true;
        }

        public void CalculePerformancesParTireur()
        {
            foreach (Tireur tireur in _tireurs)
            {
                tireur.Performances.TD = 0;
                tireur.Performances.TR = 0;
                tireur.Performances.NBVIC = 0;
            }

            foreach (Match match in _matchs)
            {
                if (match.Status == "END")
                {
                    match.Tireur1.Performances.TD += match.TouchesTireur1;
                    match.Tireur1.Performances.TR += match.TouchesTireur2;

                    match.Tireur2.Performances.TD += match.TouchesTireur2;
                    match.Tireur2.Performances.TR += match.TouchesTireur1;

                    if (match.TouchesTireur1 > match.TouchesTireur2)
                    {
                        match.Tireur1.Performances.NBVIC++;
                    }
                    else if (match.TouchesTireur2 > match.TouchesTireur1)
                    {
                        match.Tireur2.Performances.NBVIC++;
                    }
                }
            }
        }

        public string AfficherParticipantsPool()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Tireurs");
            result.AppendLine("-------------");
            foreach (Tireur tireur in _tireurs)
            {
                result.AppendLine(tireur.AfficheInfos());
                result.AppendLine();
            }

            result.AppendLine("Arbitres");
            result.AppendLine("-------------");
            foreach (Arbitre arbitre in _arbitres)
            {
                result.AppendLine(arbitre.AfficheInfos());
                result.AppendLine();
            }

            return result.ToString();
        }

        public string AfficherRecapitulatifCompletMatchs()
        {
            StringBuilder result = new StringBuilder();

            foreach (Match match in _matchs)
            {
                result.AppendLine($"Match Id = {match.Id}");
                result.AppendLine(match.AfficheInfos());
                result.AppendLine();
            }

            return result.ToString();
        }

        public string AfficherPerformancesTireurs()
        {
            StringBuilder result = new StringBuilder();

            foreach (Tireur tireur in _tireurs)
            {
                result.AppendLine(tireur.AfficheInfos());
                result.AppendLine($"Performances: TD={tireur.Performances.TD}, TR={tireur.Performances.TR}, Victoires={tireur.Performances.NBVIC}");
                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CE_POO_JUIN25_Andras6tti.Humanity;

namespace CE_POO_JUIN25_Andras6tti
{
    internal class Program
    {
        private static ElementsFournis db = new ElementsFournis();

        static void Main(string[] args)
        {
            bool continuer = true;

            Console.WriteLine("=== Programme de gestion de pools (à ne pas confondre avec une poule) ===\n");

            while (continuer)
            {
                try
                {
                    Pool pool = ChoisirEtCreerPool();
                    if (pool == null)
                    {
                        Console.WriteLine("Erreur lors de la création de la pool (Merci de contacter l'assistance technique).");
                        continue;
                    }
                    Console.WriteLine($"\n=== POOL #{pool.Id} ===\n");

                    Console.WriteLine("LISTE DES PARTICIPANTS (tireur et arbitre):");
                    Console.WriteLine(new string('=', 50));
                    Console.WriteLine(pool.AfficherParticipantsPool());

                    Console.WriteLine("RESULTATS DETAILLES DES MATCHS:");
                    Console.WriteLine(new string('=', 50));
                    Console.WriteLine(pool.AfficherRecapitulatifCompletMatchs());

                    Console.WriteLine("CALCUL DES PERFORMANCES");
                    pool.CalculePerformancesParTireur();

                    Console.WriteLine("PERFORMANCES DES TIREURS:");
                    Console.WriteLine(new string('=', 50));

                    bool poolComplete = pool.Terminee();
                    if (poolComplete)
                    {
                        Console.WriteLine("POOL COMPLETE \n");
                    }
                    else
                    {
                        Console.WriteLine("RESULTATS PARTIELS \n");
                    }

                    Console.WriteLine(pool.AfficherPerformancesTireurs());

                    if (poolComplete && DemanderSauvegarde())
                    {
                        SauvegarderPerformances(pool);
                    }

                    continuer = DemanderContinuer();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erreur: {ex.Message}");
                    Console.WriteLine("Voulez-vous continuer? (o/n)");
                    continuer = Console.ReadLine()?.ToLower() == "o";
                }
            }

            Console.WriteLine("\nMerci d'avoir utilisé ce truc, je ne sais pas honnêtement si ça va servir");
            Console.WriteLine("Appuyez sur une touche pour partir d'ici");
            Console.ReadKey();
        }

        /// <summary>
        /// Partie static, parce que je n'ai pas su faire de structure :/
        /// </summary>
        private static Pool ChoisirEtCreerPool()
        {
            Console.WriteLine("SELECTION DE LA POOL:");
            Console.WriteLine(new string('=', 50));
            Console.Write("Entrez l'id de la pool: ");

            if (!int.TryParse(Console.ReadLine(), out int poolId))
            {
                Console.WriteLine("Id invalide");
                return null;
            }

            List<Tireur> tireurs = ChargerTireurs(poolId);
            if (tireurs.Count == 0)
            {
                Console.WriteLine($"Aucun tireur trouve pour la pool : {poolId}");
                return null;
            }

            List<Arbitre> arbitres = ChargerArbitres(poolId);
            if (arbitres.Count == 0)
            {
                Console.WriteLine($"Aucun arbitre trouve pour la pool : {poolId}");
                return null;
            }

            List<Match> matchs = ChargerMatchs(poolId, tireurs, arbitres);

            return new Pool(poolId, tireurs, arbitres, matchs);
        }
        
        private static List<Tireur> ChargerTireurs(int poolId)
        {
            List<Tireur> tireurs = new List<Tireur>();

            string query = $"SELECT * FROM Escrimeur WHERE escrimeurId IN (SELECT escrimeurId FROM participationPool WHERE poolId = {poolId});";

            if (db.ExtraitInfosSelonRequete(query, out DataSet ds))
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int id = Convert.ToInt32(row["escrimeurId"]);
                    string nom = row["escrimeurNom"].ToString();
                    string prenom = row["escrimeurPrenom"].ToString();

                    Performance perf = new Performance();
                    Tireur tireur = new Tireur(perf, id, nom, prenom);
                    tireurs.Add(tireur);
                }
            }

            Console.WriteLine($"Chargé {tireurs.Count} tireur(s)");
            return tireurs;
        }
        
        private static List<Arbitre> ChargerArbitres(int poolId)
        {
            List<Arbitre> arbitres = new List<Arbitre>();

            string query = $"SELECT * FROM Escrimeur WHERE escrimeurId IN (SELECT DISTINCT arbitreId FROM Matchs WHERE poolId = {poolId});";

            if (db.ExtraitInfosSelonRequete(query, out DataSet ds))
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int id = Convert.ToInt32(row["escrimeurId"]);
                    string nom = row["escrimeurNom"].ToString();
                    string prenom = row["escrimeurPrenom"].ToString();

                    Arbitre arbitre = new Arbitre(id, nom, prenom);
                    arbitres.Add(arbitre);
                }
            }

            Console.WriteLine($"{arbitres.Count} arbitres");
            return arbitres;
        }
       
        private static List<Match> ChargerMatchs(int poolId, List<Tireur> tireurs, List<Arbitre> arbitres)
        {
            List<Match> matchs = new List<Match>();

            string query = $"SELECT Matchs.matchId, matchTouchesTireur1, matchTouchesTireur2, arbitreId, StatutId, tireurId1, tireurId2 FROM participationmatch INNER JOIN Matchs ON participationmatch.matchId = Matchs.matchId WHERE poolId = {poolId};";

            if (db.ExtraitInfosSelonRequete(query, out DataSet ds))
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int matchId = Convert.ToInt32(row["matchId"]);
                    int touchesTireur1 = Convert.ToInt32(row["matchTouchesTireur1"]);
                    int touchesTireur2 = Convert.ToInt32(row["matchTouchesTireur2"]);
                    int arbitreId = Convert.ToInt32(row["arbitreId"]);
                    int statutId = Convert.ToInt32(row["StatutId"]);
                    int tireurId1 = Convert.ToInt32(row["tireurId1"]);
                    int tireurId2 = Convert.ToInt32(row["tireurId2"]);

                    string statut = ObtenirStatut(statutId);

                    Tireur tireur1 = tireurs.FirstOrDefault(t => t.Id == tireurId1);
                    Tireur tireur2 = tireurs.FirstOrDefault(t => t.Id == tireurId2);
                    Arbitre arbitre = arbitres.FirstOrDefault(a => a.Id == arbitreId);

                    if (tireur1 != null && tireur2 != null && arbitre != null)
                    {
                        Match match = new Match(matchId, statut, tireur1, touchesTireur1, tireur2, touchesTireur2, arbitre);
                        matchs.Add(match);
                    }
                    else
                    {
                        Console.WriteLine($"Match {matchId} ignoré car le tireur ou l'arbitre  est introuvable");
                    }
                }
            }

            Console.WriteLine($"{matchs.Count} matchS");
            return matchs;
        }
       
        private static string ObtenirStatut(int statutId)
        {
            string query = $"SELECT statutInfo FROM Statut WHERE statutId = {statutId};";

            if (db.ExtraitInfosSelonRequete(query, out DataSet ds))
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0].Rows[0]["statutInfo"].ToString();
                }
            }

            return "erreur, le status est inconu";
        }
        
        private static bool DemanderSauvegarde()
        {
            Console.WriteLine("SAUVEGARDE DES PERFORMANCES:");
            Console.WriteLine(new string('=', 50));
            Console.Write("Voulez-vous sauvegarder les performances en base de données? (o/n): ");

            return Console.ReadLine()?.ToLower() == "o";
        }

        /// <summary>
        /// Pour une obscure raison ça ne veut pas faire d'insert
        /// Bien évidemment ce n'est pas ma faute vu que je suis incroyable
        /// Donc je pense que c'est cassé :/
        /// C'était du second degré biensur
        /// </summary>
        private static void SauvegarderPerformances(Pool pool)
        {
            Console.WriteLine("Sauvegarde des performances");

            try
            {
                foreach (Tireur tireur in pool.Tireurs)
                {
                    string query = $"INSERT INTO Performance (poolId, escrimeurId, perfTouchesDonnees, perfTouchesRecues, perfNbVictoires) " +
                                  $"VALUES ({pool.Id}, {tireur.Id}, {tireur.Performances.TD}, {tireur.Performances.TR}, {tireur.Performances.NBVIC}) " +
                                  $"ON DUPLICATE KEY UPDATE " +
                                  $"perfTouchesDonnees = {tireur.Performances.TD}, " +
                                  $"perfTouchesRecues = {tireur.Performances.TR}, " +
                                  $"perfNbVictoires = {tireur.Performances.NBVIC};";


                    if (db.ExtraitInfosSelonRequete(query, out DataSet _))
                    {
                        Console.WriteLine($"Performance sauvegardée pour {tireur.Nom} {tireur.Prenom}");
                    }
                    else
                    {
                        Console.WriteLine($"Erreur lors de la sauvegarde pour {tireur.Nom} {tireur.Prenom}");
                    }
                }

                Console.WriteLine("Toutes les performances ont été sauvegardes avec succes");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la sauvegarde: {ex.Message}");
            }
        }
       
        private static bool DemanderContinuer()
        {
            Console.WriteLine("\nCONTINUER");
            Console.WriteLine(new string('=', 50));
            Console.Write("Voulez vous traiter une autre pool ??? (o/n): ");

            return Console.ReadLine()?.ToLower() == "o";
        }
    }
}
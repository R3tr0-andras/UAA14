using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _6ttiAndrasBDDCsEX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;
            while (continuer)
            {
                ControllerDeChoix();

                Console.WriteLine("\nVoulez-vous relancer le programme ? (O/N)");
                string reponse = Console.ReadLine().Trim().ToUpper();

                if (reponse != "O" && reponse != "OUI")
                {
                    continuer = false;
                }
            }

            Console.WriteLine("Merci d'avoir utilisé le programme. Au revoir !");
        }

        /// <summary>
        /// Définit la chaîne de connexion à la base de données.
        /// </summary>
        /// <returns>Une chaîne de connexion valide vers la base de données.</returns>
        private static string DefinirCheminBD()
        {
            return "server=10.10.51.98;database=andras;port=3306;User Id=andras;password=root";
        }

        /// <summary>
        /// Liste les biens à partir de la table spécifiée.
        /// </summary>
        /// <param name="nomDeTable">Nom de la table à interroger.</param>
        /// <returns>Une liste de chaînes contenant les détails des biens.</returns>
        public static List<string> ListBiens(string nomDeTable)
        {
            List<string> list = new List<string>();
            try
            {
                using (MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD()))
                {
                    maConnexion.Open();
                    string query = $"SELECT * FROM {nomDeTable};";

                    using (MySqlCommand cmd = new MySqlCommand(query, maConnexion))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string temp = $"{reader[0]} {reader[1]} {reader[2]} {reader[3]} {reader[4]} {reader[5]}";
                            list.Add(temp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Erreur MySQL : {ex.Message}");
                throw;
            }
            return list;
        }

        /// <summary>
        /// Ajoute un bien dans la base de données.
        /// </summary>
        /// <param name="nom">Nom du bien.</param>
        /// <param name="taille">Taille en m².</param>
        /// <param name="prix">Prix en euros.</param>
        /// <param name="ville">Localité du bien.</param>
        /// <param name="userId">Identifiant de l'utilisateur.</param>
        /// <param name="description">Description du bien.</param>
        /// <param name="chambres">Nombre de chambres.</param>
        public static void AddBiens(string nom, int taille, int prix, string ville, int userId, string description, int chambres)
        {
            try
            {
                using (MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD()))
                {
                    maConnexion.Open();
                    string query = @"INSERT INTO biens (nom, taille, prix, ville, userId, description, chambres)
                                     VALUES (@nom, @taille, @prix, @ville, @userId, @description, @chambres)";

                    using (MySqlCommand commande = new MySqlCommand(query, maConnexion))
                    {
                        commande.Parameters.AddWithValue("@nom", nom);
                        commande.Parameters.AddWithValue("@taille", taille);
                        commande.Parameters.AddWithValue("@prix", prix);
                        commande.Parameters.AddWithValue("@ville", ville);
                        commande.Parameters.AddWithValue("@userId", userId);
                        commande.Parameters.AddWithValue("@description", description);
                        commande.Parameters.AddWithValue("@chambres", chambres);

                        if (commande.ExecuteNonQuery() > 0)
                        {
                            Console.WriteLine("Ajout effectué avec succès.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine($"Erreur MySQL : {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Met à jour un bien existant dans la base de données.
        /// </summary>
        /// <param name="bienId">Identifiant du bien à mettre à jour.</param>
        /// <param name="nom">Nom mis à jour.</param>
        /// <param name="taille">Taille mise à jour.</param>
        /// <param name="prix">Prix mis à jour.</param>
        /// <param name="ville">Localité mise à jour.</param>
        /// <param name="description">Description mise à jour.</param>
        /// <param name="chambres">Nombre de chambres mises à jour.</param>
        public static void UpdateBien(int bienId, string nom, int taille, int prix, string ville, string description, int chambres)
        {
            try
            {
                using (MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD()))
                {
                    string query = @"UPDATE biens 
                                     SET nom=@nom, taille=@taille, prix=@prix, ville=@ville, description=@description, chambres=@chambres 
                                     WHERE bienId=@bienId;";

                    using (MySqlCommand commande = new MySqlCommand(query, maConnexion))
                    {
                        maConnexion.Open();
                        commande.Parameters.AddWithValue("@bienId", bienId);
                        commande.Parameters.AddWithValue("@nom", nom);
                        commande.Parameters.AddWithValue("@taille", taille);
                        commande.Parameters.AddWithValue("@prix", prix);
                        commande.Parameters.AddWithValue("@ville", ville);
                        commande.Parameters.AddWithValue("@description", description);
                        commande.Parameters.AddWithValue("@chambres", chambres);

                        if (commande.ExecuteNonQuery() > 0)
                        {
                            Console.WriteLine("Modification effectuée avec succès.");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Erreur MySQL : {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Supprime un bien de la base de données.
        /// </summary>
        /// <param name="bienId">Identifiant du bien à supprimer.</param>
        public static void RemoveBien(int bienId)
        {
            try
            {
                using (MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD()))
                {
                    string query = "DELETE FROM biens WHERE bienId=@bienId;";
                    using (MySqlCommand removeCommand = new MySqlCommand(query, maConnexion))
                    {
                        removeCommand.Parameters.AddWithValue("@bienId", bienId);
                        maConnexion.Open();

                        if (removeCommand.ExecuteNonQuery() > 0)
                        {
                            Console.WriteLine("Suppression effectuée avec succès.");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Erreur MySQL : {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Gère le choix de l'utilisateur pour les opérations CRUD.
        /// </summary>
        public static void ControllerDeChoix()
        {
            Console.WriteLine("Que voulez-vous faire ?");
            Console.WriteLine("1. Liste des biens");
            Console.WriteLine("2. Ajouter un bien");
            Console.WriteLine("3. Modifier un bien");
            Console.WriteLine("4. Supprimer un bien");

            byte choix;
            while (true)
            {
                if (byte.TryParse(Console.ReadLine(), out choix) && choix >= 1 && choix <= 4)
                    break;

                Console.WriteLine("Recommencez svp...");
            }

            switch (choix)
            {
                case 1:
                    List<string> list = ListBiens("biens");
                    foreach (string bien in list)
                    {
                        Console.WriteLine(bien);
                    }
                    Console.WriteLine();
                    break;

                case 2:
                    Console.Write("Nom : ");
                    string nom = Console.ReadLine();

                    Console.Write("Taille : ");
                    int taille = int.Parse(Console.ReadLine());

                    Console.Write("Prix : ");
                    int prix = int.Parse(Console.ReadLine());

                    Console.Write("Localité : ");
                    string ville = Console.ReadLine();

                    Console.Write("Description : ");
                    string description = Console.ReadLine();

                    Console.Write("Chambre(s) : ");
                    int chambres = int.Parse(Console.ReadLine());

                    AddBiens(nom, taille, prix, ville, 1, description, chambres);
                    break;

                case 3:
                    Console.Write("Entrez l'ID du bien à modifier : ");
                    int bienId = int.Parse(Console.ReadLine());

                    Console.Write("Nom : ");
                    nom = Console.ReadLine();

                    Console.Write("Taille : ");
                    taille = int.Parse(Console.ReadLine());

                    Console.Write("Prix : ");
                    prix = int.Parse(Console.ReadLine());

                    Console.Write("Localité : ");
                    ville = Console.ReadLine();

                    Console.Write("Description : ");
                    description = Console.ReadLine();

                    Console.Write("Chambre(s) : ");
                    chambres = int.Parse(Console.ReadLine());

                    UpdateBien(bienId, nom, taille, prix, ville, description, chambres);
                    break;

                case 4:
                    Console.Write("Entrez l'ID du bien à supprimer : ");
                    bienId = int.Parse(Console.ReadLine());
                    RemoveBien(bienId);
                    break;

                default:
                    break;
            }
        }
    }
}

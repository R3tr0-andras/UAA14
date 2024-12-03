using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace _6ttiAndrasBDDCsEX1
{
    internal class Program
    {
        //public MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list = ListBiens("utilisateurs");
            foreach (var liste in list) 
            { 
                Console.WriteLine(liste);
            }
            Console.WriteLine("\n");

        }

        static string DefinirCheminBD() // détermine la chaîne de connexion
        {
            return "server=10.10.51.98;database=andras;port=3306;User Id=andras;password=root";
        }

        // Liste les biens
        public static List<string> ListBiens(string nomDeTable)
        {
            List<string> list = new List<string>();
            try
            {
                using (MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD()))
                {
                    maConnexion.Open();

                    string query = "SELECT * FROM " + nomDeTable + ";";

                    using (MySqlCommand cmd = new MySqlCommand(query, maConnexion))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        string temp;
                        while (reader.Read())
                        {
                            temp = reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString()
                                + " " + reader[3].ToString() + " " + reader[4].ToString() + " " + reader[5].ToString();
                            
                            list.Add(temp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return list;
        }
    }
}
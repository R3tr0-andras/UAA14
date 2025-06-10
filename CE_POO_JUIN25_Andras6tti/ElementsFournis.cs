using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_POO_JUIN25_Andras6tti
{
    internal class ElementsFournis
    {
        public string DefinirCheminBD()
        {
            // note à moi meme, la porchaine fois vérifier le ptn de port au lieu de rester bloqué dessus pdt 20min ^^
            return "server=localhost;database=escrime;port=3306;User Id=root;password=root";
        }
        public bool ExtraitInfosSelonRequete(string query, out DataSet infos)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            try
            {
                maConnection.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnection);
                infos = new DataSet();
                da.Fill(infos);

                if (infos.Tables[0].Rows.Count >= 1)
                {
                    ok = true;
                }
                maConnection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }

            return ok;
        }

        // "SELECT * FROM Escrimeur where escrimeurId in (SELECT escrimeurId FROM participationPool WHERE poolId= ...);"

        // "SELECT * FROM Escrimeur WHERE escrimeurId in (SELECT DISTINCT arbitreId FROM Matchs WHERE poolId= ...);"

        // "SELECT Matchs.matchId, matchTouchesTireur1, matchTouchesTireur2, arbitreId, StatutId, tireurId1, tireurId2 FROM participationmatch INNER JOIN Matchs ON participationmatch.matchId = Matchs.matchId WHERE poolId= ...;"

        // "SELECT * FROM Escrimeur WHERE escrimeurId= ...;"

        // "SELECT statutInfo FROM Statut WHERE statutId= ...;"

        // pour rappel, exemple usage dataset : (int)dataSetInfos.Tables[0].Rows[iEnregistrement]["escrimeurId"]
        // ou encore infoStatut.Tables[0].Rows[0]["statutInfo"].ToString()

        // bon travail... Merci ^^

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE_POO_JUIN25_Andras6tti.Humanity;

namespace CE_POO_JUIN25_Andras6tti
{
    internal class Match
    {
        private int _id;
        private string _status;
        // tireur 1
        private Tireur _tireurOne;
        private int _touchesTireurOne;
        // tireur 2
        private Tireur _tireurTwo;
        private int _touchesTireurTwo;
        // arbitre
        private Arbitre _arbitre;

        public int Id { get { return _id; } }
        public string Status { get { return _status; } set { _status = value; } }
        public Tireur Tireur1 { get { return _tireurOne; } }
        public Tireur Tireur2 { get { return _tireurTwo; } }
        public Arbitre Arbitre { get { return _arbitre; } }
        public int TouchesTireur1 { get { return _touchesTireurOne; } set { _touchesTireurOne = value; } }
        public int TouchesTireur2 { get { return _touchesTireurTwo; } set { _touchesTireurTwo = value; } }

        public Match(int id, string status, Tireur tireurOne, int touchesTireurOne, Tireur tireurTwo, int touchesTireurTwo, Arbitre arbitre)
        {
            _id = id;
            _status = status;
            _tireurOne = tireurOne;
            _touchesTireurOne = touchesTireurOne;
            _tireurTwo = tireurTwo;
            _touchesTireurTwo = touchesTireurTwo;
            _arbitre = arbitre;
        }

        public string AfficheInfos()
        {
            return $"ID = {_id}\n" +
                   $"Status = {_status}\n" +
                   $"Tireur 1 = {_tireurOne.Name}\n" +
                   $"Touches Tireur 1 = {_touchesTireurOne}\n" +
                   $"Tireur 2 = {_tireurTwo.Name}\n" +
                   $"Touches Tireur 2 = {_touchesTireurTwo}\n" +
                   $"Arbitre = {_arbitre.Name}";
        }
    }
}
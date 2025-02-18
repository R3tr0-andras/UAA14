using System;

namespace _6tti_andras_ClassesLieesEtHeritage
{
    internal class Room
    {
        private string _number; // Numéro de la salle
        private int _place; // Nombre de places dans la salle
        private Lesson _lesson; // Leçon donnée dans la salle

        public string Number => _number;
        public int Place => _place;
        public Lesson Lesson => _lesson;

        public Room(string number, int place, Lesson lesson)
        {
            _number = number;
            _place = place;
            _lesson = lesson;
        }
    }
}

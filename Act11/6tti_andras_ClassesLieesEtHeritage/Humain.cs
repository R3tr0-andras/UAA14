using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _6tti_andras_ClassesLieesEtHeritage
{
    public abstract class Humain
    {
        protected string _name; //Nom 
        protected string _fName; //Prénom
        protected int _phone; //Numéro de téléphone
        protected DateTime _date; //Date d'entrée dans l'écolde
        public string Name { get { return _name; } }
        public string FName { get { return _fName; } }
        public int Phone { get { return _phone; } set { _phone = value; } }
        public DateTime Date { get { return _date; } }
        public Humain(string name, string fName, DateTime date)
        {
            _name = name;
            _fName = fName;
            _phone = Phone;
            _date = date;
        }
        public abstract string PrintProfil();
    }

    class Teacher : Humain
    {
        private Matter _matter; //Matière enseignée par le prof
        private List<Lesson> _lessons; //Les lessons enseignée par le prof en fonction de sa matière
        public Matter Matterr { get { return _matter; } set { _matter = value; } }

        public Teacher(string name, string fName, DateTime date) : base(name, fName, date) 
        {
            _matter = Matterr;
            _lessons = new List<Lesson>();
        }
        public override string PrintProfil()
        {
            return $"Professeur : {_name} {_fName}," +
                $"\nDate d'arrivée : {_date}," +
                $"\nNuméro de téléphone : {_phone}" +
                $"\nEnseigne : {_matter}";
        }
        //partie qui n'est pas demandée donc pas dans L'UML
        public void AddLesson(Lesson lesson)
        {
            _lessons.Add(lesson);
        }
        public void RemoveLesson(int index)
        {
            _lessons.RemoveAt(index);
        }
        public void AfficherLessons()
        {
            foreach (Lesson lesson in _lessons) 
            {
                Console.WriteLine($"{lesson}\n");
            }
        }
    }

    class Student : Humain
    {
        private int _generalAverage; //Moyenne générale
        public Dictionary<Matter, int> _lessonAndNote; //Matière|moyenne

        public int GeneralAverage { get { return _generalAverage; } set { _generalAverage = value; } }

        public Student(int generalAverage, Dictionary<Matter, int> lessonAndNote, string name, string fName, DateTime date) 
            : base(name, fName, date)
        {
            _generalAverage = 0;
            _lessonAndNote = lessonAndNote;
            CalculateAverage();
        }
        public override string PrintProfil()
        {
            return $"Elève : {_name} {_fName}," +
                $"\nDate d'arrivée : {_date}," +
                $"\nNuméro de téléphone : {_phone}" +
                $"\nMoyenne générale : {_generalAverage}";
        }
        public void CalculateAverage()
        {
            if (_lessonAndNote.Count > 0)
            {
                GeneralAverage = (int)_lessonAndNote.Values.Average();
            }
            else
            {
                GeneralAverage = 0;
            }
        }
        public void ShowAllNotes()
        {

        }
    }
}

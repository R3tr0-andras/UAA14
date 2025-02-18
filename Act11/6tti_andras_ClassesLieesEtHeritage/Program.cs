using System;
using System.Collections.Generic;
using System.Linq;

namespace _6tti_andras_ClassesLieesEtHeritage
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static List<Teacher> teachers = new List<Teacher>();
        static List<Matter> matters = new List<Matter>();
        static List<Lesson> lessons = new List<Lesson>();
        static List<Room> rooms = new List<Room>();
        static List<Department> departments = new List<Department>();

        static void Main(string[] args)
        {
            bool continuer = true;
            while (continuer)
            {
                Console.Clear();
                Console.WriteLine("=== Gestion de l'école ===");
                Console.WriteLine("1. Ajouter un étudiant");
                Console.WriteLine("2. Supprimer un étudiant");
                Console.WriteLine("3. Modifier un étudiant");
                Console.WriteLine("4. Ajouter un professeur");
                Console.WriteLine("5. Supprimer un professeur");
                Console.WriteLine("6. Ajouter une matière");
                Console.WriteLine("7. Ajouter une leçon");
                Console.WriteLine("8. Ajouter une salle");
                Console.WriteLine("9. Ajouter un département");
                Console.WriteLine("10. Afficher les étudiants");
                Console.WriteLine("11. Afficher les professeurs");
                Console.WriteLine("12. Afficher les départements");
                Console.WriteLine("13. Quitter");

                Console.Write("\nChoix : ");
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1": AddStudent(); break;
                    case "2": RemoveStudent(); break;
                    case "3": ModifyStudent(); break;
                    case "4": AddTeacher(); break;
                    case "5": RemoveTeacher(); break;
                    case "6": AddMatter(); break;
                    case "7": AddLesson(); break;
                    case "8": AddRoom(); break;
                    case "9": AddDepartment(); break;
                    case "10": ShowStudents(); break;
                    case "11": ShowTeachers(); break;
                    case "12": ShowDepartments(); break;
                    case "13": continuer = false; break;
                    default: Console.WriteLine("Choix invalide !"); break;
                }

                if (continuer)
                {
                    Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                    Console.ReadKey();
                }
            }
        }
        static void AddStudent()
        {
            Console.Write("Nom : ");
            string name = Console.ReadLine();
            Console.Write("Prénom : ");
            string fName = Console.ReadLine();
            Console.Write("Moyenne générale : ");
            int generalAverage = int.Parse(Console.ReadLine()); // Ajout de la moyenne
            DateTime date = DateTime.Now;

            students.Add(new Student(generalAverage, new Dictionary<Matter, int>(), name, fName, date));

            Console.WriteLine("Étudiant ajouté !");
        }
        static void AddTeacher()
        {
            Console.Write("Nom : ");
            string name = Console.ReadLine();
            Console.Write("Prénom : ");
            string fName = Console.ReadLine();
            teachers.Add(new Teacher(name, fName, DateTime.Now));
            Console.WriteLine("Professeur ajouté !");
        }
        static void AddMatter()
        {
            Console.Write("Nom de la matière : ");
            string name = Console.ReadLine();
            matters.Add(new Matter(name));
            Console.WriteLine("Matière ajoutée !");
        }
        static void AddLesson()
        {
            Console.Write("Nom de la leçon : ");
            string name = Console.ReadLine();
            lessons.Add(new Lesson(name));
            Console.WriteLine("Leçon ajoutée !");
        }
        static void AddRoom()
        {
            Console.Write("Numéro de salle : ");
            string number = Console.ReadLine();
            Console.Write("Nombre de places : ");
            int place = int.Parse(Console.ReadLine());
            rooms.Add(new Room(number, place, new Lesson("Inconnue")));
            Console.WriteLine("Salle ajoutée !");
        }
        static void AddDepartment()
        {
            Console.Write("Nom du département : ");
            string name = Console.ReadLine();
            departments.Add(new Department(name, new List<Teacher>()));
            Console.WriteLine("Département ajouté !");
        }
        static void RemoveStudent()
        {
            ShowStudents();
            Console.Write("\nNuméro de l'étudiant à supprimer : ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < students.Count)
            {
                students.RemoveAt(index);
                Console.WriteLine("Étudiant supprimé !");
            }
            else
            {
                Console.WriteLine("Index invalide !");
            }
        }
        static void RemoveTeacher()
        {
            ShowTeachers();
            Console.Write("\nNuméro du professeur à supprimer : ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < teachers.Count)
            {
                teachers.RemoveAt(index);
                Console.WriteLine("Professeur supprimé !");
            }
            else
            {
                Console.WriteLine("Index invalide !");
            }
        }
        static void ModifyStudent()
        {
            ShowStudents();
            Console.Write("\nNuméro de l'étudiant à modifier : ");

            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= students.Count)
            {
                index--; // Ajustement pour correspondre à l’index de la liste

                Console.Write("Nouveau prénom : ");
                string newFName = Console.ReadLine();

                // Garder les anciennes données de l'étudiant
                int oldGeneralAverage = students[index].GeneralAverage;
                Dictionary<Matter, int> oldLessonAndNote = students[index]._lessonAndNote; // Ajoute un getter si nécessaire

                students[index] = new Student(oldGeneralAverage, oldLessonAndNote, students[index].Name, newFName, DateTime.Now);

                Console.WriteLine("Étudiant modifié !");
            }
            else
            {
                Console.WriteLine("Index invalide !");
            }
        }

        static void ShowStudents()
        {
            Console.WriteLine("\n--- Étudiants ---");
            if (students.Count == 0) { Console.WriteLine("Aucun étudiant."); return; }
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i].PrintProfil()}");
            }
        }
        static void ShowTeachers()
        {
            Console.WriteLine("\n--- Professeurs ---");
            if (teachers.Count == 0) { Console.WriteLine("Aucun professeur."); return; }
            for (int i = 0; i < teachers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {teachers[i].PrintProfil()}");
            }
        }
        static void ShowDepartments()
        {
            Console.WriteLine("\n--- Départements ---");
            if (departments.Count == 0) { Console.WriteLine("Aucun département."); return; }
            foreach (var dept in departments)
            {
                Console.WriteLine($"Département : {dept.Name}");
            }
        }
    }
}

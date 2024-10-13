using System;
using System.Collections.Generic;

public enum RoomType
{
    Normal,
    Boss,
    Treasure,
    Puzzle,
    Spawn
}

public class Floor
{
    public int FloorNumber { get; set; }
    public DungeonRoom[,] RoomGrid { get; set; }
    public int Rows { get; set; }
    public int Cols { get; set; }

    public Floor(int floorNumber, int rows, int cols, int roomCount)
    {
        FloorNumber = floorNumber;
        Rows = rows;
        Cols = cols;
        RoomGrid = new DungeonRoom[rows, cols];
        GenerateRooms(roomCount);
    }

    private void GenerateRooms(int roomCount)
    {
        int centerRow = Rows / 2;
        int centerCol = Cols / 2;
        RoomGrid[centerRow, centerCol] = new DungeonRoom(10, 10, RoomType.Spawn);  

        Random rand = new Random();
        Queue<(int, int)> queue = new Queue<(int, int)>();
        queue.Enqueue((centerRow, centerCol));
        int placedRooms = 1;

        while (placedRooms < roomCount && queue.Count > 0)
        {
            (int currentRow, int currentCol) = queue.Dequeue();


            List<(int, int)> directions = new List<(int, int)>
            {
                (-1, 0), 
                (1, 0),  
                (0, -1), 
                (0, 1)   
            };


            Shuffle(directions, rand);

            foreach (var (dRow, dCol) in directions)
            {
                int newRow = currentRow + dRow;
                int newCol = currentCol + dCol;

                if (newRow >= 0 && newRow < Rows && newCol >= 0 && newCol < Cols && RoomGrid[newRow, newCol] == null)
                {
                    RoomType roomType = (RoomType)rand.Next(0, Enum.GetValues(typeof(RoomType)).Length - 1); // Exclut spawn
                    RoomGrid[newRow, newCol] = new DungeonRoom(rand.Next(8, 15), rand.Next(8, 15), roomType);
                    queue.Enqueue((newRow, newCol));
                    placedRooms++;

                    if (placedRooms >= roomCount) break;
                }
            }
        }
    }

    private void Shuffle<T>(List<T> list, Random rand)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }

    public void DisplayFloorMatrix()
    {
        Console.WriteLine($"=== Étage {FloorNumber} ===");

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                if (RoomGrid[i, j] != null)
                {
               
                    switch (RoomGrid[i, j].Type)
                    {
                        case RoomType.Spawn:
                            Console.ForegroundColor = ConsoleColor.Green; 
                            Console.Write(" S ");
                            break;
                        case RoomType.Normal:
                            Console.ForegroundColor = ConsoleColor.Red; 
                            Console.Write(" N ");
                            break;
                        case RoomType.Boss:
                            Console.ForegroundColor = ConsoleColor.Yellow; 
                            Console.Write(" B ");
                            break;
                        case RoomType.Treasure:
                            Console.ForegroundColor = ConsoleColor.Cyan; 
                            Console.Write(" T ");
                            break;
                        case RoomType.Puzzle:
                            Console.ForegroundColor = ConsoleColor.Blue; 
                            Console.Write(" P ");
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray; 
                    Console.Write(" . ");
                }
            }
            Console.WriteLine();
        }

        Console.ResetColor(); 
    }

    public void DisplayLegend()
    {
        Console.WriteLine("\n=== Légende des pièces ===");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" S : Salle de spawn (point de départ)");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" N : Salle de combat (normale)");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" B : Salle de boss");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" T : Salle de trésor");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(" P : Salle d'énigme");

        Console.ResetColor(); 
        Console.WriteLine(" . : Espace vide (pas de salle)");
    }
}

public class DungeonRoom
{
    public int Width { get; set; }
    public int Height { get; set; }
    public RoomType Type { get; set; }
    public List<string> Monsters { get; set; }
    public List<string> Treasures { get; set; }

    public DungeonRoom(int width, int height, RoomType type)
    {
        Width = width;
        Height = height;
        Type = type;
        Monsters = new List<string>();
        Treasures = new List<string>();

        Random rand = new Random();
        int monsterCount = rand.Next(0, 4); 
        int treasureCount = rand.Next(0, 2); 

        for (int i = 0; i < monsterCount; i++)
        {
            Monsters.Add($"Monstre {i + 1}");
        }

        for (int i = 0; i < treasureCount; i++)
        {
            Treasures.Add($"Trésor {i + 1}");
        }
    }
}

class Dungeon
{
    public List<Floor> Floors { get; set; }

    public Dungeon(int floorCount)
    {
        Floors = new List<Floor>();
        Random rand = new Random();

        for (int i = 0; i < floorCount; i++)
        {
            int rows = rand.Next(5, 8); 
            int cols = rand.Next(5, 8); 
            int roomCount = rand.Next(5, Math.Min(rows * cols, 10)); 

            Floor floor = new Floor(i + 1, rows, cols, roomCount);
            Floors.Add(floor);
        }
    }

    public void DisplayDungeonMatrix()
    {
        foreach (var floor in Floors)
        {
            floor.DisplayFloorMatrix();
            floor.DisplayLegend(); 
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entrez le nombre d'étages pour le donjon : ");
        int floorCount;
        while (!int.TryParse(Console.ReadLine(), out floorCount) || floorCount <= 0)
        {
            Console.WriteLine("Veuillez entrer un nombre valide d'étages.");
        }

        Dungeon dungeon = new Dungeon(floorCount);
        dungeon.DisplayDungeonMatrix();
    }
}

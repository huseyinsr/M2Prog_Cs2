using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // İlk sözlük örneği
        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();

        personeelOpNummer.Add(382942, "Jim");
        personeelOpNummer.Add(789423, "Tim");

        string jim = personeelOpNummer[382942];
        Console.WriteLine(jim);

        foreach (KeyValuePair<int, string> item in personeelOpNummer)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        foreach (int key in personeelOpNummer.Keys)
        {
            Console.WriteLine(key);
        }

        foreach (string value in personeelOpNummer.Values)
        {
            Console.WriteLine(value);
        }

        // İkinci örnek: Odalarla çalışmak
        Dictionary<string, Room> rooms = new Dictionary<string, Room>();

        Room start = new Room(0, 0, new[]
        {
            "xxxxx",
            "x...x",
            "x...x",
            "xxxxx"
        });
        rooms.Add(start.GetRoomLocationKey(), start);

        ShowRoom(rooms, 0, 0);

        ShowRoom(rooms, 1, 1);

        Console.ReadLine();
    }

    private static void ShowRoom(Dictionary<string, Room> rooms, int x, int y)
    {
        string key = $"{x},{y}";
        if (rooms.ContainsKey(key))
        {
            Room room = rooms[key];
            Console.WriteLine($"You are in room: {x},{y}");
            foreach (string line in room.Level)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("Error: Room does not exist");
        }
    }
}

internal class Room
{
    internal int X { get; set; }
    internal int Y { get; set; }
    internal string[] Level { get; set; }

    internal Room(int x, int y, string[] level)
    {
        this.X = x;
        this.Y = y;
        this.Level = level;
    }

    internal string GetRoomLocationKey()
    {
        return $"{X},{Y}";
    }
}

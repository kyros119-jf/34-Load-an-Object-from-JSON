using System.Text.Json;

string json = File.ReadAllText("monster.json");

Monster monster = JsonSerializer.Deserialize<Monster>(json);

Console.WriteLine($"Name: {monster.Name}");
Console.WriteLine($"Health: {monster.Health}");
Console.WriteLine($"Damage: {monster.Damage}"); 
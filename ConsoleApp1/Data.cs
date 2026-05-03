using System;
namespace NumberBomb;

record Achievement
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string UnlockedMessage { get; set; }
    public bool IsCompleted { get; set; } = false;
}

record User
{
    public required string Name { get; set; }
    public uint Id { get; set; }
    public List<Achievement> Achievements { get; set; } = new List<Achievement>();
}

enum GameState
{
    Console,
    Gaming
}

enum Difficulty
{
    Easy,
    Midium,
    Hard,
    Expert,
    Custom
}
using System;
namespace NumberBomb;

static class Shell
{
    public static string[] builtin_commands =
    {
        "exit",
        "game",
        "login"
    };
    public static int GetNum(string prompt = "")
    {
        do
        {
            Console.Write(prompt);
            string? line = Console.ReadLine();
            int res;
            if (line == null) { continue; }
            else if (int.TryParse(line.Split(' ')[0], out res))
            {
                return res;
            }
            else
            {
                ClearAfterShow("起来重输");
                continue;
            }
        } while (true);
    }
    public static void ClearAfterShow(string message, int delay = 1000)
    {
        Console.WriteLine(message);
        Thread.Sleep(delay);
        Console.Clear();
    }

    public static string[] ReadLine(string prompt = "")
    {
        do
        {
            Console.Write(prompt);
            string? line = Console.ReadLine();
            if (line == null) { continue; }
            else { return line.Split(" "); }
        } while (true);
    }
}

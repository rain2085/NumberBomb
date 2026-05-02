using System;
namespace NumberBomb;

static class Shell
{
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
                Console.Clear();
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
}

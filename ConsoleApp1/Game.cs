using System;
namespace NumberBomb;

class Game
{
    FileStream fileStream = new FileStream("./save.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
    GameState gameState;
    const string HELP_DOC = "help\n" +
        "exit\n" +
        "login\n";
    public void Initialize()
    {
        gameState = GameState.Console;
    }
    public int Mainloop()
    {
        return HandleCammand(Shell.ReadLine());
    }

    public void Finalize()
    {
        fileStream.Close();
    }

    private bool Guessing(int min, int max, int maxCount = 0)
    {
        uint count = 0;
        int goal = new Random().Next(min, max), num, left = min, right = max;
        while (true)
        {
            num = Shell.GetNum(
                "请输入一个数字（范围：("+left.ToString()+","+right.ToString()+")）："
            );
            if (num > goal)
            {
                right = num;
                Shell.ClearAfterShow("猜大了");
            }
            else if (num < goal)
            {
                left = num;
                Shell.ClearAfterShow("猜小了");
            }
            else
            {
                Shell.ClearAfterShow("猜中了");
                break;
            }
        }
        return (maxCount == 0 ? true : (count < maxCount));
    }

    private int HandleCammand(string[] cmd)
    {
        switch (cmd[0])
        {
            case "exit":
                try
                {
                    return int.Parse(cmd[1]);
                }
                catch
                {
                    return 0;
                }
            case "game":
                Console.Clear();
                Guessing(0, 100);
                break;
            case "login":
                Console.WriteLine("Under building");
                break;
            case "help":
                Console.WriteLine(HELP_DOC);
                break;
            default:
                Console.WriteLine(cmd[0]+":Command not found");
                return -1;
        }
        return 1;
    }
}
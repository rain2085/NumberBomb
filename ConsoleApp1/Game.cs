using System;
namespace NumberBomb;

class Game
{
    FileStream fileStream = new FileStream("./save.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
    GameState gameState = GameState.Console;
    public void Initialize()
    {

    }
    public int Mainloop()
    {
        Guessing(0, 100);
        return 0;
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
}
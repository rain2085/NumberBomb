using System.Runtime.CompilerServices;

namespace NumberBomb;

internal class Program
{
    List<User> users = new List<User>();
    static void Main(string[] args)
    {
        Game game = new Game();
        game.Initialize();
        int res;
        while (true)
        {
            res = game.Mainloop();
            if (res == 0)
            {
                break;
            }
        }
        game.Finalize();
    }
}
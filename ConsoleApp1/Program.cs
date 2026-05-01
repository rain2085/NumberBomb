namespace ConsoleApp1
{
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

    class Game 
    {
        FileStream fileStream = new FileStream("./save.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

        public void Initialize()
        {
            
        }
        public int Mainloop()
        {
            
            return 0;
        }

        public void Finalize()
        {
            fileStream.Close();
        }

        private bool Guessing(uint min,uint max,int maxCount=0)
        {
            uint count = 0;
            while (true)
            { 
            }
            if (maxCount == 0)
            {
                return true;
            }
            else
            {
                return (count < maxCount);
            }
        }
    }

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

}

namespace Commandos.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.InitGame(10, 10, 10);
            foreach (var item in CommandoFactory.CommandoObjList)
            {
                item.SayName("GENERAL");
                System.Console.WriteLine(item.Type);
            }
        }
    }
}
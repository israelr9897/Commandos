namespace Commandos.Models
{
    public class Enemy
    {
        public string Name;
        public int Life = 100;
        public string LifeStatus = "Alive";

        public Enemy(string name)
        {
            Name = name;
        }

        public void Scream()
        {
            System.Console.WriteLine("I am an enemy!!!");
        }

        
    }
}
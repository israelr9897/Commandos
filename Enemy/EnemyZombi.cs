namespace Commandos.Models
{
    public class EnemyZombi : Enemy
    {
        public string Power;
        public EnemyZombi(string name, string power) : base(name)
        {
            Power = power;
        }

        public void PrintPower()
        {
            System.Console.WriteLine(Power);
        }

    }
}
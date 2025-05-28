namespace Commandos.Models
{
    public class AK47 : Weapon, IShootable
    {
        public int NumOfBalls = 30;
        public AK47() : base("AK47", "KALASHNIKOV") { }
        public void UpdateBullets()
        {
            NumOfBalls --;
        }
        public void PrintShoot()
        {
            System.Console.WriteLine("BooooooM");
        }
        public void ToStep()
        {
            System.Console.WriteLine("To release a prisoner");
        }
    }
}
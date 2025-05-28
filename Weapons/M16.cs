namespace Commandos.Models
{

    public class M16 : Weapon, IShootable
    {
        public int NumOfBalls = 29;
        public M16() : base("M16", "COLD") { }

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
            System.Console.WriteLine("Weapon Step");
        }
    }
}